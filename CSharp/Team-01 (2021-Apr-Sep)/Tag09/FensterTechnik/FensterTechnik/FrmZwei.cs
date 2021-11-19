using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FensterTechnik
{
  public partial class FrmZwei : Form
  {
    public FrmZwei()
    {
      InitializeComponent();
    }

    private void btnTest_Click(object sender, EventArgs e)
    {
      var f1 = this.Owner as FrmEins;
      f1.BackColor = Color.LightYellow;
      f1.Text = "Juhu!!!";

      f1.btnFensterZwo.Text = "aus F2 anders gemacht!";

      //var res = fontDialog1.ShowDialog();
      if (fontDialog1.ShowDialog() == DialogResult.OK)
      {
        f1.btnFensterZwo.Font = fontDialog1.Font;
      }
    }
  }
}
