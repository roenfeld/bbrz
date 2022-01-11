using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Roenfeld.Gui.WinForms;

namespace WinFormsStarter
{
  public partial class FrmMain : Form
  {
    public Roenfeld.Interfaces.IServiceProvider Services { get; set; }

    //public FrmMain(Roenfeld.Interfaces.IServiceProvider services) : this()
    //{
    //  this.Services = services;
    //}


    public FrmMain()
    {
      InitializeComponent();
    }

    private void btnShowTestControl_Click(object sender, EventArgs e)
    {
      var ctl = this.Services.Resolve<_00TestControl>(); //new _00TestControl();      
      ctl.Dock = DockStyle.Fill;
      tabPage1.Controls.Add(ctl); 
    }

  }
}
