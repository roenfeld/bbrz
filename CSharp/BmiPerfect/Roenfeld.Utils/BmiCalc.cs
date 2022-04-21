using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Model = Document => DATEN

//        Document-View-Pattern
// MVC  : Model View Controller
// MVVM : Model View ViewModel
namespace Roenfeld.Utils
{
  public class BmiCalc
  {
    public double HeightCm { get; set; }
    public double WeightKg { get; set; }

    public double Bmi
    {
      get
      {
        var m = this.HeightCm / 100;
        var m2 = m * m;
        var bmi = this.WeightKg / m2;
        return bmi;
      }
    }
  }
}
