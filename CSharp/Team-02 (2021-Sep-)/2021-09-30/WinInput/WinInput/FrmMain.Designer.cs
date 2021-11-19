
namespace WinInput
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
      this.txtTest = new System.Windows.Forms.TextBox();
      this.btnTest = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
      this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
      this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
      this.SuspendLayout();
      // 
      // txtTest
      // 
      this.txtTest.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtTest.Location = new System.Drawing.Point(28, 55);
      this.txtTest.Name = "txtTest";
      this.txtTest.Size = new System.Drawing.Size(759, 33);
      this.txtTest.TabIndex = 0;
      this.txtTest.Text = "30.9.2021";
      this.txtTest.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // btnTest
      // 
      this.btnTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btnTest.Image = global::WinInput.Properties.Resources.Accept_icon;
      this.btnTest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnTest.Location = new System.Drawing.Point(583, 266);
      this.btnTest.Name = "btnTest";
      this.btnTest.Size = new System.Drawing.Size(204, 50);
      this.btnTest.TabIndex = 1;
      this.btnTest.Text = "OK";
      this.btnTest.UseVisualStyleBackColor = true;
      this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(23, 26);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(164, 26);
      this.label1.TabIndex = 2;
      this.label1.Text = "Datum (tt.mm.jjjj)";
      // 
      // numericUpDown1
      // 
      this.numericUpDown1.DecimalPlaces = 2;
      this.numericUpDown1.ForeColor = System.Drawing.SystemColors.WindowText;
      this.numericUpDown1.Location = new System.Drawing.Point(12, 170);
      this.numericUpDown1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
      this.numericUpDown1.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
      this.numericUpDown1.Name = "numericUpDown1";
      this.numericUpDown1.Size = new System.Drawing.Size(420, 33);
      this.numericUpDown1.TabIndex = 3;
      this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.numericUpDown1.ThousandsSeparator = true;
      // 
      // dateTimePicker1
      // 
      this.dateTimePicker1.CustomFormat = "ddd, dd. MMM. yyyy";
      this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
      this.dateTimePicker1.Location = new System.Drawing.Point(12, 237);
      this.dateTimePicker1.Name = "dateTimePicker1";
      this.dateTimePicker1.Size = new System.Drawing.Size(420, 33);
      this.dateTimePicker1.TabIndex = 4;
      // 
      // monthCalendar1
      // 
      this.monthCalendar1.CalendarDimensions = new System.Drawing.Size(2, 1);
      this.monthCalendar1.Location = new System.Drawing.Point(18, 338);
      this.monthCalendar1.MaxSelectionCount = 300;
      this.monthCalendar1.Name = "monthCalendar1";
      this.monthCalendar1.TabIndex = 5;
      // 
      // FrmMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 26F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(816, 560);
      this.Controls.Add(this.monthCalendar1);
      this.Controls.Add(this.dateTimePicker1);
      this.Controls.Add(this.numericUpDown1);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.btnTest);
      this.Controls.Add(this.txtTest);
      this.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Margin = new System.Windows.Forms.Padding(6);
      this.Name = "FrmMain";
      this.Text = "Eingabe-Test";
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox txtTest;
    private System.Windows.Forms.Button btnTest;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.NumericUpDown numericUpDown1;
    private System.Windows.Forms.DateTimePicker dateTimePicker1;
    private System.Windows.Forms.MonthCalendar monthCalendar1;
  }
}

