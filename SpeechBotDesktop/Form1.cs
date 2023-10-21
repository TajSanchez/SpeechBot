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
using System.Net;
using System.Speech.Synthesis;

namespace SpeechBotDesktop
{
    public partial class Form1 : Form
    {
        SpeechRecognitionEngine listener = new SpeechRecognitionEngine();

        public Form1()
        {
            InitializeComponent();
            listener.SetInputToDefaultAudioDevice();
            listener.LoadGrammarAsync(new Grammar(new GrammarBuilder(new Choices("hello", "how are you", "Nice weather today", "My name is Taj"))));
            //EventHandler<SpeechRecognizedEventArgs> speech_recognized = Speech_Recognized();
            listener.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(Speech_Recognized);
        }


      

        private void Speech_Recognized(object sender, SpeechRecognizedEventArgs e)
        {
            string Speech = e.Result.Text;
            Textbox.Text = Speech;
        }

        private void Speak_Click(object sender, EventArgs e)
        {
            listener.RecognizeAsync(RecognizeMode.Multiple);           
            Speak.Enabled = false;
            Stop.Enabled = true;
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            listener.RecognizeAsyncCancel();
            Speak.Enabled = true;
            Stop.Enabled = false;
        }
    }
}
