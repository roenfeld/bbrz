
namespace WinPictureViewer
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
      this.lblFileName = new System.Windows.Forms.Label();
      this.btnSelectImage = new System.Windows.Forms.Button();
      this.ofdImage = new System.Windows.Forms.OpenFileDialog();
      this.webBrowser1 = new System.Windows.Forms.WebBrowser();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.beendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.einstellungenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.colorDialog1 = new System.Windows.Forms.ColorDialog();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.oeffnenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.farbeÄndernToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.fontAendernToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.copyrightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.menuStrip1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.SuspendLayout();
      // 
      // lblFileName
      // 
      this.lblFileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.lblFileName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.lblFileName.Location = new System.Drawing.Point(12, 33);
      this.lblFileName.Name = "lblFileName";
      this.lblFileName.Size = new System.Drawing.Size(817, 34);
      this.lblFileName.TabIndex = 1;
      this.lblFileName.Text = "?";
      this.lblFileName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // btnSelectImage
      // 
      this.btnSelectImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnSelectImage.Location = new System.Drawing.Point(835, 33);
      this.btnSelectImage.Name = "btnSelectImage";
      this.btnSelectImage.Size = new System.Drawing.Size(75, 34);
      this.btnSelectImage.TabIndex = 2;
      this.btnSelectImage.Text = "...";
      this.btnSelectImage.UseVisualStyleBackColor = true;
      this.btnSelectImage.Click += new System.EventHandler(this.btnSelectImage_Click);
      // 
      // ofdImage
      // 
      this.ofdImage.FileName = "openFileDialog1";
      // 
      // webBrowser1
      // 
      this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.webBrowser1.Location = new System.Drawing.Point(12, 147);
      this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
      this.webBrowser1.Name = "webBrowser1";
      this.webBrowser1.Size = new System.Drawing.Size(897, 381);
      this.webBrowser1.TabIndex = 3;
      this.webBrowser1.Url = new System.Uri("https://www.google.at", System.UriKind.Absolute);
      this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem,
            this.einstellungenToolStripMenuItem,
            this.infoToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(922, 29);
      this.menuStrip1.TabIndex = 4;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // dateiToolStripMenuItem
      // 
      this.dateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oeffnenToolStripMenuItem,
            this.toolStripSeparator1,
            this.beendenToolStripMenuItem});
      this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
      this.dateiToolStripMenuItem.Size = new System.Drawing.Size(58, 25);
      this.dateiToolStripMenuItem.Text = "Datei";
      // 
      // toolStripSeparator1
      // 
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
      // 
      // beendenToolStripMenuItem
      // 
      this.beendenToolStripMenuItem.Name = "beendenToolStripMenuItem";
      this.beendenToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
      this.beendenToolStripMenuItem.Text = "Beenden";
      // 
      // infoToolStripMenuItem
      // 
      this.infoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyrightToolStripMenuItem});
      this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
      this.infoToolStripMenuItem.Size = new System.Drawing.Size(49, 25);
      this.infoToolStripMenuItem.Text = "Info";
      // 
      // einstellungenToolStripMenuItem
      // 
      this.einstellungenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.farbeÄndernToolStripMenuItem,
            this.fontAendernToolStripMenuItem});
      this.einstellungenToolStripMenuItem.Name = "einstellungenToolStripMenuItem";
      this.einstellungenToolStripMenuItem.Size = new System.Drawing.Size(115, 25);
      this.einstellungenToolStripMenuItem.Text = "Einstellungen";
      // 
      // pictureBox1
      // 
      this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.pictureBox1.Image = global::WinPictureViewer.Properties.Resources.Binoculars;
      this.pictureBox1.Location = new System.Drawing.Point(12, 70);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(128, 71);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
      this.pictureBox1.TabIndex = 0;
      this.pictureBox1.TabStop = false;
      this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
      // 
      // oeffnenToolStripMenuItem
      // 
      this.oeffnenToolStripMenuItem.Image = global::WinPictureViewer.Properties.Resources.Folder;
      this.oeffnenToolStripMenuItem.Name = "oeffnenToolStripMenuItem";
      this.oeffnenToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
      this.oeffnenToolStripMenuItem.Text = "Öffnen...";
      this.oeffnenToolStripMenuItem.Click += new System.EventHandler(this.oeffnenToolStripMenuItem_Click);
      // 
      // farbeÄndernToolStripMenuItem
      // 
      this.farbeÄndernToolStripMenuItem.Image = global::WinPictureViewer.Properties.Resources.Palette;
      this.farbeÄndernToolStripMenuItem.Name = "farbeÄndernToolStripMenuItem";
      this.farbeÄndernToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
      this.farbeÄndernToolStripMenuItem.Text = "Farbe ändern...";
      this.farbeÄndernToolStripMenuItem.Click += new System.EventHandler(this.farbeÄndernToolStripMenuItem_Click);
      // 
      // fontAendernToolStripMenuItem
      // 
      this.fontAendernToolStripMenuItem.Image = global::WinPictureViewer.Properties.Resources.Font;
      this.fontAendernToolStripMenuItem.Name = "fontAendernToolStripMenuItem";
      this.fontAendernToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
      this.fontAendernToolStripMenuItem.Text = "Font ändern...";
      this.fontAendernToolStripMenuItem.Click += new System.EventHandler(this.fontAendernToolStripMenuItem_Click);
      // 
      // copyrightToolStripMenuItem
      // 
      this.copyrightToolStripMenuItem.Image = global::WinPictureViewer.Properties.Resources.Copyright;
      this.copyrightToolStripMenuItem.Name = "copyrightToolStripMenuItem";
      this.copyrightToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
      this.copyrightToolStripMenuItem.Text = "Copyright...";
      this.copyrightToolStripMenuItem.Click += new System.EventHandler(this.copyrightToolStripMenuItem_Click);
      // 
      // FrmMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(922, 540);
      this.Controls.Add(this.webBrowser1);
      this.Controls.Add(this.btnSelectImage);
      this.Controls.Add(this.lblFileName);
      this.Controls.Add(this.pictureBox1);
      this.Controls.Add(this.menuStrip1);
      this.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MainMenuStrip = this.menuStrip1;
      this.Margin = new System.Windows.Forms.Padding(5);
      this.Name = "FrmMain";
      this.Text = "Mein Super Bildbetrachter";
      this.Load += new System.EventHandler(this.FrmMain_Load);
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.Label lblFileName;
    private System.Windows.Forms.Button btnSelectImage;
    private System.Windows.Forms.OpenFileDialog ofdImage;
    private System.Windows.Forms.WebBrowser webBrowser1;
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem oeffnenToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    private System.Windows.Forms.ToolStripMenuItem beendenToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem copyrightToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem einstellungenToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem farbeÄndernToolStripMenuItem;
    private System.Windows.Forms.ColorDialog colorDialog1;
    private System.Windows.Forms.ToolStripMenuItem fontAendernToolStripMenuItem;
  }
}

