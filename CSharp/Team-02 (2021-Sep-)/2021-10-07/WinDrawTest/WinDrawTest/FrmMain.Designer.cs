
namespace WinDrawTest
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
      this.panMain = new System.Windows.Forms.Panel();
      this.label1 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // panMain
      // 
      this.panMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.panMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.panMain.Location = new System.Drawing.Point(45, 64);
      this.panMain.Name = "panMain";
      this.panMain.Size = new System.Drawing.Size(353, 244);
      this.panMain.TabIndex = 0;
      this.panMain.Paint += new System.Windows.Forms.PaintEventHandler(this.panMain_Paint);
      // 
      // label1
      // 
      this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.label1.Location = new System.Drawing.Point(45, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(352, 34);
      this.label1.TabIndex = 1;
      this.label1.Text = "label1";
      // 
      // FrmMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(447, 355);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.panMain);
      this.Name = "FrmMain";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.FrmMain_Load);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel panMain;
    private System.Windows.Forms.Label label1;
  }
}

