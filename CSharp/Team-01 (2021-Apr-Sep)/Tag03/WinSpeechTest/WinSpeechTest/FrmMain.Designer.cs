
namespace WinSpeechTest
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
      this.txtSpeechResult = new System.Windows.Forms.TextBox();
      this.btnTest = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // txtSpeechResult
      // 
      this.txtSpeechResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtSpeechResult.Location = new System.Drawing.Point(12, 120);
      this.txtSpeechResult.Multiline = true;
      this.txtSpeechResult.Name = "txtSpeechResult";
      this.txtSpeechResult.Size = new System.Drawing.Size(528, 365);
      this.txtSpeechResult.TabIndex = 0;
      // 
      // btnTest
      // 
      this.btnTest.Location = new System.Drawing.Point(12, 29);
      this.btnTest.Name = "btnTest";
      this.btnTest.Size = new System.Drawing.Size(283, 39);
      this.btnTest.TabIndex = 1;
      this.btnTest.Text = "button1";
      this.btnTest.UseVisualStyleBackColor = true;
      this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
      // 
      // FrmMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(552, 497);
      this.Controls.Add(this.btnTest);
      this.Controls.Add(this.txtSpeechResult);
      this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
      this.Name = "FrmMain";
      this.Text = "Speech...";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox txtSpeechResult;
    private System.Windows.Forms.Button btnTest;
  }
}

