namespace WinSort
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
      this.btnInit = new System.Windows.Forms.Button();
      this.lblStatus = new System.Windows.Forms.Label();
      this.btnBubbleSort = new System.Windows.Forms.Button();
      this.btnMergeSort = new System.Windows.Forms.Button();
      this.btnNetSort = new System.Windows.Forms.Button();
      this.btnQuickSort = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // btnInit
      // 
      this.btnInit.Location = new System.Drawing.Point(30, 30);
      this.btnInit.Name = "btnInit";
      this.btnInit.Size = new System.Drawing.Size(257, 48);
      this.btnInit.TabIndex = 0;
      this.btnInit.Text = "Initialisiere Array";
      this.btnInit.UseVisualStyleBackColor = true;
      this.btnInit.Click += new System.EventHandler(this.btnInit_Click);
      // 
      // lblStatus
      // 
      this.lblStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.lblStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.lblStatus.Location = new System.Drawing.Point(0, 324);
      this.lblStatus.Name = "lblStatus";
      this.lblStatus.Size = new System.Drawing.Size(632, 31);
      this.lblStatus.TabIndex = 1;
      this.lblStatus.Text = "...";
      this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // btnBubbleSort
      // 
      this.btnBubbleSort.Location = new System.Drawing.Point(30, 125);
      this.btnBubbleSort.Name = "btnBubbleSort";
      this.btnBubbleSort.Size = new System.Drawing.Size(257, 48);
      this.btnBubbleSort.TabIndex = 2;
      this.btnBubbleSort.Text = "Bubble Sort";
      this.btnBubbleSort.UseVisualStyleBackColor = true;
      this.btnBubbleSort.Click += new System.EventHandler(this.btnBubbleSort_Click);
      // 
      // btnMergeSort
      // 
      this.btnMergeSort.Location = new System.Drawing.Point(30, 203);
      this.btnMergeSort.Name = "btnMergeSort";
      this.btnMergeSort.Size = new System.Drawing.Size(257, 48);
      this.btnMergeSort.TabIndex = 3;
      this.btnMergeSort.Text = "Merge Sort";
      this.btnMergeSort.UseVisualStyleBackColor = true;
      this.btnMergeSort.Click += new System.EventHandler(this.btnMergeSort_Click);
      // 
      // btnNetSort
      // 
      this.btnNetSort.Location = new System.Drawing.Point(336, 125);
      this.btnNetSort.Name = "btnNetSort";
      this.btnNetSort.Size = new System.Drawing.Size(257, 48);
      this.btnNetSort.TabIndex = 4;
      this.btnNetSort.Text = ".NET Sort";
      this.btnNetSort.UseVisualStyleBackColor = true;
      this.btnNetSort.Click += new System.EventHandler(this.btnNetSort_Click);
      // 
      // btnQuickSort
      // 
      this.btnQuickSort.Location = new System.Drawing.Point(336, 203);
      this.btnQuickSort.Name = "btnQuickSort";
      this.btnQuickSort.Size = new System.Drawing.Size(257, 48);
      this.btnQuickSort.TabIndex = 5;
      this.btnQuickSort.Text = "Quick Sort";
      this.btnQuickSort.UseVisualStyleBackColor = true;
      this.btnQuickSort.Click += new System.EventHandler(this.btnQuickSort_Click);
      // 
      // FrmMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(632, 355);
      this.Controls.Add(this.btnQuickSort);
      this.Controls.Add(this.btnNetSort);
      this.Controls.Add(this.btnMergeSort);
      this.Controls.Add(this.btnBubbleSort);
      this.Controls.Add(this.lblStatus);
      this.Controls.Add(this.btnInit);
      this.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
      this.Name = "FrmMain";
      this.Text = "Form1";
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button btnInit;
    private System.Windows.Forms.Label lblStatus;
    private System.Windows.Forms.Button btnBubbleSort;
    private System.Windows.Forms.Button btnMergeSort;
    private System.Windows.Forms.Button btnNetSort;
    private System.Windows.Forms.Button btnQuickSort;
  }
}

