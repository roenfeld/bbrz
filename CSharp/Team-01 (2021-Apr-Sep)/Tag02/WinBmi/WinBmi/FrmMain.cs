using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinBmi
{
  public partial class FrmMain : Form
  {
    public FrmMain()
    {
      InitializeComponent();
    }

    private void txtGewichtKg_TextChanged(object sender, EventArgs e)
    {
      //this.BmiRechnen();
    }

    private void btnRechnen_Click(object sender, EventArgs e)
    {
      this.BmiRechnen();
    }


    private void BmiRechnen()
    { 
      double kg, cm, meter, bmi;
      bool ok;

      ok = double.TryParse(txtGewichtKg.Text, out kg);
      if ( ok == false )
      {
        MessageBox.Show("Gewicht ungültig", "BMI Rechner", MessageBoxButtons.OK, MessageBoxIcon.Information);
        txtBMI.Text = "";
        return;
      }
      ok = double.TryParse(txtGroesseCm.Text, out cm);

      meter = cm / 100;
      bmi = kg / (meter * meter);

      txtBMI.Text = bmi.ToString("N2");
      //txtBMI.Text = $"{bmi:N2}";
    }


  }
}
