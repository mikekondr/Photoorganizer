using System;
using System.Text.RegularExpressions;

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

            MainModule.readFolders(tv, rootNode, Regex.Replace(rootNode.FullPath, "((" + tv.Nodes[0].Text + ")(\\\\)?)", ""));
        }

        private void bgReadFolders_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            ExpandTreeNodeRecurse(treeView1.Nodes[0], "");
        }

        /// bgReadFiles
        /// 

        private void bgReadFiles_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {

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
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

    }
}