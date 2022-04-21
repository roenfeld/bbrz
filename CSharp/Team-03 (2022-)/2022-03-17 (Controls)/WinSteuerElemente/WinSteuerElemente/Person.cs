using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinSteuerElemente
{
  public partial class Person
  {
    public string Name { get; set; } = "Heinzi";

    public override string ToString()
    {
      return $"Meine Name ist {this.Name}";
    }
  }
}
