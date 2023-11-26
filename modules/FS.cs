using System.ComponentModel;
using System.Drawing.Imaging;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;

namespace PhotoOrganizer
{
    public class FSItem : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        protected void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public FSItem(FileInfo file, string type)
        {
            this.fullName = file.FullName;
            this.name = file.Name;
            this.type = type;
        }

        public FSItem(string filepath)
        {
            FileInfo file = new FileInfo(filepath);
            string ext = (file.Extension.Length == 0 ? "" : file.Extension.Substring(1)).ToLower();

            this.fullName = file.FullName;
            this.name = file.Name;
            this.type = ext;
        }

        public FSItem()
        { }

        protected string fullName = "";
        public string FullName { get { return fullName; } }

        protected string name = "";
        public virtual string Name
        {
            get => name;
            set
            {
                name = value;
                NotifyPropertyChanged("Name");
            }
        }

        protected string type = "";
        public virtual string Type
        {
            get => type;
            set
            {
                type = value;
                NotifyPropertyChanged("Type");
            }
        }

        public virtual int icon { get => 0; }

        public virtual DateTime DateCreated
        {
            get => new DateTime();
            set
            {
                NotifyPropertyChanged("DateCreated");
            }
        }
        public virtual DateTime DateModified
        {
            get => new DateTime();
            set
            {
                NotifyPropertyChanged("DateModified");
            }
        }
        public virtual DateTime DateTaken
        {
            get => new DateTime();
            set
            {
                NotifyPropertyChanged("DateTaken");
            }
        }
    }

    public class UnknownFile: FSItem
    {
        public UnknownFile(FileInfo file, string type) : base(file, type) { }

        public UnknownFile(string path) : base(path) { }

        public override int icon { get => 4; }
    }

    public class PhotoFile : FSItem
    {
        public override int icon { get => 5; }

        private DateTime dateCreated;
        public override DateTime DateCreated
        {
            get => dateCreated;
            set
            {
                dateCreated = value;
                NotifyPropertyChanged("DateCreated");
            }
        }
        private DateTime dateModified;
        public override DateTime DateModified
        {
            get => dateModified;
            set
            {
                dateModified = value;
                NotifyPropertyChanged("DateModified");
            }
        }
        private DateTime dateTaken;
        public override DateTime DateTaken
        {
            get => dateTaken;
            set
            {
                dateTaken = value;
                NotifyPropertyChanged("DateTaken");
            }
        }

        public PhotoFile(FileInfo file, string type) : base(file, type) { }

        public PhotoFile(string path) : base(path) { }
        
        public void ReadAttributes(Form? frm)
        {
            FileInfo file = new FileInfo(this.fullName);

            if (frm != null)
                frm.Invoke(new Action(() =>
                {
                    this.dateCreated = file.CreationTime;
                    this.dateModified = file.LastWriteTime;
                }));
            else
            {
                this.dateCreated = file.CreationTime;
                this.dateModified = file.LastWriteTime;
            }
            try
            {
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
                            if (frm != null)
                                frm.Invoke(new Action(() =>
                                {
                                    this.dateTaken = dt;
                                }));
                            else
                                this.dateTaken = dt;
                    }
                }
            }
            catch { }

            NotifyPropertyChanged();
        }

        public DateTime auto_datetime(bool force_filename = false)
        {
            DateTime result = DateTime.MinValue;

            /// from filename
            string datetime;
            Match res;
            //08/18/2018 07:22:16

            res = Regex.Match(name, "(?:[\\D]+|^)(\\d{8})(?:[\\D])", RegexOptions.IgnoreCase);
            if (res.Success)
                datetime = res.Groups[1].Value;
            else
                datetime = DateTime.MinValue.ToString("ddMMyyyy");

            res = Regex.Match(name, "(?:[\\D]+)(\\d{6}|\\d{9})(?:[\\D]+|$)", RegexOptions.IgnoreCase);
            if (res.Success)
                datetime = datetime + " " + res.Groups[1].Value;
            else
                datetime = datetime + " " + DateTime.MinValue.ToString("mmHHss");

            if (datetime == DateTime.MinValue.ToString("ddMMyyyy mmHHss"))
            {
                res = Regex.Match(name, "(?:[\\D]+|^)(\\d{17}|\\d{14})(?:[\\D]+|$)", RegexOptions.IgnoreCase);
                if (res.Success)
                    datetime = res.Groups[1].Value;
            }

            string[] vars =
            {
                "ddMMyyyy HHmmss",
                "MMddyyyy HHmmss",
                "ddMMyyyy HHmmssfff",
                "MMddyyyy HHmmssfff",
                "yyyyMMdd HHmmss",
                "yyyyMMdd HHmmssfff"
            };

            foreach (string format in vars)
            {
                if (DateTime.TryParseExact(datetime, format,
                        CultureInfo.InvariantCulture, DateTimeStyles.None, out result))
                {
                    if (result != DateTime.MinValue)
                        break;
                }
                else
                    result = DateTime.MinValue;
            }

            if (!force_filename)
            {
                if (result == DateTime.MinValue
                    && dateTaken != DateTime.MinValue)

                    result = dateTaken;

                if (result == DateTime.MinValue
                    && dateCreated != DateTime.MinValue)

                    result = dateCreated;

                if (result == DateTime.MinValue
                    && dateModified != DateTime.MinValue)

                    result = dateModified;
            }

            return result;
        }
    }

    public class CurrentFolder
    {
        private DirectoryInfo? _current;
        public BindingList<FSItem> items = new BindingList<FSItem>();

        public CurrentFolder()
        {
            _current = new DirectoryInfo(@".");
        }

        public CurrentFolder(string path)
        {
            ChangePath(path);
        }

        public string DriveLetter() => 
            (_current == null ? "" : _current.Root.Name);

        public string FullPath() =>
            (_current == null ? "" : _current.FullName);

        public void ChangePath(string path)
        {
            items.Clear();
            _current = null;
            if (path != "")
                try
                {
                    _current = new DirectoryInfo(path);
                    if (_current.Exists == false)
                        _current = null;
                }
                catch { }
        }

        public void ReadFiles(Form frm, BackgroundWorker bg)
        {
            if (_current == null)
                return;

            FSItem item = null;
            frm.Invoke(new Action( () => items.Clear() ));
            foreach (FileInfo file in _current.GetFiles())
            {
                if (bg.CancellationPending)
                    break;

                string ext = (file.Extension.Length == 0 ? "" : file.Extension.Substring(1)).ToLower();
                if (ext == "jpg")
                {
                    item = new PhotoFile(file, ext);
                }
                else
                {
                    if (MainModule.get_setting("ShowUnsupportedFiles") == false)
                        continue;
                    item = new UnknownFile(file, ext);
                }
                
                frm.Invoke(new Action( () => items.Add(item) ));
            }
            
            //друга довга частина - читання заголовків
            foreach (FSItem i in items)
            {
                if (bg.CancellationPending)
                    break;

                if (i is PhotoFile)
                    ((PhotoFile)i).ReadAttributes(frm);
            }
        }
    }
}