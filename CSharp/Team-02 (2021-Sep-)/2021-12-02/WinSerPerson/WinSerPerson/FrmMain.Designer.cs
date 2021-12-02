namespace WinSerPerson
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
      this.navPerson = new System.Windows.Forms.BindingNavigator(this.components);
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
      this.btnSaveData = new System.Windows.Forms.ToolStripButton();
      this.dgvPerson = new System.Windows.Forms.DataGridView();
      this.activeDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
      this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.birthDayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.bsPerson = new System.Windows.Forms.BindingSource(this.components);
      ((System.ComponentModel.ISupportInitialize)(this.navPerson)).BeginInit();
      this.navPerson.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgvPerson)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.bsPerson)).BeginInit();
      this.SuspendLayout();
      // 
      // navPerson
      // 
      this.navPerson.AddNewItem = this.bindingNavigatorAddNewItem;
      this.navPerson.BindingSource = this.bsPerson;
      this.navPerson.CountItem = this.bindingNavigatorCountItem;
      this.navPerson.DeleteItem = this.bindingNavigatorDeleteItem;
      this.navPerson.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.btnSaveData});
      this.navPerson.Location = new System.Drawing.Point(0, 0);
      this.navPerson.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
      this.navPerson.MoveLastItem = this.bindingNavigatorMoveLastItem;
      this.navPerson.MoveNextItem = this.bindingNavigatorMoveNextItem;
      this.navPerson.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
      this.navPerson.Name = "navPerson";
      this.navPerson.PositionItem = this.bindingNavigatorPositionItem;
      this.navPerson.Size = new System.Drawing.Size(763, 29);
      this.navPerson.TabIndex = 0;
      this.navPerson.Text = "bindingNavigator1";
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
      // dgvPerson
      // 
      dataGridViewCellStyle1.BackColor = System.Drawing.Color.OldLace;
      this.dgvPerson.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
      this.dgvPerson.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.dgvPerson.AutoGenerateColumns = false;
      this.dgvPerson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvPerson.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.activeDataGridViewCheckBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.birthDayDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn});
      this.dgvPerson.DataSource = this.bsPerson;
      this.dgvPerson.Location = new System.Drawing.Point(12, 58);
      this.dgvPerson.Name = "dgvPerson";
      this.dgvPerson.Size = new System.Drawing.Size(739, 373);
      this.dgvPerson.TabIndex = 1;
      this.dgvPerson.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvPerson_DataError);
      // 
      // activeDataGridViewCheckBoxColumn
      // 
      this.activeDataGridViewCheckBoxColumn.DataPropertyName = "Active";
      this.activeDataGridViewCheckBoxColumn.HeaderText = "Active";
      this.activeDataGridViewCheckBoxColumn.Name = "activeDataGridViewCheckBoxColumn";
      // 
      // firstNameDataGridViewTextBoxColumn
      // 
      this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
      this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
      this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
      this.firstNameDataGridViewTextBoxColumn.Width = 150;
      // 
      // lastNameDataGridViewTextBoxColumn
      // 
      this.lastNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
      this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
      this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
      // 
      // birthDayDataGridViewTextBoxColumn
      // 
      this.birthDayDataGridViewTextBoxColumn.DataPropertyName = "BirthDay";
      this.birthDayDataGridViewTextBoxColumn.HeaderText = "BirthDay";
      this.birthDayDataGridViewTextBoxColumn.Name = "birthDayDataGridViewTextBoxColumn";
      this.birthDayDataGridViewTextBoxColumn.Width = 150;
      // 
      // ageDataGridViewTextBoxColumn
      // 
      this.ageDataGridViewTextBoxColumn.DataPropertyName = "Age";
      dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
      dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Blue;
      this.ageDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
      this.ageDataGridViewTextBoxColumn.HeaderText = "Age";
      this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
      this.ageDataGridViewTextBoxColumn.ReadOnly = true;
      // 
      // bsPerson
      // 
      this.bsPerson.DataSource = typeof(WinSerPerson.Person);
      // 
      // FrmMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 26F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(763, 443);
      this.Controls.Add(this.dgvPerson);
      this.Controls.Add(this.navPerson);
      this.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
      this.Name = "FrmMain";
      this.Text = "Form1";
      ((System.ComponentModel.ISupportInitialize)(this.navPerson)).EndInit();
      this.navPerson.ResumeLayout(false);
      this.navPerson.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgvPerson)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.bsPerson)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.BindingNavigator navPerson;
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
    private System.Windows.Forms.ToolStripButton btnSaveData;
    private System.Windows.Forms.BindingSource bsPerson;
    private System.Windows.Forms.DataGridView dgvPerson;
    private System.Windows.Forms.DataGridViewCheckBoxColumn activeDataGridViewCheckBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn birthDayDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
  }
}

