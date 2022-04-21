namespace WinRechner
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
      this.numValue1 = new System.Windows.Forms.NumericUpDown();
      this.txtValue2 = new System.Windows.Forms.TextBox();
      this.lblValue1 = new System.Windows.Forms.Label();
      this.lblValue2 = new System.Windows.Forms.Label();
      this.btnAdd = new System.Windows.Forms.Button();
      this.btnSub = new System.Windows.Forms.Button();
      this.txtResult = new System.Windows.Forms.TextBox();
      this.lblResult = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.numValue1)).BeginInit();
      this.SuspendLayout();
      // 
      // numValue1
      // 
      this.numValue1.Location = new System.Drawing.Point(16, 49);
      this.numValue1.Name = "numValue1";
      this.numValue1.Size = new System.Drawing.Size(288, 31);
      this.numValue1.TabIndex = 0;
      this.numValue1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // txtValue2
      // 
      this.txtValue2.Location = new System.Drawing.Point(16, 132);
      this.txtValue2.Name = "txtValue2";
      this.txtValue2.Size = new System.Drawing.Size(288, 31);
      this.txtValue2.TabIndex = 1;
      this.txtValue2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // lblValue1
      // 
      this.lblValue1.AutoSize = true;
      this.lblValue1.Location = new System.Drawing.Point(12, 22);
      this.lblValue1.Name = "lblValue1";
      this.lblValue1.Size = new System.Drawing.Size(56, 23);
      this.lblValue1.TabIndex = 3;
      this.lblValue1.Text = "Zahl 1";
      // 
      // lblValue2
      // 
      this.lblValue2.AutoSize = true;
      this.lblValue2.Location = new System.Drawing.Point(12, 106);
      this.lblValue2.Name = "lblValue2";
      this.lblValue2.Size = new System.Drawing.Size(56, 23);
      this.lblValue2.TabIndex = 4;
      this.lblValue2.Text = "Zahl 2";
      // 
      // btnAdd
      // 
      this.btnAdd.Location = new System.Drawing.Point(445, 49);
      this.btnAdd.Name = "btnAdd";
      this.btnAdd.Size = new System.Drawing.Size(75, 31);
      this.btnAdd.TabIndex = 2;
      this.btnAdd.Text = "Add";
      this.btnAdd.UseVisualStyleBackColor = true;
      this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
      // 
      // btnSub
      // 
      this.btnSub.Location = new System.Drawing.Point(445, 121);
      this.btnSub.Name = "btnSub";
      this.btnSub.Size = new System.Drawing.Size(75, 29);
      this.btnSub.TabIndex = 5;
      this.btnSub.Text = "Sub";
      this.btnSub.UseVisualStyleBackColor = true;
      this.btnSub.Click += new System.EventHandler(this.btnSub_Click);
      // 
      // txtResult
      // 
      this.txtResult.Location = new System.Drawing.Point(16, 213);
      this.txtResult.Name = "txtResult";
      this.txtResult.Size = new System.Drawing.Size(288, 31);
      this.txtResult.TabIndex = 6;
      // 
      // lblResult
      // 
      this.lblResult.AutoSize = true;
      this.lblResult.Location = new System.Drawing.Point(12, 187);
      this.lblResult.Name = "lblResult";
      this.lblResult.Size = new System.Drawing.Size(76, 23);
      this.lblResult.TabIndex = 7;
      this.lblResult.Text = "Ergebnis";
      // 
      // FrmMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(588, 361);
      this.Controls.Add(this.lblResult);
      this.Controls.Add(this.txtResult);
      this.Controls.Add(this.btnSub);
      this.Controls.Add(this.lblValue2);
      this.Controls.Add(this.lblValue1);
      this.Controls.Add(this.btnAdd);
      this.Controls.Add(this.txtValue2);
      this.Controls.Add(this.numValue1);
      this.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Margin = new System.Windows.Forms.Padding(5);
      this.Name = "FrmMain";
      this.Text = "Taschenrechner";
      ((System.ComponentModel.ISupportInitialize)(this.numValue1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.NumericUpDown numValue1;
    private System.Windows.Forms.TextBox txtValue2;
    private System.Windows.Forms.Button btnAdd;
    private System.Windows.Forms.Label lblValue1;
    private System.Windows.Forms.Label lblValue2;
    private System.Windows.Forms.Button btnSub;
    private System.Windows.Forms.TextBox txtResult;
    private System.Windows.Forms.Label lblResult;
  }
}

