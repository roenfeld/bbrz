
namespace WinBmiOOP
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
      System.Windows.Forms.Label bmiResultLabel;
      System.Windows.Forms.Label heightCmLabel;
      System.Windows.Forms.Label weightKgLabel;
      this.bmiCalculatorBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.bmiResultTextBox = new System.Windows.Forms.TextBox();
      this.heightCmTextBox = new System.Windows.Forms.TextBox();
      this.weightKgTextBox = new System.Windows.Forms.TextBox();
      bmiResultLabel = new System.Windows.Forms.Label();
      heightCmLabel = new System.Windows.Forms.Label();
      weightKgLabel = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.bmiCalculatorBindingSource)).BeginInit();
      this.SuspendLayout();
      // 
      // bmiCalculatorBindingSource
      // 
      this.bmiCalculatorBindingSource.DataSource = typeof(WinBmiOOP.BmiCalculator);
      // 
      // bmiResultLabel
      // 
      bmiResultLabel.AutoSize = true;
      bmiResultLabel.Location = new System.Drawing.Point(122, 55);
      bmiResultLabel.Name = "bmiResultLabel";
      bmiResultLabel.Size = new System.Drawing.Size(104, 24);
      bmiResultLabel.TabIndex = 0;
      bmiResultLabel.Text = "Bmi Result:";
      // 
      // bmiResultTextBox
      // 
      this.bmiResultTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bmiCalculatorBindingSource, "BmiResult", true));
      this.bmiResultTextBox.Location = new System.Drawing.Point(232, 52);
      this.bmiResultTextBox.Name = "bmiResultTextBox";
      this.bmiResultTextBox.Size = new System.Drawing.Size(100, 29);
      this.bmiResultTextBox.TabIndex = 1;
      // 
      // heightCmLabel
      // 
      heightCmLabel.AutoSize = true;
      heightCmLabel.Location = new System.Drawing.Point(122, 90);
      heightCmLabel.Name = "heightCmLabel";
      heightCmLabel.Size = new System.Drawing.Size(104, 24);
      heightCmLabel.TabIndex = 2;
      heightCmLabel.Text = "Height Cm:";
      // 
      // heightCmTextBox
      // 
      this.heightCmTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bmiCalculatorBindingSource, "HeightCm", true));
      this.heightCmTextBox.Location = new System.Drawing.Point(232, 87);
      this.heightCmTextBox.Name = "heightCmTextBox";
      this.heightCmTextBox.Size = new System.Drawing.Size(100, 29);
      this.heightCmTextBox.TabIndex = 3;
      // 
      // weightKgLabel
      // 
      weightKgLabel.AutoSize = true;
      weightKgLabel.Location = new System.Drawing.Point(122, 125);
      weightKgLabel.Name = "weightKgLabel";
      weightKgLabel.Size = new System.Drawing.Size(102, 24);
      weightKgLabel.TabIndex = 4;
      weightKgLabel.Text = "Weight Kg:";
      // 
      // weightKgTextBox
      // 
      this.weightKgTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bmiCalculatorBindingSource, "WeightKg", true));
      this.weightKgTextBox.Location = new System.Drawing.Point(232, 122);
      this.weightKgTextBox.Name = "weightKgTextBox";
      this.weightKgTextBox.Size = new System.Drawing.Size(100, 29);
      this.weightKgTextBox.TabIndex = 5;
      // 
      // FrmMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(526, 283);
      this.Controls.Add(bmiResultLabel);
      this.Controls.Add(this.bmiResultTextBox);
      this.Controls.Add(heightCmLabel);
      this.Controls.Add(this.heightCmTextBox);
      this.Controls.Add(weightKgLabel);
      this.Controls.Add(this.weightKgTextBox);
      this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
      this.Name = "FrmMain";
      this.Text = "BMI Rechner";
      ((System.ComponentModel.ISupportInitialize)(this.bmiCalculatorBindingSource)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.BindingSource bmiCalculatorBindingSource;
    private System.Windows.Forms.TextBox bmiResultTextBox;
    private System.Windows.Forms.TextBox heightCmTextBox;
    private System.Windows.Forms.TextBox weightKgTextBox;
  }
}

