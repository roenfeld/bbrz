using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinDbAutoInc
{
  public partial class FrmMain : Form
  {
    public FrmMain()
    {
      InitializeComponent();
    }

    private void LoadPgdata()
    {
      DsPg.Loader.Weather(dsMainPg);
    }


    private void FrmMain_Load(object sender, EventArgs e)
    {
      imgMain.Images.Add("Information", SystemIcons.Information);
      imgMain.Images.Add("Warning", SystemIcons.Warning);

      imgMain.Images.Add("Asterisk", SystemIcons.Asterisk);
      imgMain.Images.Add("Error", SystemIcons.Error);
      imgMain.Images.Add(SystemIcons.Exclamation);
      imgMain.Images.Add(SystemIcons.Hand);
      imgMain.Images.Add(SystemIcons.Question);
      imgMain.Images.Add(SystemIcons.Shield);
      imgMain.Images.Add(SystemIcons.WinLogo);
      imgMain.Images.Add(SystemIcons.Application);

      tpStart.ImageIndex = 0;
      tpPostgres.ImageIndex = 1;
    }


    private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (tabControl1.SelectedTab == tpPostgres)
        this.LoadPgdata();

    }
  }
}
