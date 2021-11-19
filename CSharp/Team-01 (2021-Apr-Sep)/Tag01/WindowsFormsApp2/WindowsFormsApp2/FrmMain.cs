using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
  public partial class FrmMain : Form
  {
    public FrmMain()
    {
      InitializeComponent();

      //this.btnExit.Hide();
      this.btnExit.Text = "Beenden";
      this.btnExit.Height = 28;

      // wie im Designer-File
      //this.btnTest.Click += new System.EventHandler(this.eventHandler01);

      // Variante 2
      this.btnTest.Click += this.eventHandler01;
      this.btnTest.Click += this.eventHandler02;
      this.btnTest.Click += this.eventHandler03;

      this.textBox1.GotFocus += this.eventHandler01;
    }

    private void btnExit_Click(object sender, EventArgs e)
    {
      //this.Close();

      //this.btnExit.Hide();
      //this.btnExit.Visible = false;
      this.btnExit.Top = 100;

      // Eigenschaft (Property)
      this.ClickCount++;

      // Z 33 => Z 36 + 37
      int c = this.ClickCount;
      this.ClickCount = c + 1;

      // Properties sind Methoden(-paare)
      // Z 40-42 vom Compiler übersetzt, wenn Z 36/37
      //int c = this.get_ClickCount();
      //c++;
      //this.set_ClickCount(c);
    }


    public int ClickCount { get; set; }
    public string Message { get; set; }


    private void eventHandler01(object sender, EventArgs e)
    {
      this.BackColor = Color.Orange;
    }


    private void eventHandler02(object sender, EventArgs e)
    {
      this.ForeColor = Color.Red;
    }


    private void eventHandler03(object sender, EventArgs e)
    {
      this.textBox1.Visible = false;
    }


    //public int get_ClickCount() { return 1; }

    //public void set_ClickCount(int v) { v = v; }

  }
}
