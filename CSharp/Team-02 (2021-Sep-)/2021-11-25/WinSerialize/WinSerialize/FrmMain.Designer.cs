namespace WinSerialize
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
      this.btnXmlSerialize = new System.Windows.Forms.Button();
      this.btnXmlDeSerialize = new System.Windows.Forms.Button();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuFileSave = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuFileSaveAs = new System.Windows.Forms.ToolStripMenuItem();
      this.lbPersonen = new System.Windows.Forms.ListBox();
      this.personBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
      this.personBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
      this.dgvPersonen = new System.Windows.Forms.DataGridView();
      this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.personBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.menuStrip1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.personBindingNavigator)).BeginInit();
      this.personBindingNavigator.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgvPersonen)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).BeginInit();
      this.SuspendLayout();
      // 
      // btnXmlSerialize
      // 
      this.btnXmlSerialize.Location = new System.Drawing.Point(31, 61);
      this.btnXmlSerialize.Name = "btnXmlSerialize";
      this.btnXmlSerialize.Size = new System.Drawing.Size(332, 42);
      this.btnXmlSerialize.TabIndex = 0;
      this.btnXmlSerialize.Text = "XML Serialisieren";
      this.btnXmlSerialize.UseVisualStyleBackColor = true;
      this.btnXmlSerialize.Click += new System.EventHandler(this.btnXmlSerialize_Click);
      // 
      // btnXmlDeSerialize
      // 
      this.btnXmlDeSerialize.Location = new System.Drawing.Point(383, 61);
      this.btnXmlDeSerialize.Name = "btnXmlDeSerialize";
      this.btnXmlDeSerialize.Size = new System.Drawing.Size(332, 42);
      this.btnXmlDeSerialize.TabIndex = 1;
      this.btnXmlDeSerialize.Text = "XML DE-Serialisieren";
      this.btnXmlDeSerialize.UseVisualStyleBackColor = true;
      this.btnXmlDeSerialize.Click += new System.EventHandler(this.btnXmlDeSerialize_Click);
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(869, 29);
      this.menuStrip1.TabIndex = 2;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // mnuFile
      // 
      this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileSave,
            this.mnuFileSaveAs});
      this.mnuFile.Name = "mnuFile";
      this.mnuFile.Size = new System.Drawing.Size(58, 25);
      this.mnuFile.Text = "Datei";
      // 
      // mnuFileSave
      // 
      this.mnuFileSave.Image = global::WinSerialize.Properties.Resources.saveHS;
      this.mnuFileSave.Name = "mnuFileSave";
      this.mnuFileSave.Size = new System.Drawing.Size(199, 26);
      this.mnuFileSave.Text = "Speichern";
      this.mnuFileSave.Click += new System.EventHandler(this.mnuFileSave_Click);
      // 
      // mnuFileSaveAs
      // 
      this.mnuFileSaveAs.Image = global::WinSerialize.Properties.Resources.saveHS;
      this.mnuFileSaveAs.Name = "mnuFileSaveAs";
      this.mnuFileSaveAs.Size = new System.Drawing.Size(199, 26);
      this.mnuFileSaveAs.Text = "Speichern unter...";
      this.mnuFileSaveAs.Click += new System.EventHandler(this.mnuFileSaveAs_Click);
      // 
      // lbPersonen
      // 
      this.lbPersonen.FormattingEnabled = true;
      this.lbPersonen.ItemHeight = 25;
      this.lbPersonen.Location = new System.Drawing.Point(31, 129);
      this.lbPersonen.Name = "lbPersonen";
      this.lbPersonen.Size = new System.Drawing.Size(332, 79);
      this.lbPersonen.TabIndex = 3;
      // 
      // personBindingNavigator
      // 
      this.personBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
      this.personBindingNavigator.BindingSource = this.personBindingSource;
      this.personBindingNavigator.CountItem = this.bindingNavigatorCountItem;
      this.personBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
      this.personBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.personBindingNavigatorSaveItem});
      this.personBindingNavigator.Location = new System.Drawing.Point(0, 29);
      this.personBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
      this.personBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
      this.personBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
      this.personBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
      this.personBindingNavigator.Name = "personBindingNavigator";
      this.personBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
      this.personBindingNavigator.Size = new System.Drawing.Size(869, 29);
      this.personBindingNavigator.TabIndex = 4;
      this.personBindingNavigator.Text = "bindingNavigator1";
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
      // personBindingNavigatorSaveItem
      // 
      this.personBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.personBindingNavigatorSaveItem.Enabled = false;
      this.personBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("personBindingNavigatorSaveItem.Image")));
      this.personBindingNavigatorSaveItem.Name = "personBindingNavigatorSaveItem";
      this.personBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 26);
      this.personBindingNavigatorSaveItem.Text = "Daten speichern";
      // 
      // dgvPersonen
      // 
      dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.dgvPersonen.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
      this.dgvPersonen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.dgvPersonen.AutoGenerateColumns = false;
      this.dgvPersonen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvPersonen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
      this.dgvPersonen.DataSource = this.personBindingSource;
      this.dgvPersonen.Location = new System.Drawing.Point(31, 245);
      this.dgvPersonen.Name = "dgvPersonen";
      this.dgvPersonen.Size = new System.Drawing.Size(813, 288);
      this.dgvPersonen.TabIndex = 5;
      // 
      // dataGridViewTextBoxColumn1
      // 
      this.dataGridViewTextBoxColumn1.DataPropertyName = "FirstName";
      this.dataGridViewTextBoxColumn1.HeaderText = "Vorname";
      this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
      this.dataGridViewTextBoxColumn1.Width = 150;
      // 
      // dataGridViewTextBoxColumn2
      // 
      this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.dataGridViewTextBoxColumn2.DataPropertyName = "LastName";
      this.dataGridViewTextBoxColumn2.HeaderText = "Nachname";
      this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
      // 
      // dataGridViewTextBoxColumn3
      // 
      this.dataGridViewTextBoxColumn3.DataPropertyName = "BirthDay";
      this.dataGridViewTextBoxColumn3.HeaderText = "BirthDay";
      this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
      this.dataGridViewTextBoxColumn3.Width = 150;
      // 
      // dataGridViewTextBoxColumn4
      // 
      this.dataGridViewTextBoxColumn4.DataPropertyName = "HeightCm";
      this.dataGridViewTextBoxColumn4.HeaderText = "Grösse [cm]";
      this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
      this.dataGridViewTextBoxColumn4.Width = 150;
      // 
      // dataGridViewTextBoxColumn5
      // 
      this.dataGridViewTextBoxColumn5.DataPropertyName = "Password";
      this.dataGridViewTextBoxColumn5.HeaderText = "Password";
      this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
      this.dataGridViewTextBoxColumn5.Visible = false;
      // 
      // personBindingSource
      // 
      this.personBindingSource.DataSource = typeof(WinSerialize.Person);
      // 
      // FrmMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(869, 566);
      this.Controls.Add(this.dgvPersonen);
      this.Controls.Add(this.personBindingNavigator);
      this.Controls.Add(this.lbPersonen);
      this.Controls.Add(this.btnXmlDeSerialize);
      this.Controls.Add(this.btnXmlSerialize);
      this.Controls.Add(this.menuStrip1);
      this.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.MainMenuStrip = this.menuStrip1;
      this.Margin = new System.Windows.Forms.Padding(6);
      this.Name = "FrmMain";
      this.Text = "Form1";
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.personBindingNavigator)).EndInit();
      this.personBindingNavigator.ResumeLayout(false);
      this.personBindingNavigator.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgvPersonen)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnXmlSerialize;
    private System.Windows.Forms.Button btnXmlDeSerialize;
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem mnuFile;
    private System.Windows.Forms.ToolStripMenuItem mnuFileSave;
    private System.Windows.Forms.ToolStripMenuItem mnuFileSaveAs;
    private System.Windows.Forms.ListBox lbPersonen;
    private System.Windows.Forms.BindingSource personBindingSource;
    private System.Windows.Forms.BindingNavigator personBindingNavigator;
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
    private System.Windows.Forms.ToolStripButton personBindingNavigatorSaveItem;
    private System.Windows.Forms.DataGridView dgvPersonen;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
  }
}

