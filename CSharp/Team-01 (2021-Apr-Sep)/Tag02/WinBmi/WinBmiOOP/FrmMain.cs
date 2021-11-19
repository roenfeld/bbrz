using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinBmiOOP
{
  public partial class FrmMain : Form
  {
    public FrmMain()
    {
      InitializeComponent();

      var bc = new BmiCalculator();
      bc.HeightCm = 184;
      bc.WeightKg = 81;

      var bmi = bc.BmiResult;

      bmiCalculatorBindingSource.DataSource = bc;
    }
  }
}
