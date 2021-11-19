
namespace WinBmi
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
      this.label1 = new System.Windows.Forms.Label();
      this.txtGewichtKg = new System.Windows.Forms.TextBox();
      this.txtGroesseCm = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.btnRechnen = new System.Windows.Forms.Button();
      this.txtBMI = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(27, 32);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(144, 25);
      this.label1.TabIndex = 0;
      this.label1.Text = "Gewicht in Kg";
      // 
      // txtGewichtKg
      // 
      this.txtGewichtKg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.txtGewichtKg.Location = new System.Drawing.Point(32, 60);
      this.txtGewichtKg.Name = "txtGewichtKg";
      this.txtGewichtKg.Size = new System.Drawing.Size(183, 31);
      this.txtGewichtKg.TabIndex = 1;
      this.txtGewichtKg.Text = "100";
      this.txtGewichtKg.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.txtGewichtKg.TextChanged += new System.EventHandler(this.txtGewichtKg_TextChanged);
      // 
      // txtGroesseCm
      // 
      this.txtGroesseCm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
      this.txtGroesseCm.Location = new System.Drawing.Point(32, 148);
      this.txtGroesseCm.Name = "txtGroesseCm";
      this.txtGroesseCm.Size = new System.Drawing.Size(183, 31);
      this.txtGroesseCm.TabIndex = 3;
      this.txtGroesseCm.Text = "180";
      this.txtGroesseCm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(27, 120);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(138, 25);
      this.label2.TabIndex = 2;
      this.label2.Text = "Grösse in cm";
      // 
      // btnRechnen
      // 
      this.btnRechnen.Location = new System.Drawing.Point(32, 223);
      this.btnRechnen.Name = "btnRechnen";
      this.btnRechnen.Size = new System.Drawing.Size(183, 40);
      this.btnRechnen.TabIndex = 4;
      this.btnRechnen.Text = "Rechnen";
      this.btnRechnen.UseVisualStyleBackColor = true;
      this.btnRechnen.Click += new System.EventHandler(this.btnRechnen_Click);
      // 
      // txtBMI
      // 
      this.txtBMI.ForeColor = System.Drawing.SystemColors.ControlText;
      this.txtBMI.Location = new System.Drawing.Point(32, 315);
      this.txtBMI.Name = "txtBMI";
      this.txtBMI.Size = new System.Drawing.Size(183, 31);
      this.txtBMI.TabIndex = 6;
      this.txtBMI.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(27, 287);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(49, 25);
      this.label3.TabIndex = 5;
      this.label3.Text = "BMI";
      // 
      // FrmMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(278, 373);
      this.Controls.Add(this.txtBMI);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.btnRechnen);
      this.Controls.Add(this.txtGroesseCm);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.txtGewichtKg);
      this.Controls.Add(this.label1);
      this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Margin = new System.Windows.Forms.Padding(6);
      this.Name = "FrmMain";
      this.Text = "Mein Super-BMI Rechner";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtGewichtKg;
    private System.Windows.Forms.TextBox txtGroesseCm;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button btnRechnen;
    private System.Windows.Forms.TextBox txtBMI;
    private System.Windows.Forms.Label label3;
  }
}

