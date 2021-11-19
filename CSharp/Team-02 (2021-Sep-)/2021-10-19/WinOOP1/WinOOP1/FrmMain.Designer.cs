
namespace WinOOP1
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
      this.btnNeuesAuto = new System.Windows.Forms.Button();
      this.btnTypeCast = new System.Windows.Forms.Button();
      this.txtTest = new System.Windows.Forms.TextBox();
      this.btnCallByValue = new System.Windows.Forms.Button();
      this.btnPropAndMeths = new System.Windows.Forms.Button();
      this.btnTest = new System.Windows.Forms.Button();
      this.progressBar1 = new System.Windows.Forms.ProgressBar();
      this.SuspendLayout();
      // 
      // btnNeuesAuto
      // 
      this.btnNeuesAuto.Location = new System.Drawing.Point(14, 23);
      this.btnNeuesAuto.Margin = new System.Windows.Forms.Padding(5);
      this.btnNeuesAuto.Name = "btnNeuesAuto";
      this.btnNeuesAuto.Size = new System.Drawing.Size(220, 36);
      this.btnNeuesAuto.TabIndex = 0;
      this.btnNeuesAuto.Text = "Neu!";
      this.btnNeuesAuto.UseVisualStyleBackColor = true;
      this.btnNeuesAuto.Click += new System.EventHandler(this.btnNeuesAuto_Click);
      // 
      // btnTypeCast
      // 
      this.btnTypeCast.Location = new System.Drawing.Point(14, 111);
      this.btnTypeCast.Margin = new System.Windows.Forms.Padding(5);
      this.btnTypeCast.Name = "btnTypeCast";
      this.btnTypeCast.Size = new System.Drawing.Size(220, 36);
      this.btnTypeCast.TabIndex = 1;
      this.btnTypeCast.Text = "Type-Cast";
      this.btnTypeCast.UseVisualStyleBackColor = true;
      this.btnTypeCast.Click += new System.EventHandler(this.btnTypeCast_Click);
      // 
      // txtTest
      // 
      this.txtTest.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtTest.Location = new System.Drawing.Point(385, 23);
      this.txtTest.Name = "txtTest";
      this.txtTest.Size = new System.Drawing.Size(698, 31);
      this.txtTest.TabIndex = 2;
      this.txtTest.TextChanged += new System.EventHandler(this.txtTest_TextChanged);
      // 
      // btnCallByValue
      // 
      this.btnCallByValue.Location = new System.Drawing.Point(14, 202);
      this.btnCallByValue.Margin = new System.Windows.Forms.Padding(5);
      this.btnCallByValue.Name = "btnCallByValue";
      this.btnCallByValue.Size = new System.Drawing.Size(220, 36);
      this.btnCallByValue.TabIndex = 3;
      this.btnCallByValue.Text = "Call By Value";
      this.btnCallByValue.UseVisualStyleBackColor = true;
      this.btnCallByValue.Click += new System.EventHandler(this.btnCallByValue_Click);
      // 
      // btnPropAndMeths
      // 
      this.btnPropAndMeths.Location = new System.Drawing.Point(385, 111);
      this.btnPropAndMeths.Margin = new System.Windows.Forms.Padding(5);
      this.btnPropAndMeths.Name = "btnPropAndMeths";
      this.btnPropAndMeths.Size = new System.Drawing.Size(220, 36);
      this.btnPropAndMeths.TabIndex = 4;
      this.btnPropAndMeths.Text = "Props && Methoden";
      this.btnPropAndMeths.UseVisualStyleBackColor = true;
      //this.btnPropAndMeths.Click += new System.EventHandler(this.btnPropAndMeths_Click);
      // 
      // btnTest
      // 
      this.btnTest.Location = new System.Drawing.Point(863, 281);
      this.btnTest.Margin = new System.Windows.Forms.Padding(5);
      this.btnTest.Name = "btnTest";
      this.btnTest.Size = new System.Drawing.Size(220, 36);
      this.btnTest.TabIndex = 5;
      this.btnTest.Text = "Test 1";
      this.btnTest.UseVisualStyleBackColor = true;
      this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
      // 
      // progressBar1
      // 
      this.progressBar1.Location = new System.Drawing.Point(14, 277);
      this.progressBar1.Name = "progressBar1";
      this.progressBar1.Size = new System.Drawing.Size(463, 40);
      this.progressBar1.TabIndex = 6;
      this.progressBar1.Value = 55;
      // 
      // FrmMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1138, 357);
      this.Controls.Add(this.progressBar1);
      this.Controls.Add(this.btnTest);
      this.Controls.Add(this.btnPropAndMeths);
      this.Controls.Add(this.btnCallByValue);
      this.Controls.Add(this.txtTest);
      this.Controls.Add(this.btnTypeCast);
      this.Controls.Add(this.btnNeuesAuto);
      this.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Margin = new System.Windows.Forms.Padding(5);
      this.Name = "FrmMain";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.FrmMain_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnNeuesAuto;
    private System.Windows.Forms.Button btnTypeCast;
    private System.Windows.Forms.TextBox txtTest;
    private System.Windows.Forms.Button btnCallByValue;
    private System.Windows.Forms.Button btnPropAndMeths;
    private System.Windows.Forms.Button btnTest;
    private System.Windows.Forms.ProgressBar progressBar1;
  }
}

