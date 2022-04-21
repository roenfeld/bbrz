namespace BmiRechnerV0
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
      System.Windows.Forms.Label bmiLabel;
      System.Windows.Forms.Label heightCmLabel;
      System.Windows.Forms.Label weightKgLabel;
      this.bmiCalcBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.bmiCalcBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
      this.bmiCalcBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
      this.bmiTextBox = new System.Windows.Forms.TextBox();
      this.heightCmTextBox = new System.Windows.Forms.TextBox();
      this.weightKgTextBox = new System.Windows.Forms.TextBox();
      bmiLabel = new System.Windows.Forms.Label();
      heightCmLabel = new System.Windows.Forms.Label();
      weightKgLabel = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.bmiCalcBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.bmiCalcBindingNavigator)).BeginInit();
      this.bmiCalcBindingNavigator.SuspendLayout();
      this.SuspendLayout();
      // 
      // bmiCalcBindingSource
      // 
      this.bmiCalcBindingSource.DataSource = typeof(BmiRechnerV0.BmiCalc);
      // 
      // bmiCalcBindingNavigator
      // 
      this.bmiCalcBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
      this.bmiCalcBindingNavigator.BindingSource = this.bmiCalcBindingSource;
      this.bmiCalcBindingNavigator.CountItem = this.bindingNavigatorCountItem;
      this.bmiCalcBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
      this.bmiCalcBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
      this.bmiCalcBindingNavigator.Location = new System.Drawing.Point(0, 0);
      this.bmiCalcBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
      this.bmiCalcBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
      this.bmiCalcBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
      this.bmiCalcBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
      this.bmiCalcBindingNavigator.Name = "bmiCalcBindingNavigator";
      this.bmiCalcBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
      this.bmiCalcBindingNavigator.Size = new System.Drawing.Size(598, 25);
      this.bmiCalcBindingNavigator.TabIndex = 0;
      this.bmiCalcBindingNavigator.Text = "bindingNavigator1";
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
      // bindingNavigatorCountItem
      // 
      this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
      this.bindingNavigatorCountItem.Size = new System.Drawing.Size(48, 22);
      this.bindingNavigatorCountItem.Text = "von {0}";
      this.bindingNavigatorCountItem.ToolTipText = "Die Gesamtanzahl der Elemente.";
      // 
      // bindingNavigatorSeparator1
      // 
      this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
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
      this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
      this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
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
      // bindingNavigatorDeleteItem
      // 
      this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
      this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
      this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
      this.bindingNavigatorDeleteItem.Text = "Löschen";
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
      // bmiLabel
      // 
      bmiLabel.AutoSize = true;
      bmiLabel.Location = new System.Drawing.Point(45, 195);
      bmiLabel.Name = "bmiLabel";
      bmiLabel.Size = new System.Drawing.Size(55, 25);
      bmiLabel.TabIndex = 1;
      bmiLabel.Text = "Bmi:";
      // 
      // bmiTextBox
      // 
      this.bmiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bmiCalcBindingSource, "Bmi", true));
      this.bmiTextBox.Location = new System.Drawing.Point(169, 192);
      this.bmiTextBox.Name = "bmiTextBox";
      this.bmiTextBox.Size = new System.Drawing.Size(252, 33);
      this.bmiTextBox.TabIndex = 2;
      // 
      // heightCmLabel
      // 
      heightCmLabel.AutoSize = true;
      heightCmLabel.Location = new System.Drawing.Point(45, 83);
      heightCmLabel.Name = "heightCmLabel";
      heightCmLabel.Size = new System.Drawing.Size(118, 25);
      heightCmLabel.TabIndex = 3;
      heightCmLabel.Text = "Height Cm:";
      // 
      // heightCmTextBox
      // 
      this.heightCmTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bmiCalcBindingSource, "HeightCm", true));
      this.heightCmTextBox.Location = new System.Drawing.Point(169, 80);
      this.heightCmTextBox.Name = "heightCmTextBox";
      this.heightCmTextBox.Size = new System.Drawing.Size(252, 33);
      this.heightCmTextBox.TabIndex = 4;
      // 
      // weightKgLabel
      // 
      weightKgLabel.AutoSize = true;
      weightKgLabel.Location = new System.Drawing.Point(45, 122);
      weightKgLabel.Name = "weightKgLabel";
      weightKgLabel.Size = new System.Drawing.Size(116, 25);
      weightKgLabel.TabIndex = 5;
      weightKgLabel.Text = "Weight Kg:";
      // 
      // weightKgTextBox
      // 
      this.weightKgTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bmiCalcBindingSource, "WeightKg", true));
      this.weightKgTextBox.Location = new System.Drawing.Point(169, 119);
      this.weightKgTextBox.Name = "weightKgTextBox";
      this.weightKgTextBox.Size = new System.Drawing.Size(252, 33);
      this.weightKgTextBox.TabIndex = 6;
      // 
      // FrmMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(598, 374);
      this.Controls.Add(bmiLabel);
      this.Controls.Add(this.bmiTextBox);
      this.Controls.Add(heightCmLabel);
      this.Controls.Add(this.heightCmTextBox);
      this.Controls.Add(weightKgLabel);
      this.Controls.Add(this.weightKgTextBox);
      this.Controls.Add(this.bmiCalcBindingNavigator);
      this.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
      this.Name = "FrmMain";
      this.Text = "Form1";
      ((System.ComponentModel.ISupportInitialize)(this.bmiCalcBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.bmiCalcBindingNavigator)).EndInit();
      this.bmiCalcBindingNavigator.ResumeLayout(false);
      this.bmiCalcBindingNavigator.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.BindingSource bmiCalcBindingSource;
    private System.Windows.Forms.BindingNavigator bmiCalcBindingNavigator;
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
  }
}

