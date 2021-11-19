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

namespace WinPaintTest
{
  public partial class FrmMain : Form
  {
    public FrmMain()
    {
      InitializeComponent();
    }

    private void FrmMain_Paint(object sender, PaintEventArgs e)
    {
      Debug.WriteLine("FrmMain_Paint");

      var rect = new Rectangle(50, 5, 100, 125);

      //e.Graphics.PageUnit = GraphicsUnit.Millimeter;
      e.Graphics.DrawRectangle(Pens.Red, rect);
      e.Graphics.FillEllipse(Brushes.Orange, rect);
    }

    private void button1_Paint(object sender, PaintEventArgs e)
    {
      Debug.WriteLine("button1_Paint");

      e.Graphics.FillEllipse(Brushes.Magenta, 4,4, 16,16);
    }

    private void label1_Paint(object sender, PaintEventArgs e)
    {
      Debug.WriteLine("label1_Paint");

      var b = new SolidBrush(SystemColors.ControlDark);
      var p = new Pen(Color.CornflowerBlue, 4);

      e.Graphics.FillRectangle(b, label1.ClientRectangle);
      e.Graphics.DrawRectangle(p, 0, 0, label1.Width, label1.Height);
      e.Graphics.DrawString("label...", this.Font, Brushes.Yellow, 8, 8);
    }


    private void panel1_Paint(object sender, PaintEventArgs e)
    {
      var img = Image.FromFile(@"F:\Daten\00 Schulungsunterlagen\CodersBay\Icons\Chrome.png");
      e.Graphics.DrawImage(img, 10, 10, 48,48);

      var p = new Pen(Color.Magenta, 4);
      p.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDot;

      e.Graphics.DrawLine(p, 5, 100, 200, 100);
    }


  }
}
