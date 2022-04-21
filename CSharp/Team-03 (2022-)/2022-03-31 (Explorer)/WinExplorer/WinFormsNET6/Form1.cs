namespace WinFormsNET6
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();

      numericUpDown1.DataBindings.Add("Value", trackBar1, "Value");
    }
  }
}