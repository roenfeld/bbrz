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

namespace WinArrays
{
  public partial class FrmMain : Form
  {
    public string[] Namen = { "Attila", "Kevin", "Walter", "Ivi" };

    public FrmMain()
    {
      InitializeComponent();

      lbTest.DataSource = Namen;

      int[] werte1 = null;

      int[] werte2 = new int[5];

      int[] werte3 = new int[] { 55, 33, 21, 7 };


      float[] zahlen = new float[] { 2.7f, 3.14f, 13.76f };
      

      // Fehler: null!
      //int w = werte1[0];
      int x = werte3[3];

      // Fehler: Index!
      //int y = werte3[21];

      int len = werte3.Length;


      for(int idx=0; idx<werte3.Length; idx++)
      {
        Debug.WriteLine($"{idx} => {werte3[idx]}");
      }


      foreach(var z in zahlen)
      {
        Debug.WriteLine($"{z}");
      }

      Test1();


      var files = System.IO.Directory.GetFiles(@"C:\Windows");
    }


    private void btnAdd_Click(object sender, EventArgs e)
    {
      var tmp = this.Namen;
      this.Namen = new string[this.Namen.Length + 1];

      Array.Copy(tmp, this.Namen, tmp.Length);

      this.Namen[this.Namen.Length - 1] = txtName.Text;

      this.lbTest.DataSource = this.Namen;
    }


    private void Test1()
    {
      var werte = new List<int>() { 5, 3, 77};

      werte.Add(55);
      werte.Add(33);
      werte.Add(7);
      werte.Add(21);
      werte.Add(22);
      werte.Remove(21);

      int x = werte[3];
      x = werte.Count;

      var namen = new List<string>();

    }

    
  }
}
