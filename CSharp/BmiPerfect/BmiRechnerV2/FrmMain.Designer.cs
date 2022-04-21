namespace BmiRechnerV2
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
      this.bmiTextBox = new System.Windows.Forms.TextBox();
      this.heightCmTextBox = new System.Windows.Forms.TextBox();
      this.weightKgTextBox = new System.Windows.Forms.TextBox();
      this.trackBar1 = new System.Windows.Forms.TrackBar();
      bmiLabel = new System.Windows.Forms.Label();
      heightCmLabel = new System.Windows.Forms.Label();
      weightKgLabel = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.navBmi)).BeginInit();
      this.navBmi.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.bsBmi)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
      this.SuspendLayout();
      // 
      // bmiLabel
      // 
      bmiLabel.AutoSize = true;
      bmiLabel.Location = new System.Drawing.Point(31, 166);
      bmiLabel.Name = "bmiLabel";
      bmiLabel.Size = new System.Drawing.Size(51, 22);
      bmiLabel.TabIndex = 1;
      bmiLabel.Text = "Bmi:";
      // 
      // heightCmLabel
      // 
      heightCmLabel.AutoSize = true;
      heightCmLabel.Location = new System.Drawing.Point(31, 69);
      heightCmLabel.Name = "heightCmLabel";
      heightCmLabel.Size = new System.Drawing.Size(115, 22);
      heightCmLabel.TabIndex = 3;
      heightCmLabel.Text = "Height Cm:";
      // 
      // weightKgLabel
      // 
      weightKgLabel.AutoSize = true;
      weightKgLabel.Location = new System.Drawing.Point(31, 105);
      weightKgLabel.Name = "weightKgLabel";
      weightKgLabel.Size = new System.Drawing.Size(109, 22);
      weightKgLabel.TabIndex = 5;
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
      this.navBmi.Size = new System.Drawing.Size(487, 25);
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
      this.bsBmi.DataSource = typeof(Roenfeld.Utils.BmiCalc);
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
      // bmiTextBox
      // 
      this.bmiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBmi, "Bmi", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N1"));
      this.bmiTextBox.Location = new System.Drawing.Point(152, 163);
      this.bmiTextBox.Name = "bmiTextBox";
      this.bmiTextBox.Size = new System.Drawing.Size(236, 30);
      this.bmiTextBox.TabIndex = 2;
      // 
      // heightCmTextBox
      // 
      this.heightCmTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBmi, "HeightCm", true));
      this.heightCmTextBox.Location = new System.Drawing.Point(152, 66);
      this.heightCmTextBox.Name = "heightCmTextBox";
      this.heightCmTextBox.Size = new System.Drawing.Size(236, 30);
      this.heightCmTextBox.TabIndex = 4;
      // 
      // weightKgTextBox
      // 
      this.weightKgTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBmi, "WeightKg", true));
      this.weightKgTextBox.Location = new System.Drawing.Point(152, 102);
      this.weightKgTextBox.Name = "weightKgTextBox";
      this.weightKgTextBox.Size = new System.Drawing.Size(236, 30);
      this.weightKgTextBox.TabIndex = 6;
      // 
      // trackBar1
      // 
      this.trackBar1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsBmi, "HeightCm", true));
      this.trackBar1.Location = new System.Drawing.Point(35, 251);
      this.trackBar1.Maximum = 250;
      this.trackBar1.Name = "trackBar1";
      this.trackBar1.Size = new System.Drawing.Size(428, 45);
      this.trackBar1.TabIndex = 7;
      // 
      // FrmMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(487, 308);
      this.Controls.Add(this.trackBar1);
      this.Controls.Add(bmiLabel);
      this.Controls.Add(this.bmiTextBox);
      this.Controls.Add(heightCmLabel);
      this.Controls.Add(this.heightCmTextBox);
      this.Controls.Add(weightKgLabel);
      this.Controls.Add(this.weightKgTextBox);
      this.Controls.Add(this.navBmi);
      this.DataBindings.Add(new System.Windows.Forms.Binding("Location", global::BmiRechnerV2.Properties.Settings.Default, "Frm_Location", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.ForeColor = global::BmiRechnerV2.Properties.Settings.Default.FrmMain_Color;
      this.Location = global::BmiRechnerV2.Properties.Settings.Default.Frm_Location;
      this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
      this.Name = "FrmMain";
      this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
      this.Text = "Form1";
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
      ((System.ComponentModel.ISupportInitialize)(this.navBmi)).EndInit();
      this.navBmi.ResumeLayout(false);
      this.navBmi.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.bsBmi)).EndInit();
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
    private System.Windows.Forms.TextBox bmiTextBox;
    private System.Windows.Forms.TextBox heightCmTextBox;
    private System.Windows.Forms.TextBox weightKgTextBox;
    private System.Windows.Forms.TrackBar trackBar1;
  }
}

