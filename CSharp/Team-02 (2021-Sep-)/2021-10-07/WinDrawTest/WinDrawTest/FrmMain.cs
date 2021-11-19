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

namespace WinDrawTest
{
  public partial class FrmMain : Form
  {
    public FrmMain()
    {
      InitializeComponent();
    }

    private void FrmMain_Load(object sender, EventArgs e)
    {      
    }


    private void panMain_Paint(object sender, PaintEventArgs e)
    {
      Debug.WriteLine("panMain_Paint");

      var fileName = @"F:\Daten\00 Schulungsunterlagen\CodersBay\Icons\Add.ico";
      var img = Image.FromFile(fileName);

      e.Graphics.DrawImage(img, 0,0, panMain.Width, panMain.Height);
    }
  }
}
