
namespace FensterTechnik
{
  partial class FrmTab
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTab));
      this.tabControl1 = new System.Windows.Forms.TabControl();
      this.tpName = new System.Windows.Forms.TabPage();
      this.label2 = new System.Windows.Forms.Label();
      this.dtBirthday = new System.Windows.Forms.DateTimePicker();
      this.txtName = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.tpAddress = new System.Windows.Forms.TabPage();
      this.txtAddress = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.imgTabControl = new System.Windows.Forms.ImageList(this.components);
      this.btnOK = new System.Windows.Forms.Button();
      this.tabControl1.SuspendLayout();
      this.tpName.SuspendLayout();
      this.tpAddress.SuspendLayout();
      this.SuspendLayout();
      // 
      // tabControl1
      // 
      this.tabControl1.Controls.Add(this.tpName);
      this.tabControl1.Controls.Add(this.tpAddress);
      this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tabControl1.ImageList = this.imgTabControl;
      this.tabControl1.ItemSize = new System.Drawing.Size(156, 36);
      this.tabControl1.Location = new System.Drawing.Point(6, 6);
      this.tabControl1.Multiline = true;
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new System.Drawing.Size(600, 317);
      this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
      this.tabControl1.TabIndex = 0;
      this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
      // 
      // tpName
      // 
      this.tpName.Controls.Add(this.label2);
      this.tpName.Controls.Add(this.dtBirthday);
      this.tpName.Controls.Add(this.txtName);
      this.tpName.Controls.Add(this.label1);
      this.tpName.ImageKey = "Accept-icon.png";
      this.tpName.Location = new System.Drawing.Point(4, 40);
      this.tpName.Name = "tpName";
      this.tpName.Padding = new System.Windows.Forms.Padding(3);
      this.tpName.Size = new System.Drawing.Size(592, 273);
      this.tpName.TabIndex = 0;
      this.tpName.Text = "Name";
      this.tpName.UseVisualStyleBackColor = true;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(38, 154);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(101, 24);
      this.label2.TabIndex = 3;
      this.label2.Text = "Geburtstag";
      // 
      // dtBirthday
      // 
      this.dtBirthday.Location = new System.Drawing.Point(42, 192);
      this.dtBirthday.Name = "dtBirthday";
      this.dtBirthday.Size = new System.Drawing.Size(339, 29);
      this.dtBirthday.TabIndex = 2;
      // 
      // txtName
      // 
      this.txtName.Location = new System.Drawing.Point(42, 80);
      this.txtName.Name = "txtName";
      this.txtName.Size = new System.Drawing.Size(339, 29);
      this.txtName.TabIndex = 1;
      this.txtName.Text = "CodersBay";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(38, 38);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(61, 24);
      this.label1.TabIndex = 0;
      this.label1.Text = "Name";
      // 
      // tpAddress
      // 
      this.tpAddress.Controls.Add(this.txtAddress);
      this.tpAddress.Controls.Add(this.label3);
      this.tpAddress.ImageIndex = 1;
      this.tpAddress.Location = new System.Drawing.Point(4, 40);
      this.tpAddress.Name = "tpAddress";
      this.tpAddress.Padding = new System.Windows.Forms.Padding(3);
      this.tpAddress.Size = new System.Drawing.Size(592, 273);
      this.tpAddress.TabIndex = 1;
      this.tpAddress.Text = "Adresse";
      this.tpAddress.UseVisualStyleBackColor = true;
      // 
      // txtAddress
      // 
      this.txtAddress.Location = new System.Drawing.Point(129, 153);
      this.txtAddress.Name = "txtAddress";
      this.txtAddress.Size = new System.Drawing.Size(339, 29);
      this.txtAddress.TabIndex = 3;
      this.txtAddress.Text = "Kapfenberg";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(125, 111);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(80, 24);
      this.label3.TabIndex = 2;
      this.label3.Text = "Adresse";
      // 
      // imgTabControl
      // 
      this.imgTabControl.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgTabControl.ImageStream")));
      this.imgTabControl.TransparentColor = System.Drawing.Color.Transparent;
      this.imgTabControl.Images.SetKeyName(0, "Accept-icon.png");
      this.imgTabControl.Images.SetKeyName(1, "Information.png");
      this.imgTabControl.Images.SetKeyName(2, "Attention.png");
      this.imgTabControl.Images.SetKeyName(3, "Copy.png");
      // 
      // btnOK
      // 
      this.btnOK.Location = new System.Drawing.Point(472, 339);
      this.btnOK.Name = "btnOK";
      this.btnOK.Size = new System.Drawing.Size(130, 34);
      this.btnOK.TabIndex = 1;
      this.btnOK.Text = "OK";
      this.btnOK.UseVisualStyleBackColor = true;
      this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
      // 
      // FrmTab
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(612, 389);
      this.Controls.Add(this.btnOK);
      this.Controls.Add(this.tabControl1);
      this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Margin = new System.Windows.Forms.Padding(6);
      this.Name = "FrmTab";
      this.Padding = new System.Windows.Forms.Padding(6, 6, 6, 66);
      this.Text = "TabControl";
      this.tabControl1.ResumeLayout(false);
      this.tpName.ResumeLayout(false);
      this.tpName.PerformLayout();
      this.tpAddress.ResumeLayout(false);
      this.tpAddress.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage tpName;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.DateTimePicker dtBirthday;
    private System.Windows.Forms.TextBox txtName;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TabPage tpAddress;
    private System.Windows.Forms.TextBox txtAddress;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Button btnOK;
    private System.Windows.Forms.ImageList imgTabControl;
  }
}

