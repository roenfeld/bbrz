using System;
using System.Collections.Generic;
using System.Data;
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
      var cb = new SqlConnectionStringBuilder();
      cb.DataSource = @"(local)\SQL2K17";
      cb.InitialCatalog = "CodersBay";
      cb.IntegratedSecurity = true;
      
      var con = new SqlConnection();
      con.ConnectionString = cb.ConnectionString;
      con.Open();

      //var adapter = new SqlDataAdapter("SELECT * FROM employees", con);

      var cmd = new SqlCommand();
      cmd.CommandText = "SELECT * FROM employees";
      cmd.Connection = con;

      var adapter = new SqlDataAdapter();
      adapter.SelectCommand = cmd;

      var ds = new DataSet();
      adapter.Fill(ds);

      con.Close();
    }


    static void Ado_DataReader()
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
      cmd.CommandText = "SELECT * FROM locations";
      var rdr = cmd.ExecuteReader();
      
      while(rdr.Read())
      {
        Console.WriteLine($"{rdr.GetInt32(0)}:{rdr.GetValue(2)} {rdr.GetValue(1)}");
        Console.WriteLine($" {rdr.GetValue(4)}");
      }

      con.Close();
      Console.ReadLine();
    }
  }
}
