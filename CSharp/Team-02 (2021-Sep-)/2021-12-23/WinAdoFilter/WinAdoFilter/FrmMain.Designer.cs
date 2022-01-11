namespace WinAdoFilter
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
      this.navMain = new System.Windows.Forms.BindingNavigator(this.components);
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
      this.countriesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
      this.dgvCountries = new System.Windows.Forms.DataGridView();
      this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.bsCountries = new System.Windows.Forms.BindingSource(this.components);
      this.dsMain = new WinAdoFilter.DsCodersBay();
      this.taCountries = new WinAdoFilter.DsCodersBayTableAdapters.countriesTableAdapter();
      this.tableAdapterManager = new WinAdoFilter.DsCodersBayTableAdapters.TableAdapterManager();
      this.txtRegionId = new System.Windows.Forms.TextBox();
      this.btnFilter = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.navMain)).BeginInit();
      this.navMain.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgvCountries)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.bsCountries)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dsMain)).BeginInit();
      this.SuspendLayout();
      // 
      // navMain
      // 
      this.navMain.AddNewItem = this.bindingNavigatorAddNewItem;
      this.navMain.BindingSource = this.bsCountries;
      this.navMain.CountItem = this.bindingNavigatorCountItem;
      this.navMain.DeleteItem = this.bindingNavigatorDeleteItem;
      this.navMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.countriesBindingNavigatorSaveItem});
      this.navMain.Location = new System.Drawing.Point(0, 0);
      this.navMain.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
      this.navMain.MoveLastItem = this.bindingNavigatorMoveLastItem;
      this.navMain.MoveNextItem = this.bindingNavigatorMoveNextItem;
      this.navMain.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
      this.navMain.Name = "navMain";
      this.navMain.PositionItem = this.bindingNavigatorPositionItem;
      this.navMain.Size = new System.Drawing.Size(694, 29);
      this.navMain.TabIndex = 0;
      this.navMain.Text = "bindingNavigator1";
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
      // bindingNavigatorCountItem
      // 
      this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
      this.bindingNavigatorCountItem.Size = new System.Drawing.Size(59, 26);
      this.bindingNavigatorCountItem.Text = "von {0}";
      this.bindingNavigatorCountItem.ToolTipText = "Die Gesamtanzahl der Elemente.";
      // 
      // bindingNavigatorSeparator1
      // 
      this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
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
      this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
      this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 29);
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
      // bindingNavigatorDeleteItem
      // 
      this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
      this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
      this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 26);
      this.bindingNavigatorDeleteItem.Text = "Löschen";
      // 
      // countriesBindingNavigatorSaveItem
      // 
      this.countriesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.countriesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("countriesBindingNavigatorSaveItem.Image")));
      this.countriesBindingNavigatorSaveItem.Name = "countriesBindingNavigatorSaveItem";
      this.countriesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 26);
      this.countriesBindingNavigatorSaveItem.Text = "Daten speichern";
      this.countriesBindingNavigatorSaveItem.Click += new System.EventHandler(this.countriesBindingNavigatorSaveItem_Click);
      // 
      // dgvCountries
      // 
      dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
      this.dgvCountries.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
      this.dgvCountries.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.dgvCountries.AutoGenerateColumns = false;
      this.dgvCountries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvCountries.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
      this.dgvCountries.DataSource = this.bsCountries;
      this.dgvCountries.Location = new System.Drawing.Point(12, 138);
      this.dgvCountries.Name = "dgvCountries";
      this.dgvCountries.Size = new System.Drawing.Size(670, 313);
      this.dgvCountries.TabIndex = 1;
      // 
      // dataGridViewTextBoxColumn1
      // 
      this.dataGridViewTextBoxColumn1.DataPropertyName = "country_id";
      this.dataGridViewTextBoxColumn1.HeaderText = "country_id";
      this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
      // 
      // dataGridViewTextBoxColumn2
      // 
      this.dataGridViewTextBoxColumn2.DataPropertyName = "country_name";
      this.dataGridViewTextBoxColumn2.HeaderText = "country_name";
      this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
      // 
      // dataGridViewTextBoxColumn3
      // 
      this.dataGridViewTextBoxColumn3.DataPropertyName = "region_id";
      this.dataGridViewTextBoxColumn3.HeaderText = "region_id";
      this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
      // 
      // bsCountries
      // 
      this.bsCountries.DataMember = "countries";
      this.bsCountries.DataSource = this.dsMain;
      // 
      // dsMain
      // 
      this.dsMain.DataSetName = "DsCodersBay";
      this.dsMain.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // taCountries
      // 
      this.taCountries.ClearBeforeFill = true;
      // 
      // tableAdapterManager
      // 
      this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
      this.tableAdapterManager.countriesTableAdapter = this.taCountries;
      this.tableAdapterManager.regionsTableAdapter = null;
      this.tableAdapterManager.UpdateOrder = WinAdoFilter.DsCodersBayTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
      // 
      // txtRegionId
      // 
      this.txtRegionId.Location = new System.Drawing.Point(12, 55);
      this.txtRegionId.Name = "txtRegionId";
      this.txtRegionId.Size = new System.Drawing.Size(224, 27);
      this.txtRegionId.TabIndex = 2;
      this.txtRegionId.Text = "1";
      // 
      // btnFilter
      // 
      this.btnFilter.Location = new System.Drawing.Point(242, 55);
      this.btnFilter.Name = "btnFilter";
      this.btnFilter.Size = new System.Drawing.Size(75, 27);
      this.btnFilter.TabIndex = 3;
      this.btnFilter.Text = "Filter";
      this.btnFilter.UseVisualStyleBackColor = true;
      this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
      // 
      // FrmMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(694, 463);
      this.Controls.Add(this.btnFilter);
      this.Controls.Add(this.txtRegionId);
      this.Controls.Add(this.dgvCountries);
      this.Controls.Add(this.navMain);
      this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.Name = "FrmMain";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.FrmMain_Load);
      ((System.ComponentModel.ISupportInitialize)(this.navMain)).EndInit();
      this.navMain.ResumeLayout(false);
      this.navMain.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgvCountries)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.bsCountries)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dsMain)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private DsCodersBay dsMain;
    private System.Windows.Forms.BindingSource bsCountries;
    private DsCodersBayTableAdapters.countriesTableAdapter taCountries;
    private DsCodersBayTableAdapters.TableAdapterManager tableAdapterManager;
    private System.Windows.Forms.BindingNavigator navMain;
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
    private System.Windows.Forms.ToolStripButton countriesBindingNavigatorSaveItem;
    private System.Windows.Forms.DataGridView dgvCountries;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    private System.Windows.Forms.TextBox txtRegionId;
    private System.Windows.Forms.Button btnFilter;
  }
}

