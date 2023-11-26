namespace PhotoOrganizer
{
    partial class RenameForm
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
            comboTemplate = new ComboBox();
            panelIncrement = new Panel();
            dtStart = new DateTimePicker();
            label3 = new Label();
            numStep = new NumericUpDown();
            label2 = new Label();
            label1 = new Label();
            btnOk = new Button();
            btnCancel = new Button();
            rbtIncrement = new RadioButton();
            rbtTemplate = new RadioButton();
            rbtManual = new RadioButton();
            txtTemplate = new TextBox();
            comboDateTime = new ComboBox();
            rbtDateTime = new RadioButton();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            panelIncrement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numStep).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // comboTemplate
            // 
            comboTemplate.FormattingEnabled = true;
            comboTemplate.Location = new Point(24, 47);
            comboTemplate.Name = "comboTemplate";
            comboTemplate.Size = new Size(216, 23);
            comboTemplate.TabIndex = 0;
            // 
            // panelIncrement
            // 
            panelIncrement.Controls.Add(dtStart);
            panelIncrement.Controls.Add(label3);
            panelIncrement.Controls.Add(numStep);
            panelIncrement.Controls.Add(label2);
            panelIncrement.Controls.Add(label1);
            panelIncrement.Enabled = false;
            panelIncrement.Location = new Point(24, 101);
            panelIncrement.Name = "panelIncrement";
            panelIncrement.Size = new Size(217, 66);
            panelIncrement.TabIndex = 5;
            // 
            // dtStart
            // 
            dtStart.CustomFormat = "dd.MM.yyyy HH:mm:ss";
            dtStart.Format = DateTimePickerFormat.Custom;
            dtStart.Location = new Point(63, 2);
            dtStart.Name = "dtStart";
            dtStart.Size = new Size(151, 23);
            dtStart.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(189, 37);
            label3.Name = "label3";
            label3.Size = new Size(25, 15);
            label3.TabIndex = 4;
            label3.Text = "сек";
            // 
            // numStep
            // 
            numStep.Location = new Point(63, 33);
            numStep.Maximum = new decimal(new int[] { 172800, 0, 0, 0 });
            numStep.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numStep.Name = "numStep";
            numStep.Size = new Size(120, 23);
            numStep.TabIndex = 3;
            numStep.ThousandsSeparator = true;
            numStep.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 37);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 2;
            label2.Text = "Крок:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 6);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 0;
            label1.Text = "Початок:";
            // 
            // btnOk
            // 
            btnOk.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnOk.Location = new Point(11, 341);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(75, 23);
            btnOk.TabIndex = 6;
            btnOk.Text = "Виконати";
            btnOk.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(183, 341);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Відмінити";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // rbtIncrement
            // 
            rbtIncrement.AutoSize = true;
            rbtIncrement.Location = new Point(6, 76);
            rbtIncrement.Name = "rbtIncrement";
            rbtIncrement.Size = new Size(90, 19);
            rbtIncrement.TabIndex = 4;
            rbtIncrement.Text = "Послідовно";
            rbtIncrement.UseVisualStyleBackColor = true;
            rbtIncrement.CheckedChanged += rbtIncrement_CheckedChanged;
            // 
            // rbtTemplate
            // 
            rbtTemplate.AutoSize = true;
            rbtTemplate.Checked = true;
            rbtTemplate.Location = new Point(6, 22);
            rbtTemplate.Name = "rbtTemplate";
            rbtTemplate.Size = new Size(105, 19);
            rbtTemplate.TabIndex = 0;
            rbtTemplate.TabStop = true;
            rbtTemplate.Text = "За шаблоном:";
            rbtTemplate.UseVisualStyleBackColor = true;
            rbtTemplate.CheckedChanged += rbtTemplate_CheckedChanged;
            // 
            // rbtManual
            // 
            rbtManual.AutoSize = true;
            rbtManual.Location = new Point(6, 76);
            rbtManual.Name = "rbtManual";
            rbtManual.Size = new Size(68, 19);
            rbtManual.TabIndex = 2;
            rbtManual.Text = "Вручну:";
            rbtManual.UseVisualStyleBackColor = true;
            rbtManual.CheckedChanged += rbtManual_CheckedChanged;
            // 
            // txtTemplate
            // 
            txtTemplate.Enabled = false;
            txtTemplate.Location = new Point(24, 101);
            txtTemplate.Name = "txtTemplate";
            txtTemplate.Size = new Size(216, 23);
            txtTemplate.TabIndex = 0;
            // 
            // comboDateTime
            // 
            comboDateTime.FormattingEnabled = true;
            comboDateTime.Location = new Point(24, 47);
            comboDateTime.Name = "comboDateTime";
            comboDateTime.Size = new Size(217, 23);
            comboDateTime.TabIndex = 9;
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
            // groupBox1
            // 
            groupBox1.Controls.Add(rbtTemplate);
            groupBox1.Controls.Add(rbtManual);
            groupBox1.Controls.Add(txtTemplate);
            groupBox1.Controls.Add(comboTemplate);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(247, 137);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ім'я файлу:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rbtDateTime);
            groupBox2.Controls.Add(comboDateTime);
            groupBox2.Controls.Add(panelIncrement);
            groupBox2.Controls.Add(rbtIncrement);
            groupBox2.Location = new Point(11, 155);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(247, 180);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            groupBox2.Text = "Використати:";
            // 
            // RenameForm
            // 
            AcceptButton = btnOk;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(270, 373);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnCancel);
            Controls.Add(btnOk);
            MaximizeBox = false;
            MaximumSize = new Size(286, 412);
            MinimizeBox = false;
            MinimumSize = new Size(286, 412);
            Name = "RenameForm";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Перейменувати";
            panelIncrement.ResumeLayout(false);
            panelIncrement.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numStep).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private ComboBox comboTemplate;
        private Panel panel2;
        private Panel panelIncrement;
        private Button btnOk;
        private Button btnCancel;
        private RadioButton rbtIncrement;
        private RadioButton rbtTemplate;
        private RadioButton rbtManual;
        private TextBox txtTemplate;
        private ComboBox comboDateTime;
        private RadioButton rbtDateTime;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private NumericUpDown numStep;
        private DateTimePicker dtStart;
    }
}