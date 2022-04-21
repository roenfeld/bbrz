using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinRechner
{
  public partial class FrmMain : Form
  {
    public FrmMain()
    {
      InitializeComponent();      
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
      txtResult.Text = "funktioniert...";
    }

    private void btnSub_Click(object sender, EventArgs e)
    {

    }

  }
}
