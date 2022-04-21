using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace BmiRechnerV2
{
  public partial class FrmMain : Form
  {
    public FrmMain()
    {
      InitializeComponent();

      var fullFileName = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.PerUserRoamingAndLocal).FilePath;
      this.Text = fullFileName;

      //var dirName = System.IO.Path.GetDirectoryName(fullFileName);
      //System.Diagnostics.Process.Start(dirName);
    }

    private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
    {
      Properties.Settings.Default.Save();
    }
  }
}
