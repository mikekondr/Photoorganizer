namespace PhotoOrganizer
{
    public partial class TimestampForm : Form
    {
        private List<PhotoFile> _selected;
        private PhotoFile _current;

        public TimestampForm(List<PhotoFile> selected = null)
        {
            InitializeComponent();

            _selected = selected;
            _current = _selected[0];

            comboDateTime.Items.AddRange(new string[] {
                "Дата створення файлу",
                "Дата зміни файлу",
                "Дата зйомки" });
            comboDateTime.SelectedIndex = 2;

            dtStart.Value = DateTime.Now;

            show_example();
        }

        private void show_example()
        {
            lblCurr.Text = _current.Name;

            if (chkFileCreated.Checked)
                lblCreated.Text = _current.DateCreated.ToString() + " -->> " + get_datetime();
            else
                lblCreated.Text = "";

            if (chkFileModified.Checked)
                lblModified.Text = _current.DateModified.ToString() + " -->> " + get_datetime();
            else
                lblModified.Text = "";

            if (chkExifTaken.Checked)
                lblTaken.Text = _current.DateTaken.ToString() + " -->> " + get_datetime();
            else
                lblTaken.Text = "";
        }

        private DateTime get_datetime()
        {
            DateTime result = new DateTime();

            if (rbtDateTime.Checked)
            {
                switch (comboDateTime.SelectedIndex)
                {
                    case 0:
                        result = _current.DateCreated;
                        break;
                    case 1:
                        result = _current.DateModified;
                        break;
                    case 2:
                        result = _current.DateTaken;
                        break;
                }
            }
            else if (rbtManual.Checked)
            {
                result = dtStart.Value;
            }

            if (numStep.Value != 0)
                result = result.AddSeconds((int)numStep.Value * _selected.IndexOf(_current));

            return result;
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            int index = _selected.IndexOf(_current);
            if (index <= 0)
                return;

            index--;
            _current = _selected[index];
            show_example();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int index = _selected.IndexOf(_current);
            if (index >= _selected.Count - 1)
                return;

            index++;
            _current = _selected[index];
            show_example();
        }

        private void rbtDateTime_CheckedChanged(object sender, EventArgs e)
        {
            comboDateTime.Enabled = rbtDateTime.Checked;
            show_example();
        }

        private void rbtManual_CheckedChanged(object sender, EventArgs e)
        {
            dtStart.Enabled = rbtManual.Checked;
            show_example();
        }

        private void chk_CheckedChanged(object sender, EventArgs e)
        {
            show_example();
        }
    }
}
