using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BU = Bbrz.Util;


namespace WinForms
{
  public partial class FrmMain : Form
  {
    public FrmMain()
    {
      InitializeComponent();
      //var ok = io.File.Exists("");
    }

    private void btnCalc_Click(object sender, EventArgs e)
    {
      var result = Bbrz.Util.Math.Add(numVal1.Value, numVal2.Value);
      numResult.Value = result;
    }
  }
}
