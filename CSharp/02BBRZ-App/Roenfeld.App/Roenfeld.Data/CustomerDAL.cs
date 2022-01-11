using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roenfeld.Data
{
  public class CustomerDAL : Roenfeld.Interfaces.IDbAdapter
  {
    public DataTable Get(string tableName)
    {
      return new DataTable() { TableName = tableName };
    }

    public int Update(DataTable dt)
    {
      return -1;
    }
  }
}
