using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//: System.ComponentModel.INotifyPropertyChanged


namespace BmiLib
{
  public class BmiCalc
  {
    public double WeightKg
    {
      get; set;
    } = 55;

    public double HeightCm
    {
      get; set;
    } = 150;

    public double Bmi
    {
      get
      {
        var meters = this.HeightCm / 100;
        var m2 = meters * meters;
        var bmi = this.WeightKg / m2;
        return bmi;
      }
    }

    public Color HintColor
    {
      get
      {
        if (this.Bmi < 20)
          return Color.Orange;

        if (this.Bmi >= 30)
          return Color.Red;

        if (this.Bmi >= 25)
          return Color.Tomato;

        return Color.Green;
      }
    }


    public static void Serialize(string fullFileName, List<BmiCalc> lst)
    {
      var sw = new System.IO.FileStream(fullFileName, System.IO.FileMode.OpenOrCreate);
      var ser = new System.Xml.Serialization.XmlSerializer(lst.GetType());

      ser.Serialize(sw, lst);
      sw.Close();
    }
  }
}
