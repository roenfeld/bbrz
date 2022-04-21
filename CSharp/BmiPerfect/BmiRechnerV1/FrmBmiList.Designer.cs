namespace BmiRechnerV1
{
  partial class FrmBmiList
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      System.Windows.Forms.Label bMILabel;
      System.Windows.Forms.Label heightCmLabel;
      System.Windows.Forms.Label nameLabel;
      System.Windows.Forms.Label weightKgLabel;
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBmiList));
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
      this.navBmi = new System.Windows.Forms.BindingNavigator(this.components);
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
      this.dgvBmi = new System.Windows.Forms.DataGridView();
      this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.bMILabel1 = new System.Windows.Forms.Label();
      this.heightCmTextBox = new System.Windows.Forms.TextBox();
      this.nameTextBox = new System.Windows.Forms.TextBox();
      this.weightKgNumericUpDown = new System.Windows.Forms.NumericUpDown();
      this.trackBar1 = new System.Windows.Forms.TrackBar();
      this.progressBar1 = new System.Windows.Forms.ProgressBar();
      this.label1 = new System.Windows.Forms.Label();
      bMILabel = new System.Windows.Forms.Label();
      heightCmLabel = new System.Windows.Forms.Label();
      nameLabel = new System.Windows.Forms.Label();
      weightKgLabel = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.navBmi)).BeginInit();
      this.navBmi.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.bsBmi)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dgvBmi)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.weightKgNumericUpDown)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
      this.SuspendLayout();
      // 
      // bMILabel
      // 
      bMILabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      bMILabel.AutoSize = true;
      bMILabel.Location = new System.Drawing.Point(692, 224);
      bMILabel.Name = "bMILabel";
      bMILabel.Size = new System.Drawing.Size(56, 25);
      bMILabel.TabIndex = 2;
      bMILabel.Text = "BMI:";
      // 
      // heightCmLabel
      // 
      heightCmLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      heightCmLabel.AutoSize = true;
      heightCmLabel.Location = new System.Drawing.Point(692, 94);
      heightCmLabel.Name = "heightCmLabel";
      heightCmLabel.Size = new System.Drawing.Size(118, 25);
      heightCmLabel.TabIndex = 4;
      heightCmLabel.Text = "Height Cm:";
      // 
      // nameLabel
      // 
      nameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      nameLabel.AutoSize = true;
      nameLabel.Location = new System.Drawing.Point(692, 133);
      nameLabel.Name = "nameLabel";
      nameLabel.Size = new System.Drawing.Size(73, 25);
      nameLabel.TabIndex = 6;
      nameLabel.Text = "Name:";
      // 
      // weightKgLabel
      // 
      weightKgLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      weightKgLabel.AutoSize = true;
      weightKgLabel.Location = new System.Drawing.Point(692, 169);
      weightKgLabel.Name = "weightKgLabel";
      weightKgLabel.Size = new System.Drawing.Size(116, 25);
      weightKgLabel.TabIndex = 8;
      weightKgLabel.Text = "Weight Kg:";
      // 
      // navBmi
      // 
      this.navBmi.AddNewItem = this.bindingNavigatorAddNewItem;
      this.navBmi.BindingSource = this.bsBmi;
      this.navBmi.CountItem = this.bindingNavigatorCountItem;
      this.navBmi.DeleteItem = this.bindingNavigatorDeleteItem;
      this.navBmi.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
      this.navBmi.Location = new System.Drawing.Point(0, 0);
      this.navBmi.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
      this.navBmi.MoveLastItem = this.bindingNavigatorMoveLastItem;
      this.navBmi.MoveNextItem = this.bindingNavigatorMoveNextItem;
      this.navBmi.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
      this.navBmi.Name = "navBmi";
      this.navBmi.PositionItem = this.bindingNavigatorPositionItem;
      this.navBmi.Size = new System.Drawing.Size(991, 25);
      this.navBmi.TabIndex = 0;
      this.navBmi.Text = "bindingNavigator1";
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
      this.bsBmi.DataSource = typeof(BmiRechnerV1.BmiCalc);
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
      this.bmiCalcBindingNavigatorSaveItem.Enabled = false;
      this.bmiCalcBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("bmiCalcBindingNavigatorSaveItem.Image")));
      this.bmiCalcBindingNavigatorSaveItem.Name = "bmiCalcBindingNavigatorSaveItem";
      this.bmiCalcBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
      this.bmiCalcBindingNavigatorSaveItem.Text = "Daten speichern";
      // 
      // dgvBmi
      // 
      dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.dgvBmi.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
      this.dgvBmi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.dgvBmi.AutoGenerateColumns = false;
      this.dgvBmi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvBmi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
      this.dgvBmi.DataSource = this.bsBmi;
      this.dgvBmi.Location = new System.Drawing.Point(12, 94);
      this.dgvBmi.Name = "dgvBmi";
      this.dgvBmi.Size = new System.Drawing.Size(615, 400);
      this.dgvBmi.TabIndex = 1;
      // 
      // dataGridViewTextBoxColumn1
      // 
      this.dataGridViewTextBoxColumn1.DataPropertyName = "HeightCm";
      this.dataGridViewTextBoxColumn1.HeaderText = "HeightCm";
      this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
      // 
      // dataGridViewTextBoxColumn2
      // 
      this.dataGridViewTextBoxColumn2.DataPropertyName = "WeightKg";
      this.dataGridViewTextBoxColumn2.HeaderText = "WeightKg";
      this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
      // 
      // dataGridViewTextBoxColumn3
      // 
      this.dataGridViewTextBoxColumn3.DataPropertyName = "Name";
      this.dataGridViewTextBoxColumn3.HeaderText = "Name";
      this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
      // 
      // dataGridViewTextBoxColumn4
      // 
      this.dataGridViewTextBoxColumn4.DataPropertyName = "BMI";
      this.dataGridViewTextBoxColumn4.HeaderText = "BMI";
      this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
      this.dataGridViewTextBoxColumn4.ReadOnly = true;
      // 
      // bMILabel1
      // 
      this.bMILabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.bMILabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBmi, "BMI", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N1"));
      this.bMILabel1.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", this.bsBmi, "BmiColor", true));
      this.bMILabel1.Location = new System.Drawing.Point(816, 224);
      this.bMILabel1.Name = "bMILabel1";
      this.bMILabel1.Size = new System.Drawing.Size(120, 35);
      this.bMILabel1.TabIndex = 3;
      this.bMILabel1.Text = "...Name";
      // 
      // heightCmTextBox
      // 
      this.heightCmTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.heightCmTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBmi, "HeightCm", true));
      this.heightCmTextBox.Location = new System.Drawing.Point(816, 91);
      this.heightCmTextBox.Name = "heightCmTextBox";
      this.heightCmTextBox.Size = new System.Drawing.Size(120, 33);
      this.heightCmTextBox.TabIndex = 5;
      // 
      // nameTextBox
      // 
      this.nameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBmi, "Name", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.nameTextBox.Location = new System.Drawing.Point(816, 130);
      this.nameTextBox.Name = "nameTextBox";
      this.nameTextBox.Size = new System.Drawing.Size(120, 33);
      this.nameTextBox.TabIndex = 7;
      // 
      // weightKgNumericUpDown
      // 
      this.weightKgNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.weightKgNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsBmi, "WeightKg", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.weightKgNumericUpDown.Location = new System.Drawing.Point(816, 169);
      this.weightKgNumericUpDown.Name = "weightKgNumericUpDown";
      this.weightKgNumericUpDown.Size = new System.Drawing.Size(120, 33);
      this.weightKgNumericUpDown.TabIndex = 9;
      // 
      // trackBar1
      // 
      this.trackBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.trackBar1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsBmi, "WeightKg", true));
      this.trackBar1.Location = new System.Drawing.Point(698, 339);
      this.trackBar1.Maximum = 200;
      this.trackBar1.Name = "trackBar1";
      this.trackBar1.Size = new System.Drawing.Size(238, 45);
      this.trackBar1.TabIndex = 10;
      // 
      // progressBar1
      // 
      this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.progressBar1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsBmi, "HeightCm", true));
      this.progressBar1.Location = new System.Drawing.Point(698, 284);
      this.progressBar1.Maximum = 200;
      this.progressBar1.Name = "progressBar1";
      this.progressBar1.Size = new System.Drawing.Size(238, 26);
      this.progressBar1.TabIndex = 11;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBmi, "Name", true));
      this.label1.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
      this.label1.Location = new System.Drawing.Point(12, 35);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(147, 45);
      this.label1.TabIndex = 12;
      this.label1.Text = "...Name";
      // 
      // FrmBmiList
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(991, 517);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.progressBar1);
      this.Controls.Add(this.trackBar1);
      this.Controls.Add(bMILabel);
      this.Controls.Add(this.bMILabel1);
      this.Controls.Add(heightCmLabel);
      this.Controls.Add(this.heightCmTextBox);
      this.Controls.Add(nameLabel);
      this.Controls.Add(this.nameTextBox);
      this.Controls.Add(weightKgLabel);
      this.Controls.Add(this.weightKgNumericUpDown);
      this.Controls.Add(this.dgvBmi);
      this.Controls.Add(this.navBmi);
      this.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Margin = new System.Windows.Forms.Padding(6);
      this.Name = "FrmBmiList";
      this.Text = "BMI Liste";
      ((System.ComponentModel.ISupportInitialize)(this.navBmi)).EndInit();
      this.navBmi.ResumeLayout(false);
      this.navBmi.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.bsBmi)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dgvBmi)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.weightKgNumericUpDown)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.BindingSource bsBmi;
    private System.Windows.Forms.BindingNavigator navBmi;
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
    private System.Windows.Forms.DataGridView dgvBmi;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    private System.Windows.Forms.Label bMILabel1;
    private System.Windows.Forms.TextBox heightCmTextBox;
    private System.Windows.Forms.TextBox nameTextBox;
    private System.Windows.Forms.NumericUpDown weightKgNumericUpDown;
    private System.Windows.Forms.TrackBar trackBar1;
    private System.Windows.Forms.ProgressBar progressBar1;
    private System.Windows.Forms.Label label1;
  }
}