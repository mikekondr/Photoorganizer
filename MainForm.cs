using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PhotoOrganizer
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
            MainModule.Init();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bgReadFolders.RunWorkerAsync((treeView1, treeView1.Nodes[0]));
        }

        /// bgReadFolders
        /// 

        private void bgReadFolders_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            TreeView tv = (((TreeView, TreeNode))e.Argument).Item1;
            TreeNode rootNode = (((TreeView, TreeNode))e.Argument).Item2;

            if (rootNode.Parent == null)
                tv.Nodes[0].Nodes.Clear();

            MainModule.readFolders(tv, rootNode, treeview1_getFullPath(rootNode));

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
            MainModule.CurrentFolder.ReadFiles();
        }

        private void bgReadFiles_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            dataGridView1.Rows.Clear();
            foreach (var item in MainModule.CurrentFolder.items)
            {
                DataGridViewRow row = dataGridView1.Rows[dataGridView1.Rows.Add()];
                row.Cells["name"].Value = item.name;
                row.Cells["type"].Value = item.type;
                if (item.type == "jpg")
                {
                    row.Cells["icon"].Value = imageList1.Images[5];
                    row.Cells["dateCreated"].Value = ((PhotoFile)item).dateCreated;
                    row.Cells["dateModified"].Value = ((PhotoFile)item).dateModified;
                    row.Cells["dateTaken"].Value = ((PhotoFile)item).dateTaken;
                }
                else
                {
                    row.Cells["icon"].Value = imageList1.Images[4];
                    row.DefaultCellStyle.ForeColor = Color.Gray;
                }

            }
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

    }
}