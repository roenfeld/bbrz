namespace WinSerialize
{
  partial class FrmPerson
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
      this.btnLoadData = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // btnLoadData
      // 
      this.btnLoadData.Location = new System.Drawing.Point(26, 20);
      this.btnLoadData.Name = "btnLoadData";
      this.btnLoadData.Size = new System.Drawing.Size(210, 34);
      this.btnLoadData.TabIndex = 0;
      this.btnLoadData.Text = "Laden";
      this.btnLoadData.UseVisualStyleBackColor = true;
      this.btnLoadData.Click += new System.EventHandler(this.btnLoadData_Click);
      // 
      // FrmPerson
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(629, 420);
      this.Controls.Add(this.btnLoadData);
      this.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
      this.Name = "FrmPerson";
      this.Text = "FrmPerson";
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button btnLoadData;
  }
}