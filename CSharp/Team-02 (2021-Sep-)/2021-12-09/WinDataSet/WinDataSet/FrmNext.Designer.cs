namespace WinDataSet
{
  partial class FrmNext
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
      this.components = new System.ComponentModel.Container();
      System.Windows.Forms.Label nachnameLabel;
      System.Windows.Forms.Label vornameLabel;
      this.button1 = new System.Windows.Forms.Button();
      this.dsMain = new WinDataSet.DsDaten();
      this.bsPersonen = new System.Windows.Forms.BindingSource(this.components);
      this.nachnameTextBox = new System.Windows.Forms.TextBox();
      this.vornameTextBox = new System.Windows.Forms.TextBox();
      nachnameLabel = new System.Windows.Forms.Label();
      vornameLabel = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.dsMain)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.bsPersonen)).BeginInit();
      this.SuspendLayout();
      // 
      // nachnameLabel
      // 
      nachnameLabel.AutoSize = true;
      nachnameLabel.Location = new System.Drawing.Point(27, 79);
      nachnameLabel.Name = "nachnameLabel";
      nachnameLabel.Size = new System.Drawing.Size(97, 23);
      nachnameLabel.TabIndex = 2;
      nachnameLabel.Text = "Nachname:";
      // 
      // button1
      // 
      this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.button1.Location = new System.Drawing.Point(428, 321);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(203, 39);
      this.button1.TabIndex = 0;
      this.button1.Text = "button1";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // dsMain
      // 
      this.dsMain.DataSetName = "DsDaten";
      this.dsMain.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // bsPersonen
      // 
      this.bsPersonen.DataMember = "Personen";
      this.bsPersonen.DataSource = this.dsMain;
      // 
      // nachnameTextBox
      // 
      this.nachnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsPersonen, "Nachname", true));
      this.nachnameTextBox.Location = new System.Drawing.Point(130, 76);
      this.nachnameTextBox.Name = "nachnameTextBox";
      this.nachnameTextBox.Size = new System.Drawing.Size(279, 31);
      this.nachnameTextBox.TabIndex = 3;
      // 
      // vornameLabel
      // 
      vornameLabel.AutoSize = true;
      vornameLabel.Location = new System.Drawing.Point(27, 28);
      vornameLabel.Name = "vornameLabel";
      vornameLabel.Size = new System.Drawing.Size(85, 23);
      vornameLabel.TabIndex = 3;
      vornameLabel.Text = "Vorname:";
      // 
      // vornameTextBox
      // 
      this.vornameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsPersonen, "Vorname", true));
      this.vornameTextBox.Location = new System.Drawing.Point(130, 25);
      this.vornameTextBox.Name = "vornameTextBox";
      this.vornameTextBox.Size = new System.Drawing.Size(279, 31);
      this.vornameTextBox.TabIndex = 4;
      // 
      // FrmNext
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Khaki;
      this.ClientSize = new System.Drawing.Size(643, 372);
      this.Controls.Add(vornameLabel);
      this.Controls.Add(this.vornameTextBox);
      this.Controls.Add(nachnameLabel);
      this.Controls.Add(this.nachnameTextBox);
      this.Controls.Add(this.button1);
      this.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsPersonen, "Nachname", true));
      this.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Margin = new System.Windows.Forms.Padding(5);
      this.Name = "FrmNext";
      this.Text = "Weiter...";
      ((System.ComponentModel.ISupportInitialize)(this.dsMain)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.bsPersonen)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button button1;
    private DsDaten dsMain;
    private System.Windows.Forms.BindingSource bsPersonen;
    private System.Windows.Forms.TextBox nachnameTextBox;
    private System.Windows.Forms.TextBox vornameTextBox;
  }
}