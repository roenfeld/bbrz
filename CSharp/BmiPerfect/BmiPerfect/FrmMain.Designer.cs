namespace BmiPerfect
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
      System.Windows.Forms.Label bmiLabel;
      System.Windows.Forms.Label heightCmLabel;
      System.Windows.Forms.Label weightKgLabel;
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
      this.navMain = new System.Windows.Forms.BindingNavigator(this.components);
      this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
      this.bsBmi = new System.Windows.Forms.BindingSource(this.components);
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
      this.bmiCalcBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
      this.bmiCalcDataGridView = new System.Windows.Forms.DataGridView();
      this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.bmiTextBox = new System.Windows.Forms.TextBox();
      this.heightCmTextBox = new System.Windows.Forms.TextBox();
      this.weightKgTextBox = new System.Windows.Forms.TextBox();
      this.trackBar1 = new System.Windows.Forms.TrackBar();
      bmiLabel = new System.Windows.Forms.Label();
      heightCmLabel = new System.Windows.Forms.Label();
      weightKgLabel = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.navMain)).BeginInit();
      this.navMain.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.bsBmi)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.bmiCalcDataGridView)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
      this.SuspendLayout();
      // 
      // bmiLabel
      // 
      bmiLabel.Image = global::BmiPerfect.Properties.Resources.HandIndex;
      bmiLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      bmiLabel.Location = new System.Drawing.Point(596, 148);
      bmiLabel.Name = "bmiLabel";
      bmiLabel.Size = new System.Drawing.Size(170, 48);
      bmiLabel.TabIndex = 2;
      bmiLabel.Text = "Bmi:";
      bmiLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // heightCmLabel
      // 
      heightCmLabel.Image = global::BmiPerfect.Properties.Resources.Measure;
      heightCmLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      heightCmLabel.Location = new System.Drawing.Point(596, 52);
      heightCmLabel.Name = "heightCmLabel";
      heightCmLabel.Size = new System.Drawing.Size(170, 48);
      heightCmLabel.TabIndex = 4;
      heightCmLabel.Text = "Height Cm:";
      heightCmLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // weightKgLabel
      // 
      weightKgLabel.Image = global::BmiPerfect.Properties.Resources.Scale;
      weightKgLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      weightKgLabel.Location = new System.Drawing.Point(596, 100);
      weightKgLabel.Name = "weightKgLabel";
      weightKgLabel.Size = new System.Drawing.Size(170, 48);
      weightKgLabel.TabIndex = 6;
      weightKgLabel.Text = "Weight Kg:";
      weightKgLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // navMain
      // 
      this.navMain.AddNewItem = this.bindingNavigatorAddNewItem;
      this.navMain.BindingSource = this.bsBmi;
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
            this.bmiCalcBindingNavigatorSaveItem});
      this.navMain.Location = new System.Drawing.Point(0, 0);
      this.navMain.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
      this.navMain.MoveLastItem = this.bindingNavigatorMoveLastItem;
      this.navMain.MoveNextItem = this.bindingNavigatorMoveNextItem;
      this.navMain.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
      this.navMain.Name = "navMain";
      this.navMain.PositionItem = this.bindingNavigatorPositionItem;
      this.navMain.Size = new System.Drawing.Size(1078, 25);
      this.navMain.TabIndex = 0;
      this.navMain.Text = "bindingNavigator1";
      // 
      // bindingNavigatorAddNewItem
      // 
      this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
      this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
      this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
      this.bindingNavigatorAddNewItem.Text = "Neu hinzufügen";
      // 
      // bsBmi
      // 
      this.bsBmi.DataSource = typeof(BmiLib.BmiCalc);
      // 
      // bindingNavigatorCountItem
      // 
      this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
      this.bindingNavigatorCountItem.Size = new System.Drawing.Size(48, 22);
      this.bindingNavigatorCountItem.Text = "von {0}";
      this.bindingNavigatorCountItem.ToolTipText = "Die Gesamtanzahl der Elemente.";
      // 
      // bindingNavigatorDeleteItem
      // 
      this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
      this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
      this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
      this.bindingNavigatorDeleteItem.Text = "Löschen";
      // 
      // bindingNavigatorMoveFirstItem
      // 
      this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
      this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
      this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
      this.bindingNavigatorMoveFirstItem.Text = "Erste verschieben";
      // 
      // bindingNavigatorMovePreviousItem
      // 
      this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
      this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
      this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
      this.bindingNavigatorMovePreviousItem.Text = "Vorherige verschieben";
      // 
      // bindingNavigatorSeparator
      // 
      this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
      this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
      // 
      // bindingNavigatorPositionItem
      // 
      this.bindingNavigatorPositionItem.AccessibleName = "Position";
      this.bindingNavigatorPositionItem.AutoSize = false;
      this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9.75F);
      this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
      this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 25);
      this.bindingNavigatorPositionItem.Text = "0";
      this.bindingNavigatorPositionItem.ToolTipText = "Aktuelle Position";
      // 
      // bindingNavigatorSeparator1
      // 
      this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
      this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
      // 
      // bindingNavigatorMoveNextItem
      // 
      this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
      this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
      this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
      this.bindingNavigatorMoveNextItem.Text = "Nächste verschieben";
      // 
      // bindingNavigatorMoveLastItem
      // 
      this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
      this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
      this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
      this.bindingNavigatorMoveLastItem.Text = "Letzte verschieben";
      // 
      // bindingNavigatorSeparator2
      // 
      this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
      this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
      // 
      // bmiCalcBindingNavigatorSaveItem
      // 
      this.bmiCalcBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bmiCalcBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("bmiCalcBindingNavigatorSaveItem.Image")));
      this.bmiCalcBindingNavigatorSaveItem.Name = "bmiCalcBindingNavigatorSaveItem";
      this.bmiCalcBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
      this.bmiCalcBindingNavigatorSaveItem.Text = "Daten speichern";
      // 
      // bmiCalcDataGridView
      // 
      this.bmiCalcDataGridView.AutoGenerateColumns = false;
      this.bmiCalcDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.bmiCalcDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
      this.bmiCalcDataGridView.DataSource = this.bsBmi;
      this.bmiCalcDataGridView.Location = new System.Drawing.Point(25, 52);
      this.bmiCalcDataGridView.Name = "bmiCalcDataGridView";
      this.bmiCalcDataGridView.Size = new System.Drawing.Size(500, 455);
      this.bmiCalcDataGridView.TabIndex = 1;
      // 
      // dataGridViewTextBoxColumn1
      // 
      this.dataGridViewTextBoxColumn1.DataPropertyName = "WeightKg";
      this.dataGridViewTextBoxColumn1.HeaderText = "WeightKg";
      this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
      // 
      // dataGridViewTextBoxColumn2
      // 
      this.dataGridViewTextBoxColumn2.DataPropertyName = "HeightCm";
      this.dataGridViewTextBoxColumn2.HeaderText = "HeightCm";
      this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
      // 
      // dataGridViewTextBoxColumn3
      // 
      this.dataGridViewTextBoxColumn3.DataPropertyName = "Bmi";
      this.dataGridViewTextBoxColumn3.HeaderText = "Bmi";
      this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
      this.dataGridViewTextBoxColumn3.ReadOnly = true;
      // 
      // dataGridViewTextBoxColumn4
      // 
      this.dataGridViewTextBoxColumn4.DataPropertyName = "HintColor";
      this.dataGridViewTextBoxColumn4.HeaderText = "HintColor";
      this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
      this.dataGridViewTextBoxColumn4.ReadOnly = true;
      // 
      // bmiTextBox
      // 
      this.bmiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBmi, "Bmi", true));
      this.bmiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", this.bsBmi, "HintColor", true));
      this.bmiTextBox.Location = new System.Drawing.Point(805, 160);
      this.bmiTextBox.Name = "bmiTextBox";
      this.bmiTextBox.Size = new System.Drawing.Size(158, 27);
      this.bmiTextBox.TabIndex = 3;
      this.bmiTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // heightCmTextBox
      // 
      this.heightCmTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBmi, "HeightCm", true));
      this.heightCmTextBox.Location = new System.Drawing.Point(805, 64);
      this.heightCmTextBox.Name = "heightCmTextBox";
      this.heightCmTextBox.Size = new System.Drawing.Size(158, 27);
      this.heightCmTextBox.TabIndex = 5;
      this.heightCmTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // weightKgTextBox
      // 
      this.weightKgTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBmi, "WeightKg", true));
      this.weightKgTextBox.Location = new System.Drawing.Point(805, 112);
      this.weightKgTextBox.Name = "weightKgTextBox";
      this.weightKgTextBox.Size = new System.Drawing.Size(158, 27);
      this.weightKgTextBox.TabIndex = 7;
      this.weightKgTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // trackBar1
      // 
      this.trackBar1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsBmi, "Bmi", true));
      this.trackBar1.Location = new System.Drawing.Point(600, 257);
      this.trackBar1.Maximum = 50;
      this.trackBar1.Name = "trackBar1";
      this.trackBar1.Size = new System.Drawing.Size(363, 45);
      this.trackBar1.TabIndex = 8;
      // 
      // FrmMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1078, 553);
      this.Controls.Add(this.trackBar1);
      this.Controls.Add(bmiLabel);
      this.Controls.Add(this.bmiTextBox);
      this.Controls.Add(heightCmLabel);
      this.Controls.Add(this.heightCmTextBox);
      this.Controls.Add(weightKgLabel);
      this.Controls.Add(this.weightKgTextBox);
      this.Controls.Add(this.bmiCalcDataGridView);
      this.Controls.Add(this.navMain);
      this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Margin = new System.Windows.Forms.Padding(4);
      this.Name = "FrmMain";
      this.Text = "Form1";
      ((System.ComponentModel.ISupportInitialize)(this.navMain)).EndInit();
      this.navMain.ResumeLayout(false);
      this.navMain.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.bsBmi)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.bmiCalcDataGridView)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.BindingSource bsBmi;
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
    private System.Windows.Forms.ToolStripButton bmiCalcBindingNavigatorSaveItem;
    private System.Windows.Forms.DataGridView bmiCalcDataGridView;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    private System.Windows.Forms.TextBox bmiTextBox;
    private System.Windows.Forms.TextBox heightCmTextBox;
    private System.Windows.Forms.TextBox weightKgTextBox;
    private System.Windows.Forms.TrackBar trackBar1;
  }
}

