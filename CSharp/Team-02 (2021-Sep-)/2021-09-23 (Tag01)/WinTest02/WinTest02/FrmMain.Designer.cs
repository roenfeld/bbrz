
namespace WinTest02
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
      this.btnExit = new System.Windows.Forms.Button();
      this.btnDeleteText = new System.Windows.Forms.Button();
      this.txtName = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // btnExit
      // 
      this.btnExit.Location = new System.Drawing.Point(257, 225);
      this.btnExit.Name = "btnExit";
      this.btnExit.Size = new System.Drawing.Size(258, 48);
      this.btnExit.TabIndex = 0;
      this.btnExit.Text = "Ende";
      this.btnExit.UseVisualStyleBackColor = true;
      this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
      // 
      // btnDeleteText
      // 
      this.btnDeleteText.Location = new System.Drawing.Point(257, 140);
      this.btnDeleteText.Name = "btnDeleteText";
      this.btnDeleteText.Size = new System.Drawing.Size(258, 48);
      this.btnDeleteText.TabIndex = 1;
      this.btnDeleteText.Text = "Löschen";
      this.btnDeleteText.UseVisualStyleBackColor = true;
      this.btnDeleteText.Click += new System.EventHandler(this.btnDeleteText_Click);
      // 
      // txtName
      // 
      this.txtName.Location = new System.Drawing.Point(32, 29);
      this.txtName.Name = "txtName";
      this.txtName.Size = new System.Drawing.Size(483, 31);
      this.txtName.TabIndex = 2;
      this.txtName.Text = "Walter";
      // 
      // FrmMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(542, 306);
      this.Controls.Add(this.txtName);
      this.Controls.Add(this.btnDeleteText);
      this.Controls.Add(this.btnExit);
      this.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
      this.Name = "FrmMain";
      this.Text = "C# BBRZ, Test-02";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnExit;
    private System.Windows.Forms.Button btnDeleteText;
    private System.Windows.Forms.TextBox txtName;
  }
}

