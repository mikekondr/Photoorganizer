using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace PhotoOrganizer
{
    public class MainModule
    {
        static private CurrentFolder? _currentFolder;

        static public void Init()
        {
            _currentFolder = new CurrentFolder();
        }

        static public void ChangeCurrentFolder(string path) =>
            _currentFolder = new CurrentFolder(path);

        static public void readFolders(TreeView treeView, TreeNode rootNode, string path)
        {
            if (path == "")
            {
                foreach (DriveInfo drive in System.IO.DriveInfo.GetDrives())
                {
                    TreeNode node = (TreeNode)treeView.Invoke(NodeAdd, rootNode, drive.Name, 2);
                    if (drive.IsReady)
                    {
                        DirectoryInfo info = new DirectoryInfo(drive.Name);
                        readSubFolders(info.GetDirectories(), treeView, node);
                    }
                }
            }
            else
            {
                DirectoryInfo info = new DirectoryInfo(path);
                readSubFolders(info.GetDirectories(), treeView, rootNode);
            }
        }

        private static void readSubFolders(DirectoryInfo[] info, TreeView treeView, TreeNode parentNode)
        {
            foreach (DirectoryInfo folder in info)
            {
                TreeNode node = new TreeNode();
                node = (TreeNode)treeView.Invoke(NodeAdd, parentNode, folder.Name, 3);
                node.Tag = folder.FullName;
                if (_currentFolder.FullPath().StartsWith(folder.FullName))
                    try
                    {
                        readSubFolders(folder.GetDirectories(), treeView, node);
                    }
                    catch
                    { }
                else
                //dummy element for "plus" sign
                {
                    TreeNode dummy = (TreeNode)treeView.Invoke(NodeAdd, node, "", -1);
                    dummy.Tag = "[dummy]";
                }
            }
        }

        private static TreeNode NodeAdd(TreeNode node, string name, int imageIndex)
        {
            TreeNode tmp = node.Nodes.Add(name);
            tmp.ImageIndex = imageIndex;
            tmp.SelectedImageIndex = imageIndex;
            return tmp;
        }

        /// Properties
        /// 

        public static CurrentFolder CurrentFolder
        {
            get
            {
                return _currentFolder;
            }
        }
    }
}