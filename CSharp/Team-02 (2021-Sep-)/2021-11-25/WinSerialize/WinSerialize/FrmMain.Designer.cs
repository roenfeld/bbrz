namespace WinSerialize
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
      this.btnXmlSerialize = new System.Windows.Forms.Button();
      this.btnXmlDeSerialize = new System.Windows.Forms.Button();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuFileSave = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuFileSaveAs = new System.Windows.Forms.ToolStripMenuItem();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // btnXmlSerialize
      // 
      this.btnXmlSerialize.Location = new System.Drawing.Point(31, 61);
      this.btnXmlSerialize.Name = "btnXmlSerialize";
      this.btnXmlSerialize.Size = new System.Drawing.Size(332, 42);
      this.btnXmlSerialize.TabIndex = 0;
      this.btnXmlSerialize.Text = "XML Serialisieren";
      this.btnXmlSerialize.UseVisualStyleBackColor = true;
      this.btnXmlSerialize.Click += new System.EventHandler(this.btnXmlSerialize_Click);
      // 
      // btnXmlDeSerialize
      // 
      this.btnXmlDeSerialize.Location = new System.Drawing.Point(31, 134);
      this.btnXmlDeSerialize.Name = "btnXmlDeSerialize";
      this.btnXmlDeSerialize.Size = new System.Drawing.Size(332, 42);
      this.btnXmlDeSerialize.TabIndex = 1;
      this.btnXmlDeSerialize.Text = "XML DE-Serialisieren";
      this.btnXmlDeSerialize.UseVisualStyleBackColor = true;
      this.btnXmlDeSerialize.Click += new System.EventHandler(this.btnXmlDeSerialize_Click);
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(727, 29);
      this.menuStrip1.TabIndex = 2;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // mnuFile
      // 
      this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileSave,
            this.mnuFileSaveAs});
      this.mnuFile.Name = "mnuFile";
      this.mnuFile.Size = new System.Drawing.Size(58, 25);
      this.mnuFile.Text = "Datei";
      // 
      // mnuFileSave
      // 
      this.mnuFileSave.Image = global::WinSerialize.Properties.Resources.saveHS;
      this.mnuFileSave.Name = "mnuFileSave";
      this.mnuFileSave.Size = new System.Drawing.Size(199, 26);
      this.mnuFileSave.Text = "Speichern";
      this.mnuFileSave.Click += new System.EventHandler(this.mnuFileSave_Click);
      // 
      // mnuFileSaveAs
      // 
      this.mnuFileSaveAs.Image = global::WinSerialize.Properties.Resources.saveHS;
      this.mnuFileSaveAs.Name = "mnuFileSaveAs";
      this.mnuFileSaveAs.Size = new System.Drawing.Size(199, 26);
      this.mnuFileSaveAs.Text = "Speichern unter...";
      this.mnuFileSaveAs.Click += new System.EventHandler(this.mnuFileSaveAs_Click);
      // 
      // FrmMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(727, 429);
      this.Controls.Add(this.btnXmlDeSerialize);
      this.Controls.Add(this.btnXmlSerialize);
      this.Controls.Add(this.menuStrip1);
      this.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.MainMenuStrip = this.menuStrip1;
      this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
      this.Name = "FrmMain";
      this.Text = "Form1";
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnXmlSerialize;
    private System.Windows.Forms.Button btnXmlDeSerialize;
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem mnuFile;
    private System.Windows.Forms.ToolStripMenuItem mnuFileSave;
    private System.Windows.Forms.ToolStripMenuItem mnuFileSaveAs;
  }
}

