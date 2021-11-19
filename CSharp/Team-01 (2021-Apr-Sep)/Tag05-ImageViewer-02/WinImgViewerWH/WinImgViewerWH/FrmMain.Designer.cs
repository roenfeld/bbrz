
namespace WinImgViewerWH
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
      this.label1 = new System.Windows.Forms.Label();
      this.btnSelectFolder = new System.Windows.Forms.Button();
      this.lbFiles = new System.Windows.Forms.ListBox();
      this.picMain = new System.Windows.Forms.PictureBox();
      this.dlgFolder = new System.Windows.Forms.FolderBrowserDialog();
      this.txtFolder = new System.Windows.Forms.TextBox();
      this.listBox1 = new System.Windows.Forms.ListBox();
      this.panel1 = new System.Windows.Forms.Panel();
      ((System.ComponentModel.ISupportInitialize)(this.picMain)).BeginInit();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(21, 15);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(103, 23);
      this.label1.TabIndex = 0;
      this.label1.Text = "Verzeichnis";
      // 
      // btnSelectFolder
      // 
      this.btnSelectFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnSelectFolder.Location = new System.Drawing.Point(713, 41);
      this.btnSelectFolder.Name = "btnSelectFolder";
      this.btnSelectFolder.Size = new System.Drawing.Size(56, 30);
      this.btnSelectFolder.TabIndex = 2;
      this.btnSelectFolder.Text = "...";
      this.btnSelectFolder.UseVisualStyleBackColor = true;
      this.btnSelectFolder.Click += new System.EventHandler(this.btnSelectFolder_Click);
      // 
      // lbFiles
      // 
      this.lbFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.lbFiles.FormattingEnabled = true;
      this.lbFiles.ItemHeight = 23;
      this.lbFiles.Location = new System.Drawing.Point(25, 96);
      this.lbFiles.Name = "lbFiles";
      this.lbFiles.Size = new System.Drawing.Size(229, 418);
      this.lbFiles.TabIndex = 3;
      this.lbFiles.SelectedIndexChanged += new System.EventHandler(this.lbFiles_SelectedIndexChanged);
      // 
      // picMain
      // 
      this.picMain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.picMain.Location = new System.Drawing.Point(527, 96);
      this.picMain.Name = "picMain";
      this.picMain.Size = new System.Drawing.Size(180, 180);
      this.picMain.TabIndex = 4;
      this.picMain.TabStop = false;
      // 
      // txtFolder
      // 
      this.txtFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtFolder.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::WinImgViewerWH.Properties.Settings.Default, "LastFolder", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.txtFolder.Location = new System.Drawing.Point(25, 41);
      this.txtFolder.Name = "txtFolder";
      this.txtFolder.Size = new System.Drawing.Size(682, 30);
      this.txtFolder.TabIndex = 1;
      this.txtFolder.Text = global::WinImgViewerWH.Properties.Settings.Default.LastFolder;
      // 
      // listBox1
      // 
      this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.listBox1.FormattingEnabled = true;
      this.listBox1.ItemHeight = 23;
      this.listBox1.Location = new System.Drawing.Point(359, 418);
      this.listBox1.Name = "listBox1";
      this.listBox1.Size = new System.Drawing.Size(382, 96);
      this.listBox1.TabIndex = 5;
      // 
      // panel1
      // 
      this.panel1.Location = new System.Drawing.Point(280, 96);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(214, 196);
      this.panel1.TabIndex = 6;
      this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
      // 
      // FrmMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(781, 555);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.listBox1);
      this.Controls.Add(this.picMain);
      this.Controls.Add(this.lbFiles);
      this.Controls.Add(this.btnSelectFolder);
      this.Controls.Add(this.txtFolder);
      this.Controls.Add(this.label1);
      this.DataBindings.Add(new System.Windows.Forms.Binding("Location", global::WinImgViewerWH.Properties.Settings.Default, "FrmMainLocation", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Location = global::WinImgViewerWH.Properties.Settings.Default.FrmMainLocation;
      this.Margin = new System.Windows.Forms.Padding(5);
      this.Name = "FrmMain";
      this.Text = "Image-Viewer";
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
      this.Load += new System.EventHandler(this.FrmMain_Load);
      ((System.ComponentModel.ISupportInitialize)(this.picMain)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtFolder;
    private System.Windows.Forms.Button btnSelectFolder;
    private System.Windows.Forms.ListBox lbFiles;
    private System.Windows.Forms.PictureBox picMain;
    private System.Windows.Forms.FolderBrowserDialog dlgFolder;
    private System.Windows.Forms.ListBox listBox1;
    private System.Windows.Forms.Panel panel1;
  }
}

