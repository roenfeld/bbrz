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

namespace WinKugerl
{
  public partial class FrmMain : Form
  {
    private bool IsRunning { get; set; } = false;

    private int CurrentX, CurrentY;
    private int DeltaX, DeltaY;
    const int WidthHeight = 24;

    public FrmMain()
    {
      this.DeltaX = this.DeltaY = 2;
      InitializeComponent();
      //while (this.IsRunning)
      //{
      //  this.CurrentX++;
      //  this.Invalidate();
      //  Application.DoEvents();
      //}
    }

    private void FrmMain_Paint(object sender, PaintEventArgs e)
    {
      e.Graphics.FillEllipse(Brushes.Magenta, this.CurrentX, this.CurrentY, WidthHeight, WidthHeight);
    }


    private void timer1_Tick(object sender, EventArgs e)
    {
      //Debug.WriteLine("timer1_Tick");
      //btnStartStop.Text = DateTime.Now.ToLongTimeString();

      if (this.CurrentX <= 0)
      {
        this.DeltaX = 2;
      }
      if (this.CurrentY <= 0)
      {
        this.DeltaY = 2;
      }

      if ( this.CurrentX + WidthHeight >= this.ClientSize.Width)
      {
        this.DeltaX = -2;
      }

      if (this.CurrentY + WidthHeight >= this.ClientSize.Height)
      {
        this.DeltaY = -2;
      }


      var rc = new Rectangle(this.CurrentX - 4, this.CurrentY - 4, WidthHeight + 8, WidthHeight + 8);
      
      this.CurrentX += this.DeltaX;
      this.CurrentY += this.DeltaY;

      this.Invalidate(rc);
    }



    private void btnStartStop_Click(object sender, EventArgs e)
    {
      this.IsRunning = !this.IsRunning;
      this.timer1.Enabled = this.IsRunning;

      this.CurrentX = this.CurrentY = 0;
    }

    

    

  }
}
