using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinEmployees
{
  public partial class FrmMain : Form
  {
    public FrmMain()
    {
      InitializeComponent();
    }

    private DAL.DsCodersBay.regionsRow CurrentRegionRow
    {
      get
      {
        var drv = bsRegions.Current as DataRowView;
        var row = drv?.Row as DAL.DsCodersBay.regionsRow;
        return row;
      }
    }


    private void FrmMain_Load(object sender, EventArgs e)
    {
      DAL.DsCodersBay.FillRegions(this.dsMain);
    }

    private void bsRegions_CurrentChanged(object sender, EventArgs e)
    {
      //var drv = bsRegions.Current as DataRowView;
      //var row = drv?.Row as DAL.DsCodersBay.regionsRow;
      
      cboNavCountries.Items.Clear();

      var row = this.CurrentRegionRow;

      var id = row?.region_id;
      DAL.DsCodersBay.FillCountries(dsMain, id);

      //var cc = from x in dsMain.countries select x.country_name;
      //cboNavCountries.Items.AddRange(cc.ToArray());
      foreach (var c in dsMain.countries)
      {
        cboNavCountries.Items.Add(c.country_name);
      }
    }



  }
}
