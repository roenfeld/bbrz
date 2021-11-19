
namespace WinFileIO
{
  partial class FrmWinAPI
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
      this.btnChangeParent = new System.Windows.Forms.Button();
      this.btnJuhuu = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // btnChangeParent
      // 
      this.btnChangeParent.Location = new System.Drawing.Point(34, 21);
      this.btnChangeParent.Name = "btnChangeParent";
      this.btnChangeParent.Size = new System.Drawing.Size(280, 64);
      this.btnChangeParent.TabIndex = 0;
      this.btnChangeParent.Text = "Change parent";
      this.btnChangeParent.UseVisualStyleBackColor = true;
      this.btnChangeParent.Click += new System.EventHandler(this.btnChangeParent_Click);
      // 
      // btnJuhuu
      // 
      this.btnJuhuu.Location = new System.Drawing.Point(34, 148);
      this.btnJuhuu.Name = "btnJuhuu";
      this.btnJuhuu.Size = new System.Drawing.Size(280, 64);
      this.btnJuhuu.TabIndex = 1;
      this.btnJuhuu.Text = "Juhuu!";
      this.btnJuhuu.UseVisualStyleBackColor = true;
      this.btnJuhuu.Click += new System.EventHandler(this.button2_Click);
      // 
      // FrmMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(489, 357);
      this.Controls.Add(this.btnJuhuu);
      this.Controls.Add(this.btnChangeParent);
      this.Name = "FrmMain";
      this.Text = "Form1";
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button btnChangeParent;
    private System.Windows.Forms.Button btnJuhuu;
  }
}

