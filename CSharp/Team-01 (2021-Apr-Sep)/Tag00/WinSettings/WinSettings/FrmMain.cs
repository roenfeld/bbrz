using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinSettings
{
  public partial class FrmMain : Form
  {
    public FrmMain()
    {
      InitializeComponent();
    }

    private void FrmMain_Load(object sender, EventArgs e)
    {
      var tmp = AppDomain.CurrentDomain.SetupInformation.ConfigurationFile;

      var cfg = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.PerUserRoamingAndLocal);
      tmp = cfg.FilePath;

      //cfg = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.PerUserRoaming);
      //tmp = cfg.FilePath;

      var settings = Properties.Settings.Default;
      tmp = settings.CurrentFolder;
    }


    private void btnSelectFolder_Click(object sender, EventArgs e)
    {
      var res = fldDlg.ShowDialog();

      txtFolderPath.Text = fldDlg.SelectedPath;

      var settings = Properties.Settings.Default;
      settings.Save();

      var cfg = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.PerUserRoamingAndLocal);
      var tmp = cfg.FilePath;
    }

    
  }
}
