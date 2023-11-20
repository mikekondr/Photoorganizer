using System.Drawing.Imaging;
using System.Globalization;
using System.Text;

namespace PhotoOrganizer
{
    public class FSItem
    {
        public string name;
        public string type;
        public const int icon = 4;

        public FSItem(FileInfo file, string type)
        {
            this.name = file.FullName;
            this.type = type;
        }
    }

    public class PhotoFile : FSItem
    {
        public DateTime dateCreated { get; set; }
        public DateTime dateModified { get; set; }
        public DateTime dateTaken { get; set; }
        public new const int icon = 5;

        public PhotoFile(FileInfo file, string type) : base(file, type)
        {
            this.dateCreated = file.CreationTime;
            this.dateModified = file.LastWriteTime;
            Image img = Image.FromStream(new FileStream(file.FullName, FileMode.Open), false);
            if (img.PropertyIdList.ToList<int>().Contains(0x9003))
            {
                PropertyItem dateProperty = img.GetPropertyItem(0x9003);
                string taken = (new UTF8Encoding()).GetString(dateProperty.Value).Substring(0, 19);
                if (taken is not null)
                {
                    if (DateTime.TryParseExact(taken, "yyyy:MM:dd HH:mm:ss",
                                               CultureInfo.InvariantCulture,
                                               DateTimeStyles.None,
                                               out DateTime dt))
                        this.dateTaken = dt;
                }
            }
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
                if (ext == "jpg")
                {
                    item = new PhotoFile(file, ext);
                }
                else
                {
                    item = new FSItem(file, ext);
                }

                items.Add(item);
            }
        }
    }
}