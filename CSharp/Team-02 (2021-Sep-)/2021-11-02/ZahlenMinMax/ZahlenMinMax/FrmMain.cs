using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZahlenMinMax
{
  public partial class FrmMain : Form
  {

    private List<decimal> _values = new List<decimal>();

    public FrmMain()
    {
      InitializeComponent();

      numInput.Minimum = decimal.MinValue;
      numInput.Maximum = decimal.MaxValue;

      this.ShowMinimum();
    }

    private void RemoveCurrentItem()
    {
      var idx = lbValues.SelectedIndex;
      if (idx > -1)
      {
        _values.RemoveAt(idx);
        lbValues.Items.RemoveAt(idx);

        ShowMinimum();
      }
    }


    private void RemoveAll()
    {
      lbValues.Items.Clear();
      _values.Clear();

      ShowMinimum();
    }


    private void ShowMinimum()
    {
      if (_values.Count == 0)
      {
        numMin.Value = 0;
        numMin.ForeColor = numMin.BackColor;
        return;
      }

      numMin.ForeColor = Color.DarkRed;

      decimal min = _values[0];

      for(int i = 0; i < _values.Count; i++)
      {
        decimal v = _values[i];
        if (v < min)
          min = v;
      }

      numMin.Minimum = min;
      numMin.Value = min;
    }


    private void ShowMaximum()
    {
      var max = this._values.Max();

      numMin.Maximum = max;
      numMin.Value = max;
    }



    private void btnAddInput_Click(object sender, EventArgs e)
    {
      var v = numInput.Value;

      _values.Add(v);
      lbValues.Items.Add(v);

      numInput.Focus();
      numInput.Select(0, 100);

      //lbValues.DataSource = null;
      //lbValues.DataSource = _values;

      //lbValues.Items.Add(numInput.Value);

      //lbValues.Items.Clear();
      //for(int i=0; i < _values.Count; i++)
      //  lbValues.Items.Add(_values[i]);

      this.ShowMinimum();
      this.ShowMaximum();
    }

    
    private void lbValues_KeyUp(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Delete)
      {
        //var idx = lbValues.SelectedIndex;
        //if ( idx > -1 )
        //  lbValues.Items.RemoveAt(idx);

        //var item = lbValues.SelectedItem;
        //lbValues.Items.Remove(item);
        this.RemoveCurrentItem();
      }
    }


    private void cmLbValuesRemoveAll_Click(object sender, EventArgs e)
    {
      this.RemoveAll();
    }

    private void cmLbValuesRemoveCurrent_Click(object sender, EventArgs e)
    {
      this.RemoveCurrentItem();
    }


    public T Min<T>(IEnumerable<T> iter)
    {
      T min = iter.First();

      foreach(var x in iter)
      {
        //if (x < min)
          min = x;
      }
      return min;
    }

  }
}
