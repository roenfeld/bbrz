using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinPersonen
{
  public partial class FrmMain : Form
  {
    private string FullFileName = 
      @"F:\Daten\00 Schulungsunterlagen\CodersBay\CSharp\Tag13 (2021-08-19)\WinPersonen\TestPerson.xml";

    private List<Person> allePersonen = new List<Person>();


    public FrmMain()
    {
      InitializeComponent();

      incomeTextBox.DataBindings.Add("Text", bsPersonen, "Income");

      this.bsPersonen.DataSource = this.allePersonen;
    }


    private void btnSavePersons_Click(object sender, EventArgs e)
    {
      Person.WriteXml(this.FullFileName, this.allePersonen);
    }


    private void speichernUnterToolStripMenuItem_Click(object sender, EventArgs e)
    {
      var res = this.saveFileDialog1.ShowDialog();

      if (res == DialogResult.OK)
      {
        this.FullFileName = this.saveFileDialog1.FileName;

        Person.WriteXml(this.FullFileName, this.allePersonen);
      }
    }


  }
}
