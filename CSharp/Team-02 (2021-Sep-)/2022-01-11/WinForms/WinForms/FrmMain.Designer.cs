namespace WinForms
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
      this.numVal1 = new System.Windows.Forms.NumericUpDown();
      this.numVal2 = new System.Windows.Forms.NumericUpDown();
      this.numResult = new System.Windows.Forms.NumericUpDown();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.btnCalc = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.numVal1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numVal2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numResult)).BeginInit();
      this.SuspendLayout();
      // 
      // numVal1
      // 
      this.numVal1.Location = new System.Drawing.Point(33, 43);
      this.numVal1.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
      this.numVal1.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
      this.numVal1.Name = "numVal1";
      this.numVal1.Size = new System.Drawing.Size(316, 31);
      this.numVal1.TabIndex = 0;
      this.numVal1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.numVal1.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
      // 
      // numVal2
      // 
      this.numVal2.Location = new System.Drawing.Point(33, 114);
      this.numVal2.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
      this.numVal2.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
      this.numVal2.Name = "numVal2";
      this.numVal2.Size = new System.Drawing.Size(316, 31);
      this.numVal2.TabIndex = 1;
      this.numVal2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.numVal2.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
      // 
      // numResult
      // 
      this.numResult.Location = new System.Drawing.Point(33, 202);
      this.numResult.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
      this.numResult.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
      this.numResult.Name = "numResult";
      this.numResult.Size = new System.Drawing.Size(316, 31);
      this.numResult.TabIndex = 2;
      this.numResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(29, 17);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(61, 23);
      this.label1.TabIndex = 3;
      this.label1.Text = "Zahl 1:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(29, 88);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(61, 23);
      this.label2.TabIndex = 4;
      this.label2.Text = "Zahl 2:";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(29, 176);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(81, 23);
      this.label3.TabIndex = 5;
      this.label3.Text = "Ergebnis:";
      // 
      // btnCalc
      // 
      this.btnCalc.Location = new System.Drawing.Point(408, 114);
      this.btnCalc.Name = "btnCalc";
      this.btnCalc.Size = new System.Drawing.Size(108, 31);
      this.btnCalc.TabIndex = 6;
      this.btnCalc.Text = "Rechnen";
      this.btnCalc.UseVisualStyleBackColor = true;
      this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
      // 
      // FrmMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(563, 327);
      this.Controls.Add(this.btnCalc);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.numResult);
      this.Controls.Add(this.numVal2);
      this.Controls.Add(this.numVal1);
      this.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
      this.Name = "FrmMain";
      this.Text = "Form1";
      ((System.ComponentModel.ISupportInitialize)(this.numVal1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numVal2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numResult)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.NumericUpDown numVal1;
    private System.Windows.Forms.NumericUpDown numVal2;
    private System.Windows.Forms.NumericUpDown numResult;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Button btnCalc;
  }
}

