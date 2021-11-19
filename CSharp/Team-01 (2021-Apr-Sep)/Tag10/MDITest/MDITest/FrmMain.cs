using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDITest
{
  public partial class FrmMain : Form
  {
    public FrmMain()
    {
      InitializeComponent();
    }

    private void mnuDateiNeu_Click(object sender, EventArgs e)
    {
      var f = new FrmChild();
      f.MdiParent = this;
      f.Show();
    }

    private void infoToolStripMenuItem_Click(object sender, EventArgs e)
    {
      var f = new FrmInfo();
      f.ShowDialog();
    }
  }
}
