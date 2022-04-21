using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinDatenTypen
{
  public partial class FrmMain : Form
  {
    public FrmMain()
    {
      InitializeComponent();
    }

    private void btnDatum_Click(object sender, EventArgs e)
    {
      var now = DateTime.Now;

      var alarmDatum = DateTime.Parse("2022-02-08T09:00:00");

      var in_1_Monat = now.AddMonths(1);
      var vor_2_Wochen = now.AddDays(-14);

      var restZeit = alarmDatum.Subtract(now);

      var x = restZeit.Minutes;


      var tmp = $"{now:yyyy-MM-dd}T{numHH.Value:00}:{numMin.Value:00}:00";

      alarmDatum = DateTime.Parse(tmp);


      System.Media.SystemSounds.Exclamation.Play();
    }


    private void timer1_Tick(object sender, EventArgs e)
    {
      var now = DateTime.Now;
      btnDatum.Text = $"...{now.Second} s  + {now.Millisecond} ms";
    }


    private void btnStartStop_Click(object sender, EventArgs e)
    {
      timer1.Enabled = !timer1.Enabled;
    }


  }
}
