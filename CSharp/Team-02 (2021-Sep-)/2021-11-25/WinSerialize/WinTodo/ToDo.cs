using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinTodo
{
  public class ToDo
  {
    public string Name { get; set; }
    public string Who { get; set; }
    public DateTime DeadLine { get; set; }
    public bool Done { get; set; }
  }
}
