using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Speech.Recognition;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinSpeechTest
{
  public partial class FrmMain : Form
  {
    public FrmMain()
    {
      InitializeComponent();

      InitSpeech();
    }

    private void InitSpeech()
    {
      var culture = new System.Globalization.CultureInfo("de-DE");
      var recognizer = new SpeechRecognitionEngine(culture);

      recognizer.LoadGrammar(new DictationGrammar());
      recognizer.SetInputToDefaultAudioDevice();
      recognizer.RecognizeAsync(RecognizeMode.Multiple);

      //recognizer.SpeechDetected += this.Recognizer_SpeechDetected;
      recognizer.SpeechRecognized += this.Recognizer_SpeechRecognized;
    }

    private void Recognizer_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
    {
      txtSpeechResult.AppendText(e.Result.Text + "\n");

      if (e.Result.Text.Contains("stop"))
        this.Close();

      //SpeechUI.SendTextFeedback(e.Result, "feedback?", false);
    }

    private void Recognizer_SpeechDetected(object sender, SpeechDetectedEventArgs e)
    {
      
    }

    private void btnTest_Click(object sender, EventArgs e)
    {

    }
  }
}
