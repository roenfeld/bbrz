using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinOOP1
{
  static class Program
  {
    /// <summary>
    /// Der Haupteinstiegspunkt für die Anwendung.
    /// </summary>
    [STAThread]
    static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);

      FrmMain f = new FrmMain();
      f.Gewicht = -55;
      f.EMail = "walter@xyz.cc";
      // Compiler baut das um...
      //f.set_EMail("walter@xyz.cc");

      int a = f.Alter;
      Application.Run(f);
    }


    //static void TestDeclarations()
    //{
    //  // EXPLIZITe Variablen-Deklaration
    //  int i;
    //  i = 6;
    //  int j = 5;

    //  double x = 3.14;
    //  float f = 2.17f;
    //  decimal d = 0.5m;

    //  string name = "Max";

    //  Auto a = new Auto();

    //  // IMPLIZITe Variablen-Deklaration
    //  //var k;
    //  var idx = 5;

    //  var modell = "320";

    //  var pi = 3.14;
    //  var e = 2.17m;

    //  var au = new Auto();
    //}


    static void TestStack()
    {
      int i;
      i = 5;

      if ( i > 10 )
      {
        int x = 12;

        if ( x == 27 )
        {
          double d = 3.14;
        }
      }
    }


    public static void TestStruct(Motor mo)
    {
      mo.Starten(1);
    }
  }
}
