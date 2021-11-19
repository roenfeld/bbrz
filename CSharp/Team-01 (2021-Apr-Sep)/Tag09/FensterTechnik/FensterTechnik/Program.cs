using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FensterTechnik
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

      var f = new FrmEins();
      Application.Run(f);
    }
  }



  class ClA
  {
    public int wert;
    protected string name;
  }


  class ClB : ClA
  {
    void XY()
    {
      wert = 17;
      name = "heinzi";
    }

  }

}
