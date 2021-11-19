
namespace WinTest
{
  partial class FrmTest
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
      this.btnSelectFolder = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.lbFiles = new System.Windows.Forms.ListBox();
      this.picMain = new System.Windows.Forms.PictureBox();
      this.dlgFolder = new System.Windows.Forms.FolderBrowserDialog();
      this.txtFolder = new System.Windows.Forms.TextBox();
      ((System.ComponentModel.ISupportInitialize)(this.picMain)).BeginInit();
      this.SuspendLayout();
      // 
      // btnSelectFolder
      // 
      this.btnSelectFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnSelectFolder.Location = new System.Drawing.Point(773, 44);
      this.btnSelectFolder.Name = "btnSelectFolder";
      this.btnSelectFolder.Size = new System.Drawing.Size(58, 29);
      this.btnSelectFolder.TabIndex = 0;
      this.btnSelectFolder.Text = "...";
      this.btnSelectFolder.UseVisualStyleBackColor = true;
      this.btnSelectFolder.Click += new System.EventHandler(this.btnSelectFolder_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(16, 17);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(109, 24);
      this.label1.TabIndex = 1;
      this.label1.Text = "Verzeichnis";
      // 
      // lbFiles
      // 
      this.lbFiles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
      this.lbFiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.lbFiles.ForeColor = System.Drawing.Color.Blue;
      this.lbFiles.FormattingEnabled = true;
      this.lbFiles.HorizontalScrollbar = true;
      this.lbFiles.ItemHeight = 24;
      this.lbFiles.Location = new System.Drawing.Point(20, 92);
      this.lbFiles.Name = "lbFiles";
      this.lbFiles.Size = new System.Drawing.Size(454, 412);
      this.lbFiles.TabIndex = 3;
      this.lbFiles.SelectedIndexChanged += new System.EventHandler(this.lbFiles_SelectedIndexChanged);
      // 
      // picMain
      // 
      this.picMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.picMain.Location = new System.Drawing.Point(480, 92);
      this.picMain.Name = "picMain";
      this.picMain.Size = new System.Drawing.Size(351, 412);
      this.picMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
      this.picMain.TabIndex = 4;
      this.picMain.TabStop = false;
      // 
      // dlgFolder
      // 
      this.dlgFolder.RootFolder = System.Environment.SpecialFolder.MyComputer;
      // 
      // txtFolder
      // 
      this.txtFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtFolder.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WinTest.Properties.Settings.Default, "LastFolder", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.txtFolder.Location = new System.Drawing.Point(20, 44);
      this.txtFolder.Name = "txtFolder";
      this.txtFolder.Size = new System.Drawing.Size(747, 29);
      this.txtFolder.TabIndex = 2;
      this.txtFolder.Text = global::WinTest.Properties.Settings.Default.LastFolder;
      // 
      // FrmTest
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(843, 512);
      this.Controls.Add(this.lbFiles);
      this.Controls.Add(this.picMain);
      this.Controls.Add(this.txtFolder);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.btnSelectFolder);
      this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Margin = new System.Windows.Forms.Padding(6);
      this.Name = "FrmTest";
      this.Text = "FileViewer V1.0";
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmTest_FormClosed);
      ((System.ComponentModel.ISupportInitialize)(this.picMain)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnSelectFolder;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtFolder;
    private System.Windows.Forms.ListBox lbFiles;
    private System.Windows.Forms.PictureBox picMain;
    private System.Windows.Forms.FolderBrowserDialog dlgFolder;
  }
}

