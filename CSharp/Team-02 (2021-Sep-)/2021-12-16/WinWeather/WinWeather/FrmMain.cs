using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinWeather
{
  public partial class FrmMain : Form
  {
    public FrmMain()
    {
      InitializeComponent();

      LoadData();
    }

    private string FullFileName
    {
      get
      {
        var dirName = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
        var fileName = $"{dsMain.WeatherData.TableName}.xml";
        var fullFileName = Path.Combine(dirName, fileName);

        return fullFileName;
      }
    }


    private void LoadData()
    {
      var fullFileName = this.FullFileName;
      if ( File.Exists(fullFileName) )
      {
        dsMain.ReadXml(fullFileName);
      }
    }


    private void btnSaveWeatherData_Click(object sender, EventArgs e)
    {
      dsMain.WriteXml(this.FullFileName);
    }

    private void bsWeatherData_CurrentChanged(object sender, EventArgs e)
    {
      lblCurrentCity.Text = $"{bsWeatherData.Position}:{bsWeatherData.Current}";

      var drv = bsWeatherData.Current as DataRowView;
      var row = drv?.Row as DbCodersBay.WeatherDataRow;

      lblCurrentCity.Text = $"{bsWeatherData.Position}:{row?.City}";
    }

    private void bsWeatherData_AddingNew(object sender, AddingNewEventArgs e)
    {
      var obj = e.NewObject;
    }

  }
}
