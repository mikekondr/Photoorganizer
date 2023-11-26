namespace PhotoOrganizer
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            TreeNode treeNode1 = new TreeNode("Мій комп'ютер", 1, 1);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            splitContainer1 = new SplitContainer();
            treeView1 = new TreeView();
            contextMenuStripFolders = new ContextMenuStrip(components);
            UpdateToolStripMenuItem = new ToolStripMenuItem();
            imageList1 = new ImageList(components);
            splitContainer2 = new SplitContainer();
            dataGridView1 = new DataGridView();
            icon = new DataGridViewImageColumn();
            name = new DataGridViewTextBoxColumn();
            type = new DataGridViewTextBoxColumn();
            dateCreated = new DataGridViewTextBoxColumn();
            dateModified = new DataGridViewTextBoxColumn();
            dateTaken = new DataGridViewTextBoxColumn();
            contextMenuStripFiles = new ContextMenuStrip(components);
            renameContextMenuItem = new ToolStripMenuItem();
            timestampContextMenuItem = new ToolStripMenuItem();
            splitContainer3 = new SplitContainer();
            propertyGrid1 = new PropertyGrid();
            pictureBox1 = new PictureBox();
            mainMenuStrip = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            ExitToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            undoToolStripMenuItem = new ToolStripMenuItem();
            redoToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator4 = new ToolStripSeparator();
            выбратьвсеToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            renameMainMenuItem = new ToolStripMenuItem();
            timestampMainMenuItem = new ToolStripMenuItem();
            ToolsToolStripMenuItem = new ToolStripMenuItem();
            SettingsToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            toolStripContainer1 = new ToolStripContainer();
            menuStrip2 = new MenuStrip();
            sidePanelToolStripMenuItem = new ToolStripMenuItem();
            infoPanelToolStripMenuItem = new ToolStripMenuItem();
            previewPanelToolStripMenuItem = new ToolStripMenuItem();
            queueToolStripMenuItem = new ToolStripMenuItem();
            bgReadFolders = new System.ComponentModel.BackgroundWorker();
            bgReadFiles = new System.ComponentModel.BackgroundWorker();
            bindingSourceFiles = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            contextMenuStripFolders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            contextMenuStripFiles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer3).BeginInit();
            splitContainer3.Panel1.SuspendLayout();
            splitContainer3.Panel2.SuspendLayout();
            splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            mainMenuStrip.SuspendLayout();
            toolStripContainer1.BottomToolStripPanel.SuspendLayout();
            toolStripContainer1.ContentPanel.SuspendLayout();
            toolStripContainer1.TopToolStripPanel.SuspendLayout();
            toolStripContainer1.SuspendLayout();
            menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSourceFiles).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(treeView1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(splitContainer2);
            splitContainer1.Size = new Size(800, 402);
            splitContainer1.SplitterDistance = 154;
            splitContainer1.TabIndex = 0;
            // 
            // treeView1
            // 
            treeView1.ContextMenuStrip = contextMenuStripFolders;
            treeView1.Dock = DockStyle.Fill;
            treeView1.ImageIndex = 0;
            treeView1.ImageList = imageList1;
            treeView1.Location = new Point(0, 0);
            treeView1.Name = "treeView1";
            treeNode1.ImageIndex = 1;
            treeNode1.Name = "Узел0";
            treeNode1.SelectedImageIndex = 1;
            treeNode1.Text = "Мій комп'ютер";
            treeView1.Nodes.AddRange(new TreeNode[] { treeNode1 });
            treeView1.SelectedImageIndex = 0;
            treeView1.Size = new Size(154, 402);
            treeView1.TabIndex = 0;
            treeView1.BeforeExpand += treeView1_BeforeExpand;
            treeView1.BeforeSelect += treeView1_BeforeSelect;
            treeView1.AfterSelect += treeView1_AfterSelect;
            // 
            // contextMenuStripFolders
            // 
            contextMenuStripFolders.Items.AddRange(new ToolStripItem[] { UpdateToolStripMenuItem });
            contextMenuStripFolders.Name = "contextMenuStripFolders";
            contextMenuStripFolders.Size = new Size(123, 26);
            // 
            // UpdateToolStripMenuItem
            // 
            UpdateToolStripMenuItem.Enabled = false;
            UpdateToolStripMenuItem.Name = "UpdateToolStripMenuItem";
            UpdateToolStripMenuItem.Size = new Size(122, 22);
            UpdateToolStripMenuItem.Text = "Оновити";
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth16Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "empty.png");
            imageList1.Images.SetKeyName(1, "computer.png");
            imageList1.Images.SetKeyName(2, "drive.png");
            imageList1.Images.SetKeyName(3, "empty-folder.png");
            imageList1.Images.SetKeyName(4, "unknown-document.png");
            imageList1.Images.SetKeyName(5, "image.png");
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(dataGridView1);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(splitContainer3);
            splitContainer2.Size = new Size(642, 402);
            splitContainer2.SplitterDistance = 490;
            splitContainer2.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { icon, name, type, dateCreated, dateModified, dateTaken });
            dataGridView1.ContextMenuStrip = contextMenuStripFiles;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(490, 402);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellFormatting += dataGridView1_CellFormatting;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // icon
            // 
            icon.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            icon.DataPropertyName = "icon";
            icon.HeaderText = "";
            icon.MinimumWidth = 20;
            icon.Name = "icon";
            icon.ReadOnly = true;
            icon.Resizable = DataGridViewTriState.False;
            icon.Width = 20;
            // 
            // name
            // 
            name.DataPropertyName = "Name";
            name.HeaderText = "Найменування";
            name.Name = "name";
            name.ReadOnly = true;
            name.Width = 250;
            // 
            // type
            // 
            type.DataPropertyName = "Type";
            type.HeaderText = "Тип";
            type.Name = "type";
            type.ReadOnly = true;
            // 
            // dateCreated
            // 
            dateCreated.DataPropertyName = "DateCreated";
            dataGridViewCellStyle1.Format = "G";
            dataGridViewCellStyle1.NullValue = "\"\"";
            dateCreated.DefaultCellStyle = dataGridViewCellStyle1;
            dateCreated.HeaderText = "Дата створення";
            dateCreated.Name = "dateCreated";
            dateCreated.ReadOnly = true;
            // 
            // dateModified
            // 
            dateModified.DataPropertyName = "DateModified";
            dataGridViewCellStyle2.Format = "G";
            dataGridViewCellStyle2.NullValue = "\"\"";
            dateModified.DefaultCellStyle = dataGridViewCellStyle2;
            dateModified.HeaderText = "Дата зміни";
            dateModified.Name = "dateModified";
            dateModified.ReadOnly = true;
            // 
            // dateTaken
            // 
            dateTaken.DataPropertyName = "DateTaken";
            dataGridViewCellStyle3.Format = "G";
            dataGridViewCellStyle3.NullValue = "\"\"";
            dateTaken.DefaultCellStyle = dataGridViewCellStyle3;
            dateTaken.HeaderText = "Дата зйомки";
            dateTaken.Name = "dateTaken";
            dateTaken.ReadOnly = true;
            // 
            // contextMenuStripFiles
            // 
            contextMenuStripFiles.Items.AddRange(new ToolStripItem[] { renameContextMenuItem, timestampContextMenuItem });
            contextMenuStripFiles.Name = "contextMenuStripFiles";
            contextMenuStripFiles.Size = new Size(170, 48);
            // 
            // renameContextMenuItem
            // 
            renameContextMenuItem.Name = "renameContextMenuItem";
            renameContextMenuItem.Size = new Size(169, 22);
            renameContextMenuItem.Text = "Перейменувати";
            renameContextMenuItem.Click += RenameToolStripMenuItem_Click;
            // 
            // timestampContextMenuItem
            // 
            timestampContextMenuItem.Name = "timestampContextMenuItem";
            timestampContextMenuItem.Size = new Size(169, 22);
            timestampContextMenuItem.Text = "Змінити дату/час";
            timestampContextMenuItem.Click += TimestampToolStripMenuItem_Click;
            // 
            // splitContainer3
            // 
            splitContainer3.Dock = DockStyle.Fill;
            splitContainer3.Location = new Point(0, 0);
            splitContainer3.Name = "splitContainer3";
            splitContainer3.Orientation = Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            splitContainer3.Panel1.Controls.Add(propertyGrid1);
            // 
            // splitContainer3.Panel2
            // 
            splitContainer3.Panel2.Controls.Add(pictureBox1);
            splitContainer3.Size = new Size(148, 402);
            splitContainer3.SplitterDistance = 200;
            splitContainer3.TabIndex = 3;
            // 
            // propertyGrid1
            // 
            propertyGrid1.Dock = DockStyle.Fill;
            propertyGrid1.Enabled = false;
            propertyGrid1.HelpVisible = false;
            propertyGrid1.Location = new Point(0, 0);
            propertyGrid1.Name = "propertyGrid1";
            propertyGrid1.Size = new Size(148, 200);
            propertyGrid1.TabIndex = 2;
            propertyGrid1.ToolbarVisible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(148, 198);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // mainMenuStrip
            // 
            mainMenuStrip.Dock = DockStyle.None;
            mainMenuStrip.GripStyle = ToolStripGripStyle.Visible;
            mainMenuStrip.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem, editToolStripMenuItem, ToolsToolStripMenuItem, helpToolStripMenuItem });
            mainMenuStrip.Location = new Point(0, 0);
            mainMenuStrip.Name = "mainMenuStrip";
            mainMenuStrip.Size = new Size(800, 24);
            mainMenuStrip.TabIndex = 1;
            mainMenuStrip.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ExitToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(48, 20);
            файлToolStripMenuItem.Text = "&Файл";
            // 
            // ExitToolStripMenuItem
            // 
            ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            ExitToolStripMenuItem.Size = new Size(103, 22);
            ExitToolStripMenuItem.Text = "Ви&хід";
            ExitToolStripMenuItem.Click += ExitToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { undoToolStripMenuItem, redoToolStripMenuItem, toolStripSeparator4, выбратьвсеToolStripMenuItem, toolStripSeparator1, renameMainMenuItem, timestampMainMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(79, 20);
            editToolStripMenuItem.Text = "&Редагувати";
            // 
            // undoToolStripMenuItem
            // 
            undoToolStripMenuItem.Enabled = false;
            undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            undoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Z;
            undoToolStripMenuItem.Size = new Size(175, 22);
            undoToolStripMenuItem.Text = "&Відмінити";
            undoToolStripMenuItem.Visible = false;
            // 
            // redoToolStripMenuItem
            // 
            redoToolStripMenuItem.Enabled = false;
            redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            redoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Y;
            redoToolStripMenuItem.Size = new Size(175, 22);
            redoToolStripMenuItem.Text = "&Повторити";
            redoToolStripMenuItem.Visible = false;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(172, 6);
            toolStripSeparator4.Visible = false;
            // 
            // выбратьвсеToolStripMenuItem
            // 
            выбратьвсеToolStripMenuItem.Enabled = false;
            выбратьвсеToolStripMenuItem.Name = "выбратьвсеToolStripMenuItem";
            выбратьвсеToolStripMenuItem.Size = new Size(175, 22);
            выбратьвсеToolStripMenuItem.Text = "Выбрать &все";
            выбратьвсеToolStripMenuItem.Visible = false;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(172, 6);
            toolStripSeparator1.Visible = false;
            // 
            // renameMainMenuItem
            // 
            renameMainMenuItem.Name = "renameMainMenuItem";
            renameMainMenuItem.Size = new Size(175, 22);
            renameMainMenuItem.Text = "Перейменувати";
            renameMainMenuItem.Click += RenameToolStripMenuItem_Click;
            // 
            // timestampMainMenuItem
            // 
            timestampMainMenuItem.Name = "timestampMainMenuItem";
            timestampMainMenuItem.Size = new Size(175, 22);
            timestampMainMenuItem.Text = "Змінити дату/час";
            timestampMainMenuItem.Click += TimestampToolStripMenuItem_Click;
            // 
            // ToolsToolStripMenuItem
            // 
            ToolsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { SettingsToolStripMenuItem });
            ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem";
            ToolsToolStripMenuItem.Size = new Size(87, 20);
            ToolsToolStripMenuItem.Text = "&Інструменти";
            // 
            // SettingsToolStripMenuItem
            // 
            SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem";
            SettingsToolStripMenuItem.Size = new Size(156, 22);
            SettingsToolStripMenuItem.Text = "&Налаштування";
            SettingsToolStripMenuItem.Click += SettingsToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(61, 20);
            helpToolStripMenuItem.Text = "&Довідка";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(163, 22);
            aboutToolStripMenuItem.Text = "&Про програму...";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.BottomToolStripPanel
            // 
            toolStripContainer1.BottomToolStripPanel.Controls.Add(menuStrip2);
            // 
            // toolStripContainer1.ContentPanel
            // 
            toolStripContainer1.ContentPanel.Controls.Add(splitContainer1);
            toolStripContainer1.ContentPanel.Size = new Size(800, 402);
            toolStripContainer1.Dock = DockStyle.Fill;
            toolStripContainer1.Location = new Point(0, 0);
            toolStripContainer1.Name = "toolStripContainer1";
            toolStripContainer1.Size = new Size(800, 450);
            toolStripContainer1.TabIndex = 3;
            toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            toolStripContainer1.TopToolStripPanel.Controls.Add(mainMenuStrip);
            // 
            // menuStrip2
            // 
            menuStrip2.Dock = DockStyle.None;
            menuStrip2.Items.AddRange(new ToolStripItem[] { sidePanelToolStripMenuItem, infoPanelToolStripMenuItem, previewPanelToolStripMenuItem, queueToolStripMenuItem });
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.RightToLeft = RightToLeft.Yes;
            menuStrip2.Size = new Size(800, 24);
            menuStrip2.TabIndex = 0;
            menuStrip2.Text = "menuStrip2";
            // 
            // sidePanelToolStripMenuItem
            // 
            sidePanelToolStripMenuItem.Checked = true;
            sidePanelToolStripMenuItem.CheckOnClick = true;
            sidePanelToolStripMenuItem.CheckState = CheckState.Checked;
            sidePanelToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
            sidePanelToolStripMenuItem.Image = (Image)resources.GetObject("sidePanelToolStripMenuItem.Image");
            sidePanelToolStripMenuItem.Name = "sidePanelToolStripMenuItem";
            sidePanelToolStripMenuItem.Size = new Size(28, 20);
            sidePanelToolStripMenuItem.Text = "Показати бічну панель";
            sidePanelToolStripMenuItem.CheckedChanged += sidePanelToolStripMenuItem_CheckedChanged;
            // 
            // infoPanelToolStripMenuItem
            // 
            infoPanelToolStripMenuItem.Checked = true;
            infoPanelToolStripMenuItem.CheckOnClick = true;
            infoPanelToolStripMenuItem.CheckState = CheckState.Checked;
            infoPanelToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
            infoPanelToolStripMenuItem.Image = (Image)resources.GetObject("infoPanelToolStripMenuItem.Image");
            infoPanelToolStripMenuItem.Name = "infoPanelToolStripMenuItem";
            infoPanelToolStripMenuItem.Size = new Size(28, 20);
            infoPanelToolStripMenuItem.Text = "Інформація";
            infoPanelToolStripMenuItem.CheckedChanged += infoPanelToolStripMenuItem_CheckedChanged;
            // 
            // previewPanelToolStripMenuItem
            // 
            previewPanelToolStripMenuItem.Checked = true;
            previewPanelToolStripMenuItem.CheckOnClick = true;
            previewPanelToolStripMenuItem.CheckState = CheckState.Checked;
            previewPanelToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
            previewPanelToolStripMenuItem.Image = (Image)resources.GetObject("previewPanelToolStripMenuItem.Image");
            previewPanelToolStripMenuItem.Name = "previewPanelToolStripMenuItem";
            previewPanelToolStripMenuItem.Size = new Size(28, 20);
            previewPanelToolStripMenuItem.Text = "Перегляд фото";
            previewPanelToolStripMenuItem.CheckedChanged += previewPanelToolStripMenuItem_CheckedChanged;
            // 
            // queueToolStripMenuItem
            // 
            queueToolStripMenuItem.BackColor = SystemColors.Control;
            queueToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            queueToolStripMenuItem.ForeColor = Color.Red;
            queueToolStripMenuItem.Image = (Image)resources.GetObject("queueToolStripMenuItem.Image");
            queueToolStripMenuItem.Name = "queueToolStripMenuItem";
            queueToolStripMenuItem.Size = new Size(28, 20);
            queueToolStripMenuItem.Click += queueToolStripMenuItem_Click;
            // 
            // bgReadFolders
            // 
            bgReadFolders.WorkerSupportsCancellation = true;
            bgReadFolders.DoWork += bgReadFolders_DoWork;
            bgReadFolders.RunWorkerCompleted += bgReadFolders_RunWorkerCompleted;
            // 
            // bgReadFiles
            // 
            bgReadFiles.WorkerSupportsCancellation = true;
            bgReadFiles.DoWork += bgReadFiles_DoWork;
            // 
            // bindingSourceFiles
            // 
            bindingSourceFiles.AllowNew = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(toolStripContainer1);
            DoubleBuffered = true;
            MainMenuStrip = mainMenuStrip;
            Name = "MainForm";
            Text = "ФотоОрганайзер";
            FormClosing += MainForm_FormClosing;
            Load += Form1_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            contextMenuStripFolders.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            contextMenuStripFiles.ResumeLayout(false);
            splitContainer3.Panel1.ResumeLayout(false);
            splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer3).EndInit();
            splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            mainMenuStrip.ResumeLayout(false);
            mainMenuStrip.PerformLayout();
            toolStripContainer1.BottomToolStripPanel.ResumeLayout(false);
            toolStripContainer1.BottomToolStripPanel.PerformLayout();
            toolStripContainer1.ContentPanel.ResumeLayout(false);
            toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            toolStripContainer1.TopToolStripPanel.PerformLayout();
            toolStripContainer1.ResumeLayout(false);
            toolStripContainer1.PerformLayout();
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSourceFiles).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private TreeView treeView1;
        private MenuStrip mainMenuStrip;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem ExitToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem undoToolStripMenuItem;
        private ToolStripMenuItem redoToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem выбратьвсеToolStripMenuItem;
        private ToolStripMenuItem ToolsToolStripMenuItem;
        private ToolStripMenuItem SettingsToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripContainer toolStripContainer1;
        private System.ComponentModel.BackgroundWorker bgReadFolders;
        private ImageList imageList1;
        private DataGridView dataGridView1;
        private BindingSource bindingSourceFiles;
        private DataGridViewImageColumn icon;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn type;
        private DataGridViewTextBoxColumn dateCreated;
        private DataGridViewTextBoxColumn dateModified;
        private DataGridViewTextBoxColumn dateTaken;
        private System.ComponentModel.BackgroundWorker bgReadFiles;
        private ContextMenuStrip contextMenuStripFolders;
        private ToolStripMenuItem UpdateToolStripMenuItem;
        private ContextMenuStrip contextMenuStripFiles;
        private ToolStripMenuItem renameContextMenuItem;
        private PictureBox pictureBox1;
        private PropertyGrid propertyGrid1;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem sidePanelToolStripMenuItem;
        private ToolStripMenuItem previewPanelToolStripMenuItem;
        private ToolStripMenuItem infoPanelToolStripMenuItem;
        private SplitContainer splitContainer2;
        private SplitContainer splitContainer3;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem renameMainMenuItem;
        private ToolStripMenuItem timestampContextMenuItem;
        private ToolStripMenuItem timestampMainMenuItem;
        private ToolStripMenuItem queueToolStripMenuItem;
    }
}