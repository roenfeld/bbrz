using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinKreisOOP
{
  public class Kreis
  {
    public Kreis()
    {
      this.Radius = 1;
    }

    private int X { get; set; }

    public double Radius { get; set; }

    public double Umfang
    {
      get
      {
        return 2 * this.Radius * Math.PI;
      }
    }

  }



  public class KreisJ
  {
    private double _radius;

    public double getRadius()
    {
      return this._radius;
    }

    public void setRadius(double value)
    {
      this._radius = value;
    }



    public double getUmfang()
    {
      return 2 * _radius * 3.14;
    }


    public double getFlaeche()
    {
      return _radius * _radius * 3.14;
    }


    /// <summary>
    /// Roman, was diese Methode tut...
    /// </summary>
    /// <param name="menge"></param>
    /// <param name="einzelPreisEuro"></param>
    /// <param name="mwstPzt"></param>
    /// <returns></returns>
    public double CalculateVAT(double menge, double einzelPreisEuro, double mwstPzt)
    {
      double mwst = mwstPzt / 100;
      return menge * einzelPreisEuro * mwst;
    }
  }
}
