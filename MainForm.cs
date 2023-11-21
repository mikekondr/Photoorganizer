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


        /// Main menu
        /// 

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new AboutForm();
            frm.ShowDialog(this);
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}