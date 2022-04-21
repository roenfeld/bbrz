using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace WinProps
{
  internal static class Program
  {
    static int X = 27;

    /// <summary>
    /// Der Haupteinstiegspunkt für die Anwendung.
    /// </summary>
    [STAThread]
    static void Main()
    {
      Program.GetX();

      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run(new FrmMain());
    }


    public static int GetX()
    {
      return Program.X;
    }


    public static void Test()
    {
      Directory.CreateDirectory(@"C:\Temp\Test");

      Directory.Delete(@"C:\Temp\Test");
    }


  }
}
