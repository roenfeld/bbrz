using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsTextBox
{
  public partial class FrmMain : Form
  {
    public FrmMain()
    {
      InitializeComponent();

      this.txtTest.Text = "2021-04-22";
    }


    private void btnTest_Click(object sender, EventArgs e)
    {
      // löschen
      //this.txtTest.Text = "";
      //this.txtTest.Clear();

      // selektieren
      //this.txtTest.Focus();
      //this.txtTest.Select(2, 3);

      int x = 5;
      int y = 7;
      TestInt(ref x, y);

      string z = "Coders";
      this.TestStr(ref z);


      int h;

      //h = Convert.ToInt32(this.txtTest.Text);
      
      bool ok = int.TryParse(this.txtTest.Text, out h);
      if ( ok )
        this.btnTest.Height = h;


      //double d;
      //ok = double.TryParse(this.txtTest.Text, out d);
      //if (ok)
      //  MessageBox.Show("OK");

      DateTime dt;
      ok = DateTime.TryParse(this.txtTest.Text, out dt);
        MessageBox.Show($"Datum OK: {dt:D}");
    }



    // CALL BY VALUE : Kopie der Variable(n) (am Stack)
    private void TestInt(ref int a, int b)
    {
      a++;
      b--;
    }


    // CALL BY REFERENCE : Adresse der Var. wird am Stack übergeben => ORIGINAL
    private void TestStr(ref string s)
    {
      s = s + "-ABC";
    }



    private double GetBmi(double gewichtKg, double groesseCm)
    {
      double meter = groesseCm / 100;

      double meter2 = meter * meter;

      double bmi = gewichtKg / meter2;

      return bmi;
    }

  }
}
