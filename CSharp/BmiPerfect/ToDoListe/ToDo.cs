using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoListe
{

  public class ToDo
  {
    //public ToDo()
    //{
    //  this.EndDate = DateTime.Now.AddDays(14);
    //  this.What = "Description?";
    //  this.Who = "I";
    //}

    public DateTime EndDate { get; set; }

    public string What { get; set; } = "???";
    public string Who { get; set; } = "I";

    public bool IsDone { get; set; } = true;
  }


}
