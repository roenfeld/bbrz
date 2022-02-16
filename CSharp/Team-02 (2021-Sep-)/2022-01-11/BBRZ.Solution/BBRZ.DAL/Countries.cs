using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBRZ.DAL
{
  public class Countries
  {
    public static void Fill(DsCodersBay ds)
    {
      var ta = new DsCodersBayTableAdapters.countriesTableAdapter();
      ta.Fill(ds.countries);
      ta.Connection.Close();
    }


    public static void FillByRegion(DsCodersBay ds, int regionId)
    {
      var ta = new DsCodersBayTableAdapters.countriesTableAdapter();
      ta.FillByRegionId(ds.countries, regionId);
      ta.Connection.Close();
    }


    public static void Update(DsCodersBay ds)
    {
      var ta = new DsCodersBayTableAdapters.countriesTableAdapter();
      ta.Update(ds.countries);
      ta.Connection.Close();
    }
  }
}
