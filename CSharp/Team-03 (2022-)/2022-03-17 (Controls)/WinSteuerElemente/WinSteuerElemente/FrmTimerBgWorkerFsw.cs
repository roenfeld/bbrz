using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinSteuerElemente
{
  public partial class FrmTimerBgWorkerFsw : Form
  {
    public FrmTimerBgWorkerFsw()
    {
      InitializeComponent();

      Debug.WriteLine($"Thread-ID={Thread.CurrentThread.ManagedThreadId:N0}");
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
      //Debug.WriteLine($"timer1_Tick()");

      lblTime.Text = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss}";
      
      //Thread.Sleep(100);

      lblStatusTime.Text = $"{DateTime.Now:HH:mm:ss}";
    }


    private void btnStart_Click(object sender, EventArgs e)
    {
      btnStart.Enabled = false;
      lblStatusWorker.Text = $"gestartet...";
      lbStatus.Items.Clear();

      backgroundWorker1.WorkerReportsProgress = true;
      backgroundWorker1.RunWorkerAsync(new Person());
    }


    private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
    {
      var p = e.Argument as Person;

      for (int i = 0; i < 10; i++)
      {
        Thread.Sleep(2000);
        backgroundWorker1.ReportProgress(i + 1, null);        
      }      
    }


    private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
    {
      var status = e.ProgressPercentage;

      lblStatusWorker.Text = $"Schritt {status}...";
      lbStatus.Items.Add($"Schritt {status}...");

      if (status < 3)
        lblStatusWorker.ForeColor = Color.Blue;
      else
        lblStatusWorker.ForeColor = Color.DarkGreen;
    }


    private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
    {
      btnStart.Enabled = true;
      lblStatusWorker.Text = $"fertig...";
    }


    private void SetStatus(int status)
    {
      lblStatusWorker.Text = $"Schritt {status}...";
      lbStatus.Items.Add($"Schritt {status}...");

      if (status < 3)
        lblStatusWorker.ForeColor = Color.Blue;
      else
        lblStatusWorker.ForeColor = Color.DarkGreen;
    }


    private void btnThreadTest_Click(object sender, EventArgs e)
    {
      //Action a = this.XY;
      //this.Test(this.XY);

      //this.Runner(10);

      Task.Run(() => this.Runner(10));
    }


    private void Runner(int max)
    {
      for(int i=0; i< max; i++)
      {
        Debug.WriteLine($"Thread-ID={Thread.CurrentThread.ManagedThreadId:N0}");
        Thread.Sleep(2000);
        
      }
    }


    private void Test(Action act)
    {
      act();
    }


    private void XY()
    {
      btnStart.Enabled = false;
    }


    private void fswTemp_Created(object sender, System.IO.FileSystemEventArgs e)
    {
      var path = e.FullPath;

      Debug.WriteLine($"Info:{path} created");
    }


    private void fswTemp_Changed(object sender, System.IO.FileSystemEventArgs e)
    {
      var path = e.FullPath;

      Debug.WriteLine($"Info:{path} changed");
    }

    private void fswTemp_Deleted(object sender, System.IO.FileSystemEventArgs e)
    {
      var path = e.FullPath;

      Debug.WriteLine($"Info:{path} deleted");
    }
  }

}
