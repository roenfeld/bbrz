using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Roenfeld.Gui.WinForms
{
  public partial class _00TestControl : UserControl
  {
    public Roenfeld.Interfaces.IServiceProvider ServiceProvider { get; set; }


    public _00TestControl()
    {
      InitializeComponent();
    }

    public _00TestControl(Roenfeld.Interfaces.IServiceProvider provider) : this()
    {
      this.ServiceProvider = provider;
      this.LoadData();
    }


    private void LoadData()
    {
      var dal = this.ServiceProvider.Resolve<Roenfeld.Data.BaseDAL>();
      DataTable dt = dal.Get("countries");
    }

  }
}
