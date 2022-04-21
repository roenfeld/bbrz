using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinProps
{
  public partial class FrmMain : Form
  {
    public FrmMain()
    {
      Program.GetX();

      InitializeComponent();

      this.btnTest.Click += this.btnTest_Click;
    }

    private void p1_BmiAlarm(object sender, EventArgs e)
    {
      textBox1.Text = "Alarm 1";
    }

    private void p_BmiAlarm(object sender, EventArgs e)
    {
      textBox2.Text = "Alarm 2";
    }

    private void btnTest_Click(object sender, EventArgs e)
    {
      var p1 = new Person();

      p1.BmiAlarm += this.p1_BmiAlarm;
      p1.BmiAlarm += this.p_BmiAlarm;

      p1.HeightCm = 185;
      p1.WeightKg = 80;
      p1.Name = "Rene";
      p1.WeightKg = 100;
      

      var b = p1.Bmi;

      // p2 ist eine Instanz der Klasse Person
      Person p2 = new Person("Walter", 178);
      //p2.Name = "Walter";
      //p2.HeightCm = 178;
      p2.WeightKg = -57;
      
      Person.MaxHeightCm = 278;


      //p1.MaxHeightCm = 277;

      var x = Person.MaxNameLength;

      var k = p1.WeightKg;
      k += p2.WeightKg;


      btnTest.Text = "";
      //btnTest.ResetText();

      //btnTest.Visible = false;
      //btnTest.Hide();

      btnTest.Left = 3;
      btnTest.Top = 3;
      btnTest.SetBounds(3, 3, 200, 50);

    }

    
  }
}
