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

namespace WinImgViewerWH
{
  public partial class FrmDataBinding : Form
  {
    public FrmDataBinding()
    {
      InitializeComponent();
    }

    private void FrmDataBinding_Load(object sender, EventArgs e)
    {
      var path = @"F:\Daten\00 Schulungsunterlagen\CodersBay\Icons";

      var di = new DirectoryInfo(path);
      var fis = di.GetFiles();

      listBox1.DataSource = fis;
      listBox1.DisplayMember = nameof(FileInfo.Name);
      listBox1.ValueMember = nameof(FileInfo.FullName);
    }


    private void listBox1_DoubleClick(object sender, EventArgs e)
    {
      //var txt = listBox1.Text;
      var item = listBox1.SelectedItem;
      var value = listBox1.SelectedValue;

      MessageBox.Show(item + "\n" + value, 
        "Info", 
        MessageBoxButtons.OK, 
        MessageBoxIcon.Information);
    }


  }

}
