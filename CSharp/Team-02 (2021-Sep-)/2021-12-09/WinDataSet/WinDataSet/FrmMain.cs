using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinDataSet
{
  public partial class FrmMain : Form
  {

    public FrmMain()
    {
      InitializeComponent();     
    }

    private void LoadData()
    { 
      var fileName = "Daten.xml";
      var fullFileName = Path.Combine(this.DefaultDirName, fileName);
      
      dsMain.Clear();
      dsMain.ReadXml(fullFileName);
    }


    private void SaveData()
    {
      var fileName = "Daten.xml";
      var fullFileName = Path.Combine(this.DefaultDirName, fileName);
      dsMain.WriteXml(fullFileName);
    }


    public string DefaultDirName
    {
      get 
      { 
        var dir = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
        dir = Path.Combine(dir, "BBRZ");
        Directory.CreateDirectory(dir);
        return dir;
      }
    }



    private void btnSaveData_Click(object sender, EventArgs e)
    {
      dgvPersonen.EndEdit();
      bsPersonen.EndEdit();
      SaveData();
    }


    private void btnLoadData_Click(object sender, EventArgs e)
    {
      LoadData();
    }

    private void bsPersonen_ListChanged(object sender, ListChangedEventArgs e)
    {
      Debug.WriteLine($"bsPersonen_ListChanged:{e.ListChangedType}");
    }

    private void btnNextStep_Click(object sender, EventArgs e)
    {
      var current = bsPersonen.Current;

      var rowView = current as DataRowView;

      var person = rowView.Row as DsDaten.PersonenRow;

      var n = person.Vorname;

      var f = new FrmNext();
      f.PersonenRow = person;
      //f.PersonenTable = dsMain.Personen;
      f.StartPosition = FormStartPosition.Manual;
      f.Location = this.Location;
      f.ShowDialog();

      btnNextStep.Text = "danach";
    }


  }
}
