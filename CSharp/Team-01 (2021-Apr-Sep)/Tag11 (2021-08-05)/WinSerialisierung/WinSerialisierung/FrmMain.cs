using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinSerialisierung
{
  public partial class FrmMain : Form
  {
    public FrmMain()
    {
      InitializeComponent();
    }

    private void mnuFileOpen_Click(object sender, EventArgs e)
    {
      var ret = ofdPerson.ShowDialog(this);

      if (ret == DialogResult.OK)
      {
        var lst = Person.ReadXml(ofdPerson.FileName);
        bsPerson.DataSource = lst;
        dgvPerson.DataSource = bsPerson;
      }
    }

    private void mnuFileSaveAs_Click(object sender, EventArgs e)
    {
      var ret = sfdPerson.ShowDialog(this);

      if (ret == DialogResult.OK)
      {
        var lst = bsPerson.DataSource as List<Person>;
        Person.WriteXml(sfdPerson.FileName, lst);
      }

    }


  }
}
