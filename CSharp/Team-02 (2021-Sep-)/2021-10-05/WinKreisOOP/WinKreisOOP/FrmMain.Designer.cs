
namespace WinKreisOOP
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
      this.components = new System.ComponentModel.Container();
      System.Windows.Forms.Label radiusLabel;
      System.Windows.Forms.Label umfangLabel;
      this.radiusTextBox = new System.Windows.Forms.TextBox();
      this.umfangTextBox = new System.Windows.Forms.TextBox();
      this.bsKreis = new System.Windows.Forms.BindingSource(this.components);
      this.trbRadius = new System.Windows.Forms.TrackBar();
      radiusLabel = new System.Windows.Forms.Label();
      umfangLabel = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.bsKreis)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.trbRadius)).BeginInit();
      this.SuspendLayout();
      // 
      // radiusLabel
      // 
      radiusLabel.AutoSize = true;
      radiusLabel.Location = new System.Drawing.Point(59, 55);
      radiusLabel.Name = "radiusLabel";
      radiusLabel.Size = new System.Drawing.Size(66, 23);
      radiusLabel.TabIndex = 1;
      radiusLabel.Text = "Radius:";
      // 
      // umfangLabel
      // 
      umfangLabel.AutoSize = true;
      umfangLabel.Location = new System.Drawing.Point(59, 243);
      umfangLabel.Name = "umfangLabel";
      umfangLabel.Size = new System.Drawing.Size(76, 23);
      umfangLabel.TabIndex = 3;
      umfangLabel.Text = "Umfang:";
      // 
      // radiusTextBox
      // 
      this.radiusTextBox.Location = new System.Drawing.Point(141, 52);
      this.radiusTextBox.Name = "radiusTextBox";
      this.radiusTextBox.Size = new System.Drawing.Size(270, 31);
      this.radiusTextBox.TabIndex = 2;
      // 
      // umfangTextBox
      // 
      this.umfangTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsKreis, "Umfang", true));
      this.umfangTextBox.Location = new System.Drawing.Point(141, 240);
      this.umfangTextBox.Name = "umfangTextBox";
      this.umfangTextBox.Size = new System.Drawing.Size(270, 31);
      this.umfangTextBox.TabIndex = 4;
      // 
      // bsKreis
      // 
      this.bsKreis.DataSource = typeof(WinKreisOOP.Kreis);
      // 
      // trbRadius
      // 
      this.trbRadius.Location = new System.Drawing.Point(141, 129);
      this.trbRadius.Maximum = 50;
      this.trbRadius.Name = "trbRadius";
      this.trbRadius.Size = new System.Drawing.Size(270, 45);
      this.trbRadius.TabIndex = 5;
      // 
      // FrmMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(640, 438);
      this.Controls.Add(this.trbRadius);
      this.Controls.Add(radiusLabel);
      this.Controls.Add(this.radiusTextBox);
      this.Controls.Add(umfangLabel);
      this.Controls.Add(this.umfangTextBox);
      this.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Margin = new System.Windows.Forms.Padding(5);
      this.Name = "FrmMain";
      this.Text = "Form1";
      ((System.ComponentModel.ISupportInitialize)(this.bsKreis)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.trbRadius)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.BindingSource bsKreis;
    private System.Windows.Forms.TextBox radiusTextBox;
    private System.Windows.Forms.TextBox umfangTextBox;
    private System.Windows.Forms.TrackBar trbRadius;
  }
}

