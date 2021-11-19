using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FensterTechnik
{
  public partial class FrmMain : Form
  {
    public const string TYPE_LOGIN = "login";
    public const string TYPE_INFO = "info";

    private FrmLogin fLogin;
    private FrmInfo fInfo;

    private List<int> _werte = new List<int>();

    public FrmMain()
    {
      InitializeComponent();
    }


    private void CreateWindow(Form f, string typeOfForm)
    {
      if ( typeOfForm == nameof(FrmLogin))
      {
        if (f == null || f.IsDisposed)
        {
          fLogin = new FrmLogin();
          fLogin.Show();
          return;
        }        
      }

      if (typeOfForm == FrmMain.TYPE_INFO && (f == null || f.IsDisposed))
      {
        fInfo = new FrmInfo();
        fInfo.ShowDialog();
        return;
      }
    }



    private void CreateWindow(Form f, Type typeOfForm)
    {
      if ( typeOfForm == typeof(FrmLogin))
      {
        this.fLogin = new FrmLogin();
        this.fLogin.Show();
      }
    }


    private void CreateWindow<T>() where T : Form
    {
      if ( typeof(T) == typeof(FrmLogin) )
      {
        if (this.fLogin == null || this.fLogin.IsDisposed)
        {
          this.fLogin = new FrmLogin();
        }
        this.fLogin.Show();
      }
    }




    private void btnShowLogin_Click(object sender, EventArgs e)
    {
      //this.CreateWindow(this.fLogin, nameof(FrmLogin));
      //this.CreateWindow(this.fLogin, typeof(FrmLogin));
      this.CreateWindow<FrmLogin>();
    }

    private void btnShowInfo_Click(object sender, EventArgs e)
    {
      this.CreateWindow(this.fInfo, FrmMain.TYPE_INFO);
    }

  }


  public class Person
  {
    public const int MAX_LEN = 8;
    public string Name { get; set; }
  }
}
