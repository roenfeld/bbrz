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


namespace WinWoerter
{
  public partial class FrmMain : Form
  {
    public FrmMain()
    {
      InitializeComponent();
    }

    private void FrmMain_Load(object sender, EventArgs e)
    {
      taWoerter.Fill(dsMain.Woerter);
    }


    private void btnReadFile_Click(object sender, EventArgs e)
    {
      var fileName = @"F:\Daten\00 Schulungsunterlagen\CodersBay\gitRepo\CSharp\Team-02 (2021-Sep-)\Woerter.txt";
      var lines = File.ReadAllLines(fileName);
      
      this.Text = $"{lines.Length:N0} Zeilen...";


      foreach (var line in lines.AsParallel())
      {
        //txtFilecontent.AppendText($"{line}\r\n");

        //var row = dsMain.Woerter.NewWoerterRow();
        //row.Wort = line;

        // ins DataSet und über BindingSource -> DataGridView
        //dsMain.Woerter.Rows.Add(row);

        // umi in die DB
        taWoerter.Insert(line, null);
      }

      
    }

    
  }
}
