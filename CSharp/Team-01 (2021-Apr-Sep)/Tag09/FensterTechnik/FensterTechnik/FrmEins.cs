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
  public partial class FrmEins : Form
  {
    public FrmEins()
    {
      InitializeComponent();
    }

    private void btnFensterZwo_Click(object sender, EventArgs e)
    {
      //var f2 = new FrmZwei();
      //f2.Owner = this;
      //f2.Show();
      //f2.ShowDialog();

      var fL = new FrmLogin();
      //fL.MaximizeBox = false;
      //fL.MinimizeBox = false;
      ////fL.ControlBox = false;
      //fL.ShowInTaskbar = false;
      //fL.FormBorderStyle = FormBorderStyle.FixedSingle;
      //fL.BackColor = Color.AliceBlue;

      fL.StartPosition = FormStartPosition.CenterParent;

      if (fL.ShowDialog() == DialogResult.OK)
      {
        this.Text = $"User: {fL.UserName}";
      }

    }

  }
}
