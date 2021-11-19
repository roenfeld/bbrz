
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
      this.txtRadius = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.txtUmfang = new System.Windows.Forms.TextBox();
      this.btnRechnen = new System.Windows.Forms.Button();
      this.trbRadius = new System.Windows.Forms.TrackBar();
      ((System.ComponentModel.ISupportInitialize)(this.trbRadius)).BeginInit();
      this.SuspendLayout();
      // 
      // txtRadius
      // 
      this.txtRadius.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtRadius.Location = new System.Drawing.Point(25, 46);
      this.txtRadius.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.txtRadius.Name = "txtRadius";
      this.txtRadius.Size = new System.Drawing.Size(439, 31);
      this.txtRadius.TabIndex = 0;
      this.txtRadius.Text = "10";
      this.txtRadius.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(20, 21);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(66, 23);
      this.label1.TabIndex = 1;
      this.label1.Text = "Radius:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(20, 147);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(131, 23);
      this.label2.TabIndex = 3;
      this.label2.Text = "Umfang (2 r Pi):";
      // 
      // txtUmfang
      // 
      this.txtUmfang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtUmfang.Location = new System.Drawing.Point(25, 209);
      this.txtUmfang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.txtUmfang.Name = "txtUmfang";
      this.txtUmfang.Size = new System.Drawing.Size(439, 31);
      this.txtUmfang.TabIndex = 2;
      this.txtUmfang.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // btnRechnen
      // 
      this.btnRechnen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btnRechnen.Location = new System.Drawing.Point(334, 302);
      this.btnRechnen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.btnRechnen.Name = "btnRechnen";
      this.btnRechnen.Size = new System.Drawing.Size(130, 34);
      this.btnRechnen.TabIndex = 4;
      this.btnRechnen.Text = "Rechnen";
      this.btnRechnen.UseVisualStyleBackColor = true;
      this.btnRechnen.Click += new System.EventHandler(this.btnRechnen_Click);
      // 
      // trbRadius
      // 
      this.trbRadius.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.trbRadius.Location = new System.Drawing.Point(25, 96);
      this.trbRadius.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.trbRadius.Maximum = 50;
      this.trbRadius.Name = "trbRadius";
      this.trbRadius.Size = new System.Drawing.Size(439, 45);
      this.trbRadius.TabIndex = 5;
      this.trbRadius.Value = 5;
      this.trbRadius.ValueChanged += new System.EventHandler(this.trbRadius_ValueChanged);
      // 
      // FrmMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(495, 355);
      this.Controls.Add(this.trbRadius);
      this.Controls.Add(this.btnRechnen);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.txtUmfang);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.txtRadius);
      this.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
      this.Name = "FrmMain";
      this.Text = "Kreisrechner";
      ((System.ComponentModel.ISupportInitialize)(this.trbRadius)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox txtRadius;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtUmfang;
    private System.Windows.Forms.Button btnRechnen;
    private System.Windows.Forms.TrackBar trbRadius;
  }
}

