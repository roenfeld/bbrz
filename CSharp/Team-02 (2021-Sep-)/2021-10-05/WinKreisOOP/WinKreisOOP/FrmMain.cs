using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinKreisOOP
{
  public partial class FrmMain : Form
  {
    public FrmMain()
    {
      InitializeComponent();

      Kreis k1 = new Kreis();
      k1.Radius = 5;

      
      this.radiusTextBox.DataBindings.Add(nameof(TextBox.Text), bsKreis, nameof(Kreis.Radius));
      this.trbRadius.DataBindings.Add("Value", bsKreis, "Radius");

      this.bsKreis.DataSource = k1;

      //Auto a = new Auto("Volvo", "164");

    }
  }
}
