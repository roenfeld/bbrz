
namespace WindowsFormsApp2
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
      this.btnExit = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.btnTest = new System.Windows.Forms.Button();
      this.button2 = new System.Windows.Forms.Button();
      this.button3 = new System.Windows.Forms.Button();
      this.button4 = new System.Windows.Forms.Button();
      this.button5 = new System.Windows.Forms.Button();
      this.panel1 = new System.Windows.Forms.Panel();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // btnExit
      // 
      this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btnExit.ForeColor = System.Drawing.Color.ForestGreen;
      this.btnExit.Location = new System.Drawing.Point(387, 247);
      this.btnExit.Margin = new System.Windows.Forms.Padding(5);
      this.btnExit.Name = "btnExit";
      this.btnExit.Size = new System.Drawing.Size(279, 49);
      this.btnExit.TabIndex = 0;
      this.btnExit.Text = "Beenden";
      this.btnExit.UseVisualStyleBackColor = true;
      this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(442, 72);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(59, 23);
      this.label1.TabIndex = 1;
      this.label1.Text = "label1";
      // 
      // btnTest
      // 
      this.btnTest.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.btnTest.Location = new System.Drawing.Point(220, 318);
      this.btnTest.Name = "btnTest";
      this.btnTest.Size = new System.Drawing.Size(446, 31);
      this.btnTest.TabIndex = 2;
      this.btnTest.Text = "Event-Test";
      this.btnTest.UseVisualStyleBackColor = true;
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(18, 14);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(129, 31);
      this.button2.TabIndex = 3;
      this.button2.Text = "button2";
      this.button2.UseVisualStyleBackColor = true;
      // 
      // button3
      // 
      this.button3.Location = new System.Drawing.Point(18, 125);
      this.button3.Name = "button3";
      this.button3.Size = new System.Drawing.Size(129, 31);
      this.button3.TabIndex = 4;
      this.button3.Text = "button3";
      this.button3.UseVisualStyleBackColor = true;
      // 
      // button4
      // 
      this.button4.Location = new System.Drawing.Point(18, 88);
      this.button4.Name = "button4";
      this.button4.Size = new System.Drawing.Size(129, 31);
      this.button4.TabIndex = 5;
      this.button4.Text = "button4";
      this.button4.UseVisualStyleBackColor = true;
      // 
      // button5
      // 
      this.button5.Location = new System.Drawing.Point(18, 51);
      this.button5.Name = "button5";
      this.button5.Size = new System.Drawing.Size(129, 31);
      this.button5.TabIndex = 6;
      this.button5.Text = "button5";
      this.button5.UseVisualStyleBackColor = true;
      // 
      // panel1
      // 
      this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.panel1.Controls.Add(this.button2);
      this.panel1.Controls.Add(this.button5);
      this.panel1.Controls.Add(this.button3);
      this.panel1.Controls.Add(this.button4);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(200, 350);
      this.panel1.TabIndex = 7;
      // 
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(293, 121);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(347, 30);
      this.textBox1.TabIndex = 8;
      // 
      // FrmMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.Control;
      this.ClientSize = new System.Drawing.Size(678, 350);
      this.Controls.Add(this.textBox1);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.btnTest);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.btnExit);
      this.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
      this.Margin = new System.Windows.Forms.Padding(5);
      this.Name = "FrmMain";
      this.Text = "Mein Super Programm";
      this.panel1.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnExit;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button btnTest;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Button button3;
    private System.Windows.Forms.Button button4;
    private System.Windows.Forms.Button button5;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.TextBox textBox1;
  }
}

