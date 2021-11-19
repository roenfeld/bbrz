using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinKreisOOP
{
  class Auto
  {
    public string Marke { get; set; }
    public string Type { get; set; }
    public int Baujahr { get; set; }
    public int Zylinder { get; set; }
    public int HubraumCm3 { get; set; }

    public Auto()
    {
      this.Marke = "?";
      this.Type = "?";
    }


    public Auto(string marke, string type, int baujahr = 2000)
    {
      this.Marke = marke;
      this.Type = type;
      this.Baujahr = baujahr;
    }


  }
}
