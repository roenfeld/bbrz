using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinKreisRechner
{
  public partial class FrmMain : Form
  {
    public FrmMain()
    {
      InitializeComponent();
    }

    private void btnRechnen_Click(object sender, EventArgs e)
    {
      double radius, umfang;
      bool ok;

      ok = double.TryParse(txtRadius.Text, out radius);
      if ( ok == false )
      {
        MessageBox.Show("Bitte Zahlen eingeben", "Kreis...", MessageBoxButtons.OK, MessageBoxIcon.Information);
      }
      umfang = 2 * radius * Math.PI;

      //txtUmfang.Text = umfang.ToString("N2");
      txtUmfang.Text = $"{umfang:N2} cm";

      //flaeche = radius * radius * 3.1415;
      //txtFlaeche.Text = flaeche.ToString();

    }

  }
}
