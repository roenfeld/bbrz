
namespace WinPictureViewer
{
  partial class FrmTestDialogs
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
      this.btnOFD = new System.Windows.Forms.Button();
      this.lblInfo = new System.Windows.Forms.Label();
      this.btnSFD = new System.Windows.Forms.Button();
      this.btnFontDlg = new System.Windows.Forms.Button();
      this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
      this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
      this.fontDialog1 = new System.Windows.Forms.FontDialog();
      this.btnFolderDlg = new System.Windows.Forms.Button();
      this.btnColorDlg = new System.Windows.Forms.Button();
      this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
      this.colorDialog1 = new System.Windows.Forms.ColorDialog();
      this.btnMessageBox = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // btnOFD
      // 
      this.btnOFD.Location = new System.Drawing.Point(37, 31);
      this.btnOFD.Name = "btnOFD";
      this.btnOFD.Size = new System.Drawing.Size(522, 56);
      this.btnOFD.TabIndex = 0;
      this.btnOFD.Text = "OpenFileDialog";
      this.btnOFD.UseVisualStyleBackColor = true;
      this.btnOFD.Click += new System.EventHandler(this.btnOFD_Click);
      // 
      // lblInfo
      // 
      this.lblInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.lblInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.lblInfo.Location = new System.Drawing.Point(37, 434);
      this.lblInfo.Name = "lblInfo";
      this.lblInfo.Size = new System.Drawing.Size(522, 95);
      this.lblInfo.TabIndex = 1;
      // 
      // btnSFD
      // 
      this.btnSFD.Location = new System.Drawing.Point(37, 93);
      this.btnSFD.Name = "btnSFD";
      this.btnSFD.Size = new System.Drawing.Size(522, 56);
      this.btnSFD.TabIndex = 2;
      this.btnSFD.Text = "SaveFileDialog";
      this.btnSFD.UseVisualStyleBackColor = true;
      this.btnSFD.Click += new System.EventHandler(this.btnSFD_Click);
      // 
      // btnFontDlg
      // 
      this.btnFontDlg.Location = new System.Drawing.Point(37, 229);
      this.btnFontDlg.Name = "btnFontDlg";
      this.btnFontDlg.Size = new System.Drawing.Size(522, 56);
      this.btnFontDlg.TabIndex = 3;
      this.btnFontDlg.Text = "FontDialog";
      this.btnFontDlg.UseVisualStyleBackColor = true;
      this.btnFontDlg.Click += new System.EventHandler(this.btnFontDlg_Click);
      // 
      // openFileDialog1
      // 
      this.openFileDialog1.FileName = "openFileDialog1";
      // 
      // btnFolderDlg
      // 
      this.btnFolderDlg.Location = new System.Drawing.Point(37, 155);
      this.btnFolderDlg.Name = "btnFolderDlg";
      this.btnFolderDlg.Size = new System.Drawing.Size(522, 56);
      this.btnFolderDlg.TabIndex = 4;
      this.btnFolderDlg.Text = "FolderBrowserDialog";
      this.btnFolderDlg.UseVisualStyleBackColor = true;
      this.btnFolderDlg.Click += new System.EventHandler(this.btnFolderDlg_Click);
      // 
      // btnColorDlg
      // 
      this.btnColorDlg.Location = new System.Drawing.Point(37, 291);
      this.btnColorDlg.Name = "btnColorDlg";
      this.btnColorDlg.Size = new System.Drawing.Size(522, 56);
      this.btnColorDlg.TabIndex = 5;
      this.btnColorDlg.Text = "ColorDialog";
      this.btnColorDlg.UseVisualStyleBackColor = true;
      this.btnColorDlg.Click += new System.EventHandler(this.btnColorDlg_Click);
      // 
      // btnMessageBox
      // 
      this.btnMessageBox.Location = new System.Drawing.Point(37, 366);
      this.btnMessageBox.Name = "btnMessageBox";
      this.btnMessageBox.Size = new System.Drawing.Size(522, 56);
      this.btnMessageBox.TabIndex = 6;
      this.btnMessageBox.Text = "MessageBox";
      this.btnMessageBox.UseVisualStyleBackColor = true;
      this.btnMessageBox.Click += new System.EventHandler(this.btnMessageBox_Click);
      // 
      // FrmTestDialogs
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(602, 553);
      this.Controls.Add(this.btnMessageBox);
      this.Controls.Add(this.btnColorDlg);
      this.Controls.Add(this.btnFolderDlg);
      this.Controls.Add(this.btnFontDlg);
      this.Controls.Add(this.btnSFD);
      this.Controls.Add(this.lblInfo);
      this.Controls.Add(this.btnOFD);
      this.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
      this.Name = "FrmTestDialogs";
      this.Text = "FrmTestDialogs";
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button btnOFD;
    private System.Windows.Forms.Label lblInfo;
    private System.Windows.Forms.Button btnSFD;
    private System.Windows.Forms.Button btnFontDlg;
    private System.Windows.Forms.OpenFileDialog openFileDialog1;
    private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    private System.Windows.Forms.FontDialog fontDialog1;
    private System.Windows.Forms.Button btnFolderDlg;
    private System.Windows.Forms.Button btnColorDlg;
    private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    private System.Windows.Forms.ColorDialog colorDialog1;
    private System.Windows.Forms.Button btnMessageBox;
  }
}