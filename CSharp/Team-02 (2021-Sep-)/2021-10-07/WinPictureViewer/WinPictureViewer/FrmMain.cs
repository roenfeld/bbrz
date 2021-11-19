using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinPictureViewer
{
  //http://data.wien.gv.at/daten/OGDAddressService.svc/GetAddressInfo?Address=Geusaugasse 47 

  public enum ImpfStatus
  {
    Unbekannt = 17,
    Ungeimpft,
    Genesen,
    Geimpft = 23
  }

  public enum Status
  {
    None,
    Prepared,
    Open,
    Paid
  }

  public partial class FrmMain : Form
  {

    public FrmMain()
    {
      InitializeComponent();

      //this.webBrowser1.Url = null;
    }


    private void FrmMain_Load(object sender, EventArgs e)
    {
      //this.lblFileName.Text = this.webBrowser1.Url.ToString();

      // OK
      //if (this.webBrowser1.Url != null)
      //{
      //  this.lblFileName.Text = this.webBrowser1.Url.ToString();
      //}

      //
      //this.lblFileName.Text = this.webBrowser1.Url?.ToString();

      //this.lblFileName.Text = $"{this.webBrowser1.Url}";
    }


    private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
    {
      this.lblFileName.Text = $"{this.webBrowser1.Url}";
    }

    private void btnSelectImage_Click(object sender, EventArgs e)
    {      
      this.SelectImage();
    }


    private void oeffnenToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.SelectImage();
    }


    private void pictureBox1_Click(object sender, EventArgs e)
    {
      this.SelectImage();
    }


    private void SelectImage()
    {
      // URL als string
      //string fileName = @"F:\Daten\00 Schulungsunterlagen\CodersBay\Icons\Info.ico";
      //fileName = "https://docs.microsoft.com/favicon.ico";

      DialogResult result;

      result = ofdImage.ShowDialog();

      if (result == DialogResult.OK)
      {
        lblFileName.Text = ofdImage.FileName;        
        webBrowser1.Navigate(ofdImage.FileName);
        try
        {
          pictureBox1.Load(ofdImage.FileName);
        }
        catch { }
      }
    }


    private void stringTest()
    {
      //string dirName = @"F:\Daten\00 Schulungsunterlagen\CodersBay\Icons\";
      //string fileName = @"Info.ico";

      // interpolierter String
      //string fullFileName = $"{dirName}{fileName}";
      // ident wie vorige Zeile!
      //fullFileName = string.Format("{0}{1}", dirName, fileName);

      // interpoliert und escapesquenz ignorieren
      //fullFileName = $@"C:\Temp\{fileName}";

    }

    private void copyrightToolStripMenuItem_Click(object sender, EventArgs e)
    {
      MessageBox.Show("Copy ©", 
                "Fileviewer V0.8", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Information);
    }


    private void farbeÄndernToolStripMenuItem_Click(object sender, EventArgs e)
    {
      DialogResult res;
      res = colorDialog1.ShowDialog();
      if ( res == DialogResult.OK)
      {
        lblFileName.ForeColor = colorDialog1.Color;
      }
    }

    private void fontAendernToolStripMenuItem_Click(object sender, EventArgs e)
    {
      var ftDlg = new FontDialog();
      var res = ftDlg.ShowDialog();
      if ( res == DialogResult.OK)
      {
        this.Font = ftDlg.Font;
        this.menuStrip1.Font = ftDlg.Font;
      }
    }

    
  }
}
