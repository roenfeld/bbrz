namespace WinDbAutoInc
{

  partial class DsPg
  {

    public static class Loader
    {
      public static void Weather(DsPg ds)
      { 
        var ta = new DsPgTableAdapters.weatherTableAdapter();
        ta.Fill(ds.tableweather);
        ta.Connection.Close();
      }
    }

  }
}
