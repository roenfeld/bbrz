using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Speech;
using System.Speech.Recognition;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinSpeech
{
  public partial class FrmMain : Form
  {
    public FrmMain()
    {
      InitializeComponent();

      this.ListSpeechRecognition();
    }

    private void btnStart_Click(object sender, EventArgs e)
    {
      this.StartSpeechRecognition();
    }

    private void btnStop_Click(object sender, EventArgs e)
    {

    }

    private void ListSpeechRecognition()
    {
      var spRecs = SpeechRecognitionEngine.InstalledRecognizers();
      this.cmbInstalledSpRec.DataSource = spRecs;
      this.cmbInstalledSpRec.DisplayMember = nameof(RecognizerInfo.Description);
      this.cmbInstalledSpRec.ValueMember = "Id";
    }


    private void StartSpeechRecognition()
    {
      var ri = this.cmbInstalledSpRec.SelectedItem as RecognizerInfo;
      if ( ri == null )
      {

      }
      else
      {
        var recognizer = new SpeechRecognitionEngine(ri.Culture);
        recognizer.LoadGrammar(new DictationGrammar());
        //recognizer.LoadGrammar(new Grammar(new GrammarBuilder("huach zua")) { Name="Steirisch" });
                
        recognizer.SpeechDetected += this.Recognizer_SpeechDetected;
        recognizer.SpeechRecognized += this.Recognizer_SpeechRecognized;
        recognizer.RecognizeCompleted += this.Recognizer_RecognizeCompleted;

        recognizer.SetInputToDefaultAudioDevice();
        recognizer.RecognizeAsync(RecognizeMode.Multiple);
      }
    }


    private void XY()
    {
      var txts = new Choices();
      //txts.Add()
    }



    private void Recognizer_RecognizeCompleted(object sender, RecognizeCompletedEventArgs e)
    {
      var tmp = e.Result?.Text;
    }

    private void Recognizer_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
    {
      var tmp = $"{e.Result.Words.Count} words = {e.Result?.Text}";
      this.lbRecogonized.Items.Insert(0, tmp);
    }

    private void Recognizer_SpeechDetected(object sender, SpeechDetectedEventArgs e)
    {
      var tmp = e.AudioPosition.TotalMilliseconds;
    }
  }
}
