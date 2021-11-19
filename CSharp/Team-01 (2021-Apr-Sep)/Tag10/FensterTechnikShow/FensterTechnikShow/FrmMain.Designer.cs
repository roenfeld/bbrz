
namespace FensterTechnikShow
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
      this.btnFenster2 = new System.Windows.Forms.Button();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.mnuDatei = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuDateiFenster2 = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuDateiFensterZu = new System.Windows.Forms.ToolStripMenuItem();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // btnFenster2
      // 
      this.btnFenster2.Location = new System.Drawing.Point(84, 56);
      this.btnFenster2.Name = "btnFenster2";
      this.btnFenster2.Size = new System.Drawing.Size(332, 49);
      this.btnFenster2.TabIndex = 0;
      this.btnFenster2.Text = "Fenster anzeigen...";
      this.btnFenster2.UseVisualStyleBackColor = true;
      this.btnFenster2.Click += new System.EventHandler(this.btnFenster2_Click);
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDatei});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(747, 29);
      this.menuStrip1.TabIndex = 1;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // mnuDatei
      // 
      this.mnuDatei.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDateiFenster2,
            this.mnuDateiFensterZu});
      this.mnuDatei.Name = "mnuDatei";
      this.mnuDatei.Size = new System.Drawing.Size(58, 25);
      this.mnuDatei.Text = "Datei";
      // 
      // mnuDateiFenster2
      // 
      this.mnuDateiFenster2.Name = "mnuDateiFenster2";
      this.mnuDateiFenster2.Size = new System.Drawing.Size(210, 26);
      this.mnuDateiFenster2.Text = "Fenster anzeigen....";
      this.mnuDateiFenster2.Click += new System.EventHandler(this.mnuDateiFenster2_Click);
      // 
      // mnuDateiFensterZu
      // 
      this.mnuDateiFensterZu.Name = "mnuDateiFensterZu";
      this.mnuDateiFensterZu.Size = new System.Drawing.Size(210, 26);
      this.mnuDateiFensterZu.Text = "Fenster schliessen!";
      this.mnuDateiFensterZu.Click += new System.EventHandler(this.mnuDateiFensterZu_Click);
      // 
      // FrmMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(747, 447);
      this.Controls.Add(this.btnFenster2);
      this.Controls.Add(this.menuStrip1);
      this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.IsMdiContainer = true;
      this.MainMenuStrip = this.menuStrip1;
      this.Margin = new System.Windows.Forms.Padding(6);
      this.Name = "FrmMain";
      this.Text = "Form1";
      this.LocationChanged += new System.EventHandler(this.FrmMain_LocationChanged);
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnFenster2;
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem mnuDatei;
    private System.Windows.Forms.ToolStripMenuItem mnuDateiFenster2;
    private System.Windows.Forms.ToolStripMenuItem mnuDateiFensterZu;
  }
}

