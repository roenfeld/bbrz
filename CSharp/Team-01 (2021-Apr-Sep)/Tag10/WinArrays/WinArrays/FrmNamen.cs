using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinArrays
{
  public partial class FrmNamen : Form
  {
    private BindingList<string> Namen = new BindingList<string>();

    public FrmNamen()
    {
      InitializeComponent();

      this.lbNamen.DataSource = this.Namen;
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
      //this.lbNamen.DataSource = null;

      this.Namen.Add(this.txtNew.Text);

      //this.lbNamen.DataSource = this.Namen;
    }

  }
}
