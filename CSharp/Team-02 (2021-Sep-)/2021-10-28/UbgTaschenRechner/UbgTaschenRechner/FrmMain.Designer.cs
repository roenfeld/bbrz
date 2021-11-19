
namespace UbgTaschenRechner
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
      this.label1 = new System.Windows.Forms.Label();
      this.txtZahl1 = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.txtZahl2 = new System.Windows.Forms.NumericUpDown();
      this.btnAdd = new System.Windows.Forms.Button();
      this.btnSub = new System.Windows.Forms.Button();
      this.txtErgebnis = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.btnClear = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.txtZahl2)).BeginInit();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(32, 36);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(61, 23);
      this.label1.TabIndex = 0;
      this.label1.Text = "Zahl 1:";
      // 
      // txtZahl1
      // 
      this.txtZahl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtZahl1.Location = new System.Drawing.Point(169, 33);
      this.txtZahl1.Name = "txtZahl1";
      this.txtZahl1.Size = new System.Drawing.Size(417, 31);
      this.txtZahl1.TabIndex = 1;
      this.txtZahl1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(32, 118);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(61, 23);
      this.label2.TabIndex = 2;
      this.label2.Text = "Zahl 2:";
      // 
      // txtZahl2
      // 
      this.txtZahl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtZahl2.DecimalPlaces = 2;
      this.txtZahl2.Location = new System.Drawing.Point(169, 116);
      this.txtZahl2.Name = "txtZahl2";
      this.txtZahl2.Size = new System.Drawing.Size(417, 31);
      this.txtZahl2.TabIndex = 3;
      this.txtZahl2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.txtZahl2.ThousandsSeparator = true;
      this.txtZahl2.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
      // 
      // btnAdd
      // 
      this.btnAdd.Location = new System.Drawing.Point(169, 184);
      this.btnAdd.Name = "btnAdd";
      this.btnAdd.Size = new System.Drawing.Size(75, 32);
      this.btnAdd.TabIndex = 4;
      this.btnAdd.Text = "+";
      this.btnAdd.UseVisualStyleBackColor = true;
      this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
      // 
      // btnSub
      // 
      this.btnSub.Location = new System.Drawing.Point(265, 184);
      this.btnSub.Name = "btnSub";
      this.btnSub.Size = new System.Drawing.Size(75, 32);
      this.btnSub.TabIndex = 5;
      this.btnSub.Text = "-";
      this.btnSub.UseVisualStyleBackColor = true;
      this.btnSub.Click += new System.EventHandler(this.btnSub_Click);
      // 
      // txtErgebnis
      // 
      this.txtErgebnis.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtErgebnis.Location = new System.Drawing.Point(169, 265);
      this.txtErgebnis.Name = "txtErgebnis";
      this.txtErgebnis.Size = new System.Drawing.Size(417, 31);
      this.txtErgebnis.TabIndex = 6;
      this.txtErgebnis.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(32, 268);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(81, 23);
      this.label3.TabIndex = 7;
      this.label3.Text = "Ergebnis:";
      // 
      // btnClear
      // 
      this.btnClear.Location = new System.Drawing.Point(36, 184);
      this.btnClear.Name = "btnClear";
      this.btnClear.Size = new System.Drawing.Size(75, 32);
      this.btnClear.TabIndex = 8;
      this.btnClear.Text = "Clear";
      this.btnClear.UseVisualStyleBackColor = true;
      this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
      // 
      // FrmMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(653, 350);
      this.Controls.Add(this.btnClear);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.txtErgebnis);
      this.Controls.Add(this.btnSub);
      this.Controls.Add(this.btnAdd);
      this.Controls.Add(this.txtZahl2);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.txtZahl1);
      this.Controls.Add(this.label1);
      this.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Margin = new System.Windows.Forms.Padding(5);
      this.Name = "FrmMain";
      this.Text = "Form1";
      ((System.ComponentModel.ISupportInitialize)(this.txtZahl2)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtZahl1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.NumericUpDown txtZahl2;
    private System.Windows.Forms.Button btnAdd;
    private System.Windows.Forms.Button btnSub;
    private System.Windows.Forms.TextBox txtErgebnis;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Button btnClear;
  }
}

