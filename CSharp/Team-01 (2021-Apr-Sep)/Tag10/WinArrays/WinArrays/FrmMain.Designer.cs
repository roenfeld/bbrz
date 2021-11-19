
namespace WinArrays
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
      this.lbTest = new System.Windows.Forms.ListBox();
      this.txtName = new System.Windows.Forms.TextBox();
      this.btnAdd = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // lbTest
      // 
      this.lbTest.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.lbTest.FormattingEnabled = true;
      this.lbTest.ItemHeight = 24;
      this.lbTest.Location = new System.Drawing.Point(12, 83);
      this.lbTest.Name = "lbTest";
      this.lbTest.Size = new System.Drawing.Size(293, 268);
      this.lbTest.TabIndex = 0;
      // 
      // txtName
      // 
      this.txtName.Location = new System.Drawing.Point(209, 24);
      this.txtName.Name = "txtName";
      this.txtName.Size = new System.Drawing.Size(197, 29);
      this.txtName.TabIndex = 1;
      this.txtName.Text = "Walter";
      // 
      // btnAdd
      // 
      this.btnAdd.Location = new System.Drawing.Point(412, 24);
      this.btnAdd.Name = "btnAdd";
      this.btnAdd.Size = new System.Drawing.Size(106, 29);
      this.btnAdd.TabIndex = 2;
      this.btnAdd.Text = "++";
      this.btnAdd.UseVisualStyleBackColor = true;
      this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
      // 
      // FrmMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(550, 363);
      this.Controls.Add(this.btnAdd);
      this.Controls.Add(this.txtName);
      this.Controls.Add(this.lbTest);
      this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Margin = new System.Windows.Forms.Padding(6);
      this.Name = "FrmMain";
      this.Text = "Form1";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ListBox lbTest;
    private System.Windows.Forms.TextBox txtName;
    private System.Windows.Forms.Button btnAdd;
  }
}

