using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinTest
{
  public partial class FrmTest : Form
  {

    public FrmTest()
    {
      InitializeComponent();

      //this.FillFileListBox();
    }


    private void btnSelectFolder_Click(object sender, EventArgs e)
    {
      //DialogResult res = dlgFolder.ShowDialog();

      //if (res == DialogResult.OK)
      //{
      //  var path = dlgFolder.SelectedPath;
      //  txtFolder.Text = path;
      //}

      //var dlg = new OpenFileDialog();
      //var res = dlg.ShowDialog();

      //if ( res == DialogResult.OK)
      //{
      //  txtFolder.Text = dlg.FileName;
      //}
      
      this.SelectFolder();
    }


    private void SelectFolder()
    {
      DialogResult res = dlgFolder.ShowDialog();

      if (res == DialogResult.OK)
      {
        var path = dlgFolder.SelectedPath;
        txtFolder.Text = path;
        this.FillFileListBox();
      }
    }


    private void FillFileListBox()
    {
      lbFiles.Items.Clear();

      var path = txtFolder.Text;

      var pngFiles = Directory.GetFiles(path, "*.png");
      lbFiles.Items.AddRange(pngFiles);

      var icoFiles = Directory.GetFiles(path, "*.ico");
      lbFiles.Items.AddRange(icoFiles);
    }


    private void lbFiles_SelectedIndexChanged(object sender, EventArgs e)
    {
      //var sel = lbFiles.Items[lbFiles.SelectedIndex];
      //var sel = lbFiles.SelectedItem;
      picMain.ImageLocation = lbFiles.SelectedItem.ToString();
    }


    private void FrmTest_FormClosed(object sender, FormClosedEventArgs e)
    {
      WinTest.Properties.Settings.Default.Save();
    }

  }
}
