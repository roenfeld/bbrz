
namespace WinArrays
{
  partial class FrmNamen
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
      this.lbNamen = new System.Windows.Forms.ListBox();
      this.btnAdd = new System.Windows.Forms.Button();
      this.txtNew = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // lbNamen
      // 
      this.lbNamen.FormattingEnabled = true;
      this.lbNamen.ItemHeight = 20;
      this.lbNamen.Location = new System.Drawing.Point(28, 76);
      this.lbNamen.Name = "lbNamen";
      this.lbNamen.Size = new System.Drawing.Size(307, 324);
      this.lbNamen.TabIndex = 0;
      // 
      // btnAdd
      // 
      this.btnAdd.Location = new System.Drawing.Point(313, 12);
      this.btnAdd.Name = "btnAdd";
      this.btnAdd.Size = new System.Drawing.Size(75, 26);
      this.btnAdd.TabIndex = 1;
      this.btnAdd.Text = "++";
      this.btnAdd.UseVisualStyleBackColor = true;
      this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
      // 
      // txtNew
      // 
      this.txtNew.Location = new System.Drawing.Point(28, 12);
      this.txtNew.Name = "txtNew";
      this.txtNew.Size = new System.Drawing.Size(279, 26);
      this.txtNew.TabIndex = 2;
      // 
      // FrmNamen
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(508, 439);
      this.Controls.Add(this.txtNew);
      this.Controls.Add(this.btnAdd);
      this.Controls.Add(this.lbNamen);
      this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.Name = "FrmNamen";
      this.Text = "FrmNamen";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ListBox lbNamen;
    private System.Windows.Forms.Button btnAdd;
    private System.Windows.Forms.TextBox txtNew;
  }
}