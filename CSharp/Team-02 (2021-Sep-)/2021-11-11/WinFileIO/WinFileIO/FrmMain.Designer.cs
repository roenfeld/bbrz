
namespace WinFileIO
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
      this.lbTest = new System.Windows.Forms.ListBox();
      this.cmLbTest = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.cmLbTestSaveAs = new System.Windows.Forms.ToolStripMenuItem();
      this.cmLbTestOpen = new System.Windows.Forms.ToolStripMenuItem();
      this.ofd = new System.Windows.Forms.OpenFileDialog();
      this.btnSerialize = new System.Windows.Forms.Button();
      this.cmLbTest.SuspendLayout();
      this.SuspendLayout();
      // 
      // lbTest
      // 
      this.lbTest.FormattingEnabled = true;
      this.lbTest.HorizontalScrollbar = true;
      this.lbTest.ItemHeight = 26;
      this.lbTest.Location = new System.Drawing.Point(38, 39);
      this.lbTest.Name = "lbTest";
      this.lbTest.Size = new System.Drawing.Size(282, 472);
      this.lbTest.TabIndex = 0;
      // 
      // cmLbTest
      // 
      this.cmLbTest.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmLbTestSaveAs,
            this.cmLbTestOpen});
      this.cmLbTest.Name = "cmLbTest";
      this.cmLbTest.Size = new System.Drawing.Size(200, 56);
      // 
      // cmLbTestSaveAs
      // 
      this.cmLbTestSaveAs.Image = global::WinFileIO.Properties.Resources.saveHS;
      this.cmLbTestSaveAs.Name = "cmLbTestSaveAs";
      this.cmLbTestSaveAs.Size = new System.Drawing.Size(199, 26);
      this.cmLbTestSaveAs.Text = "Speichern unter...";
      this.cmLbTestSaveAs.Click += new System.EventHandler(this.cmLbTestSaveAs_Click);
      // 
      // cmLbTestOpen
      // 
      this.cmLbTestOpen.Image = global::WinFileIO.Properties.Resources.Folder;
      this.cmLbTestOpen.Name = "cmLbTestOpen";
      this.cmLbTestOpen.Size = new System.Drawing.Size(199, 26);
      this.cmLbTestOpen.Text = "Öffnen...";
      // 
      // ofd
      // 
      this.ofd.FileName = "Zahlen.txt";
      this.ofd.Title = "Super-Toll!";
      // 
      // btnSerialize
      // 
      this.btnSerialize.Location = new System.Drawing.Point(409, 39);
      this.btnSerialize.Name = "btnSerialize";
      this.btnSerialize.Size = new System.Drawing.Size(274, 53);
      this.btnSerialize.TabIndex = 1;
      this.btnSerialize.Text = "XML Serialize";
      this.btnSerialize.UseVisualStyleBackColor = true;
      this.btnSerialize.Click += new System.EventHandler(this.btnSerialize_Click);
      // 
      // FrmMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 26F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(810, 578);
      this.Controls.Add(this.btnSerialize);
      this.Controls.Add(this.lbTest);
      this.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Margin = new System.Windows.Forms.Padding(6);
      this.Name = "FrmMain";
      this.Text = "FrmMain";
      this.Load += new System.EventHandler(this.FrmMain_Load);
      this.cmLbTest.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.ListBox lbTest;
    private System.Windows.Forms.ContextMenuStrip cmLbTest;
    private System.Windows.Forms.ToolStripMenuItem cmLbTestSaveAs;
    private System.Windows.Forms.ToolStripMenuItem cmLbTestOpen;
    private System.Windows.Forms.OpenFileDialog ofd;
    private System.Windows.Forms.Button btnSerialize;
  }
}