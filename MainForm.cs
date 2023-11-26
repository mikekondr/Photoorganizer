using System.Text.RegularExpressions;

namespace PhotoOrganizer
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
            MainModule.Init();

            bindingSourceFiles.DataSource = MainModule.CurrentFolder.items;

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = bindingSourceFiles;
            dataGridView1.DataBindings.Add("Tag", bindingSourceFiles, "FullName");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bgReadFolders.RunWorkerAsync((treeView1, treeView1.Nodes[0]));
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            while (bgReadFolders.IsBusy)
            {
                bgReadFolders.CancelAsync();
                Thread.Sleep(100);
                Application.DoEvents();
            }

            while (bgReadFiles.IsBusy)
            {
                bgReadFiles.CancelAsync();
                Thread.Sleep(100);
                Application.DoEvents();
            }
        }

        /// bgReadFolders
        /// 

        private void bgReadFolders_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            TreeView tv = (((TreeView, TreeNode))e.Argument).Item1;
            TreeNode rootNode = (((TreeView, TreeNode))e.Argument).Item2;

            if (rootNode.Parent == null)
                tv.Nodes[0].Nodes.Clear();

            MainModule.readFolders(tv, rootNode, treeview1_getFullPath(rootNode), bgReadFolders);

            e.Result = (true, rootNode);
        }

        private void bgReadFolders_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            bool result = (((bool, TreeNode))e.Result).Item1;
            TreeNode node = (((bool, TreeNode))e.Result).Item2;

            if (result)
                ExpandTreeNodeRecurse(node, "");
        }

        /// bgReadFiles
        /// 

        private void bgReadFiles_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            MainModule.CurrentFolder.ReadFiles(this, bgReadFiles);
        }

        /// TreeView
        /// 

        private void ExpandTreeNodeRecurse(TreeNode node, string CurPath)
        {
            node.Expand();
            foreach (TreeNode child in node.Nodes)
            {
                string new_path = CurPath + (CurPath == "" ? "" : "\\") + child.Text;
                if (MainModule.CurrentFolder.FullPath().StartsWith(new_path))
                {
                    treeView1.SelectedNode = child;
                    ExpandTreeNodeRecurse(child, new_path);
                    break;
                }
            }
        }

        private void treeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            if (e.Action == TreeViewAction.Expand && e.Cancel == false)
            {
                if (e.Node.Nodes.Count == 1 && e.Node.Nodes[0].Tag == "[dummy]")
                {
                    e.Node.Nodes.Remove(e.Node.Nodes[0]);
                    bgReadFolders.RunWorkerAsync((treeView1, e.Node));
                }
                else
                {
                    //TODO: update tree, if changed...
                }
            }
        }

        private void treeView1_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            while (bgReadFiles.IsBusy)
            {
                bgReadFiles.CancelAsync();
                Thread.Sleep(100);
                Application.DoEvents();
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            MainModule.ChangeCurrentFolder(treeview1_getFullPath(e.Node));
            bgReadFiles.RunWorkerAsync();
        }

        private string treeview1_getFullPath(TreeNode node)
        {
            return Regex.Replace(node.FullPath, "((" + treeView1.Nodes[0].Text + ")(\\\\)?)", "");
        }

        /// dataGridView1
        /// 

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                if ((int)e.Value == 4)
                    dataGridView1.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.DarkGray;
                e.Value = imageList1.Images[(int)e.Value];
            }
            else if (e.ColumnIndex >= 3 && e.ColumnIndex <= 5)
            {
                if (((DateTime)e.Value) == DateTime.MinValue)
                    e.CellStyle.Format = "";
            }
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count == 0)
                pictureBox1.Image = null;
            else
            {
                int row = dataGridView1.SelectedCells[0].RowIndex;
                object o = dataGridView1.Rows[row].DataBoundItem;
                if (o is PhotoFile)
                {
                    try
                    {
                        //pictureBox1.Image = new Bitmap((o as PhotoFile).FullName);
                        pictureBox1.Image = Image.FromFile((o as PhotoFile).FullName);
                    }
                    catch
                    {
                        pictureBox1.ImageLocation = (o as PhotoFile).FullName;
                    }

                    propertyGrid1.SelectedObject = o;
                }
            }
        }


        /// Main menu
        /// 

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AboutForm().ShowDialog(this);
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SettingsForm().ShowDialog(this);
        }

        /// Commands
        ///

        private void RenameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count == 0)
                return;

            List<PhotoFile> selected = new List<PhotoFile>();
            foreach (DataGridViewCell cell in dataGridView1.SelectedCells)
            {
                object t = dataGridView1.Rows[cell.RowIndex].DataBoundItem;
                if (t is PhotoFile)
                    selected.Add(t as PhotoFile);
            }

            if (selected.Count > 0)
            {
                Form frm = new RenameForm(selected);
                frm.ShowDialog(this);
            }
        }

        private void TimestampToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count == 0)
                return;

            List<PhotoFile> selected = new List<PhotoFile>();
            foreach (DataGridViewCell cell in dataGridView1.SelectedCells)
            {
                object t = dataGridView1.Rows[cell.RowIndex].DataBoundItem;
                if (t is PhotoFile)
                    selected.Add(t as PhotoFile);
            }

            if (selected.Count > 0)
            {
                Form frm = new TimestampForm(selected);
                frm.ShowDialog(this);
            }
        }

        /// Side panel
        ///

        private void sidePanelToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            splitContainer2.Panel2Collapsed = !sidePanelToolStripMenuItem.Checked;
        }

        private void infoPanelToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            splitContainer3.Panel1Collapsed = !infoPanelToolStripMenuItem.Checked;
        }

        private void previewPanelToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            splitContainer3.Panel2Collapsed = !previewPanelToolStripMenuItem.Checked;
        }
    }
}