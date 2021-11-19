
namespace WinSerialisierung
{
  partial class FrmTest
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
      this.btnXMLSerialize = new System.Windows.Forms.Button();
      this.btnXmlDESerialize = new System.Windows.Forms.Button();
      this.btnJsonDESerialize = new System.Windows.Forms.Button();
      this.btnJsonSerialize = new System.Windows.Forms.Button();
      this.btnXmlSerializeList = new System.Windows.Forms.Button();
      this.btnXmlDESerializeList = new System.Windows.Forms.Button();
      this.btnJsonSerializeList = new System.Windows.Forms.Button();
      this.btnJsonDESerializeList = new System.Windows.Forms.Button();
      this.lbPersonen = new System.Windows.Forms.ListBox();
      this.SuspendLayout();
      // 
      // btnXMLSerialize
      // 
      this.btnXMLSerialize.Location = new System.Drawing.Point(12, 12);
      this.btnXMLSerialize.Name = "btnXMLSerialize";
      this.btnXMLSerialize.Size = new System.Drawing.Size(278, 42);
      this.btnXMLSerialize.TabIndex = 0;
      this.btnXMLSerialize.Text = "XML Serialisieren";
      this.btnXMLSerialize.UseVisualStyleBackColor = true;
      this.btnXMLSerialize.Click += new System.EventHandler(this.btnXMLSerialize_Click);
      // 
      // btnXmlDESerialize
      // 
      this.btnXmlDESerialize.Location = new System.Drawing.Point(12, 82);
      this.btnXmlDESerialize.Name = "btnXmlDESerialize";
      this.btnXmlDESerialize.Size = new System.Drawing.Size(278, 42);
      this.btnXmlDESerialize.TabIndex = 1;
      this.btnXmlDESerialize.Text = "XML DE-Serialisieren";
      this.btnXmlDESerialize.UseVisualStyleBackColor = true;
      this.btnXmlDESerialize.Click += new System.EventHandler(this.btnXmlDESerialize_Click);
      // 
      // btnJsonDESerialize
      // 
      this.btnJsonDESerialize.Location = new System.Drawing.Point(410, 82);
      this.btnJsonDESerialize.Name = "btnJsonDESerialize";
      this.btnJsonDESerialize.Size = new System.Drawing.Size(278, 42);
      this.btnJsonDESerialize.TabIndex = 3;
      this.btnJsonDESerialize.Text = "Json DE-Serialisieren";
      this.btnJsonDESerialize.UseVisualStyleBackColor = true;
      this.btnJsonDESerialize.Click += new System.EventHandler(this.btnJsonDESerialize_Click);
      // 
      // btnJsonSerialize
      // 
      this.btnJsonSerialize.Location = new System.Drawing.Point(410, 12);
      this.btnJsonSerialize.Name = "btnJsonSerialize";
      this.btnJsonSerialize.Size = new System.Drawing.Size(278, 42);
      this.btnJsonSerialize.TabIndex = 2;
      this.btnJsonSerialize.Text = "Json Serialisieren";
      this.btnJsonSerialize.UseVisualStyleBackColor = true;
      this.btnJsonSerialize.Click += new System.EventHandler(this.btnJsonSerialize_Click);
      // 
      // btnXmlSerializeList
      // 
      this.btnXmlSerializeList.Location = new System.Drawing.Point(12, 195);
      this.btnXmlSerializeList.Name = "btnXmlSerializeList";
      this.btnXmlSerializeList.Size = new System.Drawing.Size(278, 42);
      this.btnXmlSerializeList.TabIndex = 4;
      this.btnXmlSerializeList.Text = "XML Serialisieren-List";
      this.btnXmlSerializeList.UseVisualStyleBackColor = true;
      this.btnXmlSerializeList.Click += new System.EventHandler(this.btnXmlSerializeList_Click);
      // 
      // btnXmlDESerializeList
      // 
      this.btnXmlDESerializeList.Location = new System.Drawing.Point(12, 257);
      this.btnXmlDESerializeList.Name = "btnXmlDESerializeList";
      this.btnXmlDESerializeList.Size = new System.Drawing.Size(278, 42);
      this.btnXmlDESerializeList.TabIndex = 5;
      this.btnXmlDESerializeList.Text = "XML DE-Serialisieren-List";
      this.btnXmlDESerializeList.UseVisualStyleBackColor = true;
      this.btnXmlDESerializeList.Click += new System.EventHandler(this.btnXmlDESerializeList_Click);
      // 
      // btnJsonSerializeList
      // 
      this.btnJsonSerializeList.Location = new System.Drawing.Point(410, 195);
      this.btnJsonSerializeList.Name = "btnJsonSerializeList";
      this.btnJsonSerializeList.Size = new System.Drawing.Size(277, 42);
      this.btnJsonSerializeList.TabIndex = 6;
      this.btnJsonSerializeList.Text = "JSON Ser.. List";
      this.btnJsonSerializeList.UseVisualStyleBackColor = true;
      this.btnJsonSerializeList.Click += new System.EventHandler(this.btnJsonSerializeList_Click);
      // 
      // btnJsonDESerializeList
      // 
      this.btnJsonDESerializeList.Location = new System.Drawing.Point(410, 257);
      this.btnJsonDESerializeList.Name = "btnJsonDESerializeList";
      this.btnJsonDESerializeList.Size = new System.Drawing.Size(277, 42);
      this.btnJsonDESerializeList.TabIndex = 7;
      this.btnJsonDESerializeList.Text = "JSON DE-Ser.. List";
      this.btnJsonDESerializeList.UseVisualStyleBackColor = true;
      // 
      // lbPersonen
      // 
      this.lbPersonen.FormattingEnabled = true;
      this.lbPersonen.ItemHeight = 20;
      this.lbPersonen.Location = new System.Drawing.Point(12, 337);
      this.lbPersonen.Name = "lbPersonen";
      this.lbPersonen.Size = new System.Drawing.Size(278, 284);
      this.lbPersonen.TabIndex = 8;
      // 
      // FrmMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(768, 658);
      this.Controls.Add(this.lbPersonen);
      this.Controls.Add(this.btnJsonDESerializeList);
      this.Controls.Add(this.btnJsonSerializeList);
      this.Controls.Add(this.btnXmlDESerializeList);
      this.Controls.Add(this.btnXmlSerializeList);
      this.Controls.Add(this.btnJsonDESerialize);
      this.Controls.Add(this.btnJsonSerialize);
      this.Controls.Add(this.btnXmlDESerialize);
      this.Controls.Add(this.btnXMLSerialize);
      this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.Name = "FrmMain";
      this.Text = "Serialisierung";
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button btnXMLSerialize;
    private System.Windows.Forms.Button btnXmlDESerialize;
    private System.Windows.Forms.Button btnJsonDESerialize;
    private System.Windows.Forms.Button btnJsonSerialize;
    private System.Windows.Forms.Button btnXmlSerializeList;
    private System.Windows.Forms.Button btnXmlDESerializeList;
    private System.Windows.Forms.Button btnJsonSerializeList;
    private System.Windows.Forms.Button btnJsonDESerializeList;
    private System.Windows.Forms.ListBox lbPersonen;
  }
}

