using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinProps
{
  
  public class Person
  {
    public static int MaxHeightCm { get; set; } = 270;

    public const int MaxNameLength = 15;


    public event EventHandler<EventArgs> BmiAlarm;


    public Person()
    {
      this.Id = -1;
      this.Name = "Unbekannt";
      this.HeightCm = 150;
      this.WeightKg = 50;
    }


    /// <summary>
    /// Erstellt eine Person
    /// </summary>
    /// <param name="id">ID fuer diese Person</param>
    public Person(int id) : this()
    {
      this.Id = id;      
    }


    public Person(string name, int cm) : this()
    {
      this.Name = name;
      this.HeightCm= cm;
    }


    private int _id;
    public int Id 
    {
      get
      {
        return this._id;
      }
      private set
      {
        if (this._id != value && value > 0)
          this._id = value;
      }
    }

    public string Name
    {
      get; set;
    }


    private int _kg;
    public int WeightKg
    {
      get
      {
        return this._kg;
      }
      set
      {
        if (this._kg != value && value > 0)
          this._kg = value;

        if (this.Bmi > 25)
        {
          //var handler = this.BmiAlarm;
          ////if ( handler != null )
          ////  handler(this, EventArgs.Empty);
          //handler?.Invoke(this, EventArgs.Empty);

          this.BmiAlarm?.Invoke(this, EventArgs.Empty);
        }

      }
    }


    public int HeightCm { get; set; }


    public double Bmi
    {
      get
      {
        if (this.HeightCm > 0)
        {
          // BMI = kg / m2
          var m = (double)this.HeightCm / 100d;
          var m2 = m * m;

          var bmi = this.WeightKg / m2;
          return bmi;
        }
        return 0;
      }
    }


    public override string ToString()
    {
      return $"{this.Id}:{this.Name}";
    }

  }


}
