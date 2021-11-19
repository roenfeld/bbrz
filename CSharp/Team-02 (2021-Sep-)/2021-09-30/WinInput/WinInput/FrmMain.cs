using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinInput
{
  public partial class FrmMain : Form
  {
    public FrmMain()
    {
      InitializeComponent();

      numericUpDown1.Maximum = decimal.MaxValue;

      numericUpDown1.Value = 3456;
      decimal d = numericUpDown1.Value;

      dateTimePicker1.Value = DateTime.Parse("1993-12-18");
      DateTime dat = dateTimePicker1.Value;
    }


    // Do dreissigster Sept. zwei-Tsd-21
    // 10^2
    private void btnTest_Click(object sender, EventArgs e)
    {
      //int wert = this.txtTest.Text;

      //int wert1 = Convert.ToInt32(this.txtTest.Text);
      //int wert2 = int.Parse(this.txtTest.Text);
      //int wert3;

      //bool ok = int.TryParse(this.txtTest.Text, out wert3);
      //if ( ok == true)
      //{
      //  this.Text = wert3.ToString();
      //  this.Top = wert3;
      //}

      decimal.TryParse("", out decimal d0);
      //double.TryParse("", out double d1);
      //float.TryParse("", out float f1);
      //long.TryParse("", out long l);
      //short.TryParse("")

      this.Text = "";
      // DATUM !!??
      DateTime dat;
      bool ok = DateTime.TryParse(txtTest.Text, out dat);
      if ( ok == true )
      {
        this.Text = dat.ToString();
      }

    }

    
  }
}
