using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAdressbuch
{
  public partial class FrmMain : Form
  {
    private string AddressListFileName = @"F:\Temp\Addresses.xml";

    private List<AddressEntry> AllAddressList = new List<AddressEntry>();


    public FrmMain()
    {
      InitializeComponent();

      this.AllAddressList = AddressEntry.ReadXmlFile(this.AddressListFileName);
      this.bsAddress.DataSource = this.AllAddressList;
    }


    private void addressEntryBindingNavigatorSaveItem_Click(object sender, EventArgs e)
    {
      
    }


    private void mnuSave_Click(object sender, EventArgs e)
    {
      AddressEntry.WriteXmlFile(this.AddressListFileName, this.AllAddressList);
    }


    private void mnuSaveAs_Click(object sender, EventArgs e)
    {
      var dlg = new SaveFileDialog();
      dlg.ShowDialog();
    }


    private void mnuOptionsAbout_Click(object sender, EventArgs e)
    {
      MessageBox.Show("Juhu!!");
    }


    private void mnuSaveAs2_Click(object sender, EventArgs e)
    {
      var dlg = new SaveFileDialog();
      if ( dlg.ShowDialog() == DialogResult.OK)
      {
        this.AddressListFileName = dlg.FileName;
        AddressEntry.WriteXmlFile(dlg.FileName, this.AllAddressList);
      }
    }

  }
}
