using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinAdoFilter
{
  public partial class FrmMain
  {
    private void LoadData()
    {
      this.taCountries.Fill(dsMain.countries);
    }


    private void SaveData()
    {
      this.Validate();
      this.bsCountries.EndEdit();
      this.tableAdapterManager.UpdateAll(this.dsMain);
    }

    private void FilterData()
    {
      var txt = txtRegionId.Text;
      if (txt.Trim().Length == 0)
      {
        bsCountries.RemoveFilter();
        return;
      }

      var filter = $"country_id='{txt}' OR country_name LIKE '%{txt}%'";
      bsCountries.Filter = filter;
    }
  }
}
