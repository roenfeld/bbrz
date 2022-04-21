using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoListe
{
  public partial class FrmMain : Form
  {
    ToDo td = new ToDo();

    public FrmMain()
    {
      InitializeComponent();

      td.EndDate = DateTime.Now.AddMonths(1);
      td.What = "Was?";
      td.Who = "Attila?";

      bsTodo.DataSource = td;
    }

    private void FrmMain_Load(object sender, EventArgs e)
    {
    }

    private void btnTest_Click(object sender, EventArgs e)
    {
      var x = td.EndDate;
    }
  }
}
