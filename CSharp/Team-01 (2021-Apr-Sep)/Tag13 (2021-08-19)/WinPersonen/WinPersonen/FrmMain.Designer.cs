
namespace WinPersonen
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
      System.Windows.Forms.Label birthDayLabel;
      System.Windows.Forms.Label incomeLabel;
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
      this.navPersonen = new System.Windows.Forms.BindingNavigator(this.components);
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
      this.btnSavePersons = new System.Windows.Forms.ToolStripButton();
      this.dgvPersonen = new System.Windows.Forms.DataGridView();
      this.Income = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.birthDayDateTimePicker = new System.Windows.Forms.DateTimePicker();
      this.incomeTextBox = new System.Windows.Forms.TextBox();
      this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
      this.speichernUnterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.bsPersonen = new System.Windows.Forms.BindingSource(this.components);
      this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
      birthDayLabel = new System.Windows.Forms.Label();
      incomeLabel = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.navPersonen)).BeginInit();
      this.navPersonen.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgvPersonen)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.bsPersonen)).BeginInit();
      this.SuspendLayout();
      // 
      // birthDayLabel
      // 
      birthDayLabel.AutoSize = true;
      birthDayLabel.Location = new System.Drawing.Point(33, 301);
      birthDayLabel.Name = "birthDayLabel";
      birthDayLabel.Size = new System.Drawing.Size(94, 23);
      birthDayLabel.TabIndex = 2;
      birthDayLabel.Text = "Birth Day:";
      // 
      // incomeLabel
      // 
      incomeLabel.AutoSize = true;
      incomeLabel.Location = new System.Drawing.Point(88, 394);
      incomeLabel.Name = "incomeLabel";
      incomeLabel.Size = new System.Drawing.Size(80, 23);
      incomeLabel.TabIndex = 4;
      incomeLabel.Text = "Income:";
      // 
      // navPersonen
      // 
      this.navPersonen.AddNewItem = this.bindingNavigatorAddNewItem;
      this.navPersonen.BindingSource = this.bsPersonen;
      this.navPersonen.CountItem = this.bindingNavigatorCountItem;
      this.navPersonen.DeleteItem = this.bindingNavigatorDeleteItem;
      this.navPersonen.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.btnSavePersons,
            this.toolStripDropDownButton1});
      this.navPersonen.Location = new System.Drawing.Point(0, 0);
      this.navPersonen.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
      this.navPersonen.MoveLastItem = this.bindingNavigatorMoveLastItem;
      this.navPersonen.MoveNextItem = this.bindingNavigatorMoveNextItem;
      this.navPersonen.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
      this.navPersonen.Name = "navPersonen";
      this.navPersonen.PositionItem = this.bindingNavigatorPositionItem;
      this.navPersonen.Size = new System.Drawing.Size(916, 29);
      this.navPersonen.TabIndex = 0;
      this.navPersonen.Text = "bindingNavigator1";
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
      // btnSavePersons
      // 
      this.btnSavePersons.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.btnSavePersons.Image = ((System.Drawing.Image)(resources.GetObject("btnSavePersons.Image")));
      this.btnSavePersons.Name = "btnSavePersons";
      this.btnSavePersons.Size = new System.Drawing.Size(23, 26);
      this.btnSavePersons.Text = "Daten speichern";
      this.btnSavePersons.Click += new System.EventHandler(this.btnSavePersons_Click);
      // 
      // dgvPersonen
      // 
      this.dgvPersonen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.dgvPersonen.AutoGenerateColumns = false;
      this.dgvPersonen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvPersonen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.Income});
      this.dgvPersonen.DataSource = this.bsPersonen;
      this.dgvPersonen.Location = new System.Drawing.Point(28, 54);
      this.dgvPersonen.Name = "dgvPersonen";
      this.dgvPersonen.Size = new System.Drawing.Size(789, 219);
      this.dgvPersonen.TabIndex = 1;
      // 
      // Income
      // 
      this.Income.DataPropertyName = "Income";
      this.Income.HeaderText = "Income";
      this.Income.Name = "Income";
      // 
      // birthDayDateTimePicker
      // 
      this.birthDayDateTimePicker.CustomFormat = "dd.MM.yyyy HH:mm";
      this.birthDayDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsPersonen, "BirthDay", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "g"));
      this.birthDayDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
      this.birthDayDateTimePicker.Location = new System.Drawing.Point(46, 327);
      this.birthDayDateTimePicker.Name = "birthDayDateTimePicker";
      this.birthDayDateTimePicker.Size = new System.Drawing.Size(310, 30);
      this.birthDayDateTimePicker.TabIndex = 3;
      // 
      // incomeTextBox
      // 
      this.incomeTextBox.Location = new System.Drawing.Point(92, 420);
      this.incomeTextBox.Name = "incomeTextBox";
      this.incomeTextBox.Size = new System.Drawing.Size(264, 30);
      this.incomeTextBox.TabIndex = 5;
      // 
      // toolStripDropDownButton1
      // 
      this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.speichernUnterToolStripMenuItem});
      this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
      this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
      this.toolStripDropDownButton1.Size = new System.Drawing.Size(75, 26);
      this.toolStripDropDownButton1.Text = "Datei";
      // 
      // speichernUnterToolStripMenuItem
      // 
      this.speichernUnterToolStripMenuItem.Image = global::WinPersonen.Properties.Resources.saveHS;
      this.speichernUnterToolStripMenuItem.Name = "speichernUnterToolStripMenuItem";
      this.speichernUnterToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
      this.speichernUnterToolStripMenuItem.Text = "Speichern unter...";
      this.speichernUnterToolStripMenuItem.Click += new System.EventHandler(this.speichernUnterToolStripMenuItem_Click);
      // 
      // bsPersonen
      // 
      this.bsPersonen.DataSource = typeof(WinPersonen.Person);
      // 
      // dataGridViewTextBoxColumn2
      // 
      this.dataGridViewTextBoxColumn2.DataPropertyName = "Phone";
      this.dataGridViewTextBoxColumn2.HeaderText = "Phone";
      this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
      // 
      // dataGridViewTextBoxColumn1
      // 
      this.dataGridViewTextBoxColumn1.DataPropertyName = "Name";
      this.dataGridViewTextBoxColumn1.HeaderText = "Name";
      this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
      // 
      // dataGridViewTextBoxColumn3
      // 
      this.dataGridViewTextBoxColumn3.DataPropertyName = "BirthDay";
      this.dataGridViewTextBoxColumn3.HeaderText = "BirthDay";
      this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
      // 
      // FrmMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(916, 495);
      this.Controls.Add(incomeLabel);
      this.Controls.Add(this.incomeTextBox);
      this.Controls.Add(birthDayLabel);
      this.Controls.Add(this.birthDayDateTimePicker);
      this.Controls.Add(this.dgvPersonen);
      this.Controls.Add(this.navPersonen);
      this.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Margin = new System.Windows.Forms.Padding(5);
      this.Name = "FrmMain";
      this.Text = "Form1";
      ((System.ComponentModel.ISupportInitialize)(this.navPersonen)).EndInit();
      this.navPersonen.ResumeLayout(false);
      this.navPersonen.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgvPersonen)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.bsPersonen)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.BindingSource bsPersonen;
    private System.Windows.Forms.BindingNavigator navPersonen;
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
    private System.Windows.Forms.ToolStripButton btnSavePersons;
    private System.Windows.Forms.DataGridView dgvPersonen;
    private System.Windows.Forms.DateTimePicker birthDayDateTimePicker;
    private System.Windows.Forms.TextBox incomeTextBox;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    private System.Windows.Forms.DataGridViewTextBoxColumn Income;
    private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
    private System.Windows.Forms.ToolStripMenuItem speichernUnterToolStripMenuItem;
    private System.Windows.Forms.SaveFileDialog saveFileDialog1;
  }
}

