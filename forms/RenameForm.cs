namespace PhotoOrganizer
{
    public partial class RenameForm : Form
    {
        private List<PhotoFile> _selected;

        public RenameForm(List<PhotoFile> selected = null)
        {
            InitializeComponent();

            _selected = selected;

            comboTemplate.Items.AddRange(((string)MainModule.get_setting("FilenameTemplates")).Split(','));
            comboTemplate.SelectedIndex = 0;

            comboDateTime.Items.AddRange(new string[] {
                "Дата створення файлу",
                "Дата зміни файлу",
                "Дата зйомки" });
            comboDateTime.SelectedIndex = 0;

            dtStart.Value = DateTime.Now;
        }

        private void rbtTemplate_CheckedChanged(object sender, EventArgs e)
        {
            comboTemplate.Enabled = rbtTemplate.Checked;
        }

        private void rbtManual_CheckedChanged(object sender, EventArgs e)
        {
            txtTemplate.Enabled = rbtManual.Checked;
        }

        private void rbtDateTime_CheckedChanged(object sender, EventArgs e)
        {
            comboDateTime.Enabled = rbtDateTime.Checked;
        }

        private void rbtIncrement_CheckedChanged(object sender, EventArgs e)
        {
            panelIncrement.Enabled = rbtIncrement.Checked;
        }
    }
}
