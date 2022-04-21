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

namespace WinFiles
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      var di = new DirectoryInfo(@"F:\Daten\00 Schulungsunterlagen\CodersBay\gitRepo\CSharp\Team-02 (2021-Sep-)\2021-12-09\WinDataSet\WinDataSet");

      var ar = di.GetFiles();

      dgvFiles.DataSource = null;
      bsFiles.DataSource = ar;

      dgvFiles.AutoGenerateColumns = true;
      dgvFiles.DataSource = bsFiles;
    }

    private void toolStripButton1_Click(object sender, EventArgs e)
    {
      var cur = bsFiles.Current;

      var fi = cur as FileInfo;

      MessageBox.Show(fi.Name);
    }
  }
}
