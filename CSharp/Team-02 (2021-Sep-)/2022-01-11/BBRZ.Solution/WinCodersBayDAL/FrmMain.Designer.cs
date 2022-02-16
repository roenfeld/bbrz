namespace WinCodersBayDAL
{
  partial class FrmMain
  {
    /// <summary>
    /// Erforderliche Designervariable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Verwendete Ressourcen bereinigen.
    /// </summary>
    /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Vom Windows Form-Designer generierter Code

    /// <summary>
    /// Erforderliche Methode für die Designerunterstützung.
    /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
      this.navRegions = new System.Windows.Forms.BindingNavigator(this.components);
      this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
      this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
      this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
      this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
      this.btnSaveRegions = new System.Windows.Forms.ToolStripButton();
      this.dgvRegions = new System.Windows.Forms.DataGridView();
      this.tabControl1 = new System.Windows.Forms.TabControl();
      this.tpRegion = new System.Windows.Forms.TabPage();
      this.dgvCountries = new System.Windows.Forms.DataGridView();
      this.tpLocation = new System.Windows.Forms.TabPage();
      this.navCountries = new System.Windows.Forms.BindingNavigator(this.components);
      this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
      this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
      this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
      this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
      this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
      this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
      this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
      this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
      this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
      this.bsCountries = new System.Windows.Forms.BindingSource(this.components);
      this.dsMain = new BBRZ.DAL.DsCodersBay();
      this.countryidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.countrynameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.regionidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.bsRegions = new System.Windows.Forms.BindingSource(this.components);
      this.cboRegions = new System.Windows.Forms.ComboBox();
      this.regionidDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.regionnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.listBox1 = new System.Windows.Forms.ListBox();
      ((System.ComponentModel.ISupportInitialize)(this.navRegions)).BeginInit();
      this.navRegions.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgvRegions)).BeginInit();
      this.tabControl1.SuspendLayout();
      this.tpRegion.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgvCountries)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.navCountries)).BeginInit();
      this.navCountries.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.bsCountries)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dsMain)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.bsRegions)).BeginInit();
      this.SuspendLayout();
      // 
      // navRegions
      // 
      this.navRegions.AddNewItem = this.bindingNavigatorAddNewItem;
      this.navRegions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.navRegions.BindingSource = this.bsRegions;
      this.navRegions.CountItem = this.bindingNavigatorCountItem;
      this.navRegions.DeleteItem = this.bindingNavigatorDeleteItem;
      this.navRegions.Dock = System.Windows.Forms.DockStyle.None;
      this.navRegions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.btnSaveRegions});
      this.navRegions.Location = new System.Drawing.Point(6, 370);
      this.navRegions.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
      this.navRegions.MoveLastItem = this.bindingNavigatorMoveLastItem;
      this.navRegions.MoveNextItem = this.bindingNavigatorMoveNextItem;
      this.navRegions.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
      this.navRegions.Name = "navRegions";
      this.navRegions.PositionItem = this.bindingNavigatorPositionItem;
      this.navRegions.Size = new System.Drawing.Size(291, 29);
      this.navRegions.TabIndex = 0;
      this.navRegions.Text = "bindingNavigator1";
      // 
      // bindingNavigatorAddNewItem
      // 
      this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
      this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
      this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 26);
      this.bindingNavigatorAddNewItem.Text = "Neu hinzufügen";
      // 
      // bindingNavigatorCountItem
      // 
      this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
      this.bindingNavigatorCountItem.Size = new System.Drawing.Size(48, 26);
      this.bindingNavigatorCountItem.Text = "von {0}";
      this.bindingNavigatorCountItem.ToolTipText = "Die Gesamtanzahl der Elemente.";
      // 
      // bindingNavigatorDeleteItem
      // 
      this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
      this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
      this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 26);
      this.bindingNavigatorDeleteItem.Text = "Löschen";
      // 
      // bindingNavigatorMoveFirstItem
      // 
      this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
      this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
      this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 26);
      this.bindingNavigatorMoveFirstItem.Text = "Erste verschieben";
      // 
      // bindingNavigatorMovePreviousItem
      // 
      this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
      this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
      this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 26);
      this.bindingNavigatorMovePreviousItem.Text = "Vorherige verschieben";
      // 
      // bindingNavigatorSeparator
      // 
      this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
      this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 29);
      // 
      // bindingNavigatorPositionItem
      // 
      this.bindingNavigatorPositionItem.AccessibleName = "Position";
      this.bindingNavigatorPositionItem.AutoSize = false;
      this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 12F);
      this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
      this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 29);
      this.bindingNavigatorPositionItem.Text = "0";
      this.bindingNavigatorPositionItem.ToolTipText = "Aktuelle Position";
      // 
      // bindingNavigatorSeparator1
      // 
      this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
      this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 29);
      // 
      // bindingNavigatorMoveNextItem
      // 
      this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
      this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
      this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 26);
      this.bindingNavigatorMoveNextItem.Text = "Nächste verschieben";
      // 
      // bindingNavigatorMoveLastItem
      // 
      this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
      this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
      this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 26);
      this.bindingNavigatorMoveLastItem.Text = "Letzte verschieben";
      // 
      // bindingNavigatorSeparator2
      // 
      this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
      this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 29);
      // 
      // btnSaveRegions
      // 
      this.btnSaveRegions.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.btnSaveRegions.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveRegions.Image")));
      this.btnSaveRegions.Name = "btnSaveRegions";
      this.btnSaveRegions.Size = new System.Drawing.Size(23, 26);
      this.btnSaveRegions.Text = "Daten speichern";
      this.btnSaveRegions.Click += new System.EventHandler(this.btnSaveRegions_Click);
      // 
      // dgvRegions
      // 
      dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
      this.dgvRegions.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
      this.dgvRegions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
      this.dgvRegions.AutoGenerateColumns = false;
      this.dgvRegions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvRegions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.regionidDataGridViewTextBoxColumn1,
            this.regionnameDataGridViewTextBoxColumn});
      this.dgvRegions.DataSource = this.bsRegions;
      this.dgvRegions.Location = new System.Drawing.Point(6, 6);
      this.dgvRegions.Name = "dgvRegions";
      this.dgvRegions.Size = new System.Drawing.Size(410, 118);
      this.dgvRegions.TabIndex = 1;
      // 
      // tabControl1
      // 
      this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tabControl1.Controls.Add(this.tpRegion);
      this.tabControl1.Controls.Add(this.tpLocation);
      this.tabControl1.Location = new System.Drawing.Point(12, 32);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new System.Drawing.Size(851, 448);
      this.tabControl1.TabIndex = 2;
      // 
      // tpRegion
      // 
      this.tpRegion.Controls.Add(this.listBox1);
      this.tpRegion.Controls.Add(this.cboRegions);
      this.tpRegion.Controls.Add(this.navCountries);
      this.tpRegion.Controls.Add(this.dgvCountries);
      this.tpRegion.Controls.Add(this.navRegions);
      this.tpRegion.Controls.Add(this.dgvRegions);
      this.tpRegion.Location = new System.Drawing.Point(4, 32);
      this.tpRegion.Name = "tpRegion";
      this.tpRegion.Padding = new System.Windows.Forms.Padding(3);
      this.tpRegion.Size = new System.Drawing.Size(843, 412);
      this.tpRegion.TabIndex = 0;
      this.tpRegion.Text = "Region";
      this.tpRegion.UseVisualStyleBackColor = true;
      // 
      // dgvCountries
      // 
      dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
      this.dgvCountries.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
      this.dgvCountries.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.dgvCountries.AutoGenerateColumns = false;
      this.dgvCountries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvCountries.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.countryidDataGridViewTextBoxColumn,
            this.countrynameDataGridViewTextBoxColumn,
            this.regionidDataGridViewTextBoxColumn});
      this.dgvCountries.DataSource = this.bsCountries;
      this.dgvCountries.Location = new System.Drawing.Point(434, 74);
      this.dgvCountries.Name = "dgvCountries";
      this.dgvCountries.Size = new System.Drawing.Size(403, 293);
      this.dgvCountries.TabIndex = 2;
      // 
      // tpLocation
      // 
      this.tpLocation.Location = new System.Drawing.Point(4, 32);
      this.tpLocation.Name = "tpLocation";
      this.tpLocation.Padding = new System.Windows.Forms.Padding(3);
      this.tpLocation.Size = new System.Drawing.Size(843, 412);
      this.tpLocation.TabIndex = 1;
      this.tpLocation.Text = "Location";
      this.tpLocation.UseVisualStyleBackColor = true;
      // 
      // navCountries
      // 
      this.navCountries.AddNewItem = this.toolStripButton1;
      this.navCountries.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.navCountries.BindingSource = this.bsCountries;
      this.navCountries.CountItem = this.toolStripLabel1;
      this.navCountries.DeleteItem = this.toolStripButton2;
      this.navCountries.Dock = System.Windows.Forms.DockStyle.None;
      this.navCountries.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripSeparator1,
            this.toolStripTextBox1,
            this.toolStripLabel1,
            this.toolStripSeparator2,
            this.toolStripButton5,
            this.toolStripButton6,
            this.toolStripSeparator3,
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton7});
      this.navCountries.Location = new System.Drawing.Point(434, 370);
      this.navCountries.MoveFirstItem = this.toolStripButton3;
      this.navCountries.MoveLastItem = this.toolStripButton6;
      this.navCountries.MoveNextItem = this.toolStripButton5;
      this.navCountries.MovePreviousItem = this.toolStripButton4;
      this.navCountries.Name = "navCountries";
      this.navCountries.PositionItem = this.toolStripTextBox1;
      this.navCountries.Size = new System.Drawing.Size(291, 29);
      this.navCountries.TabIndex = 3;
      this.navCountries.Text = "bindingNavigator1";
      // 
      // toolStripButton1
      // 
      this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
      this.toolStripButton1.Name = "toolStripButton1";
      this.toolStripButton1.RightToLeftAutoMirrorImage = true;
      this.toolStripButton1.Size = new System.Drawing.Size(23, 26);
      this.toolStripButton1.Text = "Neu hinzufügen";
      // 
      // toolStripLabel1
      // 
      this.toolStripLabel1.Name = "toolStripLabel1";
      this.toolStripLabel1.Size = new System.Drawing.Size(48, 26);
      this.toolStripLabel1.Text = "von {0}";
      this.toolStripLabel1.ToolTipText = "Die Gesamtanzahl der Elemente.";
      // 
      // toolStripButton2
      // 
      this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
      this.toolStripButton2.Name = "toolStripButton2";
      this.toolStripButton2.RightToLeftAutoMirrorImage = true;
      this.toolStripButton2.Size = new System.Drawing.Size(23, 26);
      this.toolStripButton2.Text = "Löschen";
      // 
      // toolStripButton3
      // 
      this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
      this.toolStripButton3.Name = "toolStripButton3";
      this.toolStripButton3.RightToLeftAutoMirrorImage = true;
      this.toolStripButton3.Size = new System.Drawing.Size(23, 26);
      this.toolStripButton3.Text = "Erste verschieben";
      // 
      // toolStripButton4
      // 
      this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
      this.toolStripButton4.Name = "toolStripButton4";
      this.toolStripButton4.RightToLeftAutoMirrorImage = true;
      this.toolStripButton4.Size = new System.Drawing.Size(23, 26);
      this.toolStripButton4.Text = "Vorherige verschieben";
      // 
      // toolStripSeparator1
      // 
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new System.Drawing.Size(6, 29);
      // 
      // toolStripTextBox1
      // 
      this.toolStripTextBox1.AccessibleName = "Position";
      this.toolStripTextBox1.AutoSize = false;
      this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 12F);
      this.toolStripTextBox1.Name = "toolStripTextBox1";
      this.toolStripTextBox1.Size = new System.Drawing.Size(50, 29);
      this.toolStripTextBox1.Text = "0";
      this.toolStripTextBox1.ToolTipText = "Aktuelle Position";
      // 
      // toolStripSeparator2
      // 
      this.toolStripSeparator2.Name = "toolStripSeparator2";
      this.toolStripSeparator2.Size = new System.Drawing.Size(6, 29);
      // 
      // toolStripButton5
      // 
      this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
      this.toolStripButton5.Name = "toolStripButton5";
      this.toolStripButton5.RightToLeftAutoMirrorImage = true;
      this.toolStripButton5.Size = new System.Drawing.Size(23, 26);
      this.toolStripButton5.Text = "Nächste verschieben";
      // 
      // toolStripButton6
      // 
      this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
      this.toolStripButton6.Name = "toolStripButton6";
      this.toolStripButton6.RightToLeftAutoMirrorImage = true;
      this.toolStripButton6.Size = new System.Drawing.Size(23, 26);
      this.toolStripButton6.Text = "Letzte verschieben";
      // 
      // toolStripSeparator3
      // 
      this.toolStripSeparator3.Name = "toolStripSeparator3";
      this.toolStripSeparator3.Size = new System.Drawing.Size(6, 29);
      // 
      // toolStripButton7
      // 
      this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.toolStripButton7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton7.Image")));
      this.toolStripButton7.Name = "toolStripButton7";
      this.toolStripButton7.Size = new System.Drawing.Size(23, 26);
      this.toolStripButton7.Text = "Daten speichern";
      // 
      // bsCountries
      // 
      this.bsCountries.DataMember = "countries";
      this.bsCountries.DataSource = this.dsMain;
      this.bsCountries.CurrentChanged += new System.EventHandler(this.bsCountries_CurrentChanged);
      // 
      // dsMain
      // 
      this.dsMain.DataSetName = "DsCodersBay";
      this.dsMain.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // countryidDataGridViewTextBoxColumn
      // 
      this.countryidDataGridViewTextBoxColumn.DataPropertyName = "country_id";
      this.countryidDataGridViewTextBoxColumn.HeaderText = "country_id";
      this.countryidDataGridViewTextBoxColumn.Name = "countryidDataGridViewTextBoxColumn";
      // 
      // countrynameDataGridViewTextBoxColumn
      // 
      this.countrynameDataGridViewTextBoxColumn.DataPropertyName = "country_name";
      this.countrynameDataGridViewTextBoxColumn.HeaderText = "country_name";
      this.countrynameDataGridViewTextBoxColumn.Name = "countrynameDataGridViewTextBoxColumn";
      // 
      // regionidDataGridViewTextBoxColumn
      // 
      this.regionidDataGridViewTextBoxColumn.DataPropertyName = "region_id";
      this.regionidDataGridViewTextBoxColumn.HeaderText = "region_id";
      this.regionidDataGridViewTextBoxColumn.Name = "regionidDataGridViewTextBoxColumn";
      // 
      // bsRegions
      // 
      this.bsRegions.DataMember = "regions";
      this.bsRegions.DataSource = this.dsMain;
      this.bsRegions.CurrentChanged += new System.EventHandler(this.bsRegions_CurrentChanged);
      // 
      // cboRegions
      // 
      this.cboRegions.DataSource = this.bsRegions;
      this.cboRegions.DisplayMember = "region_name";
      this.cboRegions.FormattingEnabled = true;
      this.cboRegions.Location = new System.Drawing.Point(434, 6);
      this.cboRegions.Name = "cboRegions";
      this.cboRegions.Size = new System.Drawing.Size(266, 31);
      this.cboRegions.TabIndex = 4;
      this.cboRegions.ValueMember = "region_id";
      // 
      // regionidDataGridViewTextBoxColumn1
      // 
      this.regionidDataGridViewTextBoxColumn1.DataPropertyName = "region_id";
      this.regionidDataGridViewTextBoxColumn1.HeaderText = "region_id";
      this.regionidDataGridViewTextBoxColumn1.Name = "regionidDataGridViewTextBoxColumn1";
      this.regionidDataGridViewTextBoxColumn1.ReadOnly = true;
      // 
      // regionnameDataGridViewTextBoxColumn
      // 
      this.regionnameDataGridViewTextBoxColumn.DataPropertyName = "region_name";
      this.regionnameDataGridViewTextBoxColumn.HeaderText = "region_name";
      this.regionnameDataGridViewTextBoxColumn.Name = "regionnameDataGridViewTextBoxColumn";
      // 
      // listBox1
      // 
      this.listBox1.DataSource = this.bsRegions;
      this.listBox1.DisplayMember = "region_name";
      this.listBox1.FormattingEnabled = true;
      this.listBox1.ItemHeight = 23;
      this.listBox1.Location = new System.Drawing.Point(95, 94);
      this.listBox1.Name = "listBox1";
      this.listBox1.Size = new System.Drawing.Size(238, 234);
      this.listBox1.TabIndex = 5;
      this.listBox1.ValueMember = "region_id";
      // 
      // FrmMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(875, 492);
      this.Controls.Add(this.tabControl1);
      this.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Margin = new System.Windows.Forms.Padding(5);
      this.Name = "FrmMain";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.FrmMain_Load);
      ((System.ComponentModel.ISupportInitialize)(this.navRegions)).EndInit();
      this.navRegions.ResumeLayout(false);
      this.navRegions.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgvRegions)).EndInit();
      this.tabControl1.ResumeLayout(false);
      this.tpRegion.ResumeLayout(false);
      this.tpRegion.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgvCountries)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.navCountries)).EndInit();
      this.navCountries.ResumeLayout(false);
      this.navCountries.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.bsCountries)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dsMain)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.bsRegions)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private BBRZ.DAL.DsCodersBay dsMain;
    private System.Windows.Forms.BindingSource bsRegions;
    private System.Windows.Forms.BindingNavigator navRegions;
    private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
    private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
    private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
    private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
    private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
    private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
    private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
    private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
    private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
    private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
    private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
    private System.Windows.Forms.ToolStripButton btnSaveRegions;
    private System.Windows.Forms.DataGridView dgvRegions;
    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage tpRegion;
    private System.Windows.Forms.DataGridView dgvCountries;
    private System.Windows.Forms.TabPage tpLocation;
    private System.Windows.Forms.BindingSource bsCountries;
    private System.Windows.Forms.BindingNavigator navCountries;
    private System.Windows.Forms.ToolStripButton toolStripButton1;
    private System.Windows.Forms.ToolStripLabel toolStripLabel1;
    private System.Windows.Forms.ToolStripButton toolStripButton2;
    private System.Windows.Forms.ToolStripButton toolStripButton3;
    private System.Windows.Forms.ToolStripButton toolStripButton4;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    private System.Windows.Forms.ToolStripButton toolStripButton5;
    private System.Windows.Forms.ToolStripButton toolStripButton6;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    private System.Windows.Forms.ToolStripButton toolStripButton7;
    private System.Windows.Forms.DataGridViewTextBoxColumn countryidDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn countrynameDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn regionidDataGridViewTextBoxColumn;
    private System.Windows.Forms.ComboBox cboRegions;
    private System.Windows.Forms.DataGridViewTextBoxColumn regionidDataGridViewTextBoxColumn1;
    private System.Windows.Forms.DataGridViewTextBoxColumn regionnameDataGridViewTextBoxColumn;
    private System.Windows.Forms.ListBox listBox1;
  }
}

