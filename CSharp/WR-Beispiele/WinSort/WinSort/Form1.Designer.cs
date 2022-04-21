namespace WinSort
{
  partial class Form1
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
      this.btnCreateArray = new System.Windows.Forms.Button();
      this.btnBubbleSort = new System.Windows.Forms.Button();
      this.btnSort = new System.Windows.Forms.Button();
      this.lstVals = new System.Windows.Forms.ListBox();
      this.btnCallByValue = new System.Windows.Forms.Button();
      this.btnFnEvtHdl = new System.Windows.Forms.Button();
      this.btnEvtHdl = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // btnCreateArray
      // 
      this.btnCreateArray.Location = new System.Drawing.Point(12, 12);
      this.btnCreateArray.Name = "btnCreateArray";
      this.btnCreateArray.Size = new System.Drawing.Size(155, 34);
      this.btnCreateArray.TabIndex = 0;
      this.btnCreateArray.Text = "Erstellen";
      this.btnCreateArray.UseVisualStyleBackColor = true;
      this.btnCreateArray.Click += new System.EventHandler(this.btnCreateArray_Click);
      // 
      // btnBubbleSort
      // 
      this.btnBubbleSort.Location = new System.Drawing.Point(204, 12);
      this.btnBubbleSort.Name = "btnBubbleSort";
      this.btnBubbleSort.Size = new System.Drawing.Size(155, 34);
      this.btnBubbleSort.TabIndex = 1;
      this.btnBubbleSort.Text = "Sortieren 1";
      this.btnBubbleSort.UseVisualStyleBackColor = true;
      this.btnBubbleSort.Click += new System.EventHandler(this.btnBubbleSort_Click);
      // 
      // btnSort
      // 
      this.btnSort.Location = new System.Drawing.Point(381, 12);
      this.btnSort.Name = "btnSort";
      this.btnSort.Size = new System.Drawing.Size(155, 34);
      this.btnSort.TabIndex = 2;
      this.btnSort.Text = "Sortieren 2";
      this.btnSort.UseVisualStyleBackColor = true;
      this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
      // 
      // lstVals
      // 
      this.lstVals.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.lstVals.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lstVals.FormattingEnabled = true;
      this.lstVals.ItemHeight = 24;
      this.lstVals.Location = new System.Drawing.Point(12, 78);
      this.lstVals.Name = "lstVals";
      this.lstVals.Size = new System.Drawing.Size(347, 436);
      this.lstVals.TabIndex = 3;
      // 
      // btnCallByValue
      // 
      this.btnCallByValue.Location = new System.Drawing.Point(499, 78);
      this.btnCallByValue.Name = "btnCallByValue";
      this.btnCallByValue.Size = new System.Drawing.Size(155, 34);
      this.btnCallByValue.TabIndex = 4;
      this.btnCallByValue.Text = "Call By Value";
      this.btnCallByValue.UseVisualStyleBackColor = true;
      this.btnCallByValue.Click += new System.EventHandler(this.btnCallByValue_Click);
      // 
      // btnFnEvtHdl
      // 
      this.btnFnEvtHdl.Location = new System.Drawing.Point(499, 321);
      this.btnFnEvtHdl.Name = "btnFnEvtHdl";
      this.btnFnEvtHdl.Size = new System.Drawing.Size(155, 34);
      this.btnFnEvtHdl.TabIndex = 5;
      this.btnFnEvtHdl.Text = "Fn-Evt-Handling";
      this.btnFnEvtHdl.UseVisualStyleBackColor = true;
      // 
      // btnEvtHdl
      // 
      this.btnEvtHdl.Location = new System.Drawing.Point(499, 259);
      this.btnEvtHdl.Name = "btnEvtHdl";
      this.btnEvtHdl.Size = new System.Drawing.Size(155, 34);
      this.btnEvtHdl.TabIndex = 6;
      this.btnEvtHdl.Text = "Evt-Handling";
      this.btnEvtHdl.UseVisualStyleBackColor = true;
      this.btnEvtHdl.Click += new System.EventHandler(this.btnEvtHdl_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(694, 524);
      this.Controls.Add(this.btnEvtHdl);
      this.Controls.Add(this.btnFnEvtHdl);
      this.Controls.Add(this.btnCallByValue);
      this.Controls.Add(this.lstVals);
      this.Controls.Add(this.btnSort);
      this.Controls.Add(this.btnBubbleSort);
      this.Controls.Add(this.btnCreateArray);
      this.Name = "Form1";
      this.Text = "Form1";
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button btnCreateArray;
    private System.Windows.Forms.Button btnBubbleSort;
    private System.Windows.Forms.Button btnSort;
    private System.Windows.Forms.ListBox lstVals;
    private System.Windows.Forms.Button btnCallByValue;
    private System.Windows.Forms.Button btnFnEvtHdl;
    private System.Windows.Forms.Button btnEvtHdl;
  }
}

