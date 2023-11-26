namespace PhotoOrganizer
{
    public partial class SettingsForm : Form
    {
        private bool modified = false;

        public SettingsForm()
        {
            InitializeComponent();

            FillSettings();
        }

        private void FillSettings()
        {
            /// View
            chShowUnsupportedFiles.Checked = MainModule.get_setting("ShowUnsupportedFiles");

            // Rename
            string[] list = ((string)MainModule.get_setting("FilenameTemplates")).Split(',');
            foreach (string s in list)
                lstFilenameTewmplates.Items.Add(s);
        }

        private void Modify()
        {
            modified = true;
            this.Text = this.Text + " *";
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (modified)
            {
                MainModule.set_setting("ShowUnsupportedFiles", chShowUnsupportedFiles.Checked);

                List<string> list = new List<string>();
                foreach (ListViewItem s in lstFilenameTewmplates.Items)
                {
                    if (s.Text == "")
                        continue;
                    list.Add(s.Text);
                }
                MainModule.set_setting("FilenameTemplates", string.Join(",", list));


                MainModule.SaveSettings();
            }
            Close();
        }

        private void lstFilenameMasks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstFilenameTewmplates.SelectedItems.Count == 0)
                txtMask.Text = "";
            else
                txtMask.Text = lstFilenameTewmplates.SelectedItems[0].Text;
        }

        private void btnMaskOk_Click(object sender, EventArgs e)
        {
            if (txtMask.Text == "")
                return;

            if (lstFilenameTewmplates.SelectedItems.Count == 0)
                lstFilenameTewmplates.Items.Add(txtMask.Text);
            else
                lstFilenameTewmplates.SelectedItems[0].Text = txtMask.Text;

            lstFilenameTewmplates.SelectedItems.Clear();

            Modify();
        }

        private void txtMask_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                e.Handled = true;
                btnMaskOk.PerformClick();
            }
        }

        private void btnMasksAdd_Click(object sender, EventArgs e)
        {
            lstFilenameTewmplates.SelectedItems.Clear();
            ListViewItem item = lstFilenameTewmplates.Items.Add("filename");
            item.Selected = true;

            txtMask.Select();

            Modify();
        }

        private void btnMasksRemove_Click(object sender, EventArgs e)
        {
            if (lstFilenameTewmplates.SelectedItems.Count != 0)
            {
                lstFilenameTewmplates.Items.Remove(lstFilenameTewmplates.SelectedItems[0]);
                Modify();
            }
        }

        private void chShowUnsupportedFiles_CheckedChanged(object sender, EventArgs e)
        {
            Modify();
        }
    }
}
