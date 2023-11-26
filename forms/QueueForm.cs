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

            MainModule.Queue.QueueCountChanged += OnQueueCountChange;
        }

        private void dataGridView1_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            MainModule.Queue.OnQueueCountChanged();
        }

        public void OnQueueCountChange(int count)
        {
            if (count > 0)
                TotalLabel.Text = "У черзі: " + count.ToString() + " операцій";
            else
                TotalLabel.Text = "Черга порожня...";
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

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            int count = dataGridView1.SelectedCells.Count;
            if (count == 0)
                return;

            List<Operation> operations = new List<Operation>();
            for (int i = 0; i < count; i++)
                operations.Add( (Operation)dataGridView1.Rows[dataGridView1.SelectedCells[i].RowIndex].DataBoundItem );

            foreach (Operation operation in operations)
                MainModule.Queue.Remove(operation);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            MainModule.Queue.Clear();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Не реалізовано, поки що...");
        }
    }
}
