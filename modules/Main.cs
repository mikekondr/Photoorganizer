using System.Collections.Specialized;
using System.ComponentModel;
using System.Configuration;

namespace PhotoOrganizer
{
    public class MainModule
    {
        static private CurrentFolder _currentFolder = new CurrentFolder();

        static private Configuration _config_file = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        static private KeyValueConfigurationCollection _settings = _config_file.AppSettings.Settings;

        static public dynamic get_setting(string key)
        {
            dynamic? result = null;
            if (_settings != null)
            {
                result = _settings[key];
                
                switch (key)
                {
                    case "ShowUnsupportedFiles":
                        if (bool.TryParse(result.Value, out bool tmp))
                            result = tmp;
                        else
                            result = false;
                        break;
                    case "FilenameMasks":
                        if (result == null)
                            result = "photo_{ddMMyyyy_HHmmss}";
                        break;
                }
            }
            return result;
        }

        static public void set_setting(string key, dynamic value)
        {
            string? val = null;
            if (value != null)
                val = value.ToString();

            if (_settings[key] == null)
                _settings.Add(key, val);
            else
                _settings[key].Value = val;
        }

        static public void SaveSettings()
        {
            _config_file.Save(ConfigurationSaveMode.Full, true);
        }

        static public void Init()
        {
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