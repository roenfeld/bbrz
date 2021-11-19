using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinBmiOOP
{
  class BmiCalculator
  {
    [System.ComponentModel.Description("Weight in Kg")]
    public double WeightKg { get; set; }


    private double _heightCm;
    public double HeightCm
    {
      get
      {
        return _heightCm;
      }
      set
      {
        if ( value > 40 )
          _heightCm = value;
      }
    }

    
    /// <summary>
    /// Result of the calculation
    /// </summary>
    public double BmiResult
    {
      get
      {
        double meter = this.HeightCm / 100;
        double result = this.WeightKg / (meter * meter);
        return result;
      }
    }


    public double GetBmi()
    {
      //double meter = this.HeightCm / 100;
      //// avoid DIV 0
      //if (meter == 0)
      //  meter = 0.01;

      //double result = this.WeightKg / (meter * meter);
      //return result;
      return this.BmiResult;
    }

  }

}
