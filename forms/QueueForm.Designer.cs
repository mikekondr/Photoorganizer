namespace PhotoOrganizer
{
    partial class QueueForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            colName = new DataGridViewTextBoxColumn();
            NewName = new DataGridViewTextBoxColumn();
            DateCreated = new DataGridViewTextBoxColumn();
            NewDateCreated = new DataGridViewTextBoxColumn();
            DateModified = new DataGridViewTextBoxColumn();
            NewDateModified = new DataGridViewTextBoxColumn();
            DateTaken = new DataGridViewTextBoxColumn();
            NewDateTaken = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colName, NewName, DateCreated, NewDateCreated, DateModified, NewDateModified, DateTaken, NewDateTaken });
            dataGridView1.Dock = DockStyle.Top;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(800, 414);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellFormatting += dataGridView1_CellFormatting;
            dataGridView1.UserDeletedRow += dataGridView1_UserDeletedRow;
            // 
            // colName
            // 
            colName.DataPropertyName = "Name";
            colName.HeaderText = "Ім'я файлу";
            colName.Name = "colName";
            colName.ReadOnly = true;
            // 
            // NewName
            // 
            NewName.DataPropertyName = "NewName";
            NewName.HeaderText = "Нове ім'я";
            NewName.Name = "NewName";
            NewName.ReadOnly = true;
            // 
            // DateCreated
            // 
            DateCreated.DataPropertyName = "DateCreated";
            DateCreated.HeaderText = "Дата створення";
            DateCreated.Name = "DateCreated";
            DateCreated.ReadOnly = true;
            // 
            // NewDateCreated
            // 
            NewDateCreated.DataPropertyName = "NewDateCreated";
            NewDateCreated.HeaderText = "Нова дата створення";
            NewDateCreated.Name = "NewDateCreated";
            NewDateCreated.ReadOnly = true;
            // 
            // DateModified
            // 
            DateModified.DataPropertyName = "DateModified";
            DateModified.HeaderText = "Дата зміни";
            DateModified.Name = "DateModified";
            DateModified.ReadOnly = true;
            // 
            // NewDateModified
            // 
            NewDateModified.DataPropertyName = "NewDateModified";
            NewDateModified.HeaderText = "Нова дата зміни";
            NewDateModified.Name = "NewDateModified";
            NewDateModified.ReadOnly = true;
            // 
            // DateTaken
            // 
            DateTaken.DataPropertyName = "DateTaken";
            DateTaken.HeaderText = "Дата зйомки";
            DateTaken.Name = "DateTaken";
            DateTaken.ReadOnly = true;
            // 
            // NewDateTaken
            // 
            NewDateTaken.DataPropertyName = "NewDateTaken";
            NewDateTaken.HeaderText = "Нова дата зйомки";
            NewDateTaken.Name = "NewDateTaken";
            NewDateTaken.ReadOnly = true;
            // 
            // QueueForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Name = "QueueForm";
            Text = "Черга завдань";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn NewName;
        private DataGridViewTextBoxColumn DateCreated;
        private DataGridViewTextBoxColumn NewDateCreated;
        private DataGridViewTextBoxColumn DateModified;
        private DataGridViewTextBoxColumn NewDateModified;
        private DataGridViewTextBoxColumn DateTaken;
        private DataGridViewTextBoxColumn NewDateTaken;
    }
}