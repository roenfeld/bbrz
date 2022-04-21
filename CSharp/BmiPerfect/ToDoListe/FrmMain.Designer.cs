namespace ToDoListe
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
      System.Windows.Forms.Label endDateLabel;
      System.Windows.Forms.Label isDoneLabel;
      System.Windows.Forms.Label whatLabel;
      System.Windows.Forms.Label whoLabel;
      this.btnTest = new System.Windows.Forms.Button();
      this.bsTodo = new System.Windows.Forms.BindingSource(this.components);
      this.endDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
      this.isDoneCheckBox = new System.Windows.Forms.CheckBox();
      this.whatTextBox = new System.Windows.Forms.TextBox();
      this.whoTextBox = new System.Windows.Forms.TextBox();
      endDateLabel = new System.Windows.Forms.Label();
      isDoneLabel = new System.Windows.Forms.Label();
      whatLabel = new System.Windows.Forms.Label();
      whoLabel = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.bsTodo)).BeginInit();
      this.SuspendLayout();
      // 
      // btnTest
      // 
      this.btnTest.Location = new System.Drawing.Point(337, 302);
      this.btnTest.Name = "btnTest";
      this.btnTest.Size = new System.Drawing.Size(174, 43);
      this.btnTest.TabIndex = 9;
      this.btnTest.Text = "Test";
      this.btnTest.UseVisualStyleBackColor = true;
      this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
      // 
      // bsTodo
      // 
      this.bsTodo.DataSource = typeof(ToDoListe.ToDo);
      // 
      // endDateLabel
      // 
      endDateLabel.AutoSize = true;
      endDateLabel.Location = new System.Drawing.Point(39, 67);
      endDateLabel.Name = "endDateLabel";
      endDateLabel.Size = new System.Drawing.Size(105, 25);
      endDateLabel.TabIndex = 10;
      endDateLabel.Text = "End Date:";
      // 
      // endDateDateTimePicker
      // 
      this.endDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsTodo, "EndDate", true));
      this.endDateDateTimePicker.Location = new System.Drawing.Point(150, 63);
      this.endDateDateTimePicker.Name = "endDateDateTimePicker";
      this.endDateDateTimePicker.Size = new System.Drawing.Size(361, 33);
      this.endDateDateTimePicker.TabIndex = 11;
      // 
      // isDoneLabel
      // 
      isDoneLabel.AutoSize = true;
      isDoneLabel.Location = new System.Drawing.Point(39, 107);
      isDoneLabel.Name = "isDoneLabel";
      isDoneLabel.Size = new System.Drawing.Size(91, 25);
      isDoneLabel.TabIndex = 12;
      isDoneLabel.Text = "Is Done:";
      // 
      // isDoneCheckBox
      // 
      this.isDoneCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.bsTodo, "IsDone", true));
      this.isDoneCheckBox.Location = new System.Drawing.Point(150, 102);
      this.isDoneCheckBox.Name = "isDoneCheckBox";
      this.isDoneCheckBox.Size = new System.Drawing.Size(361, 24);
      this.isDoneCheckBox.TabIndex = 13;
      this.isDoneCheckBox.Text = "checkBox1";
      this.isDoneCheckBox.UseVisualStyleBackColor = true;
      // 
      // whatLabel
      // 
      whatLabel.AutoSize = true;
      whatLabel.Location = new System.Drawing.Point(39, 141);
      whatLabel.Name = "whatLabel";
      whatLabel.Size = new System.Drawing.Size(68, 25);
      whatLabel.TabIndex = 14;
      whatLabel.Text = "What:";
      // 
      // whatTextBox
      // 
      this.whatTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTodo, "What", true));
      this.whatTextBox.Location = new System.Drawing.Point(150, 138);
      this.whatTextBox.Name = "whatTextBox";
      this.whatTextBox.Size = new System.Drawing.Size(361, 33);
      this.whatTextBox.TabIndex = 15;
      // 
      // whoLabel
      // 
      whoLabel.AutoSize = true;
      whoLabel.Location = new System.Drawing.Point(39, 180);
      whoLabel.Name = "whoLabel";
      whoLabel.Size = new System.Drawing.Size(61, 25);
      whoLabel.TabIndex = 16;
      whoLabel.Text = "Who:";
      // 
      // whoTextBox
      // 
      this.whoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTodo, "Who", true));
      this.whoTextBox.Location = new System.Drawing.Point(150, 177);
      this.whoTextBox.Name = "whoTextBox";
      this.whoTextBox.Size = new System.Drawing.Size(361, 33);
      this.whoTextBox.TabIndex = 17;
      // 
      // FrmMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(583, 365);
      this.Controls.Add(endDateLabel);
      this.Controls.Add(this.endDateDateTimePicker);
      this.Controls.Add(isDoneLabel);
      this.Controls.Add(this.isDoneCheckBox);
      this.Controls.Add(whatLabel);
      this.Controls.Add(this.whatTextBox);
      this.Controls.Add(whoLabel);
      this.Controls.Add(this.whoTextBox);
      this.Controls.Add(this.btnTest);
      this.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Margin = new System.Windows.Forms.Padding(6);
      this.Name = "FrmMain";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.FrmMain_Load);
      ((System.ComponentModel.ISupportInitialize)(this.bsTodo)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.Button btnTest;
    private System.Windows.Forms.BindingSource bsTodo;
    private System.Windows.Forms.DateTimePicker endDateDateTimePicker;
    private System.Windows.Forms.CheckBox isDoneCheckBox;
    private System.Windows.Forms.TextBox whatTextBox;
    private System.Windows.Forms.TextBox whoTextBox;
  }
}

