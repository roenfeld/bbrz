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

namespace WinImgViewerWH
{
  public partial class FrmMain : Form
  {

    public enum Status
    {
      None,
      Failed = -7,
      Begin = 1,
      Undefined,
      Ready
    }


    public FrmMain()
    {
      InitializeComponent();

      //lbFiles.Items.Add(5);
      //lbFiles.Items.Add(Math.PI);
      //lbFiles.Items.Add(txtFolder);

      //var p = new Person();
      //p.Name = "Heinzi";
      //lbFiles.Items.Add(p);

      //var url = "https://www.google.com/images/branding/googlelogo/2x/googlelogo_color_272x92dp.png";
      //picMain.ImageLocation = url;      
    }

    private void FrmMain_Load(object sender, EventArgs e)
    {
      FillListBox(txtFolder.Text);
    }

    private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
    {
      Properties.Settings.Default.Save();    
    }


    private void btnSelectFolder_Click(object sender, EventArgs e)
    {
      this.SelectFolder();
    }

    private void panel1_Paint(object sender, PaintEventArgs e)
    {
      var item = lbFiles.SelectedItem;
      if (item == null)
        return;

      var fullFileName = Path.Combine(txtFolder.Text, item.ToString());

      var img = Image.FromFile(fullFileName);
      e.Graphics.DrawImage(img, 3, 3);
    }


    private void lbFiles_SelectedIndexChanged(object sender, EventArgs e)
    {
      //int idx = lbFiles.SelectedIndex;
      //var item = lbFiles.Items[idx];

      var item = lbFiles.SelectedItem;
      var fullFileName = Path.Combine(txtFolder.Text, item.ToString());

      picMain.ImageLocation = fullFileName;

      panel1.Invalidate();
    }


    private void SelectFolder()
    {
      var res = dlgFolder.ShowDialog();
      dlgFolder.SelectedPath = txtFolder.Text;

      if (res == DialogResult.OK)
      {
        txtFolder.Text = dlgFolder.SelectedPath;
        FillListBox(dlgFolder.SelectedPath);

        // DataBinding !
        var di = new DirectoryInfo(dlgFolder.SelectedPath);
        //var allFiles = di.GetFiles();
        //listBox1.DataSource = allFiles;
      }
    }


    private void FillListBox(string dirName)
    {
      //var files = Directory.GetFiles(dirName, "*.ico");

      //lbFiles.Items.Clear();

      //for (int i=0; i<files.Length; i++)
      //{
      //  var fileName = Path.GetFileName(files[i]);
      //  lbFiles.Items.Add(fileName);
      //}

      //files = Directory.GetFiles(dirName, "*.png");
      //for (int i = 0; i < files.Length; i++)
      //{
      //  var fileName = Path.GetFileName(files[i]);
      //  lbFiles.Items.Add(fileName);
      //}


      var patterns = new string[] { "*.ico", "*.png", "*.jpg", "*.bmp" };

      foreach (var pa in patterns)
      {
        var fileNames = GetImageFileNames(dirName, pa);
        lbFiles.Items.AddRange(fileNames);
      }

    }


    private string[] GetImageFileNames(string dirName, string pattern)
    {
      //var di = new DirectoryInfo(dirName);
      //var allFileInfos = di.GetFiles("*.ico");

      var files = Directory.GetFiles(dirName, pattern);
      var fileNames = new string[files.Length];

      for (int i = 0; i < files.Length; i++)
      {
        var tmp = Path.GetFileName(files[i]);
        fileNames[i] = tmp;
      }

      return fileNames;
    }






    private void Test()
    {
      //var b = new BBRZ();
      //b.M1();

      BBRZ.S1();

      Person.Common = "XXXX";

      var p1 = new Person();
      p1.Name = "Aha";

      var p2 = new Person();
      p2.Name = "Pfü";

    }

    


  }


  public class Person
  {
    public static string Common;
    public string Name;

    public override string ToString()
    {
      return "Person:" + Name;
    }
  }


  public class BBRZ
  {
    public void M1() { }
    private void P1() { }
    public static void S1() { }


    public string X() { return ""; }
    public string[] Y() { return new string[] { "x", "y"}; }
  }


  public static class XY
  {
    public static void M() { }
    public static void N() { }
    public static void O() { }
  }

}
