using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UbgTaschenRechner
{
  public partial class FrmMain : Form
  {
    public enum Operatoren
    {
      Addieren,
      Subtrahieren
    }

    public FrmMain()
    {
      InitializeComponent();
    }

    private List<decimal> GetEingabeWerte()
    {
      var lst = new List<decimal>();

      bool hatFunktioniert = decimal.TryParse(txtZahl1.Text, out decimal z1);
      if (!hatFunktioniert)
        return lst;

      lst.Add(z1);
      lst.Add(this.txtZahl2.Value);

      return lst;
    }



    private void btnAdd_Click(object sender, EventArgs e)
    {
      var werte = this.GetEingabeWerte();

      if (werte.Count == 2)
      {
        var erg = werte[0] + werte[1];
        txtErgebnis.Text = erg.ToString("N2");
      }
    }

    private void btnSub_Click(object sender, EventArgs e)
    {
      var werte = this.GetEingabeWerte();

      if (werte.Count == 2)
      {
        var erg = werte[0] - werte[1];
        txtErgebnis.Text = erg.ToString("N2");
      }
    }

    private void btnClear_Click(object sender, EventArgs e)
    {
      txtZahl1.Clear();
      txtZahl2.Value = 0;
    }

  }
}
