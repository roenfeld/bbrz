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

namespace WinPaint
{
  public partial class FrmMain : Form
  {
    Color MyColor = Color.Red;

    private int CurX, CurY;
    private int dX, dY;
    const int Delta = 3;

    public FrmMain()
    {
      CurX = 0;
      CurY = 30;
      dX = dY = Delta;
      InitializeComponent();
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
      if (CurX+24 >= this.ClientRectangle.Width)
        dX = -Delta;

      if (CurY+24 >= this.ClientRectangle.Height)
        dY = -Delta;

      if (CurX <= 0)
        dX = Delta;

      if (CurY <= mnuMain.Size.Height)
        dY = Delta;


      CurX += dX;
      CurY += dY;

      this.Invalidate();
    }

    private void FrmMain_Paint(object sender, PaintEventArgs e)
    {
      //Debug.WriteLine("FrmMain_Paint");
      e.Graphics.FillEllipse(Brushes.Green, CurX,CurY, 24,24);
      //e.Graphics.DrawEllipse(Pens.Orange, this.ClientRectangle);
    }


    private void btnTest_Paint(object sender, PaintEventArgs e)
    {
      //Debug.WriteLine("btnTest_Paint");

      //e.Graphics.DrawEllipse(Pens.Magenta, btnTest.ClientRectangle);

      var img = Image.FromFile(@"F:\Daten\00 Schulungsunterlagen\CodersBay\Icons\Lock.png");
      e.Graphics.DrawImage(img, 4, 4);
    }


    private void mnuOptionsColor_Click(object sender, EventArgs e)
    {
      
    }

    
  }
}
