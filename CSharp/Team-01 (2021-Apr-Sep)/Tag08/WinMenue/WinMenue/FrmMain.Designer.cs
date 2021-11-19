
namespace WinMenue
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
      this.mnuMain = new System.Windows.Forms.MenuStrip();
      this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuFileOpen = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuFileStartStop = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuFileSave = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuFileSep1 = new System.Windows.Forms.ToolStripSeparator();
      this.mnuFileExit = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuOptions = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuOptionsInfo = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuOptionsColor = new System.Windows.Forms.ToolStripMenuItem();
      this.weitersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.w1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.w1W1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.w1W2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.w1W2W1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.sdljkfhsdkfjToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.w2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.cmnuFrmMain = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.cmnuFrmMainP1 = new System.Windows.Forms.ToolStripMenuItem();
      this.cmnuFrmMainDiv = new System.Windows.Forms.ToolStripMenuItem();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.statusStrip1 = new System.Windows.Forms.StatusStrip();
      this.lblStatusMachinename = new System.Windows.Forms.ToolStripStatusLabel();
      this.lblStatusUsername = new System.Windows.Forms.ToolStripStatusLabel();
      this.dlgColor = new System.Windows.Forms.ColorDialog();
      this.mnuOptionsProcess = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuMain.SuspendLayout();
      this.cmnuFrmMain.SuspendLayout();
      this.statusStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // mnuMain
      // 
      this.mnuMain.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuOptions});
      this.mnuMain.Location = new System.Drawing.Point(0, 0);
      this.mnuMain.Name = "mnuMain";
      this.mnuMain.Size = new System.Drawing.Size(662, 38);
      this.mnuMain.TabIndex = 0;
      this.mnuMain.Text = "menuStrip1";
      // 
      // mnuFile
      // 
      this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileOpen,
            this.mnuFileStartStop,
            this.mnuFileSave,
            this.mnuFileSep1,
            this.mnuFileExit});
      this.mnuFile.Name = "mnuFile";
      this.mnuFile.Size = new System.Drawing.Size(74, 34);
      this.mnuFile.Text = "&Datei";
      this.mnuFile.DropDownOpening += new System.EventHandler(this.mnuFile_DropDownOpening);
      // 
      // mnuFileOpen
      // 
      this.mnuFileOpen.Name = "mnuFileOpen";
      this.mnuFileOpen.Size = new System.Drawing.Size(237, 54);
      this.mnuFileOpen.Text = "Öffnen...";
      // 
      // mnuFileStartStop
      // 
      this.mnuFileStartStop.CheckOnClick = true;
      this.mnuFileStartStop.Name = "mnuFileStartStop";
      this.mnuFileStartStop.Size = new System.Drawing.Size(237, 54);
      this.mnuFileStartStop.Text = "Start/Stop";
      // 
      // mnuFileSave
      // 
      this.mnuFileSave.Name = "mnuFileSave";
      this.mnuFileSave.Size = new System.Drawing.Size(237, 54);
      this.mnuFileSave.Text = "Speichern";
      // 
      // mnuFileSep1
      // 
      this.mnuFileSep1.Name = "mnuFileSep1";
      this.mnuFileSep1.Size = new System.Drawing.Size(234, 6);
      // 
      // mnuFileExit
      // 
      this.mnuFileExit.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.mnuFileExit.Image = global::WinMenue.Properties.Resources.Lock;
      this.mnuFileExit.Name = "mnuFileExit";
      this.mnuFileExit.Size = new System.Drawing.Size(237, 54);
      this.mnuFileExit.Text = "&Beenden";
      this.mnuFileExit.Click += new System.EventHandler(this.mnuFileExit_Click);
      // 
      // mnuOptions
      // 
      this.mnuOptions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOptionsInfo,
            this.mnuOptionsColor,
            this.weitersToolStripMenuItem,
            this.mnuOptionsProcess});
      this.mnuOptions.Name = "mnuOptions";
      this.mnuOptions.Size = new System.Drawing.Size(112, 34);
      this.mnuOptions.Text = "O&ptionen";
      // 
      // mnuOptionsInfo
      // 
      this.mnuOptionsInfo.Name = "mnuOptionsInfo";
      this.mnuOptionsInfo.Size = new System.Drawing.Size(180, 34);
      this.mnuOptionsInfo.Text = "Info...";
      // 
      // mnuOptionsColor
      // 
      this.mnuOptionsColor.Name = "mnuOptionsColor";
      this.mnuOptionsColor.Size = new System.Drawing.Size(180, 34);
      this.mnuOptionsColor.Text = "Farbe...";
      this.mnuOptionsColor.Click += new System.EventHandler(this.mnuOptionsColor_Click);
      // 
      // weitersToolStripMenuItem
      // 
      this.weitersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.w1ToolStripMenuItem,
            this.w2ToolStripMenuItem});
      this.weitersToolStripMenuItem.Name = "weitersToolStripMenuItem";
      this.weitersToolStripMenuItem.Size = new System.Drawing.Size(180, 34);
      this.weitersToolStripMenuItem.Text = "Weiters";
      // 
      // w1ToolStripMenuItem
      // 
      this.w1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.w1W1ToolStripMenuItem,
            this.w1W2ToolStripMenuItem});
      this.w1ToolStripMenuItem.Name = "w1ToolStripMenuItem";
      this.w1ToolStripMenuItem.Size = new System.Drawing.Size(180, 34);
      this.w1ToolStripMenuItem.Text = "W1";
      // 
      // w1W1ToolStripMenuItem
      // 
      this.w1W1ToolStripMenuItem.Name = "w1W1ToolStripMenuItem";
      this.w1W1ToolStripMenuItem.Size = new System.Drawing.Size(156, 34);
      this.w1W1ToolStripMenuItem.Text = "W1-W1";
      // 
      // w1W2ToolStripMenuItem
      // 
      this.w1W2ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.w1W2W1ToolStripMenuItem});
      this.w1W2ToolStripMenuItem.Name = "w1W2ToolStripMenuItem";
      this.w1W2ToolStripMenuItem.Size = new System.Drawing.Size(156, 34);
      this.w1W2ToolStripMenuItem.Text = "W1-W2";
      // 
      // w1W2W1ToolStripMenuItem
      // 
      this.w1W2W1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sdljkfhsdkfjToolStripMenuItem});
      this.w1W2W1ToolStripMenuItem.Name = "w1W2W1ToolStripMenuItem";
      this.w1W2W1ToolStripMenuItem.Size = new System.Drawing.Size(195, 34);
      this.w1W2W1ToolStripMenuItem.Text = "W1-W2-W1";
      // 
      // sdljkfhsdkfjToolStripMenuItem
      // 
      this.sdljkfhsdkfjToolStripMenuItem.Name = "sdljkfhsdkfjToolStripMenuItem";
      this.sdljkfhsdkfjToolStripMenuItem.Size = new System.Drawing.Size(189, 34);
      this.sdljkfhsdkfjToolStripMenuItem.Text = "sdljkfhsdkfj";
      // 
      // w2ToolStripMenuItem
      // 
      this.w2ToolStripMenuItem.Name = "w2ToolStripMenuItem";
      this.w2ToolStripMenuItem.Size = new System.Drawing.Size(180, 34);
      this.w2ToolStripMenuItem.Text = "W2";
      // 
      // cmnuFrmMain
      // 
      this.cmnuFrmMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmnuFrmMainP1,
            this.cmnuFrmMainDiv});
      this.cmnuFrmMain.Name = "cmnuFrmMain";
      this.cmnuFrmMain.Size = new System.Drawing.Size(141, 56);
      // 
      // cmnuFrmMainP1
      // 
      this.cmnuFrmMainP1.Name = "cmnuFrmMainP1";
      this.cmnuFrmMainP1.Size = new System.Drawing.Size(140, 26);
      this.cmnuFrmMainP1.Text = "Punkt 1";
      // 
      // cmnuFrmMainDiv
      // 
      this.cmnuFrmMainDiv.Image = global::WinMenue.Properties.Resources.Chrome;
      this.cmnuFrmMainDiv.Name = "cmnuFrmMainDiv";
      this.cmnuFrmMainDiv.Size = new System.Drawing.Size(140, 26);
      this.cmnuFrmMainDiv.Text = "Weiteres";
      this.cmnuFrmMainDiv.Click += new System.EventHandler(this.cmnuFrmMainDiv_Click);
      // 
      // textBox1
      // 
      this.textBox1.ContextMenuStrip = this.cmnuFrmMain;
      this.textBox1.Location = new System.Drawing.Point(45, 87);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(269, 29);
      this.textBox1.TabIndex = 2;
      // 
      // statusStrip1
      // 
      this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatusMachinename,
            this.lblStatusUsername});
      this.statusStrip1.Location = new System.Drawing.Point(0, 359);
      this.statusStrip1.Name = "statusStrip1";
      this.statusStrip1.Size = new System.Drawing.Size(662, 26);
      this.statusStrip1.TabIndex = 3;
      this.statusStrip1.Text = "statusStrip1";
      // 
      // lblStatusMachinename
      // 
      this.lblStatusMachinename.Name = "lblStatusMachinename";
      this.lblStatusMachinename.Size = new System.Drawing.Size(19, 21);
      this.lblStatusMachinename.Text = "...";
      // 
      // lblStatusUsername
      // 
      this.lblStatusUsername.Name = "lblStatusUsername";
      this.lblStatusUsername.Size = new System.Drawing.Size(19, 21);
      this.lblStatusUsername.Text = "...";
      // 
      // mnuOptionsProcess
      // 
      this.mnuOptionsProcess.Name = "mnuOptionsProcess";
      this.mnuOptionsProcess.Size = new System.Drawing.Size(180, 34);
      this.mnuOptionsProcess.Text = "Process...";
      this.mnuOptionsProcess.Click += new System.EventHandler(this.mnuOptionsProcess_Click);
      // 
      // FrmMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(662, 385);
      this.ContextMenuStrip = this.cmnuFrmMain;
      this.Controls.Add(this.statusStrip1);
      this.Controls.Add(this.textBox1);
      this.Controls.Add(this.mnuMain);
      this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.MainMenuStrip = this.mnuMain;
      this.Margin = new System.Windows.Forms.Padding(6);
      this.Name = "FrmMain";
      this.Text = "Menüs-und-StatusBar";
      this.Load += new System.EventHandler(this.FrmMain_Load);
      this.mnuMain.ResumeLayout(false);
      this.mnuMain.PerformLayout();
      this.cmnuFrmMain.ResumeLayout(false);
      this.statusStrip1.ResumeLayout(false);
      this.statusStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip mnuMain;
    private System.Windows.Forms.ToolStripMenuItem mnuFile;
    private System.Windows.Forms.ToolStripMenuItem mnuFileOpen;
    private System.Windows.Forms.ToolStripMenuItem mnuFileSave;
    private System.Windows.Forms.ToolStripSeparator mnuFileSep1;
    private System.Windows.Forms.ToolStripMenuItem mnuFileExit;
    private System.Windows.Forms.ToolStripMenuItem mnuOptions;
    private System.Windows.Forms.ToolStripMenuItem mnuOptionsInfo;
    private System.Windows.Forms.ContextMenuStrip cmnuFrmMain;
    private System.Windows.Forms.ToolStripMenuItem cmnuFrmMainP1;
    private System.Windows.Forms.ToolStripMenuItem cmnuFrmMainDiv;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.StatusStrip statusStrip1;
    private System.Windows.Forms.ToolStripStatusLabel lblStatusMachinename;
    private System.Windows.Forms.ToolStripStatusLabel lblStatusUsername;
    private System.Windows.Forms.ToolStripMenuItem mnuFileStartStop;
    private System.Windows.Forms.ToolStripMenuItem mnuOptionsColor;
    private System.Windows.Forms.ToolStripMenuItem weitersToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem w1ToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem w1W1ToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem w1W2ToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem w1W2W1ToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem sdljkfhsdkfjToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem w2ToolStripMenuItem;
    private System.Windows.Forms.ColorDialog dlgColor;
    private System.Windows.Forms.ToolStripMenuItem mnuOptionsProcess;
  }
}

