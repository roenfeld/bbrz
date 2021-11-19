using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFileIO
{
  public partial class FrmMain : Form
  {
    public FrmMain()
    {
      InitializeComponent();
    }

    private string AppDataDirectory
    {
      get
      {
        var dir = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
        dir = Path.Combine(dir, ".00_BBRZ");
        Directory.CreateDirectory(dir);
        return dir;
      }
    }


    private string AppDataFileName
    {
      get
      {
        return Path.Combine(AppDataDirectory, "IOZahlen.txt");
      }
    }


    private void SaveData(string fileName)
    {
      // C:\Temp
      // C:\Temp\
      //var dir = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
      fileName = this.AppDataFileName;

      var sw = new StreamWriter(fileName);
      for (int i = 0; i < lbTest.Items.Count; i++)
      {
        decimal d = decimal.Parse(lbTest.Items[i].ToString());
        // WIRD ALS TEXT/STRING gespeichert!!!!!!!!!!!!!!!!!!!
        sw.WriteLine(d); // lbTest.Items[i]);
      }
      sw.Close();
    }


    private void LoadData(string fileName)
    {
      var sr = new StreamReader(fileName);

      var allText = sr.ReadToEnd();

      sr.Close();

      var ar = allText.Split("\n".ToCharArray());

      lbTest.Items.Clear();
      for (int i = 0; i < ar.Length; i++)
      {
        var x = ar[i].Trim();
        if (x.Length > 0)
        {
          var ok = decimal.TryParse(x, out decimal d);
          {
            // _values.Add(d);
            lbTest.Items.Add(d);
          }
        }
      }
    }


    private void LoadData_2(string fileName)
    {
      string line;
      List<string> lstLines = new List<string>();

      lbTest.Items.Clear();

      var sr = new StreamReader(fileName);

      while(true)
      {
        line = sr.ReadLine();
        if (line == null)
          break;

        lstLines.Add(line);
      }

      sr.Close();

      lbTest.Items.AddRange(lstLines.ToArray());
    }


    private void FrmMain_Load(object sender, EventArgs e)
    {
      var rd = new Random(DateTime.Now.Millisecond);

      for (int i = 0; i < 6; i++)
      {
        lbTest.Items.Add(rd.Next(1, 30));
      }

      this.lbTest.ContextMenuStrip = this.cmLbTest;
      this.cmLbTestOpen.Click += this.CmLbTestOpen_Click;

      //TestBin();
    }


    private void CmLbTestOpen_Click(object sender, EventArgs e)
    {
      var result = ofd.ShowDialog();
      if ( result == DialogResult.OK)
      {
        this.LoadData_2(ofd.FileName);
      }
    }


    private void cmLbTestSaveAs_Click(object sender, EventArgs e)
    {
      var sfd = new SaveFileDialog();
      sfd.Title = "123";
      var result = sfd.ShowDialog();
      if (result == DialogResult.OK)
      {
        this.SaveData(sfd.FileName);
      }
    }



    private void TestBin()
    {
      var fileName = @"F:\Daten\00 Schulungsunterlagen\CodersBay\CSharp\Team-02 (2021-Sep-)\Bin.dat";

      byte b = 65;

      var fs = new FileStream(fileName, FileMode.OpenOrCreate);
      var bw = new BinaryWriter(fs);
      bw.Write(b);
      b = 0x42;
      bw.Write(b);
      b = 0xFA;
      bw.Write(b);
      fs.Close();

    }

    private void btnSerialize_Click(object sender, EventArgs e)
    {
      var 
      var lst = lbTest.Items.OfType<string>().ToList();
    }


  }
}
