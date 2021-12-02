using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinSerPerson
{
  public partial class FrmMain : Form
  {
    const string XmlFileName = @"F:\Daten\00 Schulungsunterlagen\CodersBay\gitRepo\CSharp\01DATA\Personen_02.xml";
    
    public FrmMain()
    {
      InitializeComponent();

      bsPerson.DataSource = new List<Person>();
      this.LoadData();
    }

    private void SaveData()
    {
      var fileName = FrmMain.XmlFileName;

      var lst = bsPerson.DataSource as List<Person>;
      Person.WriteToXmlFile(fileName, lst);
    }


    private void LoadData()
    {
      var fileName = @"F:\Daten\00 Schulungsunterlagen\CodersBay\gitRepo\CSharp\01DATA\Personen.xml";
      fileName = FrmMain.XmlFileName;
      List<Person> lst = Person.ReadFromXmlFile(fileName);

      bsPerson.DataSource = lst;
    }


    private void btnSaveData_Click(object sender, EventArgs e)
    {
      this.SaveData();
    }

    private void dgvPerson_DataError(object sender, DataGridViewDataErrorEventArgs e)
    {
      e.Cancel = true;
    }
  }
}
