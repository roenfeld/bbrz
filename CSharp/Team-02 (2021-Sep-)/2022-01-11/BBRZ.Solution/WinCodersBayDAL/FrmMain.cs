using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using dal = BBRZ.DAL;


namespace WinCodersBayDAL
{
  public partial class FrmMain : Form
  {
    public FrmMain()
    {
      InitializeComponent();
    }

    private void FrmMain_Load(object sender, EventArgs e)
    {
      dal.Regions.Fill(this.dsMain);
    }

    private void btnSaveRegions_Click(object sender, EventArgs e)
    {
      dal.Regions.Update(this.dsMain);
    }

  }
}
