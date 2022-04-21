using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinSort
{
  public partial class Form1 : Form
  {
    const int MAX = 100 * 1000;

    decimal[] _values;

    public Form1()
    {
      InitializeComponent();

      btnFnEvtHdl.Click += (s, e) => MessageBox.Show("Click-Functional");
    }

    private void btnEvtHdl_Click(object sender, EventArgs e)
    {
      MessageBox.Show("Click-Klassisch");
    }


    private void btnCreateArray_Click(object sender, EventArgs e)
    {
      _values = new decimal[MAX];

      Random rnd = new Random(DateTime.Now.Millisecond);

      lstVals.Items.Clear();

      for (int i = 0; i < MAX; i++)
      {
        _values[i] = (decimal)rnd.NextDouble() * 100;
        lstVals.Items.Add(_values[i]);
      }
    }


    private void btnBubbleSort_Click(object sender, EventArgs e)
    {
      var sw = new Stopwatch();
      sw.Start();

      int MAX = _values.Length;

      for(int i = 0; i< MAX -1; i++)
      {
        for(int j = i +1; j < MAX; j++)
        {
          if ( _values[i] > _values[j])
          {
            decimal tmp = _values[i];
            _values[i] = _values[j];
            _values[j] = tmp;
          }
        }
      }

      sw.Stop();
      this.Text = $"{sw.ElapsedMilliseconds:N0} ms";
    }


    private void btnSort_Click(object sender, EventArgs e)
    {
      var sw = new Stopwatch();
      sw.Start();

      Array.Sort(_values);

      sw.Stop();
      this.Text = $"{sw.ElapsedMilliseconds:N0} ms";
    }


    private void btnCallByValue_Click(object sender, EventArgs e)
    {
      int x, y;

      x = 1;
      y = 99;


      if ( x > 0 )
      {
        string s = "Test";
        int k = 23;

        if ( y > 0)
        {
          int i = 55;
        }
      }


      //Swap(ref x, ref y);
    }

    //private void Swap(ref int a, ref int b)
    //{
    //  int tmp = a;
    //  a = b;
    //  b = tmp;
    //}


    private SwapReturn Swap(int a, int b)
    {
      int tmp = a;
      a = b;
      b = tmp;

      return new SwapReturn() { x = a, y = b };
    }


    public class SwapReturn
    {
      public int x;
      public int y;
    }

    
  }
}
