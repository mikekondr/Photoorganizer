namespace PhotoOrganizer
{
    public class FSItem
    {
        public string name;
        public string type;

        public FSItem(string name, string type)
        {
            this.name = name;
            this.type = type;
        }
    }

    public class PhotoFile : FSItem
    {
        public PhotoFile(string name, string type) : base(name, type)
        {
        }
    }

    public class CurrentFolder
    {
        private DirectoryInfo? _current;
        public List<FSItem> items = new List<FSItem>();

        public CurrentFolder() =>
            _current = new DirectoryInfo(@".");

        public CurrentFolder(string path)
        {
            if (path == "")
            {
                _current = null;
            }
            else
            {
                _current = new DirectoryInfo(path);
            }
        }

        public string DriveLetter() => 
            (_current == null ? "" : _current.Root.Name);

        public string FullPath() =>
            (_current == null ? "" : _current.FullName);

        public void ReadFiles()
        {
            if (_current == null)
                return;

            FSItem item = null;
            items.Clear();
            foreach (FileInfo file in _current.GetFiles())
            {
                string ext = (file.Extension.Length == 0 ? "" : file.Extension.Substring(1)).ToLower();
                if (file.Extension == "jpg")
                {
                    item = new PhotoFile(file.FullName, ext);
                }
                else
                {
                    item = new FSItem(file.Name, ext);
                }

                items.Add(item);
            }
        }
    }
}