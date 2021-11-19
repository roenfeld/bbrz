using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

      this.numInput.Minimum = decimal.MinValue;
      this.numInput.Maximum = decimal.MaxValue;

      this.numMin.Minimum = decimal.MinValue;
      this.numMin.Maximum = decimal.MaxValue;

      this.numMax.Minimum = decimal.MinValue;
      this.numMax.Maximum = decimal.MaxValue;

      this.UpdateMinMaxSumAvg();
    }


    /// <summary>
    /// neuen Wert in List und ListBox anhaengen
    /// </summary>
    private void AddNewValue2Lists()
    {
      this._values.Add(this.numInput.Value);
      this.lbValues.Items.Add(this.numInput.Value);
    }


    private void GenerateNewInputNumber()
    { 
      var rd = new Random(DateTime.Now.Millisecond);
      var nextVal = rd.Next(3, 20);
      this.numInput.Value = nextVal;
    }


    private decimal? GetMinimum()
    {
      if (_values.Count == 0)
        return null;

      decimal min = _values[0];

      for(int i=0; i < _values.Count; i++)
      {
        if (_values[i] < min)
          min = _values[i];
      }

      return min;
    }


    private decimal? GetSum()
    {
      if (_values.Count == 0)
        return null;

      decimal sum = 0;

      for (int i = 0; i < _values.Count; i++)
      {
        sum += _values[i];  
      }

      return sum;
    }


    private decimal? GetAvg()
    {
      var sum = this.GetSum();
      if (sum == null)
        return null;

      return sum / this._values.Count;      
    }


    private void UpdateMinMaxSumAvg()
    {
      var min = this.GetMinimum();

      if (min.HasValue)
      {
        this.numMin.Value = min.Value;
        this.numMin.ForeColor = Color.DarkRed;
      }
      else
      { // unsichtbar
        this.numMin.ForeColor = this.numMin.BackColor;
      }


      var sum = this.GetSum();

      if (sum.HasValue)
      {
        this.numSum.Value = sum.Value;
        this.numSum.ForeColor = Color.DarkGreen;
      }
      else
      { // unsichtbar
        this.numSum.ForeColor = this.numSum.BackColor;
      }


      var avg = this.GetAvg();

      if (avg.HasValue)
      {
        this.numAvg.Maximum = avg.Value;
        this.numAvg.Value = avg.Value;
        this.numAvg.ForeColor = Color.Black;
      }
      else
      { // unsichtbar
        this.numAvg.ForeColor = this.numAvg.BackColor;
      }
    }



    private void btnNewValue_Click(object sender, EventArgs e)
    {
      this.AddNewValue2Lists();

      this.UpdateMinMaxSumAvg();

      this.GenerateNewInputNumber();
      
      this.numInput.Select(0, 1000);
      this.numInput.Focus();
    }


  }
}
