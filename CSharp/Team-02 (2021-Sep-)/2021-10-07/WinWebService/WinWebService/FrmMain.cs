using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinWebService
{

  //http://www.xignite.com/xCurrencies.asmx?wsdl

  public partial class FrmMain : Form
  {
    public FrmMain()
    {
      InitializeComponent();


      var cr = new ServiceReference1.CrossRate();
    }
  }
}
