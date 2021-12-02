using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinDataSet
{
  public partial class FrmMain : Form
  {
    const string XmlFileName = @"F:\Daten\00 Schulungsunterlagen\CodersBay\gitRepo\CSharp\01DATA\DatenBank.xml";

    public FrmMain()
    {
      InitializeComponent();
    }


    private void btnSaveData_Click(object sender, EventArgs e)
    {
      personDataGridView.EndEdit();
      bsPerson.EndEdit();
      dsMain.WriteXml(FrmMain.XmlFileName);
    }


    private void btnLoadData_Click(object sender, EventArgs e)
    {
      dsMain.ReadXml(FrmMain.XmlFileName);
    }

  }
}
