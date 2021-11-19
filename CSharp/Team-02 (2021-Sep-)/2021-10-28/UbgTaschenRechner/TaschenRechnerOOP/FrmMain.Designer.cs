
namespace TaschenRechnerOOP
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
      System.Windows.Forms.Label resultLabel;
      System.Windows.Forms.Label value1Label;
      System.Windows.Forms.Label value2Label;
      this.calculatorBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
      this.calculatorBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
      this.resultNumericUpDown = new System.Windows.Forms.NumericUpDown();
      this.value1NumericUpDown = new System.Windows.Forms.NumericUpDown();
      this.value2NumericUpDown = new System.Windows.Forms.NumericUpDown();
      this.calculatorBindingSource = new System.Windows.Forms.BindingSource(this.components);
      resultLabel = new System.Windows.Forms.Label();
      value1Label = new System.Windows.Forms.Label();
      value2Label = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.calculatorBindingNavigator)).BeginInit();
      this.calculatorBindingNavigator.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.resultNumericUpDown)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.value1NumericUpDown)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.value2NumericUpDown)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.calculatorBindingSource)).BeginInit();
      this.SuspendLayout();
      // 
      // calculatorBindingNavigator
      // 
      this.calculatorBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
      this.calculatorBindingNavigator.BindingSource = this.calculatorBindingSource;
      this.calculatorBindingNavigator.CountItem = this.bindingNavigatorCountItem;
      this.calculatorBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
      this.calculatorBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.calculatorBindingNavigatorSaveItem});
      this.calculatorBindingNavigator.Location = new System.Drawing.Point(0, 0);
      this.calculatorBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
      this.calculatorBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
      this.calculatorBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
      this.calculatorBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
      this.calculatorBindingNavigator.Name = "calculatorBindingNavigator";
      this.calculatorBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
      this.calculatorBindingNavigator.Size = new System.Drawing.Size(501, 29);
      this.calculatorBindingNavigator.TabIndex = 0;
      this.calculatorBindingNavigator.Text = "bindingNavigator1";
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
      // calculatorBindingNavigatorSaveItem
      // 
      this.calculatorBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.calculatorBindingNavigatorSaveItem.Enabled = false;
      this.calculatorBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("calculatorBindingNavigatorSaveItem.Image")));
      this.calculatorBindingNavigatorSaveItem.Name = "calculatorBindingNavigatorSaveItem";
      this.calculatorBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 26);
      this.calculatorBindingNavigatorSaveItem.Text = "Daten speichern";
      // 
      // resultLabel
      // 
      resultLabel.AutoSize = true;
      resultLabel.Location = new System.Drawing.Point(30, 184);
      resultLabel.Name = "resultLabel";
      resultLabel.Size = new System.Drawing.Size(62, 23);
      resultLabel.TabIndex = 3;
      resultLabel.Text = "Result:";
      // 
      // resultNumericUpDown
      // 
      this.resultNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.calculatorBindingSource, "Result", true));
      this.resultNumericUpDown.DecimalPlaces = 4;
      this.resultNumericUpDown.Location = new System.Drawing.Point(122, 184);
      this.resultNumericUpDown.Name = "resultNumericUpDown";
      this.resultNumericUpDown.Size = new System.Drawing.Size(234, 31);
      this.resultNumericUpDown.TabIndex = 4;
      this.resultNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.resultNumericUpDown.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
      // 
      // value1Label
      // 
      value1Label.AutoSize = true;
      value1Label.Location = new System.Drawing.Point(30, 61);
      value1Label.Name = "value1Label";
      value1Label.Size = new System.Drawing.Size(67, 23);
      value1Label.TabIndex = 5;
      value1Label.Text = "Value1:";
      // 
      // value1NumericUpDown
      // 
      this.value1NumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.calculatorBindingSource, "Value1", true));
      this.value1NumericUpDown.DecimalPlaces = 4;
      this.value1NumericUpDown.Location = new System.Drawing.Point(122, 61);
      this.value1NumericUpDown.Name = "value1NumericUpDown";
      this.value1NumericUpDown.Size = new System.Drawing.Size(234, 31);
      this.value1NumericUpDown.TabIndex = 6;
      this.value1NumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.value1NumericUpDown.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
      // 
      // value2Label
      // 
      value2Label.AutoSize = true;
      value2Label.Location = new System.Drawing.Point(30, 98);
      value2Label.Name = "value2Label";
      value2Label.Size = new System.Drawing.Size(67, 23);
      value2Label.TabIndex = 7;
      value2Label.Text = "Value2:";
      // 
      // value2NumericUpDown
      // 
      this.value2NumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.calculatorBindingSource, "Value2", true));
      this.value2NumericUpDown.DecimalPlaces = 4;
      this.value2NumericUpDown.Location = new System.Drawing.Point(122, 98);
      this.value2NumericUpDown.Name = "value2NumericUpDown";
      this.value2NumericUpDown.Size = new System.Drawing.Size(234, 31);
      this.value2NumericUpDown.TabIndex = 8;
      this.value2NumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.value2NumericUpDown.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
      // 
      // calculatorBindingSource
      // 
      this.calculatorBindingSource.DataSource = typeof(TaschenRechnerOOP.Calculator);
      // 
      // FrmMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(501, 317);
      this.Controls.Add(resultLabel);
      this.Controls.Add(this.resultNumericUpDown);
      this.Controls.Add(value1Label);
      this.Controls.Add(this.value1NumericUpDown);
      this.Controls.Add(value2Label);
      this.Controls.Add(this.value2NumericUpDown);
      this.Controls.Add(this.calculatorBindingNavigator);
      this.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Margin = new System.Windows.Forms.Padding(5);
      this.Name = "FrmMain";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.FrmMain_Load);
      ((System.ComponentModel.ISupportInitialize)(this.calculatorBindingNavigator)).EndInit();
      this.calculatorBindingNavigator.ResumeLayout(false);
      this.calculatorBindingNavigator.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.resultNumericUpDown)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.value1NumericUpDown)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.value2NumericUpDown)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.calculatorBindingSource)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.BindingSource calculatorBindingSource;
    private System.Windows.Forms.BindingNavigator calculatorBindingNavigator;
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
    private System.Windows.Forms.ToolStripButton calculatorBindingNavigatorSaveItem;
    private System.Windows.Forms.NumericUpDown resultNumericUpDown;
    private System.Windows.Forms.NumericUpDown value1NumericUpDown;
    private System.Windows.Forms.NumericUpDown value2NumericUpDown;
  }
}

