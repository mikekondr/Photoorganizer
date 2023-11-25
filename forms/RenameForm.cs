namespace PhotoOrganizer
{
    public partial class RenameForm : Form
    {
        private List<PhotoFile> _selected;

        public RenameForm(List<PhotoFile> selected = null)
        {
            InitializeComponent();

            _selected = selected;
        }
    }
}
