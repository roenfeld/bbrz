using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WinSerPerson
{
  public class Person
  {
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public DateTime BirthDay { get; set; }

    public bool Active { get; set; }


    public int Age
    {
      get
      {
        var ts = DateTime.Now.Subtract(this.BirthDay);
        var dat = new DateTime(ts.Ticks);

        return dat.Year - 1;
      }
    }



    internal static List<Person> ReadFromXmlFile(string fileName)
    {
      object tmp;
      var sr = new StreamReader(fileName);
      var ser = new XmlSerializer(typeof(List<Person>));
      tmp = ser.Deserialize(sr);
      var lst = tmp as List<Person>;

      sr.Close();
      return lst;
    }


    internal static void WriteToXmlFile(string fileName, List<Person> lst)
    {
      using (var sw = new StreamWriter(fileName))
      {
        var ser = new XmlSerializer(typeof(List<Person>));
        ser.Serialize(sw, lst);
      } // sw.Dispose(); => sw.Close();      
    }

  }
}
