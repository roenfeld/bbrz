using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinSerialize
{
  public class Person
  {
    #region Props

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public DateTime BirthDay { get; set; }


    //[System.Xml.Serialization.XmlAttribute("BodyHeight")]
    public float HeightCm { get; set; }


    //[System.Xml.Serialization.XmlIgnore()]
    public string Password { get; set; }


    public string FullName { get { return $"{FirstName} {LastName}"; } }

    #endregion


    public override string ToString()
    {
      return $"{FullName} {BirthDay:ddd, yyyy-MM-dd}";
    }


    #region De-Serialize

    public static List<Person> Deserialize(string fileName)
    {
      var sr = new System.IO.StreamReader(fileName);

      var ser = new System.Xml.Serialization.XmlSerializer(typeof(List<Person>));
      var tmp = ser.Deserialize(sr);
      var lst = tmp as List<Person>;

      sr.Close();
      return lst;
    }


    public static void Serialize(string fileName, List<Person> lst)
    {
      var datei = new System.IO.StreamWriter(fileName);

      var ser = new System.Xml.Serialization.XmlSerializer(typeof(List<Person>));
      ser.Serialize(datei, lst);

      datei.Close();
    }

    #endregion

  }
}
