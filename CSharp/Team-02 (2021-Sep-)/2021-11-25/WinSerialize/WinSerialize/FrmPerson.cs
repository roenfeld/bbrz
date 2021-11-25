using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinSerialize
{
  public partial class FrmPerson : Form
  {
    public FrmPerson()
    {
      InitializeComponent();
    }

    private void btnLoadData_Click(object sender, EventArgs e)
    {
      var lst = Person.Deserialize(@"C:\ProgramData\Personen.xml");
    }

  }
}
