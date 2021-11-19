using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WinPersonen
{
  public class Person
  {    
    public string Name { get; set; }
    public string Phone { get; set; }
    public DateTime BirthDay { get; set; }
    public decimal Income { get; set;  }


    public static void WriteXml(string fullFileName, List<Person> list)
    {
      var sw = new StreamWriter(fullFileName);

      var ser = new XmlSerializer(typeof(List<Person>));
      ser.Serialize(sw, list);

      sw.Close();
    }


    public static List<Person> ReadXml(string fullFileName)
    {
      var sr = new StreamReader(fullFileName);

      var ser = new XmlSerializer(typeof(List<Person>));
      var obj = ser.Deserialize(sr);

      sr.Close();

      return obj as List<Person>;
    }

  }

}
