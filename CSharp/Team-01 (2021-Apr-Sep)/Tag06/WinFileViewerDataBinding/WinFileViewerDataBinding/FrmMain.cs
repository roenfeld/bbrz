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

namespace WinFileViewerDataBinding
{
  public partial class FrmMain : Form
  {
    public FrmMain()
    {
      InitializeComponent();
    }

    private void FrmMain_Load(object sender, EventArgs e)
    {
      SetDataBindings();
    }

    private void SetDataBindings()
    {
      var path = txtSelectedFolder.Text;
      if (string.IsNullOrEmpty(path))
        return;

      var di = new DirectoryInfo(path);
      var files = di.GetFiles();

      lbFiles.DataSource = files;
      dataGridView1.DataSource = files;
    }

    private void btnSelectFolder_Click(object sender, EventArgs e)
    {
      var dlg = new FolderBrowserDialog();
      if ( dlg.ShowDialog() == DialogResult.OK)
      {
        txtSelectedFolder.Text = dlg.SelectedPath;
        SetDataBindings();
      }
    }

    private void lbFiles_SelectedIndexChanged(object sender, EventArgs e)
    {
      var btn = lbFiles.SelectedItem as Button;
      // veraltet
      //var txt = (TextBox)lbFiles.SelectedItem;

      var item = lbFiles.SelectedItem as FileInfo;  // kann null sein !
      webMain.Navigate(item.FullName);
    }


    private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
      var fi = dataGridView1.CurrentRow.DataBoundItem as FileInfo;
      webMain.Navigate(fi.FullName);
    }


  }
}
