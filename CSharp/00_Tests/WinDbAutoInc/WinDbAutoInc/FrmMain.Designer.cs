namespace WinDbAutoInc
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
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
      this.tabControl1 = new System.Windows.Forms.TabControl();
      this.tpStart = new System.Windows.Forms.TabPage();
      this.tpPostgres = new System.Windows.Forms.TabPage();
      this.tpMsSql = new System.Windows.Forms.TabPage();
      this.imgMain = new System.Windows.Forms.ImageList(this.components);
      this.dsMainPg = new WinDbAutoInc.DsPg();
      this.dgvWeatherPg = new System.Windows.Forms.DataGridView();
      this.bsWeatherPg = new System.Windows.Forms.BindingSource(this.components);
      this.navWeatherPg = new System.Windows.Forms.BindingNavigator(this.components);
      this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
      this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
      this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
      this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
      this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
      this.btnSavePg = new System.Windows.Forms.ToolStripButton();
      this.weatherTableAdapter = new WinDbAutoInc.DsPgTableAdapters.weatherTableAdapter();
      this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.locationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.temperatureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.noteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.tabControl1.SuspendLayout();
      this.tpPostgres.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dsMainPg)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dgvWeatherPg)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.bsWeatherPg)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.navWeatherPg)).BeginInit();
      this.navWeatherPg.SuspendLayout();
      this.SuspendLayout();
      // 
      // tabControl1
      // 
      this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tabControl1.Controls.Add(this.tpStart);
      this.tabControl1.Controls.Add(this.tpPostgres);
      this.tabControl1.Controls.Add(this.tpMsSql);
      this.tabControl1.ImageList = this.imgMain;
      this.tabControl1.ItemSize = new System.Drawing.Size(150, 32);
      this.tabControl1.Location = new System.Drawing.Point(13, 44);
      this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new System.Drawing.Size(959, 529);
      this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
      this.tabControl1.TabIndex = 0;
      this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
      // 
      // tpStart
      // 
      this.tpStart.ImageIndex = 0;
      this.tpStart.Location = new System.Drawing.Point(4, 36);
      this.tpStart.Margin = new System.Windows.Forms.Padding(4);
      this.tpStart.Name = "tpStart";
      this.tpStart.Padding = new System.Windows.Forms.Padding(4);
      this.tpStart.Size = new System.Drawing.Size(951, 489);
      this.tpStart.TabIndex = 0;
      this.tpStart.Text = "Start";
      this.tpStart.UseVisualStyleBackColor = true;
      // 
      // tpPostgres
      // 
      this.tpPostgres.Controls.Add(this.navWeatherPg);
      this.tpPostgres.Controls.Add(this.dgvWeatherPg);
      this.tpPostgres.Location = new System.Drawing.Point(4, 36);
      this.tpPostgres.Margin = new System.Windows.Forms.Padding(4);
      this.tpPostgres.Name = "tpPostgres";
      this.tpPostgres.Padding = new System.Windows.Forms.Padding(4);
      this.tpPostgres.Size = new System.Drawing.Size(951, 489);
      this.tpPostgres.TabIndex = 1;
      this.tpPostgres.Text = "Postgres";
      this.tpPostgres.UseVisualStyleBackColor = true;
      // 
      // tpMsSql
      // 
      this.tpMsSql.Location = new System.Drawing.Point(4, 36);
      this.tpMsSql.Name = "tpMsSql";
      this.tpMsSql.Size = new System.Drawing.Size(951, 489);
      this.tpMsSql.TabIndex = 2;
      this.tpMsSql.Text = "MS Sql-Srv";
      this.tpMsSql.UseVisualStyleBackColor = true;
      // 
      // imgMain
      // 
      this.imgMain.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
      this.imgMain.ImageSize = new System.Drawing.Size(16, 16);
      this.imgMain.TransparentColor = System.Drawing.Color.Transparent;
      // 
      // dsMainPg
      // 
      this.dsMainPg.DataSetName = "DsPg";
      this.dsMainPg.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // dgvWeatherPg
      // 
      dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
      this.dgvWeatherPg.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
      this.dgvWeatherPg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.dgvWeatherPg.AutoGenerateColumns = false;
      this.dgvWeatherPg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvWeatherPg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.locationDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.temperatureDataGridViewTextBoxColumn,
            this.noteDataGridViewTextBoxColumn});
      this.dgvWeatherPg.DataSource = this.bsWeatherPg;
      this.dgvWeatherPg.Location = new System.Drawing.Point(7, 19);
      this.dgvWeatherPg.Name = "dgvWeatherPg";
      this.dgvWeatherPg.Size = new System.Drawing.Size(719, 429);
      this.dgvWeatherPg.TabIndex = 0;
      // 
      // bsWeatherPg
      // 
      this.bsWeatherPg.DataMember = "weather";
      this.bsWeatherPg.DataSource = this.dsMainPg;
      // 
      // navWeatherPg
      // 
      this.navWeatherPg.AddNewItem = this.bindingNavigatorAddNewItem;
      this.navWeatherPg.CountItem = this.bindingNavigatorCountItem;
      this.navWeatherPg.DeleteItem = this.bindingNavigatorDeleteItem;
      this.navWeatherPg.Dock = System.Windows.Forms.DockStyle.None;
      this.navWeatherPg.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.btnSavePg});
      this.navWeatherPg.Location = new System.Drawing.Point(7, 451);
      this.navWeatherPg.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
      this.navWeatherPg.MoveLastItem = this.bindingNavigatorMoveLastItem;
      this.navWeatherPg.MoveNextItem = this.bindingNavigatorMoveNextItem;
      this.navWeatherPg.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
      this.navWeatherPg.Name = "navWeatherPg";
      this.navWeatherPg.PositionItem = this.bindingNavigatorPositionItem;
      this.navWeatherPg.Size = new System.Drawing.Size(298, 27);
      this.navWeatherPg.TabIndex = 1;
      this.navWeatherPg.Text = "bindingNavigator1";
      // 
      // bindingNavigatorMoveFirstItem
      // 
      this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
      this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
      this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 24);
      this.bindingNavigatorMoveFirstItem.Text = "Erste verschieben";
      // 
      // bindingNavigatorMovePreviousItem
      // 
      this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
      this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
      this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 24);
      this.bindingNavigatorMovePreviousItem.Text = "Vorherige verschieben";
      // 
      // bindingNavigatorSeparator
      // 
      this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
      this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
      // 
      // bindingNavigatorPositionItem
      // 
      this.bindingNavigatorPositionItem.AccessibleName = "Position";
      this.bindingNavigatorPositionItem.AutoSize = false;
      this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 11.25F);
      this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
      this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
      this.bindingNavigatorPositionItem.Text = "0";
      this.bindingNavigatorPositionItem.ToolTipText = "Aktuelle Position";
      // 
      // bindingNavigatorCountItem
      // 
      this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
      this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 24);
      this.bindingNavigatorCountItem.Text = "von {0}";
      this.bindingNavigatorCountItem.ToolTipText = "Die Gesamtanzahl der Elemente.";
      // 
      // bindingNavigatorSeparator1
      // 
      this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
      this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
      // 
      // bindingNavigatorMoveNextItem
      // 
      this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
      this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
      this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 24);
      this.bindingNavigatorMoveNextItem.Text = "Nächste verschieben";
      // 
      // bindingNavigatorMoveLastItem
      // 
      this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
      this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
      this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 24);
      this.bindingNavigatorMoveLastItem.Text = "Letzte verschieben";
      // 
      // bindingNavigatorSeparator2
      // 
      this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
      this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
      // 
      // bindingNavigatorAddNewItem
      // 
      this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
      this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
      this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 24);
      this.bindingNavigatorAddNewItem.Text = "Neu hinzufügen";
      // 
      // bindingNavigatorDeleteItem
      // 
      this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
      this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
      this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 24);
      this.bindingNavigatorDeleteItem.Text = "Löschen";
      // 
      // btnSavePg
      // 
      this.btnSavePg.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.btnSavePg.Image = ((System.Drawing.Image)(resources.GetObject("btnSavePg.Image")));
      this.btnSavePg.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.btnSavePg.Name = "btnSavePg";
      this.btnSavePg.Size = new System.Drawing.Size(23, 24);
      this.btnSavePg.Text = "toolStripButton1";
      // 
      // weatherTableAdapter
      // 
      this.weatherTableAdapter.ClearBeforeFill = true;
      // 
      // idDataGridViewTextBoxColumn
      // 
      this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
      this.idDataGridViewTextBoxColumn.HeaderText = "id";
      this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
      // 
      // locationDataGridViewTextBoxColumn
      // 
      this.locationDataGridViewTextBoxColumn.DataPropertyName = "location";
      this.locationDataGridViewTextBoxColumn.HeaderText = "location";
      this.locationDataGridViewTextBoxColumn.Name = "locationDataGridViewTextBoxColumn";
      // 
      // dateDataGridViewTextBoxColumn
      // 
      this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
      this.dateDataGridViewTextBoxColumn.HeaderText = "date";
      this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
      // 
      // temperatureDataGridViewTextBoxColumn
      // 
      this.temperatureDataGridViewTextBoxColumn.DataPropertyName = "temperature";
      this.temperatureDataGridViewTextBoxColumn.HeaderText = "temperature";
      this.temperatureDataGridViewTextBoxColumn.Name = "temperatureDataGridViewTextBoxColumn";
      // 
      // noteDataGridViewTextBoxColumn
      // 
      this.noteDataGridViewTextBoxColumn.DataPropertyName = "note";
      this.noteDataGridViewTextBoxColumn.HeaderText = "note";
      this.noteDataGridViewTextBoxColumn.Name = "noteDataGridViewTextBoxColumn";
      // 
      // FrmMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(985, 586);
      this.Controls.Add(this.tabControl1);
      this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Margin = new System.Windows.Forms.Padding(4);
      this.Name = "FrmMain";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.FrmMain_Load);
      this.tabControl1.ResumeLayout(false);
      this.tpPostgres.ResumeLayout(false);
      this.tpPostgres.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dsMainPg)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dgvWeatherPg)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.bsWeatherPg)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.navWeatherPg)).EndInit();
      this.navWeatherPg.ResumeLayout(false);
      this.navWeatherPg.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage tpStart;
    private System.Windows.Forms.TabPage tpPostgres;
    private System.Windows.Forms.TabPage tpMsSql;
    private System.Windows.Forms.ImageList imgMain;
    private System.Windows.Forms.BindingNavigator navWeatherPg;
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
    private System.Windows.Forms.ToolStripButton btnSavePg;
    private System.Windows.Forms.DataGridView dgvWeatherPg;
    private DsPg dsMainPg;
    private System.Windows.Forms.BindingSource bsWeatherPg;
    private DsPgTableAdapters.weatherTableAdapter weatherTableAdapter;
    private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn temperatureDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn noteDataGridViewTextBoxColumn;
  }
}

