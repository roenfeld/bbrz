using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FensterTechnikShow
{
  public partial class FrmMain : Form
  {
    FrmZwo FormGreen;

    public FrmMain()
    {
      InitializeComponent();
    }

    private void FrmMain_LocationChanged(object sender, EventArgs e)
    {
      //if ( this.FormGreen != null)
      //{
      //  this.FormGreen.Left = this.Left - 200;
      //  this.FormGreen.Top = this.Top + 20;
      //}
    }


    private void btnFenster2_Click(object sender, EventArgs e)
    {
      this.ShowFenster2();
    }

    private void mnuDateiFenster2_Click(object sender, EventArgs e)
    {
      this.ShowFenster2();
    }

    private void mnuDateiFensterZu_Click(object sender, EventArgs e)
    {
      if ( this.FormGreen != null )
        this.FormGreen.Close();

      foreach(var f in this.OwnedForms)
      {
        f.Close();
      }
    }


    private void ShowFenster2()
    {
      if ( this.FormGreen == null ) // || this.FormGreen.IsDisposed)
      {
        // SDI Varinate: Singel Document Interface
        this.FormGreen = new FrmZwo();
        //this.FormGreen.MdiParent = this;
        this.FormGreen.Owner = this;
        this.FormGreen.StartPosition = FormStartPosition.CenterScreen;
        
        this.FormGreen.Show();

        this.FormGreen.FormClosed += this.FormGreen_FormClosed;
      }
      else
      {
        this.FormGreen.WindowState = FormWindowState.Normal;
        this.FormGreen.BringToFront();
      }
      //this.btnFenster2.Text = DateTime.Now.ToLongTimeString();
    }


    private void FormGreen_FormClosed(object sender, FormClosedEventArgs e)
    {
      this.FormGreen = null;
      //this.ShowFenster2();
    }

    
  }

}
