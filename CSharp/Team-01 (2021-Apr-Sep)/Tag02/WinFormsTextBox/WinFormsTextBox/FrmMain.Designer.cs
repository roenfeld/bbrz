
namespace WinFormsTextBox
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
      this.txtTest = new System.Windows.Forms.TextBox();
      this.btnTest = new System.Windows.Forms.Button();
      this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
      this.SuspendLayout();
      // 
      // txtTest
      // 
      this.txtTest.Location = new System.Drawing.Point(31, 43);
      this.txtTest.Name = "txtTest";
      this.txtTest.Size = new System.Drawing.Size(298, 29);
      this.txtTest.TabIndex = 0;
      this.txtTest.Text = "CodersBay";
      // 
      // btnTest
      // 
      this.btnTest.Location = new System.Drawing.Point(31, 147);
      this.btnTest.Name = "btnTest";
      this.btnTest.Size = new System.Drawing.Size(215, 36);
      this.btnTest.TabIndex = 1;
      this.btnTest.Text = "Test";
      this.btnTest.UseVisualStyleBackColor = true;
      this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
      // 
      // dateTimePicker1
      // 
      this.dateTimePicker1.Location = new System.Drawing.Point(31, 217);
      this.dateTimePicker1.Name = "dateTimePicker1";
      this.dateTimePicker1.Size = new System.Drawing.Size(358, 29);
      this.dateTimePicker1.TabIndex = 2;
      // 
      // FrmMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(506, 276);
      this.Controls.Add(this.dateTimePicker1);
      this.Controls.Add(this.btnTest);
      this.Controls.Add(this.txtTest);
      this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
      this.Name = "FrmMain";
      this.Text = "Form1";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox txtTest;
    private System.Windows.Forms.Button btnTest;
    private System.Windows.Forms.DateTimePicker dateTimePicker1;
  }
}

