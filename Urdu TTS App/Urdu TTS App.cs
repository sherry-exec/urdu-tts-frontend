using System;
using System.Windows.Forms;
using SSML;

namespace Urdu_TTS_App
{
    public partial class UrduTTSApp : Form
    {
        SsmlEncoding synth = new SsmlEncoding();
        bool playing = false;

        public UrduTTSApp()
        {
            InitializeComponent();
        }

        private void btnSpeak_Click(object sender, EventArgs e)
        {
            try
            {
                synth.SpeakStart(txtUrdu.Text);
                playing = true;
            }
            catch (Exception ex)
            {
                playing = false;
                MessageBox.Show(ex.Message);
            }
        }

        private void btnPauseResume_Click(object sender, EventArgs e)
        {
            try
            {
                if(playing)
                {
                    synth.SpeakPause();
                    playing = false;
                }
                else
                {
                    synth.SpeakResume();
                    playing = true;
                }
            }
            catch (Exception ex)
            {
                playing = false;
                MessageBox.Show(ex.Message);
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            try
            {
                synth.SpeakCancel();
            }
            catch (Exception ex)
            {
                playing = false;
                MessageBox.Show(ex.Message);
            }
        }

        private void VolumeBar_Scroll(object sender, EventArgs e)
        {
            try
            {
                synth.Volume = VolumeBar.Value * 10;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SpeechRate_Scroll(object sender, EventArgs e)
        {
            try
            {
                synth.Rate = SpeechRate.Value;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
