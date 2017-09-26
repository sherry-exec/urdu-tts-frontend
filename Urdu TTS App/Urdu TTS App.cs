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
        // Speak variables
        SsmlEncoding synthesizer = new SsmlEncoding();
        bool playing = false;

        // Text analyzing threading variables
        Thread analyser = null;
        bool analyzing = false;

        // User selected diacritics
        List<WordRecord> suggestedDiacritics = new List<WordRecord>();

        public UrduTTSApp()
        {
            InitializeComponent();
        }

        #region Form Controls
        private void btnSpeak_Click(object sender, EventArgs e)
        {
            try
            {
                synthesizer.SpeakStart(TextProcessing.ToUPSReps(txtUrdu.Text.Trim()));
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
                synthesizer.SaveToFile(TextProcessing.ToUPSReps(txtUrdu.Text.Trim()), Directory.GetCurrentDirectory() + "\\Output Wav\\file.wav");
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
                if (playing)
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

        private void btnNewWord_Click(object sender, EventArgs e)
        {
            try
            {
                new NewWordEntry().ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            new About().ShowDialog();
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
        #endregion

        #region Events
        private void txtUrdu_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                // CTRL + S : Speak shortcut
                if (e.Modifiers == Keys.Control && e.KeyCode == Keys.S)
                {
                    synthesizer.SpeakStart(TextProcessing.ToUPSReps(txtUrdu.Text.Trim()));
                    playing = true;
                }
                // CTRL + F : Save to file shortcut
                else if (e.Modifiers == Keys.Control && e.KeyCode == Keys.F)
                {
                    synthesizer.SaveToFile(TextProcessing.ToUPSReps(txtUrdu.Text.Trim()), Directory.GetCurrentDirectory() + "\\Output Wav\\file.wav");
                }
                // CTRL + P : Parse/analyse text shortcut
                else if (e.Modifiers == Keys.Control && e.KeyCode == Keys.P)
                {
                    IconSync.Visible = true;
                    analyser = new Thread(new ThreadStart(analyseTextForUnrecognizedWords));
                    analyser.Start();
                }
                // CTRL + D : Diacritic suggestion pop-up
                else if (e.Modifiers == Keys.Control && e.KeyCode == Keys.D)
                {
                    listDiacriticsSuggestion.Items.Clear();

                    string selectedWord = txtUrdu.SelectedText.Trim();

                    // First try, if the selection is a WORD (simple, not with diacritics)
                    suggestedDiacritics = DataAccessLayer.SearchRecordsByWord(selectedWord);
                    if (suggestedDiacritics != null)
                    {
                        for (int i = 0; i < suggestedDiacritics.Count; i++)
                        {
                            listDiacriticsSuggestion.Items.Add(suggestedDiacritics[i].DiacriticRep);
                        }
                    }
                    // Second try, if the selection is a DIACRITICS REPRESENTATION (not simple word)
                    else
                    {
                        suggestedDiacritics = DataAccessLayer.SearchRecordsByWord(DataAccessLayer.UrduWordFromDiacriticRep(selectedWord));
                        if (suggestedDiacritics != null)
                        {
                            for (int i = 0; i < suggestedDiacritics.Count; i++)
                            {
                                listDiacriticsSuggestion.Items.Add(suggestedDiacritics[i].DiacriticRep);
                            }
                        }
                    }

                    // If there are some diacritics to select from
                    if (listDiacriticsSuggestion.Items.Count > 0)
                    {
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
                playing = false;
                MessageBox.Show(ex.Message);
            }
        }

        // User selected diacritic representation for a word
        private void listDiacriticsSuggestion_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                // User selected a diacritic representation for a word
                if (e.KeyChar == '\r')
                {
                    // replace that word with its selected diacritic representation
                    string w = txtUrdu.SelectedText;
                    string d = "";

                    if (w[0] == ' ')
                        d += " ";
                    d += listDiacriticsSuggestion.SelectedItem.ToString();
                    if (w[w.Length - 1] == ' ')
                        d += " ";

                    txtUrdu.SelectedText = d;
                }
                else if(e.KeyChar == ' ')
                {
                    List<string> phoneme = new List<string>();
                    phoneme.Add(suggestedDiacritics[listDiacriticsSuggestion.SelectedIndex].UpsRep);
                    synthesizer.SpeakStart(phoneme);
                    return;
                }

                suggestedDiacritics = null;
                listDiacriticsSuggestion.Visible = false;
                txtUrdu.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // User clicked a word in unrecognized list to enter it into database
        private void listUnrecognizedWords_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                int index = listUnrecognizedWords.IndexFromPoint(e.Location);
                if (index != ListBox.NoMatches)
                {
                    new NewWordEntry(listUnrecognizedWords.Items[index].ToString()).ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Private Utility Functions
        private void analyseTextForUnrecognizedWords()
        {

            if (analyzing) return;
            analyzing = true;

            listUnrecognizedWords.Items.Clear();
            List<string> unrecognizedWords = TextProcessing.UnrecognizedWords(txtUrdu.Text.Trim());
            for (int i = 0; i < unrecognizedWords.Count; i++)
            {
                listUnrecognizedWords.Items.Add(unrecognizedWords[i]);
            }

            analyzing = false;
            IconSync.Visible = false;
        }
        #endregion
    }
}
