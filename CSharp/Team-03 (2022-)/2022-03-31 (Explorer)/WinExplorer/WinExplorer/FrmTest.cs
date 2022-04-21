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

namespace WinExplorer
{
  public partial class FrmTest : Form
  {
    public FrmTest()
    {
      InitializeComponent();

      btnFillTree.Tag = DateTime.Now;

      this.AddDrives();
      lvwTest.Items.Clear();

      //dgvColLength.DataPropertyName = "Hubraum";
      //dgvColName.DataPropertyName = "Zylinder";
      //dgvFiles.DataSource = Auto.GetAutos();
    }

    private void FrmTest_FormClosed(object sender, FormClosedEventArgs e)
    {
      Properties.Settings.Default.Save();
    }


    private void trvTest_BeforeExpand(object sender, TreeViewCancelEventArgs e)
    {
      //e.Node.ForeColor = Color.LightGray;
      this.AddDirectories(e.Node);
    }


    private void trvTest_AfterExpand(object sender, TreeViewEventArgs e)
    {
    }
    

    private void trvTest_AfterSelect(object sender, TreeViewEventArgs e)
    {
      var dirInfo = e.Node.Tag as DirectoryInfo;
      this.AddFiles(dirInfo, mnuOptionsIncludeDirs.Checked); 
    }


    private void lvwTest_DoubleClick(object sender, EventArgs e)
    {
      this.StartProcess();
    }

    private void mnuOptionsIncludeDirs_CheckedChanged(object sender, EventArgs e)
    {
      var dirInfo = this.trvTest.SelectedNode?.Tag as DirectoryInfo;
      this.AddFiles(dirInfo, mnuOptionsIncludeDirs.Checked);
    }


    private void mnuOptionsSettingsOpenExplorer_Click(object sender, EventArgs e)
    {
      this.OpenUserConfigDirectory();
    }


    private void mnuOptionsFont_Click(object sender, EventArgs e)
    {
      this.SetFont();
    }


    private void dgvFiles_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
    {
      var item = dgvFiles.Rows[e.RowIndex].DataBoundItem;
      var tt = item.GetType();
    }

  }


  public class Auto
  {
    public string Marke { get; set; }
    public string Type { get; set; }
    public int Hubraum { get; set; }

    public static List<Auto> GetAutos()
    {
      var lst = new List<Auto>();
      lst.Add(new Auto() { Marke = "BMW", Type = "330", Hubraum=2947 });
      lst.Add(new Auto() { Marke = "Opel", Type = "Zafira", Hubraum=1955 });
      lst.Add(new Auto() { Marke = "VW", Type = "Golf" });
      return lst;
    }
  }
}


/*
 *
    private void btnFillTree_Click(object sender, EventArgs e)
    {
      this.AddDrives();
    }


    private void btnFillList_Click(object sender, EventArgs e)
    {
      lvwTest.Items.Clear();

      var item = lvwTest.Items.Add("", "Attila", 2);
      item.BackColor = Color.LightSteelBlue;
      //item.ForeColor = Color.Orange;
      //item.UseItemStyleForSubItems = false;

      var subItem = item.SubItems.Add("185");
      subItem.ForeColor = Color.DarkGreen;

      subItem = item.SubItems.Add("Sprachwissenschaften");
      subItem.ForeColor = Color.Yellow;

      lvwTest.Items.Add("", "Andreas", 1);
      lvwTest.Items.Add("", "Rene", 3);
      lvwTest.Items.Add("", "Walter", 0);
    }

    
 */