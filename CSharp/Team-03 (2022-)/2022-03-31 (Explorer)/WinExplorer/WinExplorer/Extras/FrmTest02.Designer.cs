namespace WinExplorer
{
  partial class FrmTest02
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
      System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Knoten0");
      this.treeView1 = new System.Windows.Forms.TreeView();
      this.splitter1 = new System.Windows.Forms.Splitter();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.SuspendLayout();
      // 
      // treeView1
      // 
      this.treeView1.Dock = System.Windows.Forms.DockStyle.Left;
      this.treeView1.Location = new System.Drawing.Point(0, 24);
      this.treeView1.Name = "treeView1";
      treeNode1.Name = "Knoten0";
      treeNode1.Text = "Knoten0";
      this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
      this.treeView1.Size = new System.Drawing.Size(319, 395);
      this.treeView1.TabIndex = 0;
      // 
      // splitter1
      // 
      this.splitter1.Location = new System.Drawing.Point(319, 24);
      this.splitter1.Name = "splitter1";
      this.splitter1.Size = new System.Drawing.Size(3, 395);
      this.splitter1.TabIndex = 1;
      this.splitter1.TabStop = false;
      // 
      // menuStrip1
      // 
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(640, 24);
      this.menuStrip1.TabIndex = 2;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // FrmTest02
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(640, 419);
      this.Controls.Add(this.splitter1);
      this.Controls.Add(this.treeView1);
      this.Controls.Add(this.menuStrip1);
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "FrmTest02";
      this.Text = "FrmTest02";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TreeView treeView1;
    private System.Windows.Forms.Splitter splitter1;
    private System.Windows.Forms.MenuStrip menuStrip1;
  }
}