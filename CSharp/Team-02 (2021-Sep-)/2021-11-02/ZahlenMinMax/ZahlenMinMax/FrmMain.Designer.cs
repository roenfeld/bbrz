
namespace ZahlenMinMax
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
      this.numInput = new System.Windows.Forms.NumericUpDown();
      this.label1 = new System.Windows.Forms.Label();
      this.btnAddInput = new System.Windows.Forms.Button();
      this.lbValues = new System.Windows.Forms.ListBox();
      this.cmLbValues = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.cmLbValuesRemoveCurrent = new System.Windows.Forms.ToolStripMenuItem();
      this.cmLbValuesRemoveAll = new System.Windows.Forms.ToolStripMenuItem();
      this.cmLbValuesRemoveLast = new System.Windows.Forms.ToolStripMenuItem();
      this.numMin = new System.Windows.Forms.NumericUpDown();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.numMax = new System.Windows.Forms.NumericUpDown();
      ((System.ComponentModel.ISupportInitialize)(this.numInput)).BeginInit();
      this.cmLbValues.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numMin)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numMax)).BeginInit();
      this.SuspendLayout();
      // 
      // numInput
      // 
      this.numInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.numInput.Location = new System.Drawing.Point(295, 67);
      this.numInput.Name = "numInput";
      this.numInput.Size = new System.Drawing.Size(151, 31);
      this.numInput.TabIndex = 0;
      this.numInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // label1
      // 
      this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(291, 28);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(118, 23);
      this.label1.TabIndex = 1;
      this.label1.Text = "Eingabe (Zahl)";
      // 
      // btnAddInput
      // 
      this.btnAddInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnAddInput.Location = new System.Drawing.Point(452, 67);
      this.btnAddInput.Name = "btnAddInput";
      this.btnAddInput.Size = new System.Drawing.Size(42, 31);
      this.btnAddInput.TabIndex = 2;
      this.btnAddInput.Text = "++";
      this.btnAddInput.UseVisualStyleBackColor = true;
      this.btnAddInput.Click += new System.EventHandler(this.btnAddInput_Click);
      // 
      // lbValues
      // 
      this.lbValues.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.lbValues.ContextMenuStrip = this.cmLbValues;
      this.lbValues.FormattingEnabled = true;
      this.lbValues.ItemHeight = 23;
      this.lbValues.Location = new System.Drawing.Point(12, 67);
      this.lbValues.Name = "lbValues";
      this.lbValues.Size = new System.Drawing.Size(277, 395);
      this.lbValues.TabIndex = 3;
      this.lbValues.KeyUp += new System.Windows.Forms.KeyEventHandler(this.lbValues_KeyUp);
      // 
      // cmLbValues
      // 
      this.cmLbValues.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmLbValuesRemoveCurrent,
            this.cmLbValuesRemoveAll,
            this.cmLbValuesRemoveLast});
      this.cmLbValues.Name = "cmLbValues";
      this.cmLbValues.Size = new System.Drawing.Size(275, 82);
      // 
      // cmLbValuesRemoveCurrent
      // 
      this.cmLbValuesRemoveCurrent.Image = global::ZahlenMinMax.Properties.Resources.Delete;
      this.cmLbValuesRemoveCurrent.Name = "cmLbValuesRemoveCurrent";
      this.cmLbValuesRemoveCurrent.Size = new System.Drawing.Size(274, 26);
      this.cmLbValuesRemoveCurrent.Text = "Aktuelles Element entfernen";
      this.cmLbValuesRemoveCurrent.Click += new System.EventHandler(this.cmLbValuesRemoveCurrent_Click);
      // 
      // cmLbValuesRemoveAll
      // 
      this.cmLbValuesRemoveAll.Name = "cmLbValuesRemoveAll";
      this.cmLbValuesRemoveAll.Size = new System.Drawing.Size(274, 26);
      this.cmLbValuesRemoveAll.Text = "Alle Elemente entfernen";
      this.cmLbValuesRemoveAll.Click += new System.EventHandler(this.cmLbValuesRemoveAll_Click);
      // 
      // cmLbValuesRemoveLast
      // 
      this.cmLbValuesRemoveLast.Name = "cmLbValuesRemoveLast";
      this.cmLbValuesRemoveLast.Size = new System.Drawing.Size(274, 26);
      this.cmLbValuesRemoveLast.Text = "Letztes Element entfernen";
      // 
      // numMin
      // 
      this.numMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.numMin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.numMin.Location = new System.Drawing.Point(295, 192);
      this.numMin.Name = "numMin";
      this.numMin.Size = new System.Drawing.Size(151, 31);
      this.numMin.TabIndex = 5;
      this.numMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // label2
      // 
      this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(295, 166);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(84, 23);
      this.label2.TabIndex = 6;
      this.label2.Text = "Minimum";
      // 
      // label3
      // 
      this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(295, 256);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(87, 23);
      this.label3.TabIndex = 8;
      this.label3.Text = "Maximum";
      // 
      // numMax
      // 
      this.numMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.numMax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.numMax.Location = new System.Drawing.Point(295, 282);
      this.numMax.Name = "numMax";
      this.numMax.Size = new System.Drawing.Size(151, 31);
      this.numMax.TabIndex = 7;
      this.numMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // FrmMain
      // 
      this.AcceptButton = this.btnAddInput;
      this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(506, 576);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.numMax);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.numMin);
      this.Controls.Add(this.lbValues);
      this.Controls.Add(this.btnAddInput);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.numInput);
      this.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Margin = new System.Windows.Forms.Padding(5);
      this.Name = "FrmMain";
      this.Text = "Zahlen, Min/Max...";
      ((System.ComponentModel.ISupportInitialize)(this.numInput)).EndInit();
      this.cmLbValues.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.numMin)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numMax)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.NumericUpDown numInput;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button btnAddInput;
    private System.Windows.Forms.ListBox lbValues;
    private System.Windows.Forms.ContextMenuStrip cmLbValues;
    private System.Windows.Forms.ToolStripMenuItem cmLbValuesRemoveCurrent;
    private System.Windows.Forms.ToolStripMenuItem cmLbValuesRemoveAll;
    private System.Windows.Forms.ToolStripMenuItem cmLbValuesRemoveLast;
    private System.Windows.Forms.NumericUpDown numMin;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.NumericUpDown numMax;
  }
}

