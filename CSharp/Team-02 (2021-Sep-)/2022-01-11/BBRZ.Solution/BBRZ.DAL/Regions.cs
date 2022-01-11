using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBRZ.DAL
{
  public class Regions
  {
    public static void Fill(DsCodersBay ds)
    {
      var ta = new DsCodersBayTableAdapters.regionsTableAdapter();
      ta.Fill(ds.regions);
      ta.Connection.Close();
    }


    public static void Update(DsCodersBay ds)
    {
      var ta = new DsCodersBayTableAdapters.regionsTableAdapter();
      ta.Update(ds.regions);
      ta.Connection.Close();
    }

  }
}
