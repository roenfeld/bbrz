using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinPersonen
{
  public class ToDo
  {
    public string Name { get; set; }

    public string Description { get; set; }


    public void Write2XmlFile(string dateiName, List<ToDo> alleTodos)
    {
      var sw = new System.IO.StreamWriter(dateiName);

      var ser = new System.Xml.Serialization.XmlSerializer(typeof(List<ToDo>));
      ser.Serialize(sw, alleTodos);

      sw.Close();
    }


  }


}
