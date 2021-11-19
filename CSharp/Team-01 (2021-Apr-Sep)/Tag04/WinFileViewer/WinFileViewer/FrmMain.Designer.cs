
namespace WinFileViewer
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
      this.components = new System.ComponentModel.Container();
      this.picMain = new System.Windows.Forms.PictureBox();
      this.lbFiles = new System.Windows.Forms.ListBox();
      this.label1 = new System.Windows.Forms.Label();
      this.btnSelectFolder = new System.Windows.Forms.Button();
      this.dlgFolder = new System.Windows.Forms.FolderBrowserDialog();
      this.txtFolder = new System.Windows.Forms.TextBox();
      this.bsFiles = new System.Windows.Forms.BindingSource(this.components);
      ((System.ComponentModel.ISupportInitialize)(this.picMain)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.bsFiles)).BeginInit();
      this.SuspendLayout();
      // 
      // picMain
      // 
      this.picMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.picMain.Location = new System.Drawing.Point(334, 88);
      this.picMain.Name = "picMain";
      this.picMain.Size = new System.Drawing.Size(362, 364);
      this.picMain.TabIndex = 9;
      this.picMain.TabStop = false;
      // 
      // lbFiles
      // 
      this.lbFiles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
      this.lbFiles.FormattingEnabled = true;
      this.lbFiles.ItemHeight = 24;
      this.lbFiles.Location = new System.Drawing.Point(21, 88);
      this.lbFiles.Name = "lbFiles";
      this.lbFiles.Size = new System.Drawing.Size(278, 364);
      this.lbFiles.TabIndex = 8;
      this.lbFiles.SelectedIndexChanged += new System.EventHandler(this.lbFiles_SelectedIndexChanged);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(17, 13);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(109, 24);
      this.label1.TabIndex = 6;
      this.label1.Text = "Verzeichnis";
      // 
      // btnSelectFolder
      // 
      this.btnSelectFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnSelectFolder.Location = new System.Drawing.Point(702, 40);
      this.btnSelectFolder.Name = "btnSelectFolder";
      this.btnSelectFolder.Size = new System.Drawing.Size(58, 29);
      this.btnSelectFolder.TabIndex = 5;
      this.btnSelectFolder.Text = "...";
      this.btnSelectFolder.UseVisualStyleBackColor = true;
      this.btnSelectFolder.Click += new System.EventHandler(this.btnSelectFolder_Click);
      // 
      // dlgFolder
      // 
      this.dlgFolder.RootFolder = System.Environment.SpecialFolder.MyComputer;
      // 
      // txtFolder
      // 
      this.txtFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtFolder.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WinFileViewer.Properties.Settings.Default, "LastFolder", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.txtFolder.Location = new System.Drawing.Point(21, 40);
      this.txtFolder.Name = "txtFolder";
      this.txtFolder.Size = new System.Drawing.Size(675, 29);
      this.txtFolder.TabIndex = 7;
      this.txtFolder.Text = global::WinFileViewer.Properties.Settings.Default.LastFolder;
      // 
      // FrmMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(772, 473);
      this.Controls.Add(this.picMain);
      this.Controls.Add(this.lbFiles);
      this.Controls.Add(this.txtFolder);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.btnSelectFolder);
      this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Margin = new System.Windows.Forms.Padding(6);
      this.Name = "FrmMain";
      this.Text = "FileViewer";
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
      ((System.ComponentModel.ISupportInitialize)(this.picMain)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.bsFiles)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.PictureBox picMain;
    private System.Windows.Forms.ListBox lbFiles;
    private System.Windows.Forms.TextBox txtFolder;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button btnSelectFolder;
    private System.Windows.Forms.FolderBrowserDialog dlgFolder;
    private System.Windows.Forms.BindingSource bsFiles;
  }
}

