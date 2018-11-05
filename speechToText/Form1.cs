using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Recognition;

namespace speechToText
{
    public partial class Form1 : Form
    {
        private Boolean isOn = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void recordBtn_Click(object sender, EventArgs e)
        {


            SpeechRecognitionEngine speechRecognitionEngine = new SpeechRecognitionEngine(new System.Globalization.CultureInfo("en-us"));
            speechRecognitionEngine.LoadGrammar(new DictationGrammar());
            speechRecognitionEngine.SetInputToDefaultAudioDevice();
            if (!isOn) {
                recordBtn.Text = "Stop";
                isOn = true;

                speechRecognitionEngine.RecognizeAsync(RecognizeMode.Multiple);
                speechRecognitionEngine.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(speechRecognitionEngine_recognize);
            } else {                
                recordBtn.Text = "Start";
                isOn = false;
            }
        }

        private void speechRecognitionEngine_recognize(object sender, SpeechRecognizedEventArgs e)
        {
            if (!isOn) {
                ((SpeechRecognitionEngine)sender).RecognizeAsyncCancel();
            }
            resultTxtBox.AppendText(e.Result.Text + "\r\n");

        }
    }
}
