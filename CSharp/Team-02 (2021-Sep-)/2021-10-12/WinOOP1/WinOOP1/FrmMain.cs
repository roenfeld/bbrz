using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinOOP1
{
  public partial class FrmMain : Form
  {
    public FrmMain()
    {
      this.EMail = "?";
      this.Alter = 0;
      InitializeComponent();

      this.Alter = 33;

      this.StartPosition = FormStartPosition.Manual;
      // this.set_Left(1000);
      this.Left = -1000;
      this.Top = 100;

      this.MeinAuto = new Auto() { Marke="Opel", Modell="Zafira" };
      this.MeinAuto.TankInhalt = 12;

      this.MeinAuto.ZuwenigSprit += this.MeinAuto_ZuwenigSprit;
      this.MeinAuto.OelWechsel += this.MeinAuto_OelWechsel;

      this.btnPropAndMeths.Click += this.btnPropAndMeths_Click;
      //this.btnPropAndMeths.Click += this.BtnPropAndMeths_Click2;
    }

    //private void BtnPropAndMeths_Click2(object sender, EventArgs e)
    //{
    //  var a = new Auto();
    //  a.KilometerStand += 200;

    //  var x = a + this.MeinAuto;
    //  MessageBox.Show($"{x.KilometerStand}");
    //}

    private void MeinAuto_OelWechsel(object sender, Auto.AutoEventArgs e)
    {
      var x = e.Message;
    }

    private void MeinAuto_ZuwenigSprit(object sender, EventArgs e)
    {
      var a = sender as Auto;
      a.TankInhalt += 6;
    }

    private void FrmMain_Load(object sender, EventArgs e)
    {
      object o1 = sender;
    }


    //string _email;
    //void SetEmail(string email)
    //{
    //  _email = email;
    //}
    //string GetEmail()
    //{
    //  return _email;
    //}

    public int Gewicht;

    //public string EMail { get; set; }
    // aus string EMail {get;set;} generiert Compiler folgende Zeilen:
    //string _backingFieldEMail;
    //string get_EMail() { return _backingFieldEMail; }
    //void set_EMail(string val) { _backingFieldEMail = val; }

    private string _email;

    public string EMail
    {
      get { return _email; }
      set 
      {
        if (string.IsNullOrEmpty(value))
          return;
        if (!value.Contains("@"))
          return;

        this.Alter = 44;
        _email = value; 
      }
    }


    public int Alter { get; private set; }

    private void txtTest_TextChanged(object sender, EventArgs e)
    {
      this.Text = txtTest.Text;
    }


    private void btnNeuesAuto_Click(object sender, EventArgs e)
    {
      // int x = this.get_Left();
      var x = this.Left;

      for (int i = 0; i < 3; i++)
      {
        Auto a = new Auto();
        a.TankInhalt = -45000;
      }
      
      btnNeuesAuto.Text = "Fertig!";
    }



    private void btnTypeCast_Click(object sender, EventArgs e)
    {
      // einfacher type cast
      double pi = 3.14;
      decimal d1 = (decimal)pi;
      int i1 = (int)d1;

      object o1 = sender;

      // TOD
      //int i2 = (int)o1;

      var btn = (Button)sender;
      btn.Text = "OK";
      var txt = sender as Button;
      if ( sender != null )
      {
        txt.BackColor = Color.Orange;
      }
    }

    private void btnCallByValue_Click(object sender, EventArgs e)
    {
      int x = 7;
      int y = 99;

      CallByValue_WertDT(x, y);

      int z = x;
      z = y;

      var a = new Auto();
      a.Marke = "Audi";
      a.Modell = "A1";
      a.TankInhalt = 45;
      CallByRef(ref a);

      var m = a.Marke;

      CallByValue(a);
    }

    private void CallByValue_WertDT(int a, int b)
    {
      a = a + 2;
      b++;
    }


    private void CallByRef(ref Auto x)
    {
      //x.Marke = "BMW";
      x = new Auto();
    }

    private void CallByValue(Auto x)
    {
      x.Marke = "BMW";
      x.LeistungKW = 102;
      x.Modell = "330i";
      x.TankInhalt = 40;
    }


    private Auto TuWas(Auto x)
    {
      var r = new Auto();
      r.TankInhalt = x.TankInhalt;
      r.Marke = "BMW";
      return r;
    }


    private Auto MeinAuto { get; set; }
    
    private void btnPropAndMeths_Click(object sender, EventArgs e)
    {      
      this.MeinAuto.Fahren(100);

      txtTest.Text = this.MeinAuto.ToString();

      //var p = new BBRZ.Person();
      //txtTest.Text = p.ToString();

      //var b = new BBRZ.Auto();
      //b.Marke = "Volvo";
      //b.FIN = "";
      //txtTest.Text = b.ToString();

      MessageBox.Show("1");
    }


    private void btnTest_Click(object sender, EventArgs e)
    {
      this.progressBar1.Visible = !this.progressBar1.Visible;
      //this.progressBar1.Hide();

      Motor m = new Motor();
      m.MotorNummer = "Y200-TB";
      m.Starten(2);
      Program.TestStruct(m);

      var hh = m.BetriebsStunden;
    }
  }

  // aus int Alter {get;set;} generiert Compiler folgende Zeilen:
  //int _backingFieldAlter;
  //int get_Alter() { return _backingFieldAlter; }




  //struct Person
  //{
  //  public int GrCm;
  //  public double GwKg;
  //}

}
