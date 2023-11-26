using System.Diagnostics.Eventing.Reader;

namespace PhotoOrganizer
{
    public partial class RenameForm : Form
    {
        private List<PhotoFile> _selected;
        private PhotoFile _current;

        public RenameForm(List<PhotoFile> selected = null)
        {
            InitializeComponent();

            _selected = selected;
            _current = _selected[0];

            comboTemplate.Items.AddRange(((string)MainModule.get_setting("FilenameTemplates")).Split(','));
            comboTemplate.SelectedIndex = 0;

            comboDateTime.Items.AddRange(new string[] {
                "Дата створення файлу",
                "Дата зміни файлу",
                "Дата зйомки",
                "З імені файлу (авто)"});
            comboDateTime.SelectedIndex = 3;

            dtStart.Value = DateTime.Now;

            show_example();
        }

        private void rbtTemplate_CheckedChanged(object sender, EventArgs e)
        {
            comboTemplate.Enabled = rbtTemplate.Checked;
            show_example();
        }

        private void rbtManual_CheckedChanged(object sender, EventArgs e)
        {
            txtTemplate.Enabled = rbtManual.Checked;
            show_example();
        }

        private void rbtDateTime_CheckedChanged(object sender, EventArgs e)
        {
            comboDateTime.Enabled = rbtDateTime.Checked;
            show_example();
        }

        private void rbtIncrement_CheckedChanged(object sender, EventArgs e)
        {
            panelIncrement.Enabled = rbtIncrement.Checked;
            show_example();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            foreach (PhotoFile item in _selected)
            {
                MainModule.Queue.Add(item, get_new_filename(item));
            }

            Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://learn.microsoft.com/ru-ru/dotnet/standard/base-types/custom-date-and-time-format-strings");
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

        private void show_example()
        {
            lblOld.Text = _current.Name;
            lblNew.Text = get_new_filename(_current);
        }

        private string get_new_filename(PhotoFile item)
        {
            string template = "", filename = "";
            if (rbtTemplate.Checked)
                template = comboTemplate.SelectedIndex != -1 ? comboTemplate.Text : "";
            else if (rbtManual.Checked)
                template = txtTemplate.Text;

            if (template == "")
                return item.Name;

            int l_ind = template.IndexOf('{');
            int r_ind = template.IndexOf('}');
            if (l_ind == -1 || r_ind == -1 || l_ind >= r_ind)
                filename = template;
            else
            {
                string format = template.Substring(l_ind + 1, r_ind - l_ind - 1);
                filename = String.Format("{0}{1:" + format + "}{2}.{3}",
                    template.Substring(0, l_ind),
                    get_datetime(_current),
                    template.Substring(r_ind + 1, template.Length - r_ind - 1),
                    _current.Type);
            }

            return filename;
        }

        private DateTime get_datetime(PhotoFile item)
        {
            DateTime result = new DateTime();

            if (rbtDateTime.Checked)
            {
                switch (comboDateTime.SelectedIndex)
                {
                    case 0:
                        result = item.DateCreated;
                        break;
                    case 1:
                        result = item.DateModified;
                        break;
                    case 2:
                        result = item.DateTaken;
                        break;
                    case 3:
                        result = item.auto_datetime();
                        break;
                }
            }
            else if (rbtIncrement.Checked)
            {
                result = dtStart.Value;
            }

            if (rbtIncrement.Checked)
                result = result.AddSeconds((int)numStep.Value * _selected.IndexOf(item));

            return result;
        }

        private void comboTemplate_SelectedIndexChanged(object sender, EventArgs e)
        {
            show_example();
        }

        private void txtTemplate_TextChanged(object sender, EventArgs e)
        {
            show_example();
        }
    }
}
