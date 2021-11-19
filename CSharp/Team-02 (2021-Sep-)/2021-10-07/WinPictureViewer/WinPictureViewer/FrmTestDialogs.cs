using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinPictureViewer
{
  public partial class FrmTestDialogs : Form
  {
    public FrmTestDialogs()
    {
      InitializeComponent();
    }

    private void btnOFD_Click(object sender, EventArgs e)
    {
      DialogResult res = openFileDialog1.ShowDialog();

      if ( res == DialogResult.OK )
      {
        lblInfo.Text = "OFD=" + openFileDialog1.FileName;
      }
    }

    private void btnSFD_Click(object sender, EventArgs e)
    {
      DialogResult res = saveFileDialog1.ShowDialog();

      if (res == DialogResult.OK)
      {
        lblInfo.Text = "SFD=" + saveFileDialog1.FileName;
      }
    }

    private void btnFontDlg_Click(object sender, EventArgs e)
    {
      DialogResult res = fontDialog1.ShowDialog();
      if ( res == DialogResult.OK )
      {
        lblInfo.Text = fontDialog1.Font.ToString();
        lblInfo.Font = fontDialog1.Font;
      }
    }

    private void btnFolderDlg_Click(object sender, EventArgs e)
    {
      DialogResult res = folderBrowserDialog1.ShowDialog();
      if ( res == DialogResult.OK )
      {
        lblInfo.Text = folderBrowserDialog1.SelectedPath;
      }
    }

    private void btnColorDlg_Click(object sender, EventArgs e)
    {
      var res = colorDialog1.ShowDialog();
      if ( res == DialogResult.OK )
      {
        lblInfo.Text = colorDialog1.Color.ToString();
        lblInfo.ForeColor = colorDialog1.Color;
      }
    }

    private void btnMessageBox_Click(object sender, EventArgs e)
    {
      //MessageBox.Show("Text");
      //MessageBox.Show(this, "Text 2");
      //MessageBox.Show("Text", "Caption");
      //MessageBox.Show("T", "C", MessageBoxButtons.YesNoCancel);

      //MessageBox.Show("T3", "I?", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Information);

      //MessageBox.Show("Fehler bei irgendwas", 
      //                "Error", 
      //                MessageBoxButtons.OK, 
      //                MessageBoxIcon.Information);


      var res = MessageBox.Show("Programm beenden?", 
                                "Frage", 
                                MessageBoxButtons.YesNo, 
                                MessageBoxIcon.Question);

      if ( res == DialogResult.Yes)
      {
        this.Close();
      }


      var caption = "Speichern unter bestätigen";
      var text = "Accept - icon.png ist bereits vorhanden.\nMöchten Sie sie ersetzen?";
      MessageBox.Show(text, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
    }


  }
}
