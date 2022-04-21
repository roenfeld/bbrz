namespace BmiRechnerV1
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
      System.Windows.Forms.Label bMILabel;
      System.Windows.Forms.Label heightCmLabel;
      System.Windows.Forms.Label nameLabel;
      System.Windows.Forms.Label weightKgLabel;
      this.btnCalc = new System.Windows.Forms.Button();
      this.bMILabel1 = new System.Windows.Forms.Label();
      this.heightCmTextBox = new System.Windows.Forms.TextBox();
      this.nameTextBox = new System.Windows.Forms.TextBox();
      this.weightKgNumericUpDown = new System.Windows.Forms.NumericUpDown();
      this.bsBmi = new System.Windows.Forms.BindingSource(this.components);
      bMILabel = new System.Windows.Forms.Label();
      heightCmLabel = new System.Windows.Forms.Label();
      nameLabel = new System.Windows.Forms.Label();
      weightKgLabel = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.weightKgNumericUpDown)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.bsBmi)).BeginInit();
      this.SuspendLayout();
      // 
      // bMILabel
      // 
      bMILabel.AutoSize = true;
      bMILabel.Location = new System.Drawing.Point(55, 197);
      bMILabel.Name = "bMILabel";
      bMILabel.Size = new System.Drawing.Size(50, 23);
      bMILabel.TabIndex = 2;
      bMILabel.Text = "BMI:";
      // 
      // heightCmLabel
      // 
      heightCmLabel.AutoSize = true;
      heightCmLabel.Location = new System.Drawing.Point(55, 90);
      heightCmLabel.Name = "heightCmLabel";
      heightCmLabel.Size = new System.Drawing.Size(105, 23);
      heightCmLabel.TabIndex = 4;
      heightCmLabel.Text = "Height Cm:";
      // 
      // nameLabel
      // 
      nameLabel.AutoSize = true;
      nameLabel.Location = new System.Drawing.Point(55, 31);
      nameLabel.Name = "nameLabel";
      nameLabel.Size = new System.Drawing.Size(66, 23);
      nameLabel.TabIndex = 6;
      nameLabel.Text = "Name:";
      // 
      // weightKgLabel
      // 
      weightKgLabel.AutoSize = true;
      weightKgLabel.Location = new System.Drawing.Point(55, 136);
      weightKgLabel.Name = "weightKgLabel";
      weightKgLabel.Size = new System.Drawing.Size(104, 23);
      weightKgLabel.TabIndex = 8;
      weightKgLabel.Text = "Weight Kg:";
      // 
      // btnCalc
      // 
      this.btnCalc.Location = new System.Drawing.Point(166, 326);
      this.btnCalc.Name = "btnCalc";
      this.btnCalc.Size = new System.Drawing.Size(185, 46);
      this.btnCalc.TabIndex = 1;
      this.btnCalc.Text = "Rechnen";
      this.btnCalc.UseVisualStyleBackColor = true;
      this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
      // 
      // bMILabel1
      // 
      this.bMILabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBmi, "BMI", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N1"));
      this.bMILabel1.DataBindings.Add(new System.Windows.Forms.Binding("ForeColor", this.bsBmi, "BmiColor", true));
      this.bMILabel1.Location = new System.Drawing.Point(166, 197);
      this.bMILabel1.Name = "bMILabel1";
      this.bMILabel1.Size = new System.Drawing.Size(120, 23);
      this.bMILabel1.TabIndex = 3;
      this.bMILabel1.Text = "label1";
      // 
      // heightCmTextBox
      // 
      this.heightCmTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBmi, "HeightCm", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.heightCmTextBox.Location = new System.Drawing.Point(166, 87);
      this.heightCmTextBox.Name = "heightCmTextBox";
      this.heightCmTextBox.Size = new System.Drawing.Size(120, 30);
      this.heightCmTextBox.TabIndex = 5;
      this.heightCmTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // nameTextBox
      // 
      this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBmi, "Name", true));
      this.nameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.nameTextBox.Location = new System.Drawing.Point(166, 28);
      this.nameTextBox.Name = "nameTextBox";
      this.nameTextBox.Size = new System.Drawing.Size(359, 30);
      this.nameTextBox.TabIndex = 7;
      // 
      // weightKgNumericUpDown
      // 
      this.weightKgNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsBmi, "WeightKg", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.weightKgNumericUpDown.Location = new System.Drawing.Point(166, 136);
      this.weightKgNumericUpDown.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
      this.weightKgNumericUpDown.Name = "weightKgNumericUpDown";
      this.weightKgNumericUpDown.Size = new System.Drawing.Size(120, 30);
      this.weightKgNumericUpDown.TabIndex = 9;
      this.weightKgNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // bsBmi
      // 
      this.bsBmi.DataSource = typeof(BmiRechnerV1.BmiCalc);
      // 
      // FrmMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(659, 407);
      this.Controls.Add(bMILabel);
      this.Controls.Add(this.bMILabel1);
      this.Controls.Add(heightCmLabel);
      this.Controls.Add(this.heightCmTextBox);
      this.Controls.Add(nameLabel);
      this.Controls.Add(this.nameTextBox);
      this.Controls.Add(weightKgLabel);
      this.Controls.Add(this.weightKgNumericUpDown);
      this.Controls.Add(this.btnCalc);
      this.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Margin = new System.Windows.Forms.Padding(5);
      this.Name = "FrmMain";
      this.Text = "Form1";
      ((System.ComponentModel.ISupportInitialize)(this.weightKgNumericUpDown)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.bsBmi)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.Button btnCalc;
    private System.Windows.Forms.BindingSource bsBmi;
    private System.Windows.Forms.Label bMILabel1;
    private System.Windows.Forms.TextBox heightCmTextBox;
    private System.Windows.Forms.TextBox nameTextBox;
    private System.Windows.Forms.NumericUpDown weightKgNumericUpDown;
  }
}

