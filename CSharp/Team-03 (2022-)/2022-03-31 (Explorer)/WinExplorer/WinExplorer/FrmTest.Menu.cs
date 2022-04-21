using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinExplorer
{
  public partial class FrmTest
  {
    private void OpenUserConfigDirectory()
    {
      try
      {
        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.PerUserRoamingAndLocal);
        var dir = System.IO.Path.GetDirectoryName(config.FilePath);
        var pi = new ProcessStartInfo() { FileName = "explorer.exe", Arguments = $"/e,{dir}"};
        Process.Start(pi);
      }
      catch (Exception ex)
      {
        MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      }
    }


    private void SetFont()
    {
      var dlg = new FontDialog();
      dlg.Font = this.Font;

      if (dlg.ShowDialog() == DialogResult.OK)
      {
        this.Font = dlg.Font;
        this.mnuMain.Font = this.Font;
      }
    }


  }
}
