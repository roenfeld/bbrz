using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinSort
{
  public partial class FrmMain : Form
  {
    public FrmMain()
    {
      InitializeComponent();

      SetPointer();
    }


    

    private void btnInit_Click(object sender, EventArgs e)
    {
      CreateArray();
    }

    private void btnBubbleSort_Click(object sender, EventArgs e)
    {
      BubbleSort();
    }

    private void btnMergeSort_Click(object sender, EventArgs e)
    {
      MergeSort(0, MAX_ELEMENTS-1);
    }

    private void btnNetSort_Click(object sender, EventArgs e)
    {
      DotNetSort();
    }

    private void btnQuickSort_Click(object sender, EventArgs e)
    {
      QuickSort();

            
    }

    private unsafe void SetPointer()
    {
      var arrInt = new short[] { 5, 10, 1};

      fixed (short *ptr = arrInt)
      {
        var x = ptr;

        var y = *ptr;

        var isEq = (*x == *ptr) && (*ptr == arrInt[0]);
        short *p = ptr + 2;
        p++;

        y = *p;

        var z = *(ptr + 2);
      }
    }
  }
}
