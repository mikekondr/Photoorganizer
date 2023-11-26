namespace PhotoOrganizer
{
    partial class TimestampForm
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
            groupBox2 = new GroupBox();
            dtStart = new DateTimePicker();
            rbtDateTime = new RadioButton();
            comboDateTime = new ComboBox();
            rbtManual = new RadioButton();
            label3 = new Label();
            numStep = new NumericUpDown();
            label2 = new Label();
            groupBox1 = new GroupBox();
            groupBox3 = new GroupBox();
            panel1 = new Panel();
            lblCurr = new Label();
            btnNext = new Button();
            btnPrev = new Button();
            lblTaken = new Label();
            lblModified = new Label();
            lblCreated = new Label();
            chkExifTaken = new CheckBox();
            chkFileModified = new CheckBox();
            chkFileCreated = new CheckBox();
            btnCancel = new Button();
            btnOk = new Button();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numStep).BeginInit();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dtStart);
            groupBox2.Controls.Add(rbtDateTime);
            groupBox2.Controls.Add(comboDateTime);
            groupBox2.Controls.Add(rbtManual);
            groupBox2.Location = new Point(12, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(247, 135);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            groupBox2.Text = "Використати:";
            // 
            // dtStart
            // 
            dtStart.CustomFormat = "dd.MM.yyyy HH:mm:ss";
            dtStart.Format = DateTimePickerFormat.Custom;
            dtStart.Location = new Point(24, 101);
            dtStart.Name = "dtStart";
            dtStart.Size = new Size(217, 23);
            dtStart.TabIndex = 11;
            dtStart.ValueChanged += chk_CheckedChanged;
            // 
            // rbtDateTime
            // 
            rbtDateTime.AutoSize = true;
            rbtDateTime.Checked = true;
            rbtDateTime.Location = new Point(6, 22);
            rbtDateTime.Name = "rbtDateTime";
            rbtDateTime.Size = new Size(77, 19);
            rbtDateTime.TabIndex = 10;
            rbtDateTime.TabStop = true;
            rbtDateTime.Text = "Дату/час:";
            rbtDateTime.UseVisualStyleBackColor = true;
            rbtDateTime.CheckedChanged += rbtDateTime_CheckedChanged;
            // 
            // comboDateTime
            // 
            comboDateTime.FormattingEnabled = true;
            comboDateTime.Location = new Point(24, 47);
            comboDateTime.Name = "comboDateTime";
            comboDateTime.Size = new Size(217, 23);
            comboDateTime.TabIndex = 9;
            comboDateTime.SelectedIndexChanged += chk_CheckedChanged;
            // 
            // rbtManual
            // 
            rbtManual.AutoSize = true;
            rbtManual.Location = new Point(6, 76);
            rbtManual.Name = "rbtManual";
            rbtManual.Size = new Size(107, 19);
            rbtManual.TabIndex = 4;
            rbtManual.Text = "Фіксована дата";
            rbtManual.UseVisualStyleBackColor = true;
            rbtManual.CheckedChanged += rbtManual_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(173, 62);
            label3.Name = "label3";
            label3.Size = new Size(25, 15);
            label3.TabIndex = 4;
            label3.Text = "сек";
            // 
            // numStep
            // 
            numStep.Location = new Point(47, 58);
            numStep.Maximum = new decimal(new int[] { 172800, 0, 0, 0 });
            numStep.Name = "numStep";
            numStep.Size = new Size(120, 23);
            numStep.TabIndex = 3;
            numStep.ThousandsSeparator = true;
            numStep.ValueChanged += chk_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 24);
            label2.Name = "label2";
            label2.Size = new Size(172, 15);
            label2.TabIndex = 2;
            label2.Text = "Додати кожному наступному:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(numStep);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(265, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(247, 135);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Змінити:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(panel1);
            groupBox3.Controls.Add(chkExifTaken);
            groupBox3.Controls.Add(chkFileModified);
            groupBox3.Controls.Add(chkFileCreated);
            groupBox3.Location = new Point(12, 153);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(500, 131);
            groupBox3.TabIndex = 15;
            groupBox3.TabStop = false;
            groupBox3.Text = "Встановлювати:";
            // 
            // panel1
            // 
            panel1.Controls.Add(lblCurr);
            panel1.Controls.Add(btnNext);
            panel1.Controls.Add(btnPrev);
            panel1.Controls.Add(lblTaken);
            panel1.Controls.Add(lblModified);
            panel1.Controls.Add(lblCreated);
            panel1.Location = new Point(183, 13);
            panel1.Name = "panel1";
            panel1.Size = new Size(311, 112);
            panel1.TabIndex = 3;
            // 
            // lblCurr
            // 
            lblCurr.Location = new Point(81, 89);
            lblCurr.Name = "lblCurr";
            lblCurr.Size = new Size(149, 23);
            lblCurr.TabIndex = 5;
            lblCurr.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(236, 89);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(75, 23);
            btnNext.TabIndex = 4;
            btnNext.Text = ">>";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // btnPrev
            // 
            btnPrev.Location = new Point(0, 89);
            btnPrev.Name = "btnPrev";
            btnPrev.Size = new Size(75, 23);
            btnPrev.TabIndex = 3;
            btnPrev.Text = "<<";
            btnPrev.UseVisualStyleBackColor = true;
            btnPrev.Click += btnPrev_Click;
            // 
            // lblTaken
            // 
            lblTaken.Location = new Point(3, 60);
            lblTaken.Name = "lblTaken";
            lblTaken.Size = new Size(308, 19);
            lblTaken.TabIndex = 2;
            // 
            // lblModified
            // 
            lblModified.Location = new Point(3, 35);
            lblModified.Name = "lblModified";
            lblModified.Size = new Size(308, 19);
            lblModified.TabIndex = 1;
            // 
            // lblCreated
            // 
            lblCreated.Location = new Point(3, 10);
            lblCreated.Name = "lblCreated";
            lblCreated.Size = new Size(308, 19);
            lblCreated.TabIndex = 0;
            // 
            // chkExifTaken
            // 
            chkExifTaken.AutoSize = true;
            chkExifTaken.Checked = true;
            chkExifTaken.CheckState = CheckState.Checked;
            chkExifTaken.Location = new Point(24, 72);
            chkExifTaken.Name = "chkExifTaken";
            chkExifTaken.Size = new Size(121, 19);
            chkExifTaken.TabIndex = 2;
            chkExifTaken.Text = "EXIF: дата зйомки";
            chkExifTaken.UseVisualStyleBackColor = true;
            chkExifTaken.CheckedChanged += chk_CheckedChanged;
            // 
            // chkFileModified
            // 
            chkFileModified.AutoSize = true;
            chkFileModified.Checked = true;
            chkFileModified.CheckState = CheckState.Checked;
            chkFileModified.Location = new Point(24, 47);
            chkFileModified.Name = "chkFileModified";
            chkFileModified.Size = new Size(137, 19);
            chkFileModified.TabIndex = 1;
            chkFileModified.Text = "Файл: дата змінення";
            chkFileModified.UseVisualStyleBackColor = true;
            chkFileModified.CheckedChanged += chk_CheckedChanged;
            // 
            // chkFileCreated
            // 
            chkFileCreated.AutoSize = true;
            chkFileCreated.Checked = true;
            chkFileCreated.CheckState = CheckState.Checked;
            chkFileCreated.Location = new Point(24, 22);
            chkFileCreated.Name = "chkFileCreated";
            chkFileCreated.Size = new Size(144, 19);
            chkFileCreated.TabIndex = 0;
            chkFileCreated.Text = "Файл: дата створення";
            chkFileCreated.UseVisualStyleBackColor = true;
            chkFileCreated.CheckedChanged += chk_CheckedChanged;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(437, 290);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 17;
            btnCancel.Text = "Відмінити";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            btnOk.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnOk.Location = new Point(12, 290);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(75, 23);
            btnOk.TabIndex = 16;
            btnOk.Text = "Виконати";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // TimestampForm
            // 
            AcceptButton = btnOk;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(520, 319);
            Controls.Add(btnCancel);
            Controls.Add(btnOk);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            MaximizeBox = false;
            MaximumSize = new Size(536, 358);
            MinimizeBox = false;
            MinimumSize = new Size(536, 358);
            Name = "TimestampForm";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Коригування дати/часу";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numStep).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private RadioButton rbtDateTime;
        private ComboBox comboDateTime;
        private DateTimePicker dtStart;
        private RadioButton rbtManual;
        private Label label3;
        private NumericUpDown numStep;
        private Label label2;
        private GroupBox groupBox1;
        private GroupBox groupBox3;
        private Panel panel1;
        private Label lblTaken;
        private Label lblModified;
        private Label lblCreated;
        private CheckBox chkExifTaken;
        private CheckBox chkFileModified;
        private CheckBox chkFileCreated;
        private Label lblCurr;
        private Button btnNext;
        private Button btnPrev;
        private Button btnCancel;
        private Button btnOk;
    }
}