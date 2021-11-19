using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFileIO
{
  public partial class FrmWinAPI : Form
  {
    public FrmWinAPI()
    {
      InitializeComponent();

      EventHandler cb = this.btnChangeParent_Click;
    }


    private void btnChangeParent_Click(object sender, EventArgs e)
    {
      IntPtr hWndDesktop = Win32.GetDesktopWindow();

      var hWndParent = Win32.GetParent(btnJuhuu.Handle);

      if ( hWndParent == hWndDesktop)
      {
        Win32.SetParent(btnJuhuu.Handle, this.Handle);
      }
      else
      {
        //btnJuhuu.Parent = null;
        Win32.SetParent(btnJuhuu.Handle, hWndDesktop);
      }
    }


    private void button2_Click(object sender, EventArgs e)
    {
      MessageBox.Show("Juhuu!");
    }
  }
}
