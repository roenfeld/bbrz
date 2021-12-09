namespace WinDataSet
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
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.Label gebTagLabel;
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
      this.dgvPersonen = new System.Windows.Forms.DataGridView();
      this.btnSaveData = new System.Windows.Forms.ToolStripButton();
      this.btnLoadData = new System.Windows.Forms.ToolStripButton();
      this.bsPersonen = new System.Windows.Forms.BindingSource(this.components);
      this.dsMain = new WinDataSet.DsDaten();
      this.vornameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.nachnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.gebTagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.groesseCmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.aktivDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
      this.groesseMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
      this.btnNextStep = new System.Windows.Forms.Button();
      gebTagLabel = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.navMain)).BeginInit();
      this.navMain.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgvPersonen)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.bsPersonen)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dsMain)).BeginInit();
      this.SuspendLayout();
      // 
      // navMain
      // 
      this.navMain.AddNewItem = this.bindingNavigatorAddNewItem;
      this.navMain.BindingSource = this.bsPersonen;
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
            this.btnSaveData,
            this.btnLoadData});
      this.navMain.Location = new System.Drawing.Point(0, 0);
      this.navMain.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
      this.navMain.MoveLastItem = this.bindingNavigatorMoveLastItem;
      this.navMain.MoveNextItem = this.bindingNavigatorMoveNextItem;
      this.navMain.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
      this.navMain.Name = "navMain";
      this.navMain.PositionItem = this.bindingNavigatorPositionItem;
      this.navMain.Size = new System.Drawing.Size(1212, 29);
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
      // dgvPersonen
      // 
      dataGridViewCellStyle4.BackColor = System.Drawing.Color.Gainsboro;
      this.dgvPersonen.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
      this.dgvPersonen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
      this.dgvPersonen.AutoGenerateColumns = false;
      this.dgvPersonen.ColumnHeadersHeight = 44;
      this.dgvPersonen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vornameDataGridViewTextBoxColumn,
            this.nachnameDataGridViewTextBoxColumn,
            this.gebTagDataGridViewTextBoxColumn,
            this.groesseCmDataGridViewTextBoxColumn,
            this.aktivDataGridViewCheckBoxColumn,
            this.groesseMDataGridViewTextBoxColumn});
      this.dgvPersonen.DataSource = this.bsPersonen;
      this.dgvPersonen.Location = new System.Drawing.Point(12, 45);
      this.dgvPersonen.Name = "dgvPersonen";
      this.dgvPersonen.RowTemplate.Height = 28;
      this.dgvPersonen.Size = new System.Drawing.Size(816, 367);
      this.dgvPersonen.TabIndex = 1;
      // 
      // btnSaveData
      // 
      this.btnSaveData.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.btnSaveData.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveData.Image")));
      this.btnSaveData.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.btnSaveData.Name = "btnSaveData";
      this.btnSaveData.Size = new System.Drawing.Size(23, 26);
      this.btnSaveData.Text = "toolStripButton1";
      this.btnSaveData.Click += new System.EventHandler(this.btnSaveData_Click);
      // 
      // btnLoadData
      // 
      this.btnLoadData.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.btnLoadData.Image = ((System.Drawing.Image)(resources.GetObject("btnLoadData.Image")));
      this.btnLoadData.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.btnLoadData.Name = "btnLoadData";
      this.btnLoadData.Size = new System.Drawing.Size(23, 26);
      this.btnLoadData.Text = "toolStripButton2";
      this.btnLoadData.Click += new System.EventHandler(this.btnLoadData_Click);
      // 
      // bsPersonen
      // 
      this.bsPersonen.DataMember = "Personen";
      this.bsPersonen.DataSource = this.dsMain;
      this.bsPersonen.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.bsPersonen_ListChanged);
      // 
      // dsMain
      // 
      this.dsMain.DataSetName = "DsDaten";
      this.dsMain.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // vornameDataGridViewTextBoxColumn
      // 
      this.vornameDataGridViewTextBoxColumn.DataPropertyName = "Vorname";
      this.vornameDataGridViewTextBoxColumn.HeaderText = "Vorname";
      this.vornameDataGridViewTextBoxColumn.Name = "vornameDataGridViewTextBoxColumn";
      this.vornameDataGridViewTextBoxColumn.Width = 125;
      // 
      // nachnameDataGridViewTextBoxColumn
      // 
      this.nachnameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.nachnameDataGridViewTextBoxColumn.DataPropertyName = "Nachname";
      this.nachnameDataGridViewTextBoxColumn.HeaderText = "Nachname";
      this.nachnameDataGridViewTextBoxColumn.Name = "nachnameDataGridViewTextBoxColumn";
      // 
      // gebTagDataGridViewTextBoxColumn
      // 
      this.gebTagDataGridViewTextBoxColumn.DataPropertyName = "GebTag";
      this.gebTagDataGridViewTextBoxColumn.HeaderText = "GebTag";
      this.gebTagDataGridViewTextBoxColumn.Name = "gebTagDataGridViewTextBoxColumn";
      this.gebTagDataGridViewTextBoxColumn.Width = 125;
      // 
      // groesseCmDataGridViewTextBoxColumn
      // 
      this.groesseCmDataGridViewTextBoxColumn.DataPropertyName = "GroesseCm";
      dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
      dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Blue;
      dataGridViewCellStyle5.Format = "N1";
      this.groesseCmDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
      this.groesseCmDataGridViewTextBoxColumn.HeaderText = "GroesseCm";
      this.groesseCmDataGridViewTextBoxColumn.Name = "groesseCmDataGridViewTextBoxColumn";
      // 
      // aktivDataGridViewCheckBoxColumn
      // 
      this.aktivDataGridViewCheckBoxColumn.DataPropertyName = "Aktiv";
      this.aktivDataGridViewCheckBoxColumn.HeaderText = "Aktiv";
      this.aktivDataGridViewCheckBoxColumn.Name = "aktivDataGridViewCheckBoxColumn";
      // 
      // groesseMDataGridViewTextBoxColumn
      // 
      this.groesseMDataGridViewTextBoxColumn.DataPropertyName = "GroesseM";
      dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
      dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      dataGridViewCellStyle6.Format = "N2";
      this.groesseMDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
      this.groesseMDataGridViewTextBoxColumn.HeaderText = "GroesseM";
      this.groesseMDataGridViewTextBoxColumn.Name = "groesseMDataGridViewTextBoxColumn";
      this.groesseMDataGridViewTextBoxColumn.ReadOnly = true;
      // 
      // gebTagLabel
      // 
      gebTagLabel.AutoSize = true;
      gebTagLabel.Location = new System.Drawing.Point(860, 91);
      gebTagLabel.Name = "gebTagLabel";
      gebTagLabel.Size = new System.Drawing.Size(76, 23);
      gebTagLabel.TabIndex = 2;
      gebTagLabel.Text = "Geb Tag:";
      // 
      // dateTimePicker1
      // 
      this.dateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsPersonen, "GebTag", true));
      this.dateTimePicker1.Location = new System.Drawing.Point(864, 117);
      this.dateTimePicker1.Name = "dateTimePicker1";
      this.dateTimePicker1.Size = new System.Drawing.Size(336, 31);
      this.dateTimePicker1.TabIndex = 3;
      // 
      // btnNextStep
      // 
      this.btnNextStep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btnNextStep.Location = new System.Drawing.Point(998, 380);
      this.btnNextStep.Name = "btnNextStep";
      this.btnNextStep.Size = new System.Drawing.Size(202, 32);
      this.btnNextStep.TabIndex = 4;
      this.btnNextStep.Text = "Weiter>>";
      this.btnNextStep.UseVisualStyleBackColor = true;
      this.btnNextStep.Click += new System.EventHandler(this.btnNextStep_Click);
      // 
      // FrmMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1212, 424);
      this.Controls.Add(this.btnNextStep);
      this.Controls.Add(this.dateTimePicker1);
      this.Controls.Add(gebTagLabel);
      this.Controls.Add(this.dgvPersonen);
      this.Controls.Add(this.navMain);
      this.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Margin = new System.Windows.Forms.Padding(5);
      this.Name = "FrmMain";
      this.Text = "Form1";
      ((System.ComponentModel.ISupportInitialize)(this.navMain)).EndInit();
      this.navMain.ResumeLayout(false);
      this.navMain.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgvPersonen)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.bsPersonen)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dsMain)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.BindingNavigator navMain;
    private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
    private System.Windows.Forms.BindingSource bsPersonen;
    private DsDaten dsMain;
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
    private System.Windows.Forms.ToolStripButton btnSaveData;
    private System.Windows.Forms.ToolStripButton btnLoadData;
    private System.Windows.Forms.DataGridView dgvPersonen;
    private System.Windows.Forms.DataGridViewTextBoxColumn vornameDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn nachnameDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn gebTagDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn groesseCmDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewCheckBoxColumn aktivDataGridViewCheckBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn groesseMDataGridViewTextBoxColumn;
    private System.Windows.Forms.DateTimePicker dateTimePicker1;
    private System.Windows.Forms.Button btnNextStep;
  }
}

