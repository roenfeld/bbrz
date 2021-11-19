using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZahlenMinMax
{
  static class Program
  {
    /// <summary>
    /// Der Haupteinstiegspunkt für die Anwendung.
    /// </summary>
    [STAThread]
    static void Main()
    {
      LinqTest();

      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run(new FrmMain());
    }


    static void LinqTest()
    {
      int[] list = { 5, 3, 7, 12, 88, 53, 27, 11};

      var min = list.Min();
      var max = list.Max();
      var sum = list.Sum();

      // comprehension syntax
      var t1 = from x in list where x > 12 select x;
      
      // Linq extension methods
      var t11 = list.Where(x => x > 12);

      var t2 = from x in list where x > 5 orderby x select x*2;
      var t22 = list.Where(x => x > 5).OrderBy(x => x).Select(x => x * 2);


      string[] names = { "Lucy", "Max", "Dave", "Walter", "Michaela", "Walter" };

      var n1 = names[0];

      int tmp = 0;
      //if (n1 == "lucy")
      //  tmp = 1;

      //// vorsicht n1 == null ?????
      //if (n1.ToLower() == "lucy".ToLower())
      //  tmp = 2;

      if ( string.Compare(n1, "luCy", true) == 0 )
        tmp = 3;

      var jn = n1.Contains("c");

      var n11 = from x in names 
                where x.Contains("a") && x.Contains("e")
                orderby x 
                select x;

      var n22 = names.Where(x => x.Contains("a")).OrderBy(x => x).ToList();
      n22.Add("Test");

      var nx = names.Where(x => x.Contains("ß")).OrderBy(x => x).FirstOrDefault();

    }



  }
}
