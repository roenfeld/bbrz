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
      this.navRegions = new System.Windows.Forms.BindingNavigator(this.components);
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
      this.btnSaveRegions = new System.Windows.Forms.ToolStripButton();
      this.dgvRegions = new System.Windows.Forms.DataGridView();
      this.bsRegions = new System.Windows.Forms.BindingSource(this.components);
      this.dsMain = new BBRZ.DAL.DsCodersBay();
      this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      ((System.ComponentModel.ISupportInitialize)(this.navRegions)).BeginInit();
      this.navRegions.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgvRegions)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.bsRegions)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dsMain)).BeginInit();
      this.SuspendLayout();
      // 
      // navRegions
      // 
      this.navRegions.AddNewItem = this.bindingNavigatorAddNewItem;
      this.navRegions.BindingSource = this.bsRegions;
      this.navRegions.CountItem = this.bindingNavigatorCountItem;
      this.navRegions.DeleteItem = this.bindingNavigatorDeleteItem;
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
      this.navRegions.Location = new System.Drawing.Point(0, 0);
      this.navRegions.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
      this.navRegions.MoveLastItem = this.bindingNavigatorMoveLastItem;
      this.navRegions.MoveNextItem = this.bindingNavigatorMoveNextItem;
      this.navRegions.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
      this.navRegions.Name = "navRegions";
      this.navRegions.PositionItem = this.bindingNavigatorPositionItem;
      this.navRegions.Size = new System.Drawing.Size(663, 29);
      this.navRegions.TabIndex = 0;
      this.navRegions.Text = "bindingNavigator1";
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
      // btnSaveRegions
      // 
      this.btnSaveRegions.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.btnSaveRegions.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveRegions.Image")));
      this.btnSaveRegions.Name = "regionsBindingNavigatorSaveItem";
      this.btnSaveRegions.Size = new System.Drawing.Size(23, 26);
      this.btnSaveRegions.Text = "Daten speichern";
      this.btnSaveRegions.Click += new System.EventHandler(this.btnSaveRegions_Click);
      // 
      // dgvRegions
      // 
      dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
      this.dgvRegions.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
      this.dgvRegions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.dgvRegions.AutoGenerateColumns = false;
      this.dgvRegions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvRegions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
      this.dgvRegions.DataSource = this.bsRegions;
      this.dgvRegions.Location = new System.Drawing.Point(26, 52);
      this.dgvRegions.Name = "dgvRegions";
      this.dgvRegions.Size = new System.Drawing.Size(434, 291);
      this.dgvRegions.TabIndex = 1;
      // 
      // bsRegions
      // 
      this.bsRegions.DataMember = "regions";
      this.bsRegions.DataSource = this.dsMain;
      // 
      // dsMain
      // 
      this.dsMain.DataSetName = "DsCodersBay";
      this.dsMain.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // dataGridViewTextBoxColumn1
      // 
      this.dataGridViewTextBoxColumn1.DataPropertyName = "region_id";
      this.dataGridViewTextBoxColumn1.HeaderText = "region_id";
      this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
      this.dataGridViewTextBoxColumn1.ReadOnly = true;
      // 
      // dataGridViewTextBoxColumn2
      // 
      this.dataGridViewTextBoxColumn2.DataPropertyName = "region_name";
      this.dataGridViewTextBoxColumn2.HeaderText = "region_name";
      this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
      this.dataGridViewTextBoxColumn2.Width = 250;
      // 
      // FrmMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(663, 374);
      this.Controls.Add(this.dgvRegions);
      this.Controls.Add(this.navRegions);
      this.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
      this.Name = "FrmMain";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.FrmMain_Load);
      ((System.ComponentModel.ISupportInitialize)(this.navRegions)).EndInit();
      this.navRegions.ResumeLayout(false);
      this.navRegions.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgvRegions)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.bsRegions)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dsMain)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

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
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
  }
}

