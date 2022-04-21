using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace WinSteuerElemente
{
  public partial class FrmMain : Form
  {
    public FrmMain()
    {
      InitializeComponent();

      var p = new Person();

      this.InitNumeric();
    }

    private void FrmMain_Load(object sender, EventArgs e)
    {
      this.InitGui();
    }


    private void AddListBoxItems()
    {
      //this.lbNamen.Items.AddRange(new object[] {
      //      "Ananas",
      //      "Himbeeren",
      //      "Erdbeeren",
      //      "Brombeeren"});

      //lbNamen.Items.Clear();
      lbNamen.Sorted = false;

      lbNamen.Items.Add("Himbeeren");
      lbNamen.Items.Insert(1, "Quatro Stagione");
      lbNamen.Items.Add("Erdbeeren");

      lbNamen.Items.Add(this.btnExit);
      lbNamen.Items.Add(new Person());
      lbNamen.Items.Add(55);
      lbNamen.Items.Add(0xA1);
      lbNamen.Items.Add(Properties.Resources.delete_icon);

      for (int i = 0; i < 100; i++)
      {
        lbNamen.Items.Add($"Test-{i+1}");
      }

      lbNamen2.Items.AddRange(lbNamen.Items);

      cbPLZ.Items.Add("8010");
      cbPLZ.Items.Add("8011");
      cbPLZ.Items.Add("8020");
      cbPLZ.Items.Add("8045");
      cbPLZ.Items.Add("8051");

      //cbPLZ.SelectedIndex = 3;

      var dirName = @"F:\Temp";
      var di = new DirectoryInfo(dirName);
      var allFiles = di.GetFiles();

      //this.cbPLZ.Items.Clear();
      //foreach (var file in allFiles)
      //{
      //  this.cbPLZ.Items.Add(file);
      //}
      cbPLZ.DataSource = allFiles;

      lbNamen.DataSource = allFiles;
      lbNamen.DisplayMember = "Length";
    }


    private void btnExit_Click(object sender, EventArgs e)
    {
      this.Exit();
    }


    private void lbNamen_SelectedIndexChanged(object sender, EventArgs e)
    {
      int idx = lbNamen.SelectedIndex;
      var item = lbNamen.SelectedItem;

      var txt = $"idx={idx}, item={item}";
      this.Text = txt;
    }


    private void tabMain_SelectedIndexChanged(object sender, EventArgs e)
    {
      int idx = tabMain.SelectedIndex;
      var tab = tabMain.SelectedTab;

      var txt = $"idx={idx}, item={tab}";
      this.Text = txt;

      if (tabMain.SelectedTab == tpListBox)
      {
        this.AddListBoxItems();
        lbNamen.SelectedIndex = 2;
        lbNamen.SelectedItem = "Hawaii";
      }
    }

    private void calHolidays_DateChanged(object sender, DateRangeEventArgs e)
    {
      var txt = calHolidays.SelectionStart.ToString("dddd, dd.MMM.yyyy");
      //txt = calHolidays.SelectionStart.ToLongDateString();
      lblLieferDatum.Text = txt;
      
    }

    private void lblTest_MouseEnter(object sender, EventArgs e)
    {
      lblTest.BackColor = Color.Orange;
    }

    private void lblTest_MouseLeave(object sender, EventArgs e)
    {
      lblTest.BackColor = lblTest.Parent.BackColor;
    }

    private void llWebOrf_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      System.Diagnostics.Process.Start(llWebOrf.Text);
    }

    private void btnProgress_Click(object sender, EventArgs e)
    {
      //if (prgVerlauf.Value == prgVerlauf.Maximum)
      //  prgVerlauf.Value = prgVerlauf.Minimum;

      //prgVerlauf.Value += 10;

      if (prgVerlauf.Style == ProgressBarStyle.Marquee)
        prgVerlauf.Style = ProgressBarStyle.Continuous;
      else
        prgVerlauf.Style = ProgressBarStyle.Marquee;
    }


    private void trackBar1_ValueChanged(object sender, EventArgs e)
    {
      //lblHeight.Text = trackBar1.Value.ToString();
    }

    private void mnuDateiBeenden_Click(object sender, EventArgs e)
    {
      this.Exit();
    }

    private void cmNiMainInfo_Click(object sender, EventArgs e)
    {

    }

    private void cmNiMainBeenden_Click(object sender, EventArgs e)
    {
      this.Exit();
    }

    private void cmNiMain_Opening(object sender, CancelEventArgs e)
    {
      var txt = calHolidays.SelectionStart.ToString();

      cmNiMainInfo.DropDownItems.Clear();
      cmNiMainInfo.DropDownItems.Add(txt,
                    Properties.Resources.delete_icon,
                    cmNiMainInfoDynamic_Click);
    }


    private void cmNiMainInfoDynamic_Click(object sender, EventArgs e)
    {
      MessageBox.Show("Info...");
    }


    private void btnSetPanelColor_Click(object sender, EventArgs e)
    {
      this.SetPanelColor();
    }

    private void btnSetPanelFont_Click(object sender, EventArgs e)
    {
      this.SetPanelFont();
    }

    private void btnOpenFile_Click(object sender, EventArgs e)
    {
      this.OpenFile();
    }

    private void button2_Click(object sender, EventArgs e)
    {
      this.SaveFile();
    }

    private void btnSelectFolder_Click(object sender, EventArgs e)
    {
      this.SetFolder();
    }

    
  }
}
