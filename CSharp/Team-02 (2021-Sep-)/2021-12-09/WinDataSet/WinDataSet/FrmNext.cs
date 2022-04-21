using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinDataSet
{
  public partial class FrmNext : Form
  {
    public FrmNext()
    {
      InitializeComponent();
    }


    private DsDaten.PersonenRow _personenRow;
    public DsDaten.PersonenRow PersonenRow
    {
      get { return _personenRow; }
      set
      {
        _personenRow = value;
        dsMain.Personen.ImportRow(_personenRow);
      }
    }

    private DsDaten.PersonenDataTable _personenTable;
    public DsDaten.PersonenDataTable PersonenTable
    {
      get { return _personenTable; }
      set
      {
        _personenTable = value;
        bsPersonen.DataSource = _personenTable;
      }
    }

    private void button1_Click(object sender, EventArgs e)
    {
      var f = new SaveFileDialog();
      f.ShowDialog();
    }


  }
}
