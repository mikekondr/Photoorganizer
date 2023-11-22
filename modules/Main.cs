using System.Collections.Specialized;
using System.ComponentModel;
using System.Configuration;

namespace PhotoOrganizer
{
    public class MainModule
    {
        static private CurrentFolder _currentFolder;

        static private NameValueCollection _settings;
        static public dynamic get_setting(string key)
        {
            dynamic result = null;
            if (_settings != null)
            {
                result = _settings[key];
            }
            return result;
        }
        static public void set_setting(string key, dynamic value)
        {
            _settings[key] = value;
        }

        static public void Init()
        {
            _currentFolder = new CurrentFolder();

            /// Settings

            _settings = ConfigurationManager.AppSettings;
        }

        static public void ChangeCurrentFolder(string path) =>
            _currentFolder.ChangePath(path);

        static public void readFolders(TreeView treeView, TreeNode rootNode, string path, BackgroundWorker bg)
        {
            if (path == "")
            {
                foreach (DriveInfo drive in System.IO.DriveInfo.GetDrives())
                {
                    if (bg.CancellationPending)
                        break;

                    TreeNode node = (TreeNode)treeView.Invoke(NodeAdd, rootNode, drive.Name, 2);
                    if (drive.IsReady)
                    {
                        DirectoryInfo info = new DirectoryInfo(drive.Name);
                        readSubFolders(info, treeView, node, bg);
                    }
                }
            }
            else
            {
                DirectoryInfo info = new DirectoryInfo(path);
                readSubFolders(info, treeView, rootNode, bg);
            }
        }

        private static void readSubFolders(DirectoryInfo info, TreeView treeView, TreeNode parentNode, BackgroundWorker bg)
        {
            DirectoryInfo[] dirs;
            try
            {
                dirs = info.GetDirectories();
            }
            catch
            {
                return;
            }

            foreach (DirectoryInfo folder in dirs)
            {
                if (bg.CancellationPending)
                    break;

                TreeNode node = new TreeNode();
                node = (TreeNode)treeView.Invoke(NodeAdd, parentNode, folder.Name, 3);
                node.Tag = folder.FullName;
                //if (_currentFolder.FullPath().StartsWith(folder.FullName))
                if (_currentFolder.FullPath().StartsWith(folder.FullName))
                    try
                    {
                        readSubFolders(folder, treeView, node, bg);
                    }
                    catch
                    { }
                else
                {
                    try
                    {
                        if (folder.GetDirectories().Length != 0)
                        {
                            //dummy element for "plus" sign
                            TreeNode dummy = (TreeNode)treeView.Invoke(NodeAdd, node, "", -1);
                            dummy.Tag = "[dummy]";

                        }
                    }
                    catch { }
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