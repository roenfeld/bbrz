
namespace FensterTechnik
{
  partial class FrmEins
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
      this.btnFensterZwo = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // btnFensterZwo
      // 
      this.btnFensterZwo.Location = new System.Drawing.Point(48, 37);
      this.btnFensterZwo.Name = "btnFensterZwo";
      this.btnFensterZwo.Size = new System.Drawing.Size(359, 81);
      this.btnFensterZwo.TabIndex = 0;
      this.btnFensterZwo.Text = "Fenster 2...";
      this.btnFensterZwo.UseVisualStyleBackColor = true;
      this.btnFensterZwo.Click += new System.EventHandler(this.btnFensterZwo_Click);
      // 
      // FrmEins
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(471, 283);
      this.Controls.Add(this.btnFensterZwo);
      this.Name = "FrmEins";
      this.Text = "FrmEins";
      this.ResumeLayout(false);

    }

    #endregion

    public System.Windows.Forms.Button btnFensterZwo;
  }
}