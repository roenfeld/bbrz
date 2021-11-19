
namespace WinSpeech
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
      this.btnStart = new System.Windows.Forms.Button();
      this.btnStop = new System.Windows.Forms.Button();
      this.lbRecogonized = new System.Windows.Forms.ListBox();
      this.cmbInstalledSpRec = new System.Windows.Forms.ComboBox();
      this.SuspendLayout();
      // 
      // btnStart
      // 
      this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnStart.Location = new System.Drawing.Point(379, 21);
      this.btnStart.Name = "btnStart";
      this.btnStart.Size = new System.Drawing.Size(315, 42);
      this.btnStart.TabIndex = 0;
      this.btnStart.Text = "Start Speech Recognition";
      this.btnStart.UseVisualStyleBackColor = true;
      this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
      // 
      // btnStop
      // 
      this.btnStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnStop.Location = new System.Drawing.Point(379, 99);
      this.btnStop.Name = "btnStop";
      this.btnStop.Size = new System.Drawing.Size(315, 42);
      this.btnStop.TabIndex = 1;
      this.btnStop.Text = "Stop Speech Recognition";
      this.btnStop.UseVisualStyleBackColor = true;
      this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
      // 
      // lbRecogonized
      // 
      this.lbRecogonized.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.lbRecogonized.FormattingEnabled = true;
      this.lbRecogonized.ItemHeight = 24;
      this.lbRecogonized.Location = new System.Drawing.Point(25, 166);
      this.lbRecogonized.Name = "lbRecogonized";
      this.lbRecogonized.Size = new System.Drawing.Size(669, 412);
      this.lbRecogonized.TabIndex = 2;
      // 
      // cmbInstalledSpRec
      // 
      this.cmbInstalledSpRec.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.cmbInstalledSpRec.FormattingEnabled = true;
      this.cmbInstalledSpRec.Location = new System.Drawing.Point(25, 21);
      this.cmbInstalledSpRec.Name = "cmbInstalledSpRec";
      this.cmbInstalledSpRec.Size = new System.Drawing.Size(324, 32);
      this.cmbInstalledSpRec.TabIndex = 3;
      // 
      // FrmMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(721, 596);
      this.Controls.Add(this.cmbInstalledSpRec);
      this.Controls.Add(this.lbRecogonized);
      this.Controls.Add(this.btnStop);
      this.Controls.Add(this.btnStart);
      this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
      this.Name = "FrmMain";
      this.Text = "Form1";
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button btnStart;
    private System.Windows.Forms.Button btnStop;
    private System.Windows.Forms.ListBox lbRecogonized;
    private System.Windows.Forms.ComboBox cmbInstalledSpRec;
  }
}

