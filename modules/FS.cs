namespace PhotoOrganizer
{
    public class FSItem
    {
        public string name;

        public FSItem(string name)
        {
            this.name = name;
        }
    }

    public class PhotoFile : FSItem
    {
        public PhotoFile(string name) : base(name)
        {
        }
    }

    public class CurrentFolder
    {
        private DirectoryInfo _current;

        public CurrentFolder() =>
            _current = new DirectoryInfo(@".");

        public string DriveLetter()
        {
            return _current.Root.Name;
        }

        public string FullPath()
        {
            return _current.FullName;
        }
    }
}