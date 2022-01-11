using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using Rdi = Roenfeld.Dependency;


namespace WinFormsStarter
{
  internal static class Program
  {

    static Program()
    {
      var types = new List<Type>() { typeof(FrmMain)};
      Roenfeld.Dependency.Container.Create(types);      
    }


    /// <summary>
    /// Der Haupteinstiegspunkt für die Anwendung.
    /// </summary>
    [STAThread]
    static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);

      var f = Roenfeld.Dependency.ServiceProvider.GetType<FrmMain>();

      Application.Run(f);
    }
  }
}
