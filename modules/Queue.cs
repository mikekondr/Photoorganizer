using System.ComponentModel;

namespace PhotoOrganizer
{
    public class Queue 
    {
        public BindingList<Operation> items;

        public Queue()
        {
            items = new BindingList<Operation>();
        }

        public void Add(Operation operation)
        {
            int index = -1;
            foreach (var item in items)
                if (item.FullName == operation.FullName)
                {
                    index = items.IndexOf(item);
                    break;
                }

            if (index == -1)
                items.Add(operation);
            else
                Update(index, operation);
        }

        public void Add(PhotoFile photoFile, string newName,
            DateTime newDateCreated, DateTime newDateModified, DateTime newDateTaken)
        {
            Add(new Operation(photoFile, newName, newDateCreated, newDateModified, newDateTaken));
        }

        public void Update(int index, Operation item)
        {
            items[index].NewName = item.NewName ?? items[index].NewName;
            items[index].NewDateCreated = item.NewDateCreated == DateTime.MinValue ? items[index].NewDateCreated : item.NewDateCreated;
            items[index].NewDateModified = item.NewDateModified == DateTime.MinValue ? items[index].NewDateModified : item.NewDateModified;
            items[index].NewDateTaken = item.NewDateTaken == DateTime.MinValue ? items[index].NewDateTaken : item.NewDateTaken;
            items[index].DetermineType();
        }

        public int Count { get => items.Count; }

        public void Clear() =>
            items.Clear();

        public void Remove(Operation item) =>
            items.Remove(item);

        public void Remove(int index) =>
            items.RemoveAt(index);
    }

    public class Operation : PhotoFile
    {
        private string newName;
        public string NewName
        {
            get => newName;
            set
            {
                newName = value;
                NotifyPropertyChanged("NewName");
            }
        }
        private DateTime newDateCreated;
        public DateTime NewDateCreated
        {
            get => newDateCreated;
            set
            {
                newDateCreated = value;
                NotifyPropertyChanged("NewDateCreated");
            }
        }
        private DateTime newDateModified;
        public DateTime NewDateModified
        {
            get => newDateModified;
            set
            {
                newDateModified = value;
                NotifyPropertyChanged("NewDateModified");
            }
        }
        private DateTime newDateTaken;
        public DateTime NewDateTaken
        {
            get => newDateTaken;
            set
            {
                newDateTaken = value;
                NotifyPropertyChanged("NewDateTaken");
            }
        }

        private OperationType operationType = 0;
        public OperationType OperationType
        {
            get => operationType;
            set
            {
                operationType = value;
                NotifyPropertyChanged("OperatinType");
            }
        }

        public Operation(PhotoFile photoFile, string? newName = null,
            DateTime? newDateCreated = null,
            DateTime? newDateModified = null,
            DateTime? newDateTaken = null) : base(photoFile.FullName)
        {
            this.newName = newName ?? string.Empty;
            this.newDateCreated = newDateCreated ?? DateTime.MinValue;
            this.newDateModified = newDateModified ?? DateTime.MinValue;
            this.newDateTaken = newDateTaken ?? DateTime.MinValue;

            DetermineType();
        }

        public void DetermineType()
        {
            int t = 0;
            if (newName != null)
                t += 1;
            if (newDateCreated != DateTime.MinValue
                    || newDateModified != DateTime.MinValue
                    || newDateTaken != DateTime.MinValue)
                t += 2;

            operationType = (OperationType)t;
            NotifyPropertyChanged("OperationType");
        }
    }

    public enum OperationType
    {
        empty = 0,
        rename,
        set_date,
        set_date_n_rename
    }
}