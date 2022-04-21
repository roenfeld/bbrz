using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinSteuerElemente
{
  public partial class FrmMain
  {
    private void InitGui()
    {
      this.InitCheckBoxes();

      this.InitDateTime();

      this.InitTextBox();

      this.InitNumeric();

      var fileName = @"F:\Temp\Test.rtf";
      this.InitRtfTextBox(fileName);

      this.InitDataBindings();

      tabMain.SelectedTab = tpInputCtrls;

      //webBrowser1.Navigate(@"F:\Temp\Test.pdf");

      // siehe TabMain.SelectedIndexChanged...
      //this.AddListBoxItems();
      //lbNamen.SelectedIndex = 2;
      //lbNamen.SelectedItem = "Hawaii";
    }


    private void InitCheckBoxes()
    {
      chkCheese.Checked = false;
      chkBacon.CheckState = CheckState.Unchecked;
      chkPfeff.Checked = true;
    }


    private void InitDateTime()
    {
      this.dtpBestellDatum.Value = DateTime.Parse("2022-03-03T11:47:53");

      this.dtpBestellDatum.Format = DateTimePickerFormat.Custom;
      this.dtpBestellDatum.CustomFormat = "dddd, dd.MMM.yyyy HH:mm";
    }


    private void InitTextBox()
    {
      var txt = File.ReadAllText(@"F:\Temp\Personen.xml");
      txtName.Text = txt;
    }


    private void InitNumeric()
    {
      numWert.Minimum = decimal.MinValue;
      numWert.Maximum = decimal.MaxValue;
      numWert.DecimalPlaces = 3;
      numWert.ThousandsSeparator = true;
      numWert.Value = 4114.56m;
    }


    private void InitRtfTextBox(string fileName)
    {      
      txtInfo.LoadFile(fileName);
      txtInfo.ZoomFactor = 1.5f;

      lblFileName.Text = fileName;
    }


    private void InitDataBindings()
    {
      prgVerlauf.Style = ProgressBarStyle.Blocks;
      prgVerlauf.Maximum = trackBar1.Maximum;

      lblHeight.DataBindings.Add("Text", trackBar1, "Value");
      prgVerlauf.DataBindings.Add("Value", trackBar1, "Value");

      btnExit.DataBindings.Add("Enabled", chkCanExit, "Checked");
    }


  }
}
