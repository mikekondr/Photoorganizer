namespace PhotoOrganizer
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();

            FillSettings();
        }

        private void FillSettings()
        {
            /// View
            chShowUnsupportedFiles.Checked = (bool)MainModule.get_setting("ShowUnsupportedFiles");
        }
    }
}
