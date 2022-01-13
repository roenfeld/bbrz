using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
  public partial class DsCodersBay
  {
    public static void FillRegions(DsCodersBay ds)
    {
      var ta = new DAL.DsCodersBayTableAdapters.regionsTableAdapter();
      ta.Fill(ds.regions);
      ta.Connection.Close();
    }


    public static void FillCountries(DsCodersBay ds)
    {
      var ta = new DsCodersBayTableAdapters.countriesTableAdapter();
      ta.Fill(ds.countries);
      ta.Connection.Close();
    }

    public static void FillCountries(DsCodersBay ds, int? regionId)
    {
      if (ds == null || regionId == null)
        return;
      var ta = new DsCodersBayTableAdapters.countriesTableAdapter();
      ta.FillByRegionId(ds.countries, regionId.Value);
      ta.Connection.Close();
    }


  }

}
