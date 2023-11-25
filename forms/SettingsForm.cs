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
            string[] list = ((string)MainModule.get_setting("FilenameMasks").Value).Split(',');
            foreach (string s in list)
                lstFilenameMasks.Items.Add(s);
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
                foreach (ListViewItem s in lstFilenameMasks.Items)
                {
                    if (s.Text == "")
                        continue;
                    list.Add(s.Text);
                }
                MainModule.set_setting("FilenameMasks", string.Join(",", list));


                MainModule.SaveSettings();
            }
            Close();
        }

        private void lstFilenameMasks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstFilenameMasks.SelectedItems.Count == 0)
                txtMask.Text = "";
            else
                txtMask.Text = lstFilenameMasks.SelectedItems[0].Text;
        }

        private void btnMaskOk_Click(object sender, EventArgs e)
        {
            if (txtMask.Text == "")
                return;

            if (lstFilenameMasks.SelectedItems.Count == 0)
                lstFilenameMasks.Items.Add(txtMask.Text);
            else
                lstFilenameMasks.SelectedItems[0].Text = txtMask.Text;

            lstFilenameMasks.SelectedItems.Clear();

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
            lstFilenameMasks.SelectedItems.Clear();
            ListViewItem item = lstFilenameMasks.Items.Add("filename");
            item.Selected = true;

            txtMask.Select();

            Modify();
        }

        private void btnMasksRemove_Click(object sender, EventArgs e)
        {
            if (lstFilenameMasks.SelectedItems.Count != 0)
            {
                lstFilenameMasks.Items.Remove(lstFilenameMasks.SelectedItems[0]);
                Modify();
            }
        }

        private void chShowUnsupportedFiles_CheckedChanged(object sender, EventArgs e)
        {
            Modify();
        }
    }
}
