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
            rbtTemplate = new RadioButton();
            panel1 = new Panel();
            label1 = new Label();
            comboBox1 = new ComboBox();
            rbtManual = new RadioButton();
            panel2 = new Panel();
            textBox1 = new TextBox();
            rbtIncrement = new RadioButton();
            panel3 = new Panel();
            btnOk = new Button();
            btnCancel = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // rbtTemplate
            // 
            rbtTemplate.AutoSize = true;
            rbtTemplate.Location = new Point(12, 12);
            rbtTemplate.Name = "rbtTemplate";
            rbtTemplate.Size = new Size(102, 19);
            rbtTemplate.TabIndex = 0;
            rbtTemplate.TabStop = true;
            rbtTemplate.Text = "За шаблоном";
            rbtTemplate.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(comboBox1);
            panel1.Location = new Point(30, 37);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 100);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.Location = new Point(3, 29);
            label1.Name = "label1";
            label1.Size = new Size(194, 71);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(3, 3);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(194, 23);
            comboBox1.TabIndex = 0;
            // 
            // rbtManual
            // 
            rbtManual.AutoSize = true;
            rbtManual.Location = new Point(12, 143);
            rbtManual.Name = "rbtManual";
            rbtManual.Size = new Size(65, 19);
            rbtManual.TabIndex = 2;
            rbtManual.TabStop = true;
            rbtManual.Text = "Вручну";
            rbtManual.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(textBox1);
            panel2.Location = new Point(30, 168);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 30);
            panel2.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(3, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(194, 23);
            textBox1.TabIndex = 0;
            // 
            // rbtIncrement
            // 
            rbtIncrement.AutoSize = true;
            rbtIncrement.Location = new Point(12, 204);
            rbtIncrement.Name = "rbtIncrement";
            rbtIncrement.Size = new Size(90, 19);
            rbtIncrement.TabIndex = 4;
            rbtIncrement.TabStop = true;
            rbtIncrement.Text = "Послідовно";
            rbtIncrement.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.Location = new Point(30, 229);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 100);
            panel3.TabIndex = 5;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(12, 347);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(75, 23);
            btnOk.TabIndex = 6;
            btnOk.Text = "Виконати";
            btnOk.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(167, 347);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Відмінити";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // RenameForm
            // 
            AcceptButton = btnOk;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(254, 378);
            Controls.Add(btnCancel);
            Controls.Add(btnOk);
            Controls.Add(panel3);
            Controls.Add(rbtIncrement);
            Controls.Add(panel2);
            Controls.Add(rbtManual);
            Controls.Add(panel1);
            Controls.Add(rbtTemplate);
            Name = "RenameForm";
            Text = "Перейменувати";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton rbtTemplate;
        private Panel panel1;
        private Label label1;
        private ComboBox comboBox1;
        private RadioButton rbtManual;
        private Panel panel2;
        private TextBox textBox1;
        private RadioButton rbtIncrement;
        private Panel panel3;
        private Button btnOk;
        private Button btnCancel;
    }
}