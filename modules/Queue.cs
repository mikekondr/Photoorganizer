namespace PhotoOrganizer
{
    public class Queue
    {

    }

    public class Operation : PhotoFile
    {
        public Operation(FileInfo file, string type) : base(file, type)
        {
        }
    }
}