using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinSerialisierung
{
  public class Person
  {
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public DateTime BirthDay { get; set; }

    public string Info { get; set; }


    public override string ToString()
    {
      return $"{LastName}" + ", " + FirstName + $" [* {BirthDay:D}]";
    }


    public static void WriteXml(string fullFileName, List<Person> lst)
    {
      //@"F:\Daten\00 Schulungsunterlagen\CodersBay\CSharp\Personen.xml"
      var ser = new System.Xml.Serialization.XmlSerializer(typeof(List<Person>));
      var sw = new System.IO.StreamWriter(fullFileName);
      ser.Serialize(sw, lst);
      sw.Close();
    }


    public static List<Person> ReadXml(string fullFileName)
    {
      var ser = new System.Xml.Serialization.XmlSerializer(typeof(List<Person>));
      var sr = new System.IO.StreamReader(fullFileName);

      var lst = ser.Deserialize(sr) as List<Person>;
      sr.Close();

      return lst;
    }

  }

}
