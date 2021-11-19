
namespace FensterTechnik
{
  partial class FrmZwei
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
      this.btnTest = new System.Windows.Forms.Button();
      this.fontDialog1 = new System.Windows.Forms.FontDialog();
      this.SuspendLayout();
      // 
      // btnTest
      // 
      this.btnTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnTest.Location = new System.Drawing.Point(49, 43);
      this.btnTest.Name = "btnTest";
      this.btnTest.Size = new System.Drawing.Size(467, 97);
      this.btnTest.TabIndex = 0;
      this.btnTest.Text = "Ändern!";
      this.btnTest.UseVisualStyleBackColor = true;
      this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
      // 
      // FrmZwei
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.ClientSize = new System.Drawing.Size(586, 332);
      this.Controls.Add(this.btnTest);
      this.Name = "FrmZwei";
      this.Text = "FrmZwei";
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button btnTest;
    private System.Windows.Forms.FontDialog fontDialog1;
  }
}