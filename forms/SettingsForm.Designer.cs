namespace PhotoOrganizer
{
    partial class SettingsForm
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
            tabControl1 = new TabControl();
            tabView = new TabPage();
            chShowUnsupportedFiles = new CheckBox();
            tabRename = new TabPage();
            groupBox1 = new GroupBox();
            btnMaskOk = new Button();
            btnMasksRemove = new Button();
            btnMasksAdd = new Button();
            txtMask = new TextBox();
            lstFilenameMasks = new ListView();
            btnOk = new Button();
            btnCancel = new Button();
            tabControl1.SuspendLayout();
            tabView.SuspendLayout();
            tabRename.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabView);
            tabControl1.Controls.Add(tabRename);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(346, 279);
            tabControl1.TabIndex = 0;
            // 
            // tabView
            // 
            tabView.Controls.Add(chShowUnsupportedFiles);
            tabView.Location = new Point(4, 24);
            tabView.Name = "tabView";
            tabView.Padding = new Padding(3);
            tabView.Size = new Size(338, 251);
            tabView.TabIndex = 0;
            tabView.Text = "Вигляд";
            tabView.UseVisualStyleBackColor = true;
            // 
            // chShowUnsupportedFiles
            // 
            chShowUnsupportedFiles.AutoSize = true;
            chShowUnsupportedFiles.Location = new Point(8, 6);
            chShowUnsupportedFiles.Name = "chShowUnsupportedFiles";
            chShowUnsupportedFiles.Size = new Size(216, 19);
            chShowUnsupportedFiles.TabIndex = 0;
            chShowUnsupportedFiles.Text = "Показувати непідтримувані файли";
            chShowUnsupportedFiles.UseVisualStyleBackColor = true;
            chShowUnsupportedFiles.CheckedChanged += chShowUnsupportedFiles_CheckedChanged;
            // 
            // tabRename
            // 
            tabRename.Controls.Add(groupBox1);
            tabRename.Location = new Point(4, 24);
            tabRename.Name = "tabRename";
            tabRename.Padding = new Padding(3);
            tabRename.Size = new Size(338, 251);
            tabRename.TabIndex = 1;
            tabRename.Text = "Перейменування";
            tabRename.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnMaskOk);
            groupBox1.Controls.Add(btnMasksRemove);
            groupBox1.Controls.Add(btnMasksAdd);
            groupBox1.Controls.Add(txtMask);
            groupBox1.Controls.Add(lstFilenameMasks);
            groupBox1.Location = new Point(6, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(324, 240);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Шаблони імен файлів";
            // 
            // btnMaskOk
            // 
            btnMaskOk.Location = new Point(240, 207);
            btnMaskOk.Name = "btnMaskOk";
            btnMaskOk.Size = new Size(34, 23);
            btnMaskOk.TabIndex = 4;
            btnMaskOk.Text = "Ok";
            btnMaskOk.UseVisualStyleBackColor = true;
            btnMaskOk.Click += btnMaskOk_Click;
            // 
            // btnMasksRemove
            // 
            btnMasksRemove.Location = new Point(280, 179);
            btnMasksRemove.Name = "btnMasksRemove";
            btnMasksRemove.Size = new Size(34, 23);
            btnMasksRemove.TabIndex = 2;
            btnMasksRemove.Text = "–";
            btnMasksRemove.UseVisualStyleBackColor = true;
            btnMasksRemove.Click += btnMasksRemove_Click;
            // 
            // btnMasksAdd
            // 
            btnMasksAdd.Location = new Point(280, 150);
            btnMasksAdd.Name = "btnMasksAdd";
            btnMasksAdd.Size = new Size(34, 23);
            btnMasksAdd.TabIndex = 1;
            btnMasksAdd.Text = "+";
            btnMasksAdd.UseVisualStyleBackColor = true;
            btnMasksAdd.Click += btnMasksAdd_Click;
            // 
            // txtMask
            // 
            txtMask.Location = new Point(6, 207);
            txtMask.Name = "txtMask";
            txtMask.Size = new Size(228, 23);
            txtMask.TabIndex = 3;
            txtMask.KeyDown += txtMask_KeyDown;
            // 
            // lstFilenameMasks
            // 
            lstFilenameMasks.FullRowSelect = true;
            lstFilenameMasks.Location = new Point(6, 22);
            lstFilenameMasks.MultiSelect = false;
            lstFilenameMasks.Name = "lstFilenameMasks";
            lstFilenameMasks.Size = new Size(268, 179);
            lstFilenameMasks.Sorting = SortOrder.Ascending;
            lstFilenameMasks.TabIndex = 0;
            lstFilenameMasks.UseCompatibleStateImageBehavior = false;
            lstFilenameMasks.View = View.List;
            lstFilenameMasks.SelectedIndexChanged += lstFilenameMasks_SelectedIndexChanged;
            // 
            // btnOk
            // 
            btnOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnOk.Location = new Point(3, 293);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(118, 23);
            btnOk.TabIndex = 1;
            btnOk.Text = "Зберегти";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.Location = new Point(224, 293);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(118, 23);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Відмінити";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(346, 319);
            Controls.Add(btnCancel);
            Controls.Add(btnOk);
            Controls.Add(tabControl1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SettingsForm";
            Padding = new Padding(0, 0, 0, 40);
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Налаштування";
            tabControl1.ResumeLayout(false);
            tabView.ResumeLayout(false);
            tabView.PerformLayout();
            tabRename.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabView;
        private CheckBox chShowUnsupportedFiles;
        private Button btnOk;
        private Button btnCancel;
        private TabPage tabRename;
        private GroupBox groupBox1;
        private ListView lstFilenameMasks;
        private TextBox txtMask;
        private Button btnMasksRemove;
        private Button btnMasksAdd;
        private Button btnMaskOk;
    }
}