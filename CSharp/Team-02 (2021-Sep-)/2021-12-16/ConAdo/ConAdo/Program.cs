using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAdo
{
  internal class Program
  {
    static void Main(string[] args)
    {
      // Server=myServerName\myInstanceName;Database=myDataBase;User Id=myUsername;Password=myPassword;
      // Data Source = 190.190.200.100; Initial Catalog = myDataBase; User ID = myUsername; Password = myPassword;
      //  Trusted_Connection=True;  Integrated Security=SSPI

      var con = new SqlConnection();
      con.ConnectionString = @"Data Source=(local)\SQL2K17; Initial Catalog=CodersBay; Integrated Security=SSPI";
      con.Open();
      Console.WriteLine("connection opened...");

      var cmd = new SqlCommand();
      cmd.Connection = con;
      cmd.CommandText = "SELECT * FROM employees";
      var rdr = cmd.ExecuteReader();

      while(rdr.Read())
      {
        Console.WriteLine($"{rdr.GetValue(0)}:{rdr.GetValue(2)} {rdr.GetValue(1)}");
      }

      con.Close();
      Console.ReadLine();
    }
  }
}
