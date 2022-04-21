using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAdoTest02
{
  public partial class FrmMain : Form
  {
    public FrmMain()
    {
      InitializeComponent();
    }

    private void countriesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
    {
      this.Validate();
      this.bsCountries.EndEdit();
      //this.tableAdapterManager.UpdateAll(this.dsMain);
      this.taCountries.Update(this.dsMain.countries);
    }

    private void FrmMain_Load(object sender, EventArgs e)
    {
      // TODO: Diese Codezeile lädt Daten in die Tabelle "dataSetCodersBay.countries". Sie können sie bei Bedarf verschieben oder entfernen.
      this.taCountries.Fill(this.dsMain.countries);
    }

  }
}
