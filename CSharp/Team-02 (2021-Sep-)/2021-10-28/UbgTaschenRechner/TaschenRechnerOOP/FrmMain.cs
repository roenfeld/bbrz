using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaschenRechnerOOP
{
  public partial class FrmMain : Form
  {
    private Calculator _calc = new Calculator();

    public FrmMain()
    {
      InitializeComponent();

      value1NumericUpDown.Minimum = decimal.MinValue;
      value1NumericUpDown.Maximum = decimal.MaxValue;

      value2NumericUpDown.Minimum = decimal.MinValue;
      value2NumericUpDown.Maximum = decimal.MaxValue;
      
      resultNumericUpDown.Minimum = decimal.MinValue;
      resultNumericUpDown.Maximum = decimal.MaxValue;

      _calc.Value1 = 1;
      _calc.Value2 = 2;
      _calc.Operator = Calculator.Operators.Add;

      calculatorBindingSource.DataSource = _calc;
    }

    private void FrmMain_Load(object sender, EventArgs e)
    {

    }
  }
}
