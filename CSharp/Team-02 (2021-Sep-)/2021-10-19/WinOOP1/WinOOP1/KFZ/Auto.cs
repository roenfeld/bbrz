using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinOOP1
{
  
  class Auto : Kfz, IMotor
  {
    public class AutoEventArgs : EventArgs
    {
      public AutoEventArgs(string s)
      {
        this.Message = s;
      }
      public string Message { get; private set; }
    }

    public event EventHandler<EventArgs> ZuwenigSprit;
    public event EventHandler<AutoEventArgs> OelWechsel;


    #region Properties

    public string Marke { get; set; }
    public string Modell { get; set; }

    public int LeistungKW { get; set; }
    public double KilometerStand { get; set; }


    private double _tankInhalt;
    public double TankInhalt
    {
      get
      {
        return this._tankInhalt;
      }
      set
      {
        _tankInhalt = value;
      }
    }

    public int Zylinder { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }


    #endregion

    public void Meth01()
    {
      throw new NotImplementedException();
    }


    public Auto() : base("Auto")
    {
      this.Marke = "Unbekannt";
      this.Modell = "Keines";
      this.KilometerStand = 0;
      this.LeistungKW = 0;
      this._tankInhalt = 0.2;

      this.SerienNummer = "000-000";
    }

    public Auto(string marke) : this()
    {
      this.Marke = marke;
    }

    public Auto(string marke, string modell) : this(marke)
    {
      this.Modell = modell;
      this.LeistungKW = 88;
    }



    #region Methods

    public override string ToString()
    {
      return $"Marke={this.Marke}, Modell={this.Modell}, Tankinhalt={this.TankInhalt} l";
    }


    public override bool Fahren(double km)
    {
      var verbrauch = 0.05 * km;
      if (verbrauch > this.TankInhalt)
      {
        var handler = this.ZuwenigSprit;
        if (handler != null)
          handler(this, EventArgs.Empty);

        return false;
      }
      this.KilometerStand += km;
      this.TankInhalt -= verbrauch;

      return true;
    }


    public bool Fahren(int km)
    {
      this.Fahren((double)km);
      return true;
    }


    public bool Fahren(double km, double verbrauchP100Km)
    {
      return true;
    }

    


    #endregion


    public static string[] GetMarken()
    {
      var s = new string[] { "Audi", "BMW", "Citroen", "Dacia", "Fiat", "Gumpert" };
      return s;
    }

    // Properties & Methoden sind nahe Verwandte!!!
    //public static string[] Marken
    //{
    //  get
    //  {
    //    var s = new string[] { "Audi", "BMW", "Citroen", "Dacia", "Fiat" };
    //    return s;
    //  }
    //}


    public static string[] GetTypen(string marke)
    {
      if (marke == "Opel")
        return new string[] { "Astra", "B-Kadett", "Zafira" };

      if (marke == "BMW")
        return new string[] { "1er", "B-2er", "320" };

      return null;
    }



    public override void TuWas()
    {
    }

    


    //public static Auto operator +(Auto a, Auto b)
    //{
    //  var ret = new Auto();
    //  ret.KilometerStand = a.KilometerStand + b.KilometerStand;
    //  return ret;
    //}

  }


  struct Motor
  {
    public double BetriebsStunden { get; set; }
    public string MotorNummer { get; set; }

    public void Starten(double stunden)
    {
      this.BetriebsStunden += stunden;
    }
  }
}


namespace BBRZ
{
  class Person
  {
  }

  class Auto : WinOOP1.Auto
  {
    public string FIN { get; set; }
  }
}
