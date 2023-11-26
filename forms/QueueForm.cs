using System.Windows.Forms;

namespace PhotoOrganizer
{
    public partial class QueueForm : Form
    {
        public QueueForm()
        {
            InitializeComponent();

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = MainModule.Queue.items;

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = bindingSource;
        }

        private void dataGridView1_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            MainModule.Queue.OnQueueCountChanged();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            switch (e.ColumnIndex)
            {
                case 0:
                case 2:
                case 4:
                case 6:
                    if (row.Cells[e.ColumnIndex + 1].FormattedValue != ""
                            && e.Value != row.Cells[e.ColumnIndex + 1].Value)
                        e.CellStyle.ForeColor = Color.Red;
                    break;
                case 1:
                case 3:
                case 5:
                case 7:
                    if (e.Value != null)
                        e.CellStyle.ForeColor = Color.Green;
                    break;
            }
        }
    }
}
