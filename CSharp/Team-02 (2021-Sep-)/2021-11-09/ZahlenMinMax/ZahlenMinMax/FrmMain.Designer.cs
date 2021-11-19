
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
      this.lbValues = new System.Windows.Forms.ListBox();
      this.numInput = new System.Windows.Forms.NumericUpDown();
      this.btnNewValue = new System.Windows.Forms.Button();
      this.numMin = new System.Windows.Forms.NumericUpDown();
      this.label1 = new System.Windows.Forms.Label();
      this.numMax = new System.Windows.Forms.NumericUpDown();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.numSum = new System.Windows.Forms.NumericUpDown();
      this.label4 = new System.Windows.Forms.Label();
      this.numAvg = new System.Windows.Forms.NumericUpDown();
      ((System.ComponentModel.ISupportInitialize)(this.numInput)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numMin)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numMax)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numSum)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numAvg)).BeginInit();
      this.SuspendLayout();
      // 
      // lbValues
      // 
      this.lbValues.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.lbValues.BackColor = System.Drawing.SystemColors.Info;
      this.lbValues.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
      this.lbValues.FormattingEnabled = true;
      this.lbValues.ItemHeight = 26;
      this.lbValues.Location = new System.Drawing.Point(17, 43);
      this.lbValues.Name = "lbValues";
      this.lbValues.Size = new System.Drawing.Size(291, 420);
      this.lbValues.TabIndex = 0;
      // 
      // numInput
      // 
      this.numInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.numInput.Location = new System.Drawing.Point(355, 43);
      this.numInput.Name = "numInput";
      this.numInput.Size = new System.Drawing.Size(153, 33);
      this.numInput.TabIndex = 1;
      this.numInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // btnNewValue
      // 
      this.btnNewValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnNewValue.Location = new System.Drawing.Point(514, 43);
      this.btnNewValue.Name = "btnNewValue";
      this.btnNewValue.Size = new System.Drawing.Size(53, 33);
      this.btnNewValue.TabIndex = 2;
      this.btnNewValue.Text = "++";
      this.btnNewValue.UseVisualStyleBackColor = true;
      this.btnNewValue.Click += new System.EventHandler(this.btnNewValue_Click);
      // 
      // numMin
      // 
      this.numMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.numMin.Location = new System.Drawing.Point(355, 151);
      this.numMin.Name = "numMin";
      this.numMin.Size = new System.Drawing.Size(153, 33);
      this.numMin.TabIndex = 3;
      this.numMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(350, 122);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(96, 26);
      this.label1.TabIndex = 4;
      this.label1.Text = "Minimum";
      // 
      // numMax
      // 
      this.numMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.numMax.Location = new System.Drawing.Point(355, 247);
      this.numMax.Name = "numMax";
      this.numMax.Size = new System.Drawing.Size(153, 33);
      this.numMax.TabIndex = 5;
      this.numMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(350, 218);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(99, 26);
      this.label2.TabIndex = 6;
      this.label2.Text = "Maximum";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(350, 313);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(77, 26);
      this.label3.TabIndex = 8;
      this.label3.Text = "Summe";
      // 
      // numSum
      // 
      this.numSum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.numSum.Location = new System.Drawing.Point(355, 342);
      this.numSum.Name = "numSum";
      this.numSum.Size = new System.Drawing.Size(153, 33);
      this.numSum.TabIndex = 7;
      this.numSum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(350, 401);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(120, 26);
      this.label4.TabIndex = 10;
      this.label4.Text = "Durchschnitt";
      // 
      // numAvg
      // 
      this.numAvg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.numAvg.DecimalPlaces = 1;
      this.numAvg.Location = new System.Drawing.Point(355, 430);
      this.numAvg.Name = "numAvg";
      this.numAvg.Size = new System.Drawing.Size(153, 33);
      this.numAvg.TabIndex = 9;
      this.numAvg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // FrmMain
      // 
      this.AcceptButton = this.btnNewValue;
      this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 26F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(580, 565);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.numAvg);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.numSum);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.numMax);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.numMin);
      this.Controls.Add(this.btnNewValue);
      this.Controls.Add(this.numInput);
      this.Controls.Add(this.lbValues);
      this.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Margin = new System.Windows.Forms.Padding(6);
      this.Name = "FrmMain";
      this.Text = "Zahlne, Min/Max";
      ((System.ComponentModel.ISupportInitialize)(this.numInput)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numMin)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numMax)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numSum)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numAvg)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ListBox lbValues;
    private System.Windows.Forms.NumericUpDown numInput;
    private System.Windows.Forms.Button btnNewValue;
    private System.Windows.Forms.NumericUpDown numMin;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.NumericUpDown numMax;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.NumericUpDown numSum;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.NumericUpDown numAvg;
  }
}

