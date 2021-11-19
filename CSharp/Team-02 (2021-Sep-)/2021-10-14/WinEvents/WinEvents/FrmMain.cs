using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinEvents
{
  public partial class FrmMain : Form
  {
    public FrmMain()
    {
      InitializeComponent();
    }


    private void txtName_TextChanged(object sender, EventArgs e)
    {
      this.Text = "txtName_TextChanged";
    }


    private void txtName_Click(object sender, EventArgs e)
    {
      this.Text = "txtName_Click";
    }


    private void txtName_KeyPress(object sender, KeyPressEventArgs e)
    {
      this.Text = "txtName_KeyPress";
    }


  }
}
