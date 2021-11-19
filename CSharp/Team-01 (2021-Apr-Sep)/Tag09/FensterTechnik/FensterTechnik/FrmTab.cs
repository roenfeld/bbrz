using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FensterTechnik
{
  public partial class FrmTab : Form
  {
    public FrmTab()
    {
      InitializeComponent();
      tabControl1.SelectedTab = tpAddress;
    }

    private void btnOK_Click(object sender, EventArgs e)
    {
      var tmp = $"{txtName.Text} ... {txtAddress.Text}";
      MessageBox.Show(tmp);
    }


    private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
    {
      //MessageBox.Show(tabControl1.SelectedTab.Name);
    }


  }
}
