using System.ComponentModel;
using System.Drawing.Imaging;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;

namespace PhotoOrganizer
{
    public class FSItem: INotifyPropertyChanged
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

        protected string fullName = "";

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
        public UnknownFile(FileInfo file, string type) : base(file, type)
        { }

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

        public PhotoFile(FileInfo file, string type) : base(file, type)
        { }

        public void ReadAttributes(Form frm)
        {
            FileInfo file = new FileInfo(this.fullName);

            frm.Invoke(new Action(() =>
            {
                this.dateCreated = file.CreationTime;
                this.dateModified = file.LastWriteTime;
            }));
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
                            frm.Invoke(new Action(() =>
                            {
                                this.dateTaken = dt;
                            }));
                    }
                }
            }
            catch { }

            NotifyPropertyChanged();
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