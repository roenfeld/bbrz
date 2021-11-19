
namespace WinKreisRechner
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
      this.lblUmfang = new System.Windows.Forms.Label();
      this.txtUmfang = new System.Windows.Forms.TextBox();
      this.btnRechnen = new System.Windows.Forms.Button();
      this.lblRadius = new System.Windows.Forms.Label();
      this.txtRadius = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // lblUmfang
      // 
      this.lblUmfang.AutoSize = true;
      this.lblUmfang.Location = new System.Drawing.Point(23, 177);
      this.lblUmfang.Name = "lblUmfang";
      this.lblUmfang.Size = new System.Drawing.Size(86, 25);
      this.lblUmfang.TabIndex = 0;
      this.lblUmfang.Text = "Umfang";
      // 
      // txtUmfang
      // 
      this.txtUmfang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtUmfang.Location = new System.Drawing.Point(136, 174);
      this.txtUmfang.Name = "txtUmfang";
      this.txtUmfang.Size = new System.Drawing.Size(253, 31);
      this.txtUmfang.TabIndex = 1;
      this.txtUmfang.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // btnRechnen
      // 
      this.btnRechnen.Location = new System.Drawing.Point(191, 88);
      this.btnRechnen.Name = "btnRechnen";
      this.btnRechnen.Size = new System.Drawing.Size(194, 36);
      this.btnRechnen.TabIndex = 2;
      this.btnRechnen.Text = "Rechnen";
      this.btnRechnen.UseVisualStyleBackColor = true;
      this.btnRechnen.Click += new System.EventHandler(this.btnRechnen_Click);
      // 
      // lblRadius
      // 
      this.lblRadius.AutoSize = true;
      this.lblRadius.Location = new System.Drawing.Point(23, 23);
      this.lblRadius.Name = "lblRadius";
      this.lblRadius.Size = new System.Drawing.Size(79, 25);
      this.lblRadius.TabIndex = 3;
      this.lblRadius.Text = "Radius";
      // 
      // txtRadius
      // 
      this.txtRadius.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtRadius.Location = new System.Drawing.Point(136, 20);
      this.txtRadius.Name = "txtRadius";
      this.txtRadius.Size = new System.Drawing.Size(253, 31);
      this.txtRadius.TabIndex = 4;
      this.txtRadius.Text = "5";
      this.txtRadius.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // FrmMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(445, 268);
      this.Controls.Add(this.txtRadius);
      this.Controls.Add(this.lblRadius);
      this.Controls.Add(this.btnRechnen);
      this.Controls.Add(this.txtUmfang);
      this.Controls.Add(this.lblUmfang);
      this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
      this.Name = "FrmMain";
      this.Text = "Kreis-Rechner";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lblUmfang;
    private System.Windows.Forms.TextBox txtUmfang;
    private System.Windows.Forms.Button btnRechnen;
    private System.Windows.Forms.Label lblRadius;
    private System.Windows.Forms.TextBox txtRadius;
  }
}

