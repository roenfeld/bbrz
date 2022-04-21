using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinSteuerElemente
{
  public partial class FrmMain
  {
    private void Exit()
    {
      if (chkCanExit.Checked == true)
      {
        var msg = "Speichern..?\nWirklich beenden?";
        var ret = MessageBox.Show(msg, "Frage", 
                                  MessageBoxButtons.YesNo, 
                                  MessageBoxIcon.Question);

        if (ret != DialogResult.Yes)
          return;

        this.Close();
        //Application.Exit();
      }

      var txt = $"{calHolidays.SelectionStart} bis {calHolidays.SelectionEnd}";
      MessageBox.Show(txt);
    }


    private void SetPanelColor()
    {
      //var f = new FrmTest();
      //f.Location = this.Location;
      //f.StartPosition = FormStartPosition.Manual;
      //f.ShowDialog();

      DialogResult r = this.colorDialog1.ShowDialog();
      if (r == DialogResult.OK)
        panLeft.BackColor = colorDialog1.Color;
    }


    private void SetPanelFont()
    {
      var ftDlg = new FontDialog();
      
      var r = ftDlg.ShowDialog();
      if (r == DialogResult.OK)
        panLeft.Font = ftDlg.Font;
    }


    private void SaveFile()
    {
      var dlg = new SaveFileDialog();
      var r = dlg.ShowDialog();
      if (r == DialogResult.OK)
      {
        lblFileName.Text = dlg.FileName;
      }
    }


    private void OpenFile()
    {
      var dlg = new OpenFileDialog();
      //dlg.Title = "Speichern";
      var r = dlg.ShowDialog();
      if ( r == DialogResult.OK)
      {
        this.InitRtfTextBox(dlg.FileName);
      }
    }


    private void SetFolder()
    {
      var r = folderBrowserDialog1.ShowDialog();
      if ( r == DialogResult.OK)
      {
        lblFileName.Text = folderBrowserDialog1.SelectedPath;
      }
    }


  }
}
