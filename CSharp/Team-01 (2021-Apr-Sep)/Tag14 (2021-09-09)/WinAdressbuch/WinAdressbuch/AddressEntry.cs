using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinAdressbuch
{
  public class AddressEntry
  {
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Address { get; set; }
    public string PostCode { get; set; }
    public string City { get; set; }
    public string Country { get; set; }


    public static void WriteXmlFile(string fileName, List<AddressEntry> lst)
    {
      var sw = new System.IO.StreamWriter(fileName);

      var ser = new System.Xml.Serialization.XmlSerializer(typeof(List<AddressEntry>));
      ser.Serialize(sw, lst);

      sw.Close();
    }


    public static List<AddressEntry> ReadXmlFile(string fileName)
    {
      var sr = new System.IO.StreamReader(fileName);

      var ser = new System.Xml.Serialization.XmlSerializer(typeof(List<AddressEntry>));
      var obj = ser.Deserialize(sr);

      sr.Close();

      return obj as List<AddressEntry>;
    }


  }

}
