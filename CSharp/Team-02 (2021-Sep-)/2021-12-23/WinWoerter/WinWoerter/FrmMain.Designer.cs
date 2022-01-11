namespace WinWoerter
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
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
      this.btnReadFile = new System.Windows.Forms.Button();
      this.txtFilecontent = new System.Windows.Forms.TextBox();
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
      this.woerterBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
      this.dgvWoerter = new System.Windows.Forms.DataGridView();
      this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.wortDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dialektDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.bsWoerter = new System.Windows.Forms.BindingSource(this.components);
      this.dsMain = new WinWoerter.DsWoerterBuch();
      this.taWoerter = new WinWoerter.DsWoerterBuchTableAdapters.WoerterTableAdapter();
      ((System.ComponentModel.ISupportInitialize)(this.navMain)).BeginInit();
      this.navMain.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgvWoerter)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.bsWoerter)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dsMain)).BeginInit();
      this.SuspendLayout();
      // 
      // btnReadFile
      // 
      this.btnReadFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btnReadFile.Location = new System.Drawing.Point(901, 433);
      this.btnReadFile.Name = "btnReadFile";
      this.btnReadFile.Size = new System.Drawing.Size(180, 30);
      this.btnReadFile.TabIndex = 0;
      this.btnReadFile.Text = "Datei lesen...";
      this.btnReadFile.UseVisualStyleBackColor = true;
      this.btnReadFile.Click += new System.EventHandler(this.btnReadFile_Click);
      // 
      // txtFilecontent
      // 
      this.txtFilecontent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtFilecontent.Location = new System.Drawing.Point(628, 32);
      this.txtFilecontent.Multiline = true;
      this.txtFilecontent.Name = "txtFilecontent";
      this.txtFilecontent.ScrollBars = System.Windows.Forms.ScrollBars.Both;
      this.txtFilecontent.Size = new System.Drawing.Size(453, 395);
      this.txtFilecontent.TabIndex = 1;
      this.txtFilecontent.WordWrap = false;
      // 
      // navMain
      // 
      this.navMain.AddNewItem = this.bindingNavigatorAddNewItem;
      this.navMain.BindingSource = this.bsWoerter;
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
            this.woerterBindingNavigatorSaveItem});
      this.navMain.Location = new System.Drawing.Point(0, 0);
      this.navMain.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
      this.navMain.MoveLastItem = this.bindingNavigatorMoveLastItem;
      this.navMain.MoveNextItem = this.bindingNavigatorMoveNextItem;
      this.navMain.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
      this.navMain.Name = "navMain";
      this.navMain.PositionItem = this.bindingNavigatorPositionItem;
      this.navMain.Size = new System.Drawing.Size(1093, 29);
      this.navMain.TabIndex = 2;
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
      // woerterBindingNavigatorSaveItem
      // 
      this.woerterBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.woerterBindingNavigatorSaveItem.Enabled = false;
      this.woerterBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("woerterBindingNavigatorSaveItem.Image")));
      this.woerterBindingNavigatorSaveItem.Name = "woerterBindingNavigatorSaveItem";
      this.woerterBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 26);
      this.woerterBindingNavigatorSaveItem.Text = "Daten speichern";
      // 
      // dgvWoerter
      // 
      dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
      this.dgvWoerter.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
      this.dgvWoerter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
      this.dgvWoerter.AutoGenerateColumns = false;
      this.dgvWoerter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvWoerter.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.wortDataGridViewTextBoxColumn,
            this.dialektDataGridViewTextBoxColumn});
      this.dgvWoerter.DataSource = this.bsWoerter;
      this.dgvWoerter.Location = new System.Drawing.Point(12, 32);
      this.dgvWoerter.Name = "dgvWoerter";
      this.dgvWoerter.Size = new System.Drawing.Size(582, 431);
      this.dgvWoerter.TabIndex = 3;
      // 
      // dataGridViewTextBoxColumn1
      // 
      this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
      this.dataGridViewTextBoxColumn1.HeaderText = "Id";
      this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
      this.dataGridViewTextBoxColumn1.ReadOnly = true;
      // 
      // wortDataGridViewTextBoxColumn
      // 
      this.wortDataGridViewTextBoxColumn.DataPropertyName = "Wort";
      this.wortDataGridViewTextBoxColumn.HeaderText = "Wort";
      this.wortDataGridViewTextBoxColumn.Name = "wortDataGridViewTextBoxColumn";
      // 
      // dialektDataGridViewTextBoxColumn
      // 
      this.dialektDataGridViewTextBoxColumn.DataPropertyName = "Dialekt";
      this.dialektDataGridViewTextBoxColumn.HeaderText = "Dialekt";
      this.dialektDataGridViewTextBoxColumn.Name = "dialektDataGridViewTextBoxColumn";
      // 
      // bsWoerter
      // 
      this.bsWoerter.DataMember = "Woerter";
      this.bsWoerter.DataSource = this.dsMain;
      // 
      // dsMain
      // 
      this.dsMain.DataSetName = "DsWoerterBuch";
      this.dsMain.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // taWoerter
      // 
      this.taWoerter.ClearBeforeFill = true;
      // 
      // FrmMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1093, 475);
      this.Controls.Add(this.dgvWoerter);
      this.Controls.Add(this.navMain);
      this.Controls.Add(this.txtFilecontent);
      this.Controls.Add(this.btnReadFile);
      this.Name = "FrmMain";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.FrmMain_Load);
      ((System.ComponentModel.ISupportInitialize)(this.navMain)).EndInit();
      this.navMain.ResumeLayout(false);
      this.navMain.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgvWoerter)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.bsWoerter)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dsMain)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnReadFile;
    private System.Windows.Forms.TextBox txtFilecontent;
    private DsWoerterBuch dsMain;
    private System.Windows.Forms.BindingSource bsWoerter;
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
    private System.Windows.Forms.ToolStripButton woerterBindingNavigatorSaveItem;
    private System.Windows.Forms.DataGridView dgvWoerter;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    private System.Windows.Forms.DataGridViewTextBoxColumn wortDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn dialektDataGridViewTextBoxColumn;
    private DsWoerterBuchTableAdapters.WoerterTableAdapter taWoerter;
  }
}

