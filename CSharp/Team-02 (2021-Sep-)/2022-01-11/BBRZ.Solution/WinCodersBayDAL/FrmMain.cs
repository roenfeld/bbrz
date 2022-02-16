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

    private dal.DsCodersBay.regionsRow CurrentRegionRow
    {
      get
      {
        var drv = bsRegions.Current as DataRowView;
        var row = drv?.Row as dal.DsCodersBay.regionsRow;
        return row;
      }
    }


    private dal.DsCodersBay.countriesRow CurrentCountryRow
    {
      get
      {
        var drv = bsCountries.Current as DataRowView;
        var row = drv?.Row as dal.DsCodersBay.countriesRow;
        return row;
      }
    }



    private void FrmMain_Load(object sender, EventArgs e)
    {
      dal.Regions.Fill(this.dsMain);
    }


    private void bsRegions_CurrentChanged(object sender, EventArgs e)
    {
      var regionRow = this.CurrentRegionRow;
      if (regionRow == null)
      {
        dsMain.countries.Clear();
      }
      else
      {
        dal.Countries.FillByRegion(dsMain, regionRow.region_id);
        dsMain.countries.region_idColumn.DefaultValue = regionRow.region_id;
      }
    }

    private void bsCountries_CurrentChanged(object sender, EventArgs e)
    {
      var countryRow = this.CurrentCountryRow;
    }

    private void btnSaveRegions_Click(object sender, EventArgs e)
    {
      dal.Regions.Update(this.dsMain);
    }

    
  }
}
