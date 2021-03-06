using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinSerialize
{
  public partial class FrmMain : Form
  {
    private static string AB = "AB";
    public static string CD = "CD";
    public string EF = "EF";
    public string GH = "GH";

    private const string DataDirName = @"F:\Daten\00 Schulungsunterlagen\CodersBay\gitRepo\CSharp\01DATA";

    private List<Person> _persons = new List<Person>();

    public FrmMain()
    {
      InitializeComponent();

      Person p1 = new Person();
      p1.FirstName = "Max";
      p1.LastName = "Greinix";
      p1.BirthDay = DateTime.Parse("1993-12-18");

      var p2 = new Person()
      {
        FirstName = "Dave",
        LastName = "Jursitzky",
        BirthDay = DateTime.Parse("1997-02-02"),
        HeightCm = 188.1f
      };

      _persons.Add(p1);
      _persons.Add(p2);
      _persons.Add(new Person()
      {
        FirstName = "Lucy",
        LastName = "Trattner",
        BirthDay = DateTime.Parse("1992-07-31"),
        HeightCm = 169.3f,
        Password = "strenggeheim"
      });
    }


    public List<Person> Persons
    {
      get { return this._persons; }
    }


    private string DataFileName
    {
      get
      {
        var dirName = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
        var fileName = System.IO.Path.Combine(dirName, "Personen.xml");
        return fileName;
      }
    }


    public void LoadData()
    {
      this.LoadData(this.DataFileName);
    }

    private void LoadData(string fileName)
    {
      this._persons = Person.Deserialize(fileName);      
    }


    private void SaveData(string fileName)
    {
      Person.Serialize(fileName, this._persons);
    }


    private void btnXmlSerialize_Click(object sender, EventArgs e)
    {
      // No GO, wenn in C:\Programme... installiert
      //var dirName = Application.StartupPath;
      //var dirName = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
      //var fileName = System.IO.Path.Combine(dirName, "Personen.xml");
      this.SaveData(this.DataFileName);
    }

    private void btnXmlDeSerialize_Click(object sender, EventArgs e)
    {
      this._persons = Person.Deserialize(this.DataFileName);
      
      this.lbPersonen.DataSource = this._persons;
      //this.lbPersonen.DisplayMember = "BirthDay";

      this.dgvPersonen.DataSource = this._persons;
    }

    private void mnuFileSave_Click(object sender, EventArgs e)
    {
      this.SaveData(this.DataFileName);
    }

    private void mnuFileSaveAs_Click(object sender, EventArgs e)
    {
      var sfd = new SaveFileDialog();
      sfd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);

      if (sfd.ShowDialog(this) == DialogResult.OK)
      {
        this.SaveData(sfd.FileName);
      }
    }

  }
}
