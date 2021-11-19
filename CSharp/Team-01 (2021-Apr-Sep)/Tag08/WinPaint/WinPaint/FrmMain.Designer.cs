
namespace WinPaint
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
      this.mnuFileExit = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuOptions = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuOptionsColor = new System.Windows.Forms.ToolStripMenuItem();
      this.btnTest = new System.Windows.Forms.Button();
      this.timer1 = new System.Windows.Forms.Timer(this.components);
      this.mnuMain.SuspendLayout();
      this.SuspendLayout();
      // 
      // mnuMain
      // 
      this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuOptions});
      this.mnuMain.Location = new System.Drawing.Point(0, 0);
      this.mnuMain.Name = "mnuMain";
      this.mnuMain.Size = new System.Drawing.Size(560, 29);
      this.mnuMain.TabIndex = 0;
      this.mnuMain.Text = "menuStrip1";
      // 
      // mnuFile
      // 
      this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileExit});
      this.mnuFile.Name = "mnuFile";
      this.mnuFile.Size = new System.Drawing.Size(58, 25);
      this.mnuFile.Text = "Datei";
      // 
      // mnuFileExit
      // 
      this.mnuFileExit.Name = "mnuFileExit";
      this.mnuFileExit.Size = new System.Drawing.Size(140, 26);
      this.mnuFileExit.Text = "Beenden";
      // 
      // mnuOptions
      // 
      this.mnuOptions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOptionsColor});
      this.mnuOptions.Name = "mnuOptions";
      this.mnuOptions.Size = new System.Drawing.Size(87, 25);
      this.mnuOptions.Text = "Optionen";
      // 
      // mnuOptionsColor
      // 
      this.mnuOptionsColor.Name = "mnuOptionsColor";
      this.mnuOptionsColor.Size = new System.Drawing.Size(127, 26);
      this.mnuOptionsColor.Text = "Farbe...";
      this.mnuOptionsColor.Click += new System.EventHandler(this.mnuOptionsColor_Click);
      // 
      // btnTest
      // 
      this.btnTest.Location = new System.Drawing.Point(40, 88);
      this.btnTest.Name = "btnTest";
      this.btnTest.Size = new System.Drawing.Size(249, 69);
      this.btnTest.TabIndex = 1;
      this.btnTest.Text = "button1";
      this.btnTest.UseVisualStyleBackColor = true;
      this.btnTest.Paint += new System.Windows.Forms.PaintEventHandler(this.btnTest_Paint);
      // 
      // timer1
      // 
      this.timer1.Enabled = true;
      this.timer1.Interval = 20;
      this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
      // 
      // FrmMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(560, 392);
      this.Controls.Add(this.btnTest);
      this.Controls.Add(this.mnuMain);
      this.DoubleBuffered = true;
      this.MainMenuStrip = this.mnuMain;
      this.Name = "FrmMain";
      this.Text = "Form1";
      this.Paint += new System.Windows.Forms.PaintEventHandler(this.FrmMain_Paint);
      this.mnuMain.ResumeLayout(false);
      this.mnuMain.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip mnuMain;
    private System.Windows.Forms.ToolStripMenuItem mnuFile;
    private System.Windows.Forms.ToolStripMenuItem mnuFileExit;
    private System.Windows.Forms.ToolStripMenuItem mnuOptions;
    private System.Windows.Forms.ToolStripMenuItem mnuOptionsColor;
    private System.Windows.Forms.Button btnTest;
    private System.Windows.Forms.Timer timer1;
  }
}

