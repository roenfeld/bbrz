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
    private User MyUser { get; set; }


    public FrmMain()
    {
      MyUser = new User() { Email = "", Password = "1234" };
      InitializeComponent();


      //FrmMain f2 = new FrmMain();
      //f2.MyUser = this.MyUser;
      //f2.ShowDialog();

      //this.MyUser = f2.MyUser;
    }

    private void btnRechnen_Click(object sender, EventArgs e)
    {
      double radius;

      bool ok = double.TryParse(txtRadius.Text, out radius);

      radius = trbRadius.Value;


      if ( ok )
      {
        double umfang = 2 * radius * Math.PI;
        txtUmfang.Text = umfang.ToString("N2");
      }
      else
      {
        DialogResult r;
        r = MessageBox.Show("Zahlen...!", 
                            "Fehler", 
                            MessageBoxButtons.OK, 
                            MessageBoxIcon.Information);

        //if (r == DialogResult.Yes)
        //  this.Close();
      }

    }

    private void trbRadius_ValueChanged(object sender, EventArgs e)
    {
      txtRadius.Text = trbRadius.Value.ToString();
    }
  }
}
