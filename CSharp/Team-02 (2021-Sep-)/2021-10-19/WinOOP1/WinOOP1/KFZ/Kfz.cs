using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinOOP1
{
  abstract class Kfz
  {
    public string Bezeichnung { get; set; }

    protected string SerienNummer { get; set; }

    public Kfz()
    {
      this.Bezeichnung = "?";
      this.SerienNummer = "";
    }

    public Kfz(string bezeichnung) : this()
    {
      this.Bezeichnung = bezeichnung;
    }


    public virtual bool Fahren(double km)
    {
      return true;
    }


    public abstract void TuWas();


    // geht
    //protected abstract void DoIt();

    // geht nicht
    //private abstract void DoIt();
  }


  interface IMotor
  {
    int Zylinder { get; set; }

    void Meth01();
  }

}
