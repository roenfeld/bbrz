
namespace WinLayout
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
      this.btnOK = new System.Windows.Forms.Button();
      this.btnCancel = new System.Windows.Forms.Button();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.txtTest = new System.Windows.Forms.TextBox();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.panel1 = new System.Windows.Forms.Panel();
      this.chkSpeck = new System.Windows.Forms.CheckBox();
      this.checkBox2 = new System.Windows.Forms.CheckBox();
      this.checkBox3 = new System.Windows.Forms.CheckBox();
      this.checkBox4 = new System.Windows.Forms.CheckBox();
      this.radFleisch = new System.Windows.Forms.RadioButton();
      this.radVegan = new System.Windows.Forms.RadioButton();
      this.radMitXY = new System.Windows.Forms.RadioButton();
      this.radOhneXY = new System.Windows.Forms.RadioButton();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.panel2 = new System.Windows.Forms.Panel();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.mnuDatei = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuDateiZuruecksetzen = new System.Windows.Forms.ToolStripMenuItem();
      this.progressBar1 = new System.Windows.Forms.ProgressBar();
      this.trackBar1 = new System.Windows.Forms.TrackBar();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.groupBox1.SuspendLayout();
      this.panel1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.panel2.SuspendLayout();
      this.menuStrip1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
      this.SuspendLayout();
      // 
      // btnOK
      // 
      this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btnOK.Location = new System.Drawing.Point(650, 23);
      this.btnOK.Name = "btnOK";
      this.btnOK.Size = new System.Drawing.Size(170, 48);
      this.btnOK.TabIndex = 0;
      this.btnOK.Text = "OK";
      this.btnOK.UseVisualStyleBackColor = true;
      this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
      // 
      // btnCancel
      // 
      this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btnCancel.Location = new System.Drawing.Point(474, 23);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(170, 48);
      this.btnCancel.TabIndex = 1;
      this.btnCancel.Text = "Abbrechen";
      this.btnCancel.UseVisualStyleBackColor = true;
      this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
      // 
      // pictureBox1
      // 
      this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.pictureBox1.BackColor = System.Drawing.Color.Wheat;
      this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.pictureBox1.Location = new System.Drawing.Point(6, 81);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(358, 250);
      this.pictureBox1.TabIndex = 2;
      this.pictureBox1.TabStop = false;
      // 
      // txtTest
      // 
      this.txtTest.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtTest.Location = new System.Drawing.Point(6, 37);
      this.txtTest.Name = "txtTest";
      this.txtTest.Size = new System.Drawing.Size(358, 27);
      this.txtTest.TabIndex = 3;
      // 
      // groupBox1
      // 
      this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBox1.Controls.Add(this.pictureBox1);
      this.groupBox1.Controls.Add(this.txtTest);
      this.groupBox1.Location = new System.Drawing.Point(460, 58);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(370, 349);
      this.groupBox1.TabIndex = 4;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "groupBox1";
      // 
      // panel1
      // 
      this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.panel1.BackColor = System.Drawing.Color.Azure;
      this.panel1.Controls.Add(this.trackBar1);
      this.panel1.Controls.Add(this.btnOK);
      this.panel1.Controls.Add(this.btnCancel);
      this.panel1.Location = new System.Drawing.Point(12, 422);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(832, 84);
      this.panel1.TabIndex = 5;
      // 
      // chkSpeck
      // 
      this.chkSpeck.AutoSize = true;
      this.chkSpeck.Location = new System.Drawing.Point(37, 84);
      this.chkSpeck.Name = "chkSpeck";
      this.chkSpeck.Size = new System.Drawing.Size(65, 23);
      this.chkSpeck.TabIndex = 6;
      this.chkSpeck.Text = "Speck";
      this.chkSpeck.UseVisualStyleBackColor = true;
      // 
      // checkBox2
      // 
      this.checkBox2.AutoSize = true;
      this.checkBox2.Location = new System.Drawing.Point(37, 122);
      this.checkBox2.Name = "checkBox2";
      this.checkBox2.Size = new System.Drawing.Size(97, 23);
      this.checkBox2.TabIndex = 7;
      this.checkBox2.Text = "checkBox2";
      this.checkBox2.UseVisualStyleBackColor = true;
      // 
      // checkBox3
      // 
      this.checkBox3.AutoSize = true;
      this.checkBox3.Location = new System.Drawing.Point(37, 164);
      this.checkBox3.Name = "checkBox3";
      this.checkBox3.Size = new System.Drawing.Size(97, 23);
      this.checkBox3.TabIndex = 8;
      this.checkBox3.Text = "checkBox3";
      this.checkBox3.UseVisualStyleBackColor = true;
      // 
      // checkBox4
      // 
      this.checkBox4.AutoSize = true;
      this.checkBox4.Location = new System.Drawing.Point(37, 203);
      this.checkBox4.Name = "checkBox4";
      this.checkBox4.Size = new System.Drawing.Size(97, 23);
      this.checkBox4.TabIndex = 9;
      this.checkBox4.Text = "checkBox4";
      this.checkBox4.UseVisualStyleBackColor = true;
      // 
      // radFleisch
      // 
      this.radFleisch.AutoSize = true;
      this.radFleisch.Location = new System.Drawing.Point(35, 26);
      this.radFleisch.Name = "radFleisch";
      this.radFleisch.Size = new System.Drawing.Size(72, 23);
      this.radFleisch.TabIndex = 10;
      this.radFleisch.TabStop = true;
      this.radFleisch.Text = "Fleisch";
      this.radFleisch.UseVisualStyleBackColor = true;
      // 
      // radVegan
      // 
      this.radVegan.AutoSize = true;
      this.radVegan.Location = new System.Drawing.Point(35, 63);
      this.radVegan.Name = "radVegan";
      this.radVegan.Size = new System.Drawing.Size(67, 23);
      this.radVegan.TabIndex = 11;
      this.radVegan.TabStop = true;
      this.radVegan.Text = "Vegan";
      this.radVegan.UseVisualStyleBackColor = true;
      // 
      // radMitXY
      // 
      this.radMitXY.AutoSize = true;
      this.radMitXY.Location = new System.Drawing.Point(34, 35);
      this.radMitXY.Name = "radMitXY";
      this.radMitXY.Size = new System.Drawing.Size(69, 23);
      this.radMitXY.TabIndex = 12;
      this.radMitXY.TabStop = true;
      this.radMitXY.Text = "Mit XY";
      this.radMitXY.UseVisualStyleBackColor = true;
      // 
      // radOhneXY
      // 
      this.radOhneXY.AutoSize = true;
      this.radOhneXY.Location = new System.Drawing.Point(34, 77);
      this.radOhneXY.Name = "radOhneXY";
      this.radOhneXY.Size = new System.Drawing.Size(82, 23);
      this.radOhneXY.TabIndex = 13;
      this.radOhneXY.TabStop = true;
      this.radOhneXY.Text = "Ohne XY";
      this.radOhneXY.UseVisualStyleBackColor = true;
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.radFleisch);
      this.groupBox2.Controls.Add(this.radVegan);
      this.groupBox2.Location = new System.Drawing.Point(218, 58);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(187, 111);
      this.groupBox2.TabIndex = 14;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Vegan?";
      // 
      // panel2
      // 
      this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.panel2.Controls.Add(this.radMitXY);
      this.panel2.Controls.Add(this.radOhneXY);
      this.panel2.Location = new System.Drawing.Point(218, 192);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(187, 155);
      this.panel2.TabIndex = 15;
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDatei});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(856, 29);
      this.menuStrip1.TabIndex = 16;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // mnuDatei
      // 
      this.mnuDatei.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDateiZuruecksetzen});
      this.mnuDatei.Name = "mnuDatei";
      this.mnuDatei.Size = new System.Drawing.Size(58, 25);
      this.mnuDatei.Text = "Datei";
      // 
      // mnuDateiZuruecksetzen
      // 
      this.mnuDateiZuruecksetzen.Name = "mnuDateiZuruecksetzen";
      this.mnuDateiZuruecksetzen.Size = new System.Drawing.Size(181, 26);
      this.mnuDateiZuruecksetzen.Text = "Zurücksetzen...";
      this.mnuDateiZuruecksetzen.Click += new System.EventHandler(this.mnuDateiZuruecksetzen_Click);
      // 
      // progressBar1
      // 
      this.progressBar1.Location = new System.Drawing.Point(12, 384);
      this.progressBar1.Name = "progressBar1";
      this.progressBar1.Size = new System.Drawing.Size(410, 23);
      this.progressBar1.TabIndex = 17;
      this.progressBar1.Value = 50;
      // 
      // trackBar1
      // 
      this.trackBar1.Location = new System.Drawing.Point(25, 23);
      this.trackBar1.Name = "trackBar1";
      this.trackBar1.Size = new System.Drawing.Size(415, 45);
      this.trackBar1.TabIndex = 18;
      // 
      // FrmMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(856, 518);
      this.Controls.Add(this.progressBar1);
      this.Controls.Add(this.panel2);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.checkBox4);
      this.Controls.Add(this.checkBox3);
      this.Controls.Add(this.checkBox2);
      this.Controls.Add(this.chkSpeck);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.menuStrip1);
      this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.MainMenuStrip = this.menuStrip1;
      this.Margin = new System.Windows.Forms.Padding(4);
      this.MinimumSize = new System.Drawing.Size(400, 300);
      this.Name = "FrmMain";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.FrmMain_Load);
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.panel2.ResumeLayout(false);
      this.panel2.PerformLayout();
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnOK;
    private System.Windows.Forms.Button btnCancel;
    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.TextBox txtTest;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.CheckBox chkSpeck;
    private System.Windows.Forms.CheckBox checkBox2;
    private System.Windows.Forms.CheckBox checkBox3;
    private System.Windows.Forms.CheckBox checkBox4;
    private System.Windows.Forms.RadioButton radFleisch;
    private System.Windows.Forms.RadioButton radVegan;
    private System.Windows.Forms.RadioButton radMitXY;
    private System.Windows.Forms.RadioButton radOhneXY;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem mnuDatei;
    private System.Windows.Forms.ToolStripMenuItem mnuDateiZuruecksetzen;
    private System.Windows.Forms.TrackBar trackBar1;
    private System.Windows.Forms.ProgressBar progressBar1;
  }
}

