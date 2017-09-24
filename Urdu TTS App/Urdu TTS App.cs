using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using UrduTTS;

namespace Urdu_TTS_App
{
    public partial class UrduTTSApp : Form
    {
        System.Windows.Forms.Timer parseTimer = new System.Windows.Forms.Timer();

        // Speak variables
        SsmlEncoding synthesizer = new SsmlEncoding();
        bool playing = false;

        // Text analyzing threading variables
        Thread analyser = null;
        bool analyzing = false;

        // User selected diacritics
        List<WordRecord> selectedDiacritics = null;
        List<WordRecord> currentDiacritics = null;

        public UrduTTSApp()
        {
            InitializeComponent();

            TextProcessing.Init();
            
            // Analyser frequency - once per 0.75 sec
            parseTimer.Interval = 750;
            parseTimer.Tick += Timer_Tick;
        }
        private void btnSpeak_Click(object sender, EventArgs e)
        {
            try
            {
                // wait while text processing is not completed
                while (analyzing) ;

                synthesizer.SpeakStart(txtUrdu.Text.Trim());
                playing = true;
            }
            catch (Exception ex)
            {
                playing = false;
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSaveToFile_Click(object sender, EventArgs e)
        {
            try
            {
                synthesizer.SaveToFile(txtUrdu.Text.Trim(), Directory.GetCurrentDirectory() + "\\Output Wav\\file.wav");
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
                    synthesizer.SpeakPause();
                else
                    synthesizer.SpeakResume();

                playing = !playing; //toggle
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
                synthesizer.SpeakCancel();
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
                synthesizer.Volume = VolumeBar.Value * 10;
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
                synthesizer.Rate = SpeechRate.Value;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void chkWordCaching_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                DataAccessLayer.DatabaseCaching = chkWordCaching.Checked;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNewWord_Click(object sender, EventArgs e)
        {
            try
            {
                new NewWordEntry().ShowDialog();
                startAnalyseTextThread();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtUrdu_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.Modifiers == Keys.Control && e.KeyCode == Keys.D)
                {
                    listDiacriticsSuggestion.Items.Clear();

                    string selectedWord = txtUrdu.SelectedText.Trim();
                    currentDiacritics= DataAccessLayer.SearchRecordsByWord(selectedWord);
                    if(currentDiacritics != null)
                    {
                        for (int i = 0; i < currentDiacritics.Count; i++)
                        {
                            listDiacriticsSuggestion.Items.Add(currentDiacritics[i].DiacriticRep);
                        }

                        listDiacriticsSuggestion.Visible = true;
                        listDiacriticsSuggestion.SelectedIndex = 0;
                        listDiacriticsSuggestion.Focus();
                    }
                }
                else
                {
                    listDiacriticsSuggestion.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void listDiacriticsSuggestion_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if(e.KeyChar == '\r')
                {
                    enterUserSelectedDiacritic(listDiacriticsSuggestion.SelectedIndex);
                }

                currentDiacritics = null;
                listDiacriticsSuggestion.Visible = false;
                txtUrdu.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listUnrecognizedWords_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                int index = listUnrecognizedWords.IndexFromPoint(e.Location);
                if (index != ListBox.NoMatches)
                {
                    new NewWordEntry(listUnrecognizedWords.Items[index].ToString()).ShowDialog();

                    startAnalyseTextThread();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtUrdu_TextChanged(object sender, EventArgs e)
        {
            try
            {
                parseTimer.Stop();
                parseTimer.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            try
            {
                parseTimer.Stop();
                startAnalyseTextThread();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void startAnalyseTextThread()
        {
            if (analyser != null && analyser.IsAlive)
                analyser.Abort();

            analyser = new Thread(new ThreadStart(analyseText));
            analyser.Start();
        }
        private void analyseText()
        {
            try
            {
                if (analyzing) return;
                analyzing = true;

                List<string> unenteredWords = TextProcessing.UnrecognizedWords(txtUrdu.Text.Trim());
                listUnrecognizedWords.Items.Clear();
                for (int i = 0; i < unenteredWords.Count; i++)
                {
                    listUnrecognizedWords.Items.Add(unenteredWords[i]);
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                analyzing = false;
            }
        }

        private void enterUserSelectedDiacritic(int selectedIndex)
        {
            try
            {
                for (int i = 0; i < selectedDiacritics.Count; i++)
                {
                    if (selectedDiacritics[i].UrduWord == currentDiacritics[selectedIndex].UrduWord)
                    {
                        selectedDiacritics[i] = currentDiacritics[selectedIndex];
                        return;
                    }
                }

                selectedDiacritics.Add(currentDiacritics[selectedIndex]);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
