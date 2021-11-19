using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinTest01
{
  public partial class FrmMain : Form
  {
    public FrmMain()
    {
      InitializeComponent();

      this.Load += new System.EventHandler(this.Fenster_Load);
      this.Load += new System.EventHandler(this.XY);
    }

    private void Fenster_Load(object sender, EventArgs e)
    {
      this.textBox1.BackColor = Color.LimeGreen;
    }


    private void XY(object sender, EventArgs e)
    {
      this.label1.BackColor = Color.LimeGreen;
    }



    private void btnExit_Click(object sender, EventArgs e)
    {
      this.Close();
    }


    private void textBox1_TextChanged(object sender, EventArgs e)
    {
      this.Text = this.textBox1.Text;
    }

    private void textBox1_BackColorChanged(object sender, EventArgs e)
    {
      textBox1.Text = "Juhu!!";
    }


    private void button1_Click(object sender, EventArgs e)
    {
      int x = 12;
      x++;
      this.Close();
    }

    
  }


  public class Sepp
  {
    //int X;
    void XY()
    {
      //this.X = 17;
    }
  }
}
