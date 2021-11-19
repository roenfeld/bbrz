using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinArrayVsList
{
  public partial class FrmMain : Form
  {
    private DecimalArray _array = new DecimalArray();

    private List<decimal> _values;

    public FrmMain()
    {
      this._values = new List<decimal>(1000);

      InitializeComponent();

      txtNewValue.Maximum = decimal.MaxValue;

      var jaNein = this._values.Contains(17);
      int idx = this._values.BinarySearch(23);

      var d = this._values[idx];
    }

    private void btnAddNewValue_Click(object sender, EventArgs e)
    {
      //this._array.AddNewValue(this.txtNewValue.Value);
      
      this._values.Add(this.txtNewValue.Value);
      
      this.lbValues.DataSource = null;
      this.lbValues.DataSource = this._values;

      this.txtNewValue.Value = this.txtNewValue.Value * 2;
    }
  }


  public class DecimalArray
  {
    private decimal[] _values = new decimal[4000];
    private int _index = 0;

    public void AddNewValue(decimal newValue)
    {
      if (this._index == this._values.Length)
      {
        var tmp = new decimal[this._index + 4];
        for (int i = 0; i < this._values.Length; i++)
        {
          tmp[i] = this._values[i];
        }
        this._values = tmp;
      }
      this._values[this._index] = newValue;
      this._index++;      
    }

    public decimal[] Values
    {
      get
      {
        return this._values;
      }
    }

  }
}
