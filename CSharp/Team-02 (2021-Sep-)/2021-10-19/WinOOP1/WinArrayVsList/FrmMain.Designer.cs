
namespace WinArrayVsList
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
      this.txtNewValue = new System.Windows.Forms.NumericUpDown();
      this.btnAddNewValue = new System.Windows.Forms.Button();
      this.lbValues = new System.Windows.Forms.ListBox();
      ((System.ComponentModel.ISupportInitialize)(this.txtNewValue)).BeginInit();
      this.SuspendLayout();
      // 
      // txtNewValue
      // 
      this.txtNewValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtNewValue.Location = new System.Drawing.Point(31, 28);
      this.txtNewValue.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
      this.txtNewValue.Name = "txtNewValue";
      this.txtNewValue.Size = new System.Drawing.Size(321, 33);
      this.txtNewValue.TabIndex = 0;
      // 
      // btnAddNewValue
      // 
      this.btnAddNewValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnAddNewValue.Location = new System.Drawing.Point(358, 28);
      this.btnAddNewValue.Name = "btnAddNewValue";
      this.btnAddNewValue.Size = new System.Drawing.Size(88, 33);
      this.btnAddNewValue.TabIndex = 1;
      this.btnAddNewValue.Text = "++";
      this.btnAddNewValue.UseVisualStyleBackColor = true;
      this.btnAddNewValue.Click += new System.EventHandler(this.btnAddNewValue_Click);
      // 
      // lbValues
      // 
      this.lbValues.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.lbValues.FormattingEnabled = true;
      this.lbValues.ItemHeight = 26;
      this.lbValues.Location = new System.Drawing.Point(31, 75);
      this.lbValues.Name = "lbValues";
      this.lbValues.Size = new System.Drawing.Size(320, 264);
      this.lbValues.TabIndex = 2;
      // 
      // FrmMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 26F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(458, 361);
      this.Controls.Add(this.lbValues);
      this.Controls.Add(this.btnAddNewValue);
      this.Controls.Add(this.txtNewValue);
      this.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
      this.Name = "FrmMain";
      this.Text = "Form1";
      ((System.ComponentModel.ISupportInitialize)(this.txtNewValue)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.NumericUpDown txtNewValue;
    private System.Windows.Forms.Button btnAddNewValue;
    private System.Windows.Forms.ListBox lbValues;
  }
}

