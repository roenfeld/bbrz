using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinExplorer
{
  public partial class FrmTest
  {


    private void AddDirectoriesAsync(TreeNode parentNode, DirectoryInfo dirInfo)
    {
      Action<TreeNode, DirectoryInfo> act = this.AddDirectories;

      Task.Run(() => {
        this.Invoke(act, new object[] { parentNode, dirInfo });
        //this.AddDirectories(parentNode, dirInfo);
      });

    }


    private void AddDirectoriesBgWorker(TreeNode parentNode, DirectoryInfo dirInfo)
    {
      var bgw = new BackgroundWorker();
      bgw.WorkerReportsProgress = true;
      bgw.DoWork += this.Bgw_DoWork;
      bgw.ProgressChanged += this.Bgw_ProgressChanged;
      bgw.RunWorkerCompleted += this.Bgw_RunWorkerCompleted;

      bgw.RunWorkerAsync( new object[] { parentNode, dirInfo });
    }

    

    private void Bgw_DoWork(object sender, DoWorkEventArgs e)
    {
      var bgw = sender as BackgroundWorker;

      var arr = e.Argument as object[];
      var parentNode = (TreeNode)arr[0];
      var dirInfo = (DirectoryInfo)arr[1];

      try
      {
        bgw.ReportProgress(0, e.Argument);

        //parentNode.Nodes.Clear();
        var subDirInfos = dirInfo.GetDirectories();
        var dirCount = subDirInfos.Length;
        var counter = 0;

        foreach (var subDir in subDirInfos)
        {
          //var txt = $"{subDir.Name}";
          //var childNode = new TreeNode(txt, 2, 3);
          //childNode.Tag = subDir;
          //parentNode.Nodes.Add(childNode);

          counter++;
          var pct = (100 / dirCount) * counter;
          bgw.ReportProgress(pct, new object[] { parentNode, subDir});
        }
      }
      catch (Exception ioEx)
      {
      }

    }

    private void Bgw_ProgressChanged(object sender, ProgressChangedEventArgs e)
    {
      var arr = e.UserState as object[];
      var parentNode = (TreeNode)arr[0];
      var dirInfo = (DirectoryInfo)arr[1];

      if (e.ProgressPercentage == 0)
        this.progressBar1.Visible = true;

      this.progressBar1.Value = e.ProgressPercentage > 100 ? 100 : e.ProgressPercentage;
    }


    private void Bgw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
    {
      this.progressBar1.Visible = false;
    }
  }


}
