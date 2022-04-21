namespace WinDatenTypen
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
      this.btnDatum = new System.Windows.Forms.Button();
      this.timer1 = new System.Windows.Forms.Timer(this.components);
      this.btnStartStop = new System.Windows.Forms.Button();
      this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.textBox2 = new System.Windows.Forms.TextBox();
      this.numHH = new System.Windows.Forms.NumericUpDown();
      this.numMin = new System.Windows.Forms.NumericUpDown();
      ((System.ComponentModel.ISupportInitialize)(this.numHH)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numMin)).BeginInit();
      this.SuspendLayout();
      // 
      // btnDatum
      // 
      this.btnDatum.Location = new System.Drawing.Point(60, 280);
      this.btnDatum.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
      this.btnDatum.Name = "btnDatum";
      this.btnDatum.Size = new System.Drawing.Size(360, 83);
      this.btnDatum.TabIndex = 0;
      this.btnDatum.Text = "Datum...";
      this.btnDatum.UseVisualStyleBackColor = true;
      this.btnDatum.Click += new System.EventHandler(this.btnDatum_Click);
      // 
      // timer1
      // 
      this.timer1.Enabled = true;
      this.timer1.Interval = 3000;
      this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
      // 
      // btnStartStop
      // 
      this.btnStartStop.Location = new System.Drawing.Point(60, 21);
      this.btnStartStop.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
      this.btnStartStop.Name = "btnStartStop";
      this.btnStartStop.Size = new System.Drawing.Size(360, 41);
      this.btnStartStop.TabIndex = 1;
      this.btnStartStop.Text = "Start/Stop";
      this.btnStartStop.UseVisualStyleBackColor = true;
      this.btnStartStop.Click += new System.EventHandler(this.btnStartStop_Click);
      // 
      // dateTimePicker1
      // 
      this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
      this.dateTimePicker1.Location = new System.Drawing.Point(60, 120);
      this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
      this.dateTimePicker1.Name = "dateTimePicker1";
      this.dateTimePicker1.Size = new System.Drawing.Size(360, 30);
      this.dateTimePicker1.TabIndex = 2;
      // 
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(60, 177);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(60, 30);
      this.textBox1.TabIndex = 3;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(131, 180);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(17, 23);
      this.label1.TabIndex = 4;
      this.label1.Text = ":";
      // 
      // textBox2
      // 
      this.textBox2.Location = new System.Drawing.Point(154, 177);
      this.textBox2.Name = "textBox2";
      this.textBox2.Size = new System.Drawing.Size(60, 30);
      this.textBox2.TabIndex = 5;
      // 
      // numHH
      // 
      this.numHH.Location = new System.Drawing.Point(60, 229);
      this.numHH.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
      this.numHH.Name = "numHH";
      this.numHH.Size = new System.Drawing.Size(60, 30);
      this.numHH.TabIndex = 6;
      this.numHH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // numMin
      // 
      this.numMin.Location = new System.Drawing.Point(154, 229);
      this.numMin.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
      this.numMin.Name = "numMin";
      this.numMin.Size = new System.Drawing.Size(60, 30);
      this.numMin.TabIndex = 7;
      this.numMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // FrmMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(544, 402);
      this.Controls.Add(this.numMin);
      this.Controls.Add(this.numHH);
      this.Controls.Add(this.textBox2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.textBox1);
      this.Controls.Add(this.dateTimePicker1);
      this.Controls.Add(this.btnStartStop);
      this.Controls.Add(this.btnDatum);
      this.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
      this.Name = "FrmMain";
      this.Text = "Form1";
      ((System.ComponentModel.ISupportInitialize)(this.numHH)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numMin)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnDatum;
    private System.Windows.Forms.Timer timer1;
    private System.Windows.Forms.Button btnStartStop;
    private System.Windows.Forms.DateTimePicker dateTimePicker1;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.NumericUpDown numHH;
    private System.Windows.Forms.NumericUpDown numMin;
  }
}

