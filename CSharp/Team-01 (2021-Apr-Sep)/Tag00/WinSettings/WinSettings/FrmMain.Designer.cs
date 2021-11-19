
namespace WinSettings
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
      this.fldDlg = new System.Windows.Forms.FolderBrowserDialog();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.btnSelectFolder = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.txtFolderPath = new System.Windows.Forms.TextBox();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.SuspendLayout();
      // 
      // fldDlg
      // 
      this.fldDlg.RootFolder = System.Environment.SpecialFolder.MyComputer;
      // 
      // pictureBox1
      // 
      this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.pictureBox1.Location = new System.Drawing.Point(254, 114);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(471, 323);
      this.pictureBox1.TabIndex = 0;
      this.pictureBox1.TabStop = false;
      // 
      // btnSelectFolder
      // 
      this.btnSelectFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnSelectFolder.Location = new System.Drawing.Point(655, 41);
      this.btnSelectFolder.Name = "btnSelectFolder";
      this.btnSelectFolder.Size = new System.Drawing.Size(70, 31);
      this.btnSelectFolder.TabIndex = 2;
      this.btnSelectFolder.Text = "...";
      this.btnSelectFolder.UseVisualStyleBackColor = true;
      this.btnSelectFolder.Click += new System.EventHandler(this.btnSelectFolder_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(13, 13);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(150, 25);
      this.label1.TabIndex = 3;
      this.label1.Text = "Select folder...";
      // 
      // txtFolderPath
      // 
      this.txtFolderPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtFolderPath.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WinSettings.Properties.Settings.Default, "CurrentFolder", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.txtFolderPath.Location = new System.Drawing.Point(18, 41);
      this.txtFolderPath.Name = "txtFolderPath";
      this.txtFolderPath.Size = new System.Drawing.Size(631, 31);
      this.txtFolderPath.TabIndex = 1;
      this.txtFolderPath.Text = global::WinSettings.Properties.Settings.Default.CurrentFolder;
      // 
      // FrmMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(737, 449);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.btnSelectFolder);
      this.Controls.Add(this.txtFolderPath);
      this.Controls.Add(this.pictureBox1);
      this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
      this.Name = "FrmMain";
      this.Text = "File-Viewer";
      this.Load += new System.EventHandler(this.FrmMain_Load);
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.FolderBrowserDialog fldDlg;
    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.TextBox txtFolderPath;
    private System.Windows.Forms.Button btnSelectFolder;
    private System.Windows.Forms.Label label1;
  }
}

