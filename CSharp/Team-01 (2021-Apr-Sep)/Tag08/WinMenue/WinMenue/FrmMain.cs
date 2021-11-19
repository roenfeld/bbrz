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

namespace WinMenue
{
  public partial class FrmMain : Form
  {
    public FrmMain()
    {
      InitializeComponent();
    }

    private void FrmMain_Load(object sender, EventArgs e)
    {
      var sw = new System.Diagnostics.Stopwatch();
      sw.Start();

      this.lblStatusMachinename.Text = Environment.MachineName;
      this.lblStatusUsername.Text = Environment.UserName;

      System.Diagnostics.Debug.WriteLine("FrmMain_Load: loaded");
      sw.Stop();

      System.Diagnostics.Debug.WriteLine($"FrmMain_Load: {sw.ElapsedMilliseconds} ms");
    }


    private void mnuFileExit_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void mnuFile_DropDownOpening(object sender, EventArgs e)
    {
      this.mnuFileOpen.Enabled = this.mnuFileStartStop.Checked;
    }

    private void cmnuFrmMainDiv_Click(object sender, EventArgs e)
    {
      //Process.Start("www.google.com");
      Process.Start("winword.exe");
    }

    private void mnuOptionsProcess_Click(object sender, EventArgs e)
    {
      Process.Start("calc");
    }


    Color myColor = Color.Red;

    private void mnuOptionsColor_Click(object sender, EventArgs e)
    {
      var rv = dlgColor.ShowDialog();

      if ( rv == DialogResult.OK)
      {
        myColor = dlgColor.Color;
        lblStatusMachinename.BackColor = myColor;
      }

    }

    
  }
}
