
namespace WinSerialisierung
{
  partial class FrmMain
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
      this.ofdPerson = new System.Windows.Forms.OpenFileDialog();
      this.dgvPerson = new System.Windows.Forms.DataGridView();
      this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.mnuFileOpen = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuFileSaveAs = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuFileExit = new System.Windows.Forms.ToolStripMenuItem();
      this.bsPerson = new System.Windows.Forms.BindingSource(this.components);
      this.sfdPerson = new System.Windows.Forms.SaveFileDialog();
      this.menuStrip1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgvPerson)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.bsPerson)).BeginInit();
      this.SuspendLayout();
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile});
      this.menuStrip1.Location = new System.Drawing.Point(4, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(514, 29);
      this.menuStrip1.TabIndex = 0;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // mnuFile
      // 
      this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileOpen,
            this.mnuFileSaveAs,
            this.toolStripSeparator1,
            this.mnuFileExit});
      this.mnuFile.Name = "mnuFile";
      this.mnuFile.Size = new System.Drawing.Size(58, 25);
      this.mnuFile.Text = "Datei";
      // 
      // ofdPerson
      // 
      this.ofdPerson.FileName = "Personen.xml";
      // 
      // dgvPerson
      // 
      dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
      this.dgvPerson.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
      this.dgvPerson.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.dgvPerson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvPerson.Location = new System.Drawing.Point(7, 32);
      this.dgvPerson.Name = "dgvPerson";
      this.dgvPerson.Size = new System.Drawing.Size(508, 441);
      this.dgvPerson.TabIndex = 2;
      // 
      // toolStripSeparator1
      // 
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new System.Drawing.Size(196, 6);
      // 
      // mnuFileOpen
      // 
      this.mnuFileOpen.Image = global::WinSerialisierung.Properties.Resources.FolderOpen;
      this.mnuFileOpen.Name = "mnuFileOpen";
      this.mnuFileOpen.Size = new System.Drawing.Size(199, 26);
      this.mnuFileOpen.Text = "Öffnen...";
      this.mnuFileOpen.Click += new System.EventHandler(this.mnuFileOpen_Click);
      // 
      // mnuFileSaveAs
      // 
      this.mnuFileSaveAs.Image = global::WinSerialisierung.Properties.Resources.saveHS;
      this.mnuFileSaveAs.Name = "mnuFileSaveAs";
      this.mnuFileSaveAs.Size = new System.Drawing.Size(199, 26);
      this.mnuFileSaveAs.Text = "Speichern unter...";
      this.mnuFileSaveAs.Click += new System.EventHandler(this.mnuFileSaveAs_Click);
      // 
      // mnuFileExit
      // 
      this.mnuFileExit.Image = global::WinSerialisierung.Properties.Resources.TurnOff;
      this.mnuFileExit.Name = "mnuFileExit";
      this.mnuFileExit.Size = new System.Drawing.Size(199, 26);
      this.mnuFileExit.Text = "Beenden";
      // 
      // FrmMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(522, 480);
      this.Controls.Add(this.dgvPerson);
      this.Controls.Add(this.menuStrip1);
      this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MainMenuStrip = this.menuStrip1;
      this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.Name = "FrmMain";
      this.Padding = new System.Windows.Forms.Padding(4, 0, 4, 4);
      this.Text = "Personen-Info";
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgvPerson)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.bsPerson)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem mnuFile;
    private System.Windows.Forms.ToolStripMenuItem mnuFileOpen;
    private System.Windows.Forms.ToolStripMenuItem mnuFileExit;
    private System.Windows.Forms.OpenFileDialog ofdPerson;
    private System.Windows.Forms.DataGridView dgvPerson;
    private System.Windows.Forms.BindingSource bsPerson;
    private System.Windows.Forms.ToolStripMenuItem mnuFileSaveAs;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    private System.Windows.Forms.SaveFileDialog sfdPerson;
  }
}