using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Diagnostics;

namespace BmiRechnerV1
{
  // GUI = Graph... User INTERFACE
  public class BmiCalc : object, INotifyPropertyChanged
  {
    public event EventHandler<EventArgs> BmiAlarm;
    public event PropertyChangedEventHandler PropertyChanged;

    public const double MinHeightCm = 31;

    public BmiCalc()
    {
      this.Name = "?";
      this.HeightCm = MinHeightCm;
      this.WeightKg = MinHeightCm;
    }

    public BmiCalc(string name) : this()
    {
      this.Name = name;
    }

    public BmiCalc(string name, double weightKg) : this(name)
    {
      this.WeightKg = weightKg;
    }

    public BmiCalc(string name, double weightKg, double heightCm) : this(name, weightKg)
    {
      this.Name = name;
      this.HeightCm = heightCm;
      this.WeightKg = weightKg;
    }


    protected double _heightCm;
    public double HeightCm
    {
      get
      {
        return this._heightCm;
      }
      set
      {
        if (value >= BmiCalc.MinHeightCm && value != this._heightCm)
        {
          this._heightCm = value;

          this.RaisePropertyChangedEvent(nameof(HeightCm));
          this.RaisePropertyChangedEvent(nameof(BMI));

          this.CheckBMI_AndRaiseEvent();
        }
      }
    }



    private double _weightKg;
    public double WeightKg
    {
      get { return _weightKg; } 
      set 
      {
        if (value >= 2 && value != this._weightKg)
        {
          this._weightKg = value;

          this.RaisePropertyChangedEvent(nameof(WeightKg));
          this.RaisePropertyChangedEvent(nameof(BMI));
          this.RaisePropertyChangedEvent(nameof(BmiColor));

          this.CheckBMI_AndRaiseEvent();
        }
      }
    }


    public string Name
    {
      get; set;
    }


    public double BMI
    {
      get
      {
        var m = this.HeightCm / 100;
        var m2 = m * m;
        var bmi = this.WeightKg / m2;
        return bmi;
      }
    }


    /// <summary>
    /// Prüfe den BMI und ggfalls Event %NAME% auslösen
    /// </summary>
    private void CheckBMI_AndRaiseEvent()
    {
      if (this.BMI >= 30)
      {
        // NICHT THREAD-SAFE
        //if ( this.BmiAlarm != null )
        //  BmiAlarm(this, EventArgs.Empty);
        
        // THREAD-SAFE
        var handler = this.BmiAlarm;
        if (handler != null)
          handler(this, EventArgs.Empty);

        // Version Elvis-Operator (NET 4.5++)
        //this.BmiAlarm?.Invoke(this, EventArgs.Empty);  
      }
    }


    private void RaisePropertyChangedEvent(string propertyName)
    {
      Debug.WriteLine($"RaisePropertyChangedEvent_01: {this.Name}: {propertyName}");

      var evt = this.PropertyChanged;
      if (evt != null)
      {
        Debug.WriteLine($"RaisePropertyChangedEvent_02: {propertyName}");
        var args = new PropertyChangedEventArgs(propertyName);
        evt(this, args);
      }
    }


    //public double get_Bmi()
    //{
    //  var m = this.HeightCm / 100;
    //  var m2 = m * m;
    //  var bmi = this.WeightKg / m2;
    //  return bmi;
    //}


    public Color BmiColor
    {
      get
      {
        if (this.BMI >= 30)
          return Color.Red;
        if (this.BMI >= 25)
          return Color.Orange;
        else
          return Color.Green;
      }
    }


    // Auto Property
    //public double Weight { get; set; }
    //double backingField_weightKg;
    //public double get_WeightKg() { return  backingField_weightKg; }
    //public void set_WeightKg(double value) { backingField_weightKg = value; }

  }


  public class BmiCalcDate : BmiCalc
  {
    public BmiCalcDate() 
    {
      this.Date = DateTime.Now;
    }

    public BmiCalcDate(DateTime d) : this()
    {
      this.Date = d;
    }

    public DateTime Date { get; set; }
  }


  public interface IMickeyMouse
  {
    string Name { get; set; }

    void XY();    
  }

  public class WordFile : IMickeyMouse
  {
    public string Name { get; set; }

    public void XY()
    {      
    }
  }

  public class ExcelFile : IMickeyMouse
  {
    public string Name { get; set; }

    public void XY()
    {      
    }
  }

  public class FileChecker
  {
    void Test()
    {
      var w = new WordFile();
      this.CheckFile(w);

      var x = new ExcelFile();
      this.CheckFile(x);
    }

    public Boolean CheckFile(IMickeyMouse f)
    {
      if (f.Name == null)
        return false;

      return true;
    }

  }
}
