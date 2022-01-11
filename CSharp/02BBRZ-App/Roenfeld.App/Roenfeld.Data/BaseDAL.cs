using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roenfeld.Data
{
  public class BaseDAL : Roenfeld.Interfaces.IDbAdapter
  {
    public static DataTable GetProviderFactoryClasses()
    {
      // Retrieve the installed providers and factories.
      DataTable table = DbProviderFactories.GetFactoryClasses();

      // Display each row and column value.
      foreach (DataRow row in table.Rows)
      {
        foreach (DataColumn column in table.Columns)
        {
          Console.WriteLine(row[column]);
        }
      }
      return table;
    }

    public DataTable Get(string tableName)
    {
      var dt = new DataTable();
      //var con = DbFactory
      return dt;
    }

    public int Update(DataTable dt)
    {
      throw new NotImplementedException();
    }
  }
}
