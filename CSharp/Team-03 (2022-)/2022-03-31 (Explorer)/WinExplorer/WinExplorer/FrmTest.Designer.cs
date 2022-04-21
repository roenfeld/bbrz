namespace WinExplorer
{
  partial class FrmTest
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
      this.components = new System.ComponentModel.Container();
      System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Knoten1");
      System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Knoten2.1");
      System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Knoten2", new System.Windows.Forms.TreeNode[] {
            treeNode2});
      System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Knoten3.1.1");
      System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Knoten3.1", new System.Windows.Forms.TreeNode[] {
            treeNode4});
      System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Knoten3", new System.Windows.Forms.TreeNode[] {
            treeNode5});
      System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("ROOT", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode3,
            treeNode6});
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTest));
      System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
      System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
      System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "Test1",
            "123",
            "info"}, "File");
      System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("Test2");
      System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("Test3");
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
      this.trvTest = new System.Windows.Forms.TreeView();
      this.imgTest = new System.Windows.Forms.ImageList(this.components);
      this.btnFillTree = new System.Windows.Forms.Button();
      this.progressBar1 = new System.Windows.Forms.ProgressBar();
      this.lvwTest = new System.Windows.Forms.ListView();
      this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.btnFillList = new System.Windows.Forms.Button();
      this.chkIncludeDirs = new System.Windows.Forms.CheckBox();
      this.mnuMain = new System.Windows.Forms.MenuStrip();
      this.mnuMainFile = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuOptions = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuOptionsIncludeDirs = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuOptionsSettings = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuOptionsSettingsOpenExplorer = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuOptionsFont = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.panLeft = new System.Windows.Forms.Panel();
      this.splitter1 = new System.Windows.Forms.Splitter();
      this.panCenter = new System.Windows.Forms.Panel();
      this.dgvFiles = new System.Windows.Forms.DataGridView();
      this.dgvColName = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dgvColIcon = new System.Windows.Forms.DataGridViewImageColumn();
      this.dgvColLength = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.mnuMain.SuspendLayout();
      this.panLeft.SuspendLayout();
      this.panCenter.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgvFiles)).BeginInit();
      this.SuspendLayout();
      // 
      // trvTest
      // 
      this.trvTest.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.trvTest.ImageIndex = 0;
      this.trvTest.ImageList = this.imgTest;
      this.trvTest.Location = new System.Drawing.Point(9, 10);
      this.trvTest.Margin = new System.Windows.Forms.Padding(4);
      this.trvTest.Name = "trvTest";
      treeNode1.Name = "Knoten1";
      treeNode1.Text = "Knoten1";
      treeNode2.ImageIndex = 2;
      treeNode2.Name = "Knoten21";
      treeNode2.Text = "Knoten2.1";
      treeNode3.Name = "Knoten2";
      treeNode3.Text = "Knoten2";
      treeNode4.Name = "Knoten311";
      treeNode4.Text = "Knoten3.1.1";
      treeNode5.Name = "Knoten31";
      treeNode5.Text = "Knoten3.1";
      treeNode6.Name = "Knoten3";
      treeNode6.Text = "Knoten3";
      treeNode7.Name = "ndRoot";
      treeNode7.Text = "ROOT";
      this.trvTest.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode7});
      this.trvTest.PathSeparator = "#";
      this.trvTest.SelectedImageIndex = 0;
      this.trvTest.Size = new System.Drawing.Size(362, 499);
      this.trvTest.TabIndex = 0;
      this.trvTest.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.trvTest_BeforeExpand);
      this.trvTest.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.trvTest_AfterExpand);
      this.trvTest.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trvTest_AfterSelect);
      // 
      // imgTest
      // 
      this.imgTest.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgTest.ImageStream")));
      this.imgTest.TransparentColor = System.Drawing.Color.Transparent;
      this.imgTest.Images.SetKeyName(0, "PC");
      this.imgTest.Images.SetKeyName(1, "HDD");
      this.imgTest.Images.SetKeyName(2, "FolderClosed");
      this.imgTest.Images.SetKeyName(3, "FolderOpened");
      this.imgTest.Images.SetKeyName(4, "File");
      // 
      // btnFillTree
      // 
      this.btnFillTree.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btnFillTree.Location = new System.Drawing.Point(468, 476);
      this.btnFillTree.Margin = new System.Windows.Forms.Padding(4);
      this.btnFillTree.Name = "btnFillTree";
      this.btnFillTree.Size = new System.Drawing.Size(167, 33);
      this.btnFillTree.TabIndex = 1;
      this.btnFillTree.Text = "Tree füllen";
      this.btnFillTree.UseVisualStyleBackColor = true;
      this.btnFillTree.Visible = false;
      // 
      // progressBar1
      // 
      this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.progressBar1.Location = new System.Drawing.Point(9, 491);
      this.progressBar1.Margin = new System.Windows.Forms.Padding(4);
      this.progressBar1.Name = "progressBar1";
      this.progressBar1.Size = new System.Drawing.Size(364, 23);
      this.progressBar1.TabIndex = 2;
      this.progressBar1.Visible = false;
      // 
      // lvwTest
      // 
      this.lvwTest.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.lvwTest.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
      this.lvwTest.FullRowSelect = true;
      listViewGroup1.Header = "ListViewGroup";
      listViewGroup1.Name = "listViewGroup1";
      listViewGroup2.Header = "ListViewGroup";
      listViewGroup2.Name = "listViewGroup2";
      this.lvwTest.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2});
      this.lvwTest.HideSelection = false;
      this.lvwTest.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
      this.lvwTest.LargeImageList = this.imgTest;
      this.lvwTest.Location = new System.Drawing.Point(10, 332);
      this.lvwTest.Margin = new System.Windows.Forms.Padding(4);
      this.lvwTest.Name = "lvwTest";
      this.lvwTest.ShowGroups = false;
      this.lvwTest.Size = new System.Drawing.Size(181, 134);
      this.lvwTest.SmallImageList = this.imgTest;
      this.lvwTest.TabIndex = 3;
      this.lvwTest.UseCompatibleStateImageBehavior = false;
      this.lvwTest.View = System.Windows.Forms.View.Details;
      this.lvwTest.Visible = false;
      this.lvwTest.DoubleClick += new System.EventHandler(this.lvwTest_DoubleClick);
      // 
      // columnHeader1
      // 
      this.columnHeader1.Text = "Name";
      this.columnHeader1.Width = 217;
      // 
      // columnHeader2
      // 
      this.columnHeader2.Text = "Size";
      this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.columnHeader2.Width = 219;
      // 
      // columnHeader3
      // 
      this.columnHeader3.Text = "Info";
      this.columnHeader3.Width = 148;
      // 
      // btnFillList
      // 
      this.btnFillList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btnFillList.Location = new System.Drawing.Point(287, 476);
      this.btnFillList.Margin = new System.Windows.Forms.Padding(4);
      this.btnFillList.Name = "btnFillList";
      this.btnFillList.Size = new System.Drawing.Size(167, 33);
      this.btnFillList.TabIndex = 4;
      this.btnFillList.Text = "List füllen";
      this.btnFillList.UseVisualStyleBackColor = true;
      this.btnFillList.Visible = false;
      // 
      // chkIncludeDirs
      // 
      this.chkIncludeDirs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.chkIncludeDirs.AutoSize = true;
      this.chkIncludeDirs.Checked = true;
      this.chkIncludeDirs.CheckState = System.Windows.Forms.CheckState.Checked;
      this.chkIncludeDirs.Location = new System.Drawing.Point(70, 474);
      this.chkIncludeDirs.Margin = new System.Windows.Forms.Padding(4);
      this.chkIncludeDirs.Name = "chkIncludeDirs";
      this.chkIncludeDirs.Size = new System.Drawing.Size(189, 29);
      this.chkIncludeDirs.TabIndex = 5;
      this.chkIncludeDirs.Text = "Include Directories";
      this.chkIncludeDirs.UseVisualStyleBackColor = true;
      this.chkIncludeDirs.Visible = false;
      // 
      // mnuMain
      // 
      this.mnuMain.Font = new System.Drawing.Font("Segoe UI", 14.25F);
      this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMainFile,
            this.mnuOptions});
      this.mnuMain.Location = new System.Drawing.Point(0, 0);
      this.mnuMain.Name = "mnuMain";
      this.mnuMain.Size = new System.Drawing.Size(1028, 33);
      this.mnuMain.TabIndex = 6;
      this.mnuMain.Text = "menuStrip1";
      // 
      // mnuMainFile
      // 
      this.mnuMainFile.Name = "mnuMainFile";
      this.mnuMainFile.Size = new System.Drawing.Size(53, 29);
      this.mnuMainFile.Text = "File";
      // 
      // mnuOptions
      // 
      this.mnuOptions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOptionsIncludeDirs,
            this.mnuOptionsSettings,
            this.toolStripSeparator1,
            this.aboutToolStripMenuItem});
      this.mnuOptions.Name = "mnuOptions";
      this.mnuOptions.Size = new System.Drawing.Size(90, 29);
      this.mnuOptions.Text = "Options";
      // 
      // mnuOptionsIncludeDirs
      // 
      this.mnuOptionsIncludeDirs.CheckOnClick = true;
      this.mnuOptionsIncludeDirs.Name = "mnuOptionsIncludeDirs";
      this.mnuOptionsIncludeDirs.Size = new System.Drawing.Size(242, 30);
      this.mnuOptionsIncludeDirs.Text = "Include Directories";
      this.mnuOptionsIncludeDirs.CheckedChanged += new System.EventHandler(this.mnuOptionsIncludeDirs_CheckedChanged);
      // 
      // mnuOptionsSettings
      // 
      this.mnuOptionsSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOptionsSettingsOpenExplorer,
            this.mnuOptionsFont});
      this.mnuOptionsSettings.Name = "mnuOptionsSettings";
      this.mnuOptionsSettings.Size = new System.Drawing.Size(242, 30);
      this.mnuOptionsSettings.Text = "Settings...";
      // 
      // mnuOptionsSettingsOpenExplorer
      // 
      this.mnuOptionsSettingsOpenExplorer.Name = "mnuOptionsSettingsOpenExplorer";
      this.mnuOptionsSettingsOpenExplorer.Size = new System.Drawing.Size(238, 30);
      this.mnuOptionsSettingsOpenExplorer.Text = "Open in Explorer...";
      this.mnuOptionsSettingsOpenExplorer.Click += new System.EventHandler(this.mnuOptionsSettingsOpenExplorer_Click);
      // 
      // mnuOptionsFont
      // 
      this.mnuOptionsFont.Name = "mnuOptionsFont";
      this.mnuOptionsFont.Size = new System.Drawing.Size(238, 30);
      this.mnuOptionsFont.Text = "Font...";
      this.mnuOptionsFont.Click += new System.EventHandler(this.mnuOptionsFont_Click);
      // 
      // toolStripSeparator1
      // 
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new System.Drawing.Size(239, 6);
      // 
      // aboutToolStripMenuItem
      // 
      this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
      this.aboutToolStripMenuItem.Size = new System.Drawing.Size(242, 30);
      this.aboutToolStripMenuItem.Text = "About...";
      // 
      // panLeft
      // 
      this.panLeft.BackColor = System.Drawing.SystemColors.Control;
      this.panLeft.Controls.Add(this.trvTest);
      this.panLeft.Controls.Add(this.progressBar1);
      this.panLeft.Dock = System.Windows.Forms.DockStyle.Left;
      this.panLeft.Location = new System.Drawing.Point(0, 33);
      this.panLeft.Margin = new System.Windows.Forms.Padding(4);
      this.panLeft.Name = "panLeft";
      this.panLeft.Padding = new System.Windows.Forms.Padding(6);
      this.panLeft.Size = new System.Drawing.Size(380, 516);
      this.panLeft.TabIndex = 7;
      // 
      // splitter1
      // 
      this.splitter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.splitter1.Location = new System.Drawing.Point(380, 33);
      this.splitter1.Margin = new System.Windows.Forms.Padding(4);
      this.splitter1.Name = "splitter1";
      this.splitter1.Size = new System.Drawing.Size(4, 516);
      this.splitter1.TabIndex = 8;
      this.splitter1.TabStop = false;
      // 
      // panCenter
      // 
      this.panCenter.Controls.Add(this.lvwTest);
      this.panCenter.Controls.Add(this.btnFillTree);
      this.panCenter.Controls.Add(this.btnFillList);
      this.panCenter.Controls.Add(this.chkIncludeDirs);
      this.panCenter.Controls.Add(this.dgvFiles);
      this.panCenter.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panCenter.Location = new System.Drawing.Point(384, 33);
      this.panCenter.Margin = new System.Windows.Forms.Padding(4);
      this.panCenter.Name = "panCenter";
      this.panCenter.Padding = new System.Windows.Forms.Padding(6);
      this.panCenter.Size = new System.Drawing.Size(644, 516);
      this.panCenter.TabIndex = 9;
      // 
      // dgvFiles
      // 
      dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
      this.dgvFiles.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
      this.dgvFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.dgvFiles.BackgroundColor = System.Drawing.SystemColors.Window;
      this.dgvFiles.ColumnHeadersHeight = 32;
      this.dgvFiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvColName,
            this.dgvColIcon,
            this.dgvColLength});
      this.dgvFiles.Location = new System.Drawing.Point(7, 10);
      this.dgvFiles.Name = "dgvFiles";
      this.dgvFiles.RowHeadersWidth = 22;
      this.dgvFiles.RowTemplate.Height = 32;
      this.dgvFiles.Size = new System.Drawing.Size(628, 422);
      this.dgvFiles.TabIndex = 6;
      this.dgvFiles.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvFiles_RowHeaderMouseClick);
      // 
      // dgvColName
      // 
      this.dgvColName.DataPropertyName = "Name";
      this.dgvColName.HeaderText = "Filename";
      this.dgvColName.Name = "dgvColName";
      this.dgvColName.Width = 250;
      // 
      // dgvColIcon
      // 
      this.dgvColIcon.DataPropertyName = "Icon";
      this.dgvColIcon.HeaderText = "";
      this.dgvColIcon.Image = global::WinExplorer.Properties.Resources.OK_Check;
      this.dgvColIcon.Name = "dgvColIcon";
      this.dgvColIcon.Resizable = System.Windows.Forms.DataGridViewTriState.True;
      this.dgvColIcon.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
      // 
      // dgvColLength
      // 
      this.dgvColLength.DataPropertyName = "Length";
      dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
      dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      dataGridViewCellStyle2.Format = "N0";
      dataGridViewCellStyle2.NullValue = null;
      this.dgvColLength.DefaultCellStyle = dataGridViewCellStyle2;
      this.dgvColLength.HeaderText = "Size in Byte";
      this.dgvColLength.Name = "dgvColLength";
      this.dgvColLength.Width = 150;
      // 
      // FrmTest
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1028, 549);
      this.Controls.Add(this.panCenter);
      this.Controls.Add(this.splitter1);
      this.Controls.Add(this.panLeft);
      this.Controls.Add(this.mnuMain);
      this.DataBindings.Add(new System.Windows.Forms.Binding("Location", global::WinExplorer.Properties.Settings.Default, "StartPosition", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::WinExplorer.Properties.Settings.Default, "Font", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.Font = global::WinExplorer.Properties.Settings.Default.Font;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Location = global::WinExplorer.Properties.Settings.Default.StartPosition;
      this.MainMenuStrip = this.mnuMain;
      this.Margin = new System.Windows.Forms.Padding(6);
      this.Name = "FrmTest";
      this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
      this.Text = "FrmTest";
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmTest_FormClosed);
      this.mnuMain.ResumeLayout(false);
      this.mnuMain.PerformLayout();
      this.panLeft.ResumeLayout(false);
      this.panCenter.ResumeLayout(false);
      this.panCenter.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgvFiles)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TreeView trvTest;
    private System.Windows.Forms.ImageList imgTest;
    private System.Windows.Forms.Button btnFillTree;
    private System.Windows.Forms.ProgressBar progressBar1;
    private System.Windows.Forms.ListView lvwTest;
    private System.Windows.Forms.ColumnHeader columnHeader1;
    private System.Windows.Forms.ColumnHeader columnHeader2;
    private System.Windows.Forms.ColumnHeader columnHeader3;
    private System.Windows.Forms.Button btnFillList;
    private System.Windows.Forms.CheckBox chkIncludeDirs;
    private System.Windows.Forms.MenuStrip mnuMain;
    private System.Windows.Forms.ToolStripMenuItem mnuMainFile;
    private System.Windows.Forms.ToolStripMenuItem mnuOptions;
    private System.Windows.Forms.ToolStripMenuItem mnuOptionsFont;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    private System.Windows.Forms.Panel panLeft;
    private System.Windows.Forms.Splitter splitter1;
    private System.Windows.Forms.Panel panCenter;
    private System.Windows.Forms.ToolStripMenuItem mnuOptionsIncludeDirs;
    private System.Windows.Forms.ToolStripMenuItem mnuOptionsSettings;
    private System.Windows.Forms.ToolStripMenuItem mnuOptionsSettingsOpenExplorer;
    private System.Windows.Forms.DataGridView dgvFiles;
    private System.Windows.Forms.DataGridViewTextBoxColumn dgvColName;
    private System.Windows.Forms.DataGridViewImageColumn dgvColIcon;
    private System.Windows.Forms.DataGridViewTextBoxColumn dgvColLength;
  }
}