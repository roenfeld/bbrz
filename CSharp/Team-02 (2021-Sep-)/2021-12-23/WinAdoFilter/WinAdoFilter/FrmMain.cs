using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAdoFilter
{
  public partial class FrmMain : Form
  {
    public FrmMain()
    {
      InitializeComponent();
    }


    private void countriesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
    {
      this.SaveData();
    }

    private void FrmMain_Load(object sender, EventArgs e)
    {
      this.LoadData();
    }

    private void btnFilter_Click(object sender, EventArgs e)
    {
      this.FilterData();
    }

  }
}
