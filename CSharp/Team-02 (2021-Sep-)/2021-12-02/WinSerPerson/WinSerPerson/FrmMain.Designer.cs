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
      System.Windows.Forms.Label activeLabel;
      System.Windows.Forms.Label ageLabel;
      System.Windows.Forms.Label birthDayLabel;
      System.Windows.Forms.Label firstNameLabel;
      System.Windows.Forms.Label lastNameLabel;
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
      this.navPerson = new System.Windows.Forms.BindingNavigator(this.components);
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
      this.btnSaveData = new System.Windows.Forms.ToolStripButton();
      this.dgvPerson = new System.Windows.Forms.DataGridView();
      this.tabControl1 = new System.Windows.Forms.TabControl();
      this.tabPage1 = new System.Windows.Forms.TabPage();
      this.tabPage2 = new System.Windows.Forms.TabPage();
      this.activeCheckBox = new System.Windows.Forms.CheckBox();
      this.ageTextBox = new System.Windows.Forms.TextBox();
      this.birthDayDateTimePicker = new System.Windows.Forms.DateTimePicker();
      this.firstNameTextBox = new System.Windows.Forms.TextBox();
      this.lastNameTextBox = new System.Windows.Forms.TextBox();
      this.bsPerson = new System.Windows.Forms.BindingSource(this.components);
      this.activeDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
      this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.birthDayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      activeLabel = new System.Windows.Forms.Label();
      ageLabel = new System.Windows.Forms.Label();
      birthDayLabel = new System.Windows.Forms.Label();
      firstNameLabel = new System.Windows.Forms.Label();
      lastNameLabel = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.navPerson)).BeginInit();
      this.navPerson.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgvPerson)).BeginInit();
      this.tabControl1.SuspendLayout();
      this.tabPage1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.bsPerson)).BeginInit();
      this.SuspendLayout();
      // 
      // navPerson
      // 
      this.navPerson.AddNewItem = this.bindingNavigatorAddNewItem;
      this.navPerson.BindingSource = this.bsPerson;
      this.navPerson.CountItem = this.bindingNavigatorCountItem;
      this.navPerson.DeleteItem = this.bindingNavigatorDeleteItem;
      this.navPerson.Dock = System.Windows.Forms.DockStyle.None;
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
      this.navPerson.Location = new System.Drawing.Point(6, 15);
      this.navPerson.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
      this.navPerson.MoveLastItem = this.bindingNavigatorMoveLastItem;
      this.navPerson.MoveNextItem = this.bindingNavigatorMoveNextItem;
      this.navPerson.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
      this.navPerson.Name = "navPerson";
      this.navPerson.PositionItem = this.bindingNavigatorPositionItem;
      this.navPerson.Size = new System.Drawing.Size(302, 29);
      this.navPerson.TabIndex = 0;
      this.navPerson.Text = "bindingNavigator1";
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
      this.bindingNavigatorCountItem.Size = new System.Drawing.Size(59, 26);
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
      this.dgvPerson.Location = new System.Drawing.Point(6, 47);
      this.dgvPerson.Name = "dgvPerson";
      this.dgvPerson.Size = new System.Drawing.Size(832, 402);
      this.dgvPerson.TabIndex = 1;
      this.dgvPerson.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvPerson_DataError);
      // 
      // tabControl1
      // 
      this.tabControl1.Controls.Add(this.tabPage1);
      this.tabControl1.Controls.Add(this.tabPage2);
      this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tabControl1.Location = new System.Drawing.Point(6, 6);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new System.Drawing.Size(1236, 536);
      this.tabControl1.TabIndex = 2;
      // 
      // tabPage1
      // 
      this.tabPage1.AutoScroll = true;
      this.tabPage1.Controls.Add(activeLabel);
      this.tabPage1.Controls.Add(this.activeCheckBox);
      this.tabPage1.Controls.Add(ageLabel);
      this.tabPage1.Controls.Add(this.ageTextBox);
      this.tabPage1.Controls.Add(birthDayLabel);
      this.tabPage1.Controls.Add(this.birthDayDateTimePicker);
      this.tabPage1.Controls.Add(firstNameLabel);
      this.tabPage1.Controls.Add(this.firstNameTextBox);
      this.tabPage1.Controls.Add(lastNameLabel);
      this.tabPage1.Controls.Add(this.lastNameTextBox);
      this.tabPage1.Controls.Add(this.dgvPerson);
      this.tabPage1.Controls.Add(this.navPerson);
      this.tabPage1.Location = new System.Drawing.Point(4, 35);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage1.Size = new System.Drawing.Size(1228, 497);
      this.tabPage1.TabIndex = 0;
      this.tabPage1.Text = "tabPage1";
      this.tabPage1.UseVisualStyleBackColor = true;
      // 
      // tabPage2
      // 
      this.tabPage2.Location = new System.Drawing.Point(4, 35);
      this.tabPage2.Name = "tabPage2";
      this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage2.Size = new System.Drawing.Size(1228, 497);
      this.tabPage2.TabIndex = 1;
      this.tabPage2.Text = "tabPage2";
      this.tabPage2.UseVisualStyleBackColor = true;
      // 
      // activeLabel
      // 
      activeLabel.AutoSize = true;
      activeLabel.Location = new System.Drawing.Point(844, 303);
      activeLabel.Name = "activeLabel";
      activeLabel.Size = new System.Drawing.Size(70, 26);
      activeLabel.TabIndex = 2;
      activeLabel.Text = "Active:";
      // 
      // activeCheckBox
      // 
      this.activeCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.bsPerson, "Active", true));
      this.activeCheckBox.Location = new System.Drawing.Point(971, 305);
      this.activeCheckBox.Name = "activeCheckBox";
      this.activeCheckBox.Size = new System.Drawing.Size(200, 24);
      this.activeCheckBox.TabIndex = 3;
      this.activeCheckBox.UseVisualStyleBackColor = true;
      // 
      // ageLabel
      // 
      ageLabel.AutoSize = true;
      ageLabel.Location = new System.Drawing.Point(844, 247);
      ageLabel.Name = "ageLabel";
      ageLabel.Size = new System.Drawing.Size(50, 26);
      ageLabel.TabIndex = 4;
      ageLabel.Text = "Age:";
      // 
      // ageTextBox
      // 
      this.ageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsPerson, "Age", true));
      this.ageTextBox.Location = new System.Drawing.Point(961, 240);
      this.ageTextBox.Name = "ageTextBox";
      this.ageTextBox.Size = new System.Drawing.Size(246, 33);
      this.ageTextBox.TabIndex = 5;
      // 
      // birthDayLabel
      // 
      birthDayLabel.AutoSize = true;
      birthDayLabel.Location = new System.Drawing.Point(844, 190);
      birthDayLabel.Name = "birthDayLabel";
      birthDayLabel.Size = new System.Drawing.Size(97, 26);
      birthDayLabel.TabIndex = 6;
      birthDayLabel.Text = "Birth Day:";
      // 
      // birthDayDateTimePicker
      // 
      this.birthDayDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsPerson, "BirthDay", true));
      this.birthDayDateTimePicker.Location = new System.Drawing.Point(961, 186);
      this.birthDayDateTimePicker.Name = "birthDayDateTimePicker";
      this.birthDayDateTimePicker.Size = new System.Drawing.Size(246, 33);
      this.birthDayDateTimePicker.TabIndex = 7;
      // 
      // firstNameLabel
      // 
      firstNameLabel.AutoSize = true;
      firstNameLabel.Location = new System.Drawing.Point(844, 73);
      firstNameLabel.Name = "firstNameLabel";
      firstNameLabel.Size = new System.Drawing.Size(111, 26);
      firstNameLabel.TabIndex = 8;
      firstNameLabel.Text = "First Name:";
      // 
      // firstNameTextBox
      // 
      this.firstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsPerson, "FirstName", true));
      this.firstNameTextBox.Location = new System.Drawing.Point(961, 70);
      this.firstNameTextBox.Name = "firstNameTextBox";
      this.firstNameTextBox.Size = new System.Drawing.Size(246, 33);
      this.firstNameTextBox.TabIndex = 9;
      // 
      // lastNameLabel
      // 
      lastNameLabel.AutoSize = true;
      lastNameLabel.Location = new System.Drawing.Point(844, 131);
      lastNameLabel.Name = "lastNameLabel";
      lastNameLabel.Size = new System.Drawing.Size(108, 26);
      lastNameLabel.TabIndex = 10;
      lastNameLabel.Text = "Last Name:";
      // 
      // lastNameTextBox
      // 
      this.lastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsPerson, "LastName", true));
      this.lastNameTextBox.Location = new System.Drawing.Point(961, 128);
      this.lastNameTextBox.Name = "lastNameTextBox";
      this.lastNameTextBox.Size = new System.Drawing.Size(246, 33);
      this.lastNameTextBox.TabIndex = 11;
      // 
      // bsPerson
      // 
      this.bsPerson.AllowNew = true;
      this.bsPerson.DataSource = typeof(WinSerPerson.Person);
      this.bsPerson.Sort = "BirthDay DESC";
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
      this.firstNameDataGridViewTextBoxColumn.HeaderText = "Vorname";
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
      // FrmMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 26F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1248, 548);
      this.Controls.Add(this.tabControl1);
      this.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Margin = new System.Windows.Forms.Padding(6);
      this.Name = "FrmMain";
      this.Padding = new System.Windows.Forms.Padding(6);
      this.Text = "Form1";
      ((System.ComponentModel.ISupportInitialize)(this.navPerson)).EndInit();
      this.navPerson.ResumeLayout(false);
      this.navPerson.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgvPerson)).EndInit();
      this.tabControl1.ResumeLayout(false);
      this.tabPage1.ResumeLayout(false);
      this.tabPage1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.bsPerson)).EndInit();
      this.ResumeLayout(false);

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
    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage tabPage1;
    private System.Windows.Forms.TabPage tabPage2;
    private System.Windows.Forms.DataGridViewCheckBoxColumn activeDataGridViewCheckBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn birthDayDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
    private System.Windows.Forms.CheckBox activeCheckBox;
    private System.Windows.Forms.TextBox ageTextBox;
    private System.Windows.Forms.DateTimePicker birthDayDateTimePicker;
    private System.Windows.Forms.TextBox firstNameTextBox;
    private System.Windows.Forms.TextBox lastNameTextBox;
  }
}

