using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinSteuerElemente
{
  public partial class FrmTest : Form
  {
    public FrmTest()
    {
      InitializeComponent();

      //label1.DataBindings.Add("Text", trackBar1, "Value");

      //textBox1.DataBindings.Add("Text", trackBar1, "Value");

      //button1.DataBindings.Add("Top", trackBar1, "Value");

      lblStatus.Text = "Es werkelt..!";
      lblStatus.ForeColor = Color.Red;
    }

    private void trackBar1_ValueChanged(object sender, EventArgs e)
    {
      label1.Text = trackBar1.Value.ToString();
      textBox1.Text = trackBar1.Value.ToString();

      button1.Top = trackBar1.Value;
    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {
      int val = int.Parse(textBox1.Text);

      trackBar1.Value = val;
    }

    private void toolStripDropDownButton1_Click(object sender, EventArgs e)
    {
      this.Close();
    }
  }
}
