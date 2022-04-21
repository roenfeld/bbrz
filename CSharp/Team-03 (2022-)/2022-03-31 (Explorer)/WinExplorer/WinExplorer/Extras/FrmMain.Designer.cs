namespace WinExplorer
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
      this.toolStrip1 = new System.Windows.Forms.ToolStrip();
      this.tbFile = new System.Windows.Forms.ToolStripDropDownButton();
      this.tbFileExit = new System.Windows.Forms.ToolStripMenuItem();
      this.statusStrip1 = new System.Windows.Forms.StatusStrip();
      this.trvDirs = new System.Windows.Forms.TreeView();
      this.splitter1 = new System.Windows.Forms.Splitter();
      this.panel1 = new System.Windows.Forms.Panel();
      this.lvFiles = new System.Windows.Forms.ListView();
      this.toolStrip1.SuspendLayout();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // toolStrip1
      // 
      this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbFile});
      this.toolStrip1.Location = new System.Drawing.Point(0, 0);
      this.toolStrip1.Name = "toolStrip1";
      this.toolStrip1.Size = new System.Drawing.Size(1014, 25);
      this.toolStrip1.TabIndex = 0;
      this.toolStrip1.Text = "toolStrip1";
      // 
      // tbFile
      // 
      this.tbFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
      this.tbFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbFileExit});
      this.tbFile.Image = ((System.Drawing.Image)(resources.GetObject("tbFile.Image")));
      this.tbFile.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.tbFile.Name = "tbFile";
      this.tbFile.Size = new System.Drawing.Size(51, 22);
      this.tbFile.Text = "Datei";
      // 
      // tbFileExit
      // 
      this.tbFileExit.Name = "tbFileExit";
      this.tbFileExit.Size = new System.Drawing.Size(180, 22);
      this.tbFileExit.Text = "Beenden";
      // 
      // statusStrip1
      // 
      this.statusStrip1.Location = new System.Drawing.Point(0, 532);
      this.statusStrip1.Name = "statusStrip1";
      this.statusStrip1.Size = new System.Drawing.Size(1014, 22);
      this.statusStrip1.TabIndex = 1;
      this.statusStrip1.Text = "statusStrip1";
      // 
      // trvDirs
      // 
      this.trvDirs.Dock = System.Windows.Forms.DockStyle.Left;
      this.trvDirs.Location = new System.Drawing.Point(0, 25);
      this.trvDirs.Name = "trvDirs";
      this.trvDirs.Size = new System.Drawing.Size(330, 507);
      this.trvDirs.TabIndex = 2;
      // 
      // splitter1
      // 
      this.splitter1.Location = new System.Drawing.Point(330, 25);
      this.splitter1.Name = "splitter1";
      this.splitter1.Size = new System.Drawing.Size(4, 507);
      this.splitter1.TabIndex = 3;
      this.splitter1.TabStop = false;
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      this.panel1.Controls.Add(this.lvFiles);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel1.Location = new System.Drawing.Point(334, 25);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(680, 507);
      this.panel1.TabIndex = 4;
      // 
      // lvFiles
      // 
      this.lvFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.lvFiles.HideSelection = false;
      this.lvFiles.Location = new System.Drawing.Point(6, 17);
      this.lvFiles.Name = "lvFiles";
      this.lvFiles.Size = new System.Drawing.Size(662, 379);
      this.lvFiles.TabIndex = 0;
      this.lvFiles.UseCompatibleStateImageBehavior = false;
      // 
      // FrmMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1014, 554);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.splitter1);
      this.Controls.Add(this.trvDirs);
      this.Controls.Add(this.statusStrip1);
      this.Controls.Add(this.toolStrip1);
      this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.Name = "FrmMain";
      this.Text = "Form1";
      this.toolStrip1.ResumeLayout(false);
      this.toolStrip1.PerformLayout();
      this.panel1.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ToolStrip toolStrip1;
    private System.Windows.Forms.ToolStripDropDownButton tbFile;
    private System.Windows.Forms.ToolStripMenuItem tbFileExit;
    private System.Windows.Forms.StatusStrip statusStrip1;
    private System.Windows.Forms.TreeView trvDirs;
    private System.Windows.Forms.Splitter splitter1;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.ListView lvFiles;
  }
}

