using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roenfeld.Interfaces
{
  public interface IDbAdapter
  {
    /// <summary>
    /// performs a Select * From [tableName]
    /// </summary>
    /// <param name="tableName"></param>
    /// <returns></returns>
    DataTable Get(string tableName);

    int Update(DataTable dt);
  }
}
