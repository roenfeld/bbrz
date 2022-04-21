using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAdoTest
{
  public partial class FrmMain : Form
  {
    public FrmMain()
    {
      InitializeComponent();
    }

    private void FrmMain_Load(object sender, EventArgs e)
    {
      // TODO: Diese Codezeile lädt Daten in die Tabelle "dataSetCodersBay.employees".
      // Sie können sie bei Bedarf verschieben oder entfernen.
      this.taEmployees.Fill(this.dsMain.employees);
    }


    private void employeesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
    {
      this.Validate();
      this.bsEmployees.EndEdit();
      //this.tableAdapterManager.UpdateAll(this.dsMain);
      this.taEmployees.Update(this.dsMain.employees);
    }

    


  }
}
