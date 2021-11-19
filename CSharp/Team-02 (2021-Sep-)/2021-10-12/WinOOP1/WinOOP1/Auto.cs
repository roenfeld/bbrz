using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinOOP1
{
  class Auto
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


    private double _kilometerStand;
    public double KilometerStand
    {
      get { return this._kilometerStand;  }
      set
      {
        if (value < 0)
          return;

        this._kilometerStand = value;

        if ( this._kilometerStand % 500 == 0)
        {
          var e = new AutoEventArgs("Ölwechsel, du Hammel!");
          this.OelWechsel?.Invoke(this, e);
        }
      }
    }


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

    #endregion


    public Auto()
    {
      this.Marke = "Unbekannt";
      this.Modell = "Keines";
      this.KilometerStand = 0;
      this.LeistungKW = 0;
      this._tankInhalt = 0.2;
    }


    #region Methods

    public override string ToString()
    {
      return $"Marke={this.Marke}, Modell={this.Modell}, Tankinhalt={this.TankInhalt} l";
    }


    public bool Fahren(double km)
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

    #endregion


    public static Auto operator +(Auto a, Auto b)
    {
      var ret = new Auto();
      ret.KilometerStand = a.KilometerStand + b.KilometerStand;
      return ret;
    }

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
