
namespace WinFileViewerDataBinding
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
      this.txtSelectedFolder = new System.Windows.Forms.TextBox();
      this.btnSelectFolder = new System.Windows.Forms.Button();
      this.lbFiles = new System.Windows.Forms.ListBox();
      this.webMain = new System.Windows.Forms.WebBrowser();
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      this.SuspendLayout();
      // 
      // txtSelectedFolder
      // 
      this.txtSelectedFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtSelectedFolder.Location = new System.Drawing.Point(26, 38);
      this.txtSelectedFolder.Name = "txtSelectedFolder";
      this.txtSelectedFolder.Size = new System.Drawing.Size(617, 33);
      this.txtSelectedFolder.TabIndex = 0;
      this.txtSelectedFolder.Text = "F:\\Daten\\00 Schulungsunterlagen\\CodersBay\\CSharp\\Übungen\\UebgImgViewer";
      // 
      // btnSelectFolder
      // 
      this.btnSelectFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnSelectFolder.Location = new System.Drawing.Point(649, 38);
      this.btnSelectFolder.Name = "btnSelectFolder";
      this.btnSelectFolder.Size = new System.Drawing.Size(75, 33);
      this.btnSelectFolder.TabIndex = 1;
      this.btnSelectFolder.Text = "...";
      this.btnSelectFolder.UseVisualStyleBackColor = true;
      this.btnSelectFolder.Click += new System.EventHandler(this.btnSelectFolder_Click);
      // 
      // lbFiles
      // 
      this.lbFiles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
      this.lbFiles.FormattingEnabled = true;
      this.lbFiles.ItemHeight = 25;
      this.lbFiles.Location = new System.Drawing.Point(26, 104);
      this.lbFiles.Name = "lbFiles";
      this.lbFiles.Size = new System.Drawing.Size(341, 304);
      this.lbFiles.TabIndex = 2;
      this.lbFiles.SelectedIndexChanged += new System.EventHandler(this.lbFiles_SelectedIndexChanged);
      // 
      // webMain
      // 
      this.webMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.webMain.Location = new System.Drawing.Point(402, 104);
      this.webMain.MinimumSize = new System.Drawing.Size(20, 20);
      this.webMain.Name = "webMain";
      this.webMain.Size = new System.Drawing.Size(322, 307);
      this.webMain.TabIndex = 3;
      this.webMain.Url = new System.Uri("", System.UriKind.Relative);
      // 
      // dataGridView1
      // 
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Location = new System.Drawing.Point(13, 204);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.Size = new System.Drawing.Size(353, 226);
      this.dataGridView1.TabIndex = 4;
      this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
      // 
      // FrmMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(736, 449);
      this.Controls.Add(this.dataGridView1);
      this.Controls.Add(this.webMain);
      this.Controls.Add(this.lbFiles);
      this.Controls.Add(this.btnSelectFolder);
      this.Controls.Add(this.txtSelectedFolder);
      this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
      this.Name = "FrmMain";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.FrmMain_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox txtSelectedFolder;
    private System.Windows.Forms.Button btnSelectFolder;
    private System.Windows.Forms.ListBox lbFiles;
    private System.Windows.Forms.WebBrowser webMain;
    private System.Windows.Forms.DataGridView dataGridView1;
  }
}

