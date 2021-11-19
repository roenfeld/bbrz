
namespace FensterTechnik
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
      this.btnShowLogin = new System.Windows.Forms.Button();
      this.btnShowInfo = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // btnShowLogin
      // 
      this.btnShowLogin.Location = new System.Drawing.Point(29, 29);
      this.btnShowLogin.Name = "btnShowLogin";
      this.btnShowLogin.Size = new System.Drawing.Size(270, 57);
      this.btnShowLogin.TabIndex = 0;
      this.btnShowLogin.Text = "Login...";
      this.btnShowLogin.UseVisualStyleBackColor = true;
      this.btnShowLogin.Click += new System.EventHandler(this.btnShowLogin_Click);
      // 
      // btnShowInfo
      // 
      this.btnShowInfo.Location = new System.Drawing.Point(29, 132);
      this.btnShowInfo.Name = "btnShowInfo";
      this.btnShowInfo.Size = new System.Drawing.Size(270, 57);
      this.btnShowInfo.TabIndex = 1;
      this.btnShowInfo.Text = "Info...";
      this.btnShowInfo.UseVisualStyleBackColor = true;
      this.btnShowInfo.Click += new System.EventHandler(this.btnShowInfo_Click);
      // 
      // FrmMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 26F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(581, 329);
      this.Controls.Add(this.btnShowInfo);
      this.Controls.Add(this.btnShowLogin);
      this.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
      this.Name = "FrmMain";
      this.Text = "Form1";
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button btnShowLogin;
    private System.Windows.Forms.Button btnShowInfo;
  }
}

