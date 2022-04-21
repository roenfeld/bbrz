using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BmiRechnerV1
{
  public partial class FrmMain : Form
  {
    BmiCalc bmiA = new BmiCalc();

    BmiCalc bmiX = new BmiCalc("Kevin");
    BmiCalc bmiY = new BmiCalc("Andreas", 82);
    BmiCalc bmiZ = new BmiCalc("Rene", 84, 186);

    BmiCalcDate bmiD = new BmiCalcDate(DateTime.Parse("1967-05-27"));

    
    TextBox txt1 = new TextBox();
    TextBox txt2 = null;

    int w1 = 3, w2 = 5;

    // txt1 ist eine Instanz von TextBox
    //   w1 ist eine Instanz von int(eger)

    // txt1 ist  ein InstanzVERWEIS
    //   w1 ist KEIN InstanzVERWEIS
    //   w1 ist KEIN .......VERWEIS

    public FrmMain()
    {
      InitializeComponent();

      this.bmiA.Name = "Attila";
      
      bmiA.HeightCm = 2;
      bmiA.WeightKg = -85;

      bmiA.HeightCm = 151;
      bmiA.WeightKg = 100;

      bmiZ.BmiAlarm += this.Bmi_BmiAlarm;
      this.bsBmi.DataSource = bmiZ;


      bmiD.Date = DateTime.Now;

      this.Init();

      double w;
      w = this.bmiY.BMI;
      //w = bmiY.get_Bmi();

      //var cm = BmiCalc.MinHeightCm;
      //var n = bmiX.Name;
      //var l = bmiX.Name.Length;

      //txt2 = txt1;
      //n = txt2.Text;

      //var t = BmiCalc.Test;

      //bmi.BMI = 27;

      //txtHeightCm.DataBindings.Add("Text", bmi, "HeightCm");
      //lblHeight.DataBindings.Add("Text", bmi, "WeightKg");
      //button1.DataBindings.Add("Text", bmi, "HeightCm");

      //txtHeightCm.DataBindings.Add("Left", bmi, "HeightCm");
      //txtHeightCm.DataBindings.Add("Top", bmi, "HeightCm");
    }

    private void Bmi_BmiAlarm(object sender, EventArgs e)
    {
      var x = 17;
      x++;

      var b = sender as BmiCalc;
      
      MessageBox.Show($"Alarm für {b.Name} BMI={b.BMI:N1}");
    }





    private void btnCalc_Click(object sender, EventArgs e)
    {
      //bmiZ.WeightKg = double.Parse(txtWeight.Text);

      var msg = $"KG={bmiZ.WeightKg}";
      MessageBox.Show(msg);
    }


    private void Init()
    {
      //txtWeight.DataBindings.Add("Text", bmiZ, "WeightKg");
      //txtWeight.Text = bmiZ.WeightKg.ToString();
    }


    

    
  }
}
