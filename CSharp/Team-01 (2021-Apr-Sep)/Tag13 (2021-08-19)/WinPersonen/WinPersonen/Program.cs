using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinPersonen
{
  static class Program
  {
    /// <summary>
    /// Der Haupteinstiegspunkt für die Anwendung.
    /// </summary>
    [STAThread]
    static void Main()
    {
      //TestPerson();

      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run(new FrmMain());
    }


    private static void TestPerson()
    {
      var fileName = @"F:\Daten\00 Schulungsunterlagen\CodersBay\CSharp\Tag13 (2021-08-19)\WinPersonen\TestPerson.xml";

      var lst = new List<Person>();

      var p = new Person();
      p.Name = "Attila";
      p.BirthDay = DateTime.Now;
      p.Phone = "+43 664 123456";

      lst.Add(p);

      Person.WriteXml(fileName, lst);        
    }


  }
}
