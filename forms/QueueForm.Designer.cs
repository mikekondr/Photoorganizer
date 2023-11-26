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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QueueForm));
            dataGridView1 = new DataGridView();
            colName = new DataGridViewTextBoxColumn();
            NewName = new DataGridViewTextBoxColumn();
            DateCreated = new DataGridViewTextBoxColumn();
            NewDateCreated = new DataGridViewTextBoxColumn();
            DateModified = new DataGridViewTextBoxColumn();
            NewDateModified = new DataGridViewTextBoxColumn();
            DateTaken = new DataGridViewTextBoxColumn();
            NewDateTaken = new DataGridViewTextBoxColumn();
            toolStripContainer1 = new ToolStripContainer();
            toolStrip2 = new ToolStrip();
            toolStripButton3 = new ToolStripButton();
            StatusLabel = new ToolStripLabel();
            toolStripProgressBar1 = new ToolStripProgressBar();
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            TotalLabel = new ToolStripLabel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            toolStripContainer1.BottomToolStripPanel.SuspendLayout();
            toolStripContainer1.ContentPanel.SuspendLayout();
            toolStripContainer1.TopToolStripPanel.SuspendLayout();
            toolStripContainer1.SuspendLayout();
            toolStrip2.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colName, NewName, DateCreated, NewDateCreated, DateModified, NewDateModified, DateTaken, NewDateTaken });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(800, 400);
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
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.BottomToolStripPanel
            // 
            toolStripContainer1.BottomToolStripPanel.Controls.Add(toolStrip2);
            // 
            // toolStripContainer1.ContentPanel
            // 
            toolStripContainer1.ContentPanel.Controls.Add(dataGridView1);
            toolStripContainer1.ContentPanel.Size = new Size(800, 400);
            toolStripContainer1.Dock = DockStyle.Fill;
            toolStripContainer1.Location = new Point(0, 0);
            toolStripContainer1.Name = "toolStripContainer1";
            toolStripContainer1.Size = new Size(800, 450);
            toolStripContainer1.TabIndex = 1;
            toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            toolStripContainer1.TopToolStripPanel.Controls.Add(toolStrip1);
            // 
            // toolStrip2
            // 
            toolStrip2.Dock = DockStyle.None;
            toolStrip2.Items.AddRange(new ToolStripItem[] { toolStripButton3, StatusLabel, toolStripProgressBar1 });
            toolStrip2.Location = new Point(3, 0);
            toolStrip2.Name = "toolStrip2";
            toolStrip2.Size = new Size(99, 25);
            toolStrip2.TabIndex = 0;
            // 
            // toolStripButton3
            // 
            toolStripButton3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            toolStripButton3.Image = (Image)resources.GetObject("toolStripButton3.Image");
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(87, 22);
            toolStripButton3.Text = "Виконати!";
            toolStripButton3.Click += toolStripButton3_Click;
            // 
            // StatusLabel
            // 
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Size = new Size(57, 22);
            StatusLabel.Text = "Прогрес:";
            StatusLabel.Visible = false;
            // 
            // toolStripProgressBar1
            // 
            toolStripProgressBar1.Name = "toolStripProgressBar1";
            toolStripProgressBar1.Size = new Size(100, 22);
            toolStripProgressBar1.Visible = false;
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.None;
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripButton2, toolStripSeparator1, TotalLabel });
            toolStrip1.Location = new Point(3, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(86, 25);
            toolStrip1.TabIndex = 0;
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(23, 22);
            toolStripButton1.Text = "toolStripButton1";
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(23, 22);
            toolStripButton2.Text = "toolStripButton2";
            toolStripButton2.Click += toolStripButton2_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // TotalLabel
            // 
            TotalLabel.Name = "TotalLabel";
            TotalLabel.Size = new Size(0, 22);
            // 
            // QueueForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(toolStripContainer1);
            Name = "QueueForm";
            Text = "Черга завдань";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            toolStripContainer1.BottomToolStripPanel.ResumeLayout(false);
            toolStripContainer1.BottomToolStripPanel.PerformLayout();
            toolStripContainer1.ContentPanel.ResumeLayout(false);
            toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            toolStripContainer1.TopToolStripPanel.PerformLayout();
            toolStripContainer1.ResumeLayout(false);
            toolStripContainer1.PerformLayout();
            toolStrip2.ResumeLayout(false);
            toolStrip2.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
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
        private ToolStripContainer toolStripContainer1;
        private ToolStrip toolStrip2;
        private ToolStripLabel StatusLabel;
        private ToolStripProgressBar toolStripProgressBar1;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripLabel TotalLabel;
        private ToolStripButton toolStripButton3;
    }
}