using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinDbCountries
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
      this.tableAdapterManager.UpdateAll(this.dsMain);

    }

    private void FrmMain_Load(object sender, EventArgs e)
    {
      // TODO: Diese Codezeile lädt Daten in die Tabelle "dsCodersBay.countries". Sie können sie bei Bedarf verschieben oder entfernen.
      this.countriesTableAdapter.Fill(this.dsMain.countries);

      bsCountries.Filter = "region_id=1";
    }

    private void btnTest_Click(object sender, EventArgs e)
    {
      var cur = bsCountries.Current;
      var rv = cur as DataRowView;
      //var rv = bsCountries.Current as DataRowView;

      var country = rv.Row as DsCodersBay.countriesRow;
      //country.region_id = 1;

      MessageBox.Show($"{country.country_name}", "Aktuelles Element");

      country = dsMain.countries.Rows[9] as DsCodersBay.countriesRow;
      MessageBox.Show($"{country.country_name}", "10. Element");
    }
  }
}
