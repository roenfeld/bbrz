using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFileViewer
{
  public partial class FrmMain : Form
  {
    public FrmMain()
    {
      InitializeComponent();

      this.FillListBox();
    }

    private void btnSelectFolder_Click(object sender, EventArgs e)
    {
      this.SelectFolder();
    }

    private void SelectFolder()
    { 
      var res = dlgFolder.ShowDialog();

      if ( res == DialogResult.OK )
      {
        txtFolder.Text = dlgFolder.SelectedPath;
        this.FillListBox();
      }
    }


    private void FillListBox()
    {
      var path = txtFolder.Text;
      var pngFiles = Directory.GetFiles(path, "*.png");
      lbFiles.Items.AddRange(pngFiles);

      var icoFiles = Directory.GetFiles(path, "*.ico");
      lbFiles.Items.AddRange(icoFiles);
    }


    private void lbFiles_SelectedIndexChanged(object sender, EventArgs e)
    {
      var fileName = lbFiles.SelectedItem.ToString();

      picMain.SizeMode = PictureBoxSizeMode.CenterImage;
      picMain.ImageLocation = fileName;

      this.SelectedFileName = fileName;
    }


    private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
    {
      Properties.Settings.Default.Save();
    }

    private string SelectedFileName { get; set; }

    
    
  }
}
