using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinSerialisierung
{
  public partial class FrmTest : Form
  {
    private const string DirectoryName = @"F:\Daten\00 Schulungsunterlagen\CodersBay\CSharp";

    private static readonly string XmlFileName = System.IO.Path.Combine(DirectoryName, "Personen.xml");

    public FrmTest()
    {
      InitializeComponent();
    }


    private List<Person> GetPersonen()
    {
      var lst = new List<Person>();

      var p = new Person();
      p.FirstName = "Attila";
      p.LastName = "Hazafy";
      p.BirthDay = DateTime.Parse("1981-05-06");
      p.Info = "BBRZ";

      lst.Add(p);

      p = new Person() { 
        FirstName = "Kevin", 
        LastName = "Kaltenegger", 
        BirthDay = DateTime.Parse("1995-03-09"), 
        Info = "TN" };

      lst.Add(p);

      return lst;
    }


    private void btnXMLSerialize_Click(object sender, EventArgs e)
    {
      var p = new Person();
      p.FirstName = "Attila";
      p.LastName = "Hazafy";
      p.BirthDay = DateTime.Parse("1981-05-06");
      p.Info = "BBRZ";
      
      var ser = new System.Xml.Serialization.XmlSerializer(typeof(Person));
      var sw = new System.IO.StreamWriter(@"F:\Daten\00 Schulungsunterlagen\CodersBay\CSharp\Person.xml");
      ser.Serialize(sw, p);
      sw.Close();
    }


    private void btnXmlDESerialize_Click(object sender, EventArgs e)
    {
      try
      {
        var ser = new System.Xml.Serialization.XmlSerializer(typeof(Person));
        var sr = new System.IO.StreamReader(@"F:\Daten\00 Schulungsunterlagen\CodersBay\CSharp\Person.xml");
        var p = ser.Deserialize(sr) as Person;
      }
      catch(Exception ex)
      {
        MessageBox.Show(this, ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        System.Diagnostics.Process.Start(@"F:\Daten\00 Schulungsunterlagen\CodersBay\CSharp\Person.xml");
      }
    }


    private void btnJsonSerialize_Click(object sender, EventArgs e)
    {
      var p = new Person();
      p.FirstName = "Kevin";
      p.LastName = "Kaltenegger";
      p.BirthDay = DateTime.Parse("1995-03-09");
      p.Info = "BBRZ";

      string json = Newtonsoft.Json.JsonConvert.SerializeObject(p);
      var sw = new System.IO.StreamWriter(@"F:\Daten\00 Schulungsunterlagen\CodersBay\CSharp\Person.json");
      sw.Write(json);
      sw.Close();
    }


    private void btnJsonDESerialize_Click(object sender, EventArgs e)
    {
      var sr = new System.IO.StreamReader(@"F:\Daten\00 Schulungsunterlagen\CodersBay\CSharp\Person.json");
      string json = sr.ReadToEnd();
      sr.Close();
      var p = Newtonsoft.Json.JsonConvert.DeserializeObject<Person>(json);

      //var x = Newtonsoft.Json.JsonConvert.DeserializeObject(json);
      //p = x as Person;
    }


    private void btnXmlSerializeList_Click(object sender, EventArgs e)
    {
      var lst = new List<Person>();

      var p = new Person();
      p.FirstName = "Attila";
      p.LastName = "Hazafy";
      p.BirthDay = DateTime.Parse("1981-05-06");
      p.Info = "BBRZ";

      lst.Add(p);

      p = new Person()
      {
        FirstName = "Kevin",
        LastName = "Kaltenegger",
        BirthDay = DateTime.Parse("1995-03-09"),
        Info = "TN"
      };

      lst.Add(p);

      //var ser = new System.Xml.Serialization.XmlSerializer(typeof(List<Person>));
      //var sw = new System.IO.StreamWriter(@"F:\Daten\00 Schulungsunterlagen\CodersBay\CSharp\Personen.xml");
      //ser.Serialize(sw, lst);
      //sw.Close();
      
      Person.WriteXml(FrmTest.XmlFileName, lst);
    }


    private void btnXmlDESerializeList_Click(object sender, EventArgs e)
    {
      //var ser = new System.Xml.Serialization.XmlSerializer(typeof(List<Person>));
      //var sr = new System.IO.StreamReader(@"F:\Daten\00 Schulungsunterlagen\CodersBay\CSharp\Personen.xml");

      //var lst = ser.Deserialize(sr) as List<Person>;
      //sr.Close();


      //var lst = Person.ReadXml(@"F:\Daten\00 Schulungsunterlagen\CodersBay\CSharp\Personen.xml");
      var lst = Person.ReadXml(FrmTest.XmlFileName);

      lbPersonen.DataSource = lst;
      lbPersonen.DisplayMember = nameof(Person.LastName);
    }

    
    private void btnJsonSerializeList_Click(object sender, EventArgs e)
    {
      var lst = this.GetPersonen();

      string json = Newtonsoft.Json.JsonConvert.SerializeObject(lst, Newtonsoft.Json.Formatting.Indented);

      var sw = new System.IO.StreamWriter(@"F:\Daten\00 Schulungsunterlagen\CodersBay\CSharp\Personen.json");
      sw.Write(json);
      sw.Close();
    }



    
  }
}
