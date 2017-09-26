using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UrduTTS;

namespace Urdu_TTS_App
{
    public partial class NewWordEntry : Form
    {
        // Private Variables
        Timer speakTimer = null;

        SsmlEncoding speechSynth = null;
        List<WordRecord> wordRecords = null;

        bool txtIPA_Access = false,
             txtUPS_Access = false,
             loadingFromDg = false,
             enteringUnrecognizedWord = false;

        // Initialization Functions
        #region Form Initialization Functions
        void Init()
        {
            try
            {
                InitializeComponent();
                speechSynth = new SsmlEncoding();
                wordRecords = new List<WordRecord>();
                speakTimer = new Timer();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public NewWordEntry()
        {
            try
            {
                Init();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public NewWordEntry(string urduWord)
        {
            try
            {
                Init();
                txtInputUrdu.Text = urduWord.Trim();
                enteringUnrecognizedWord = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                loadPhonemes();

                if (enteringUnrecognizedWord)
                {
                    txtInputUrdu.ReadOnly = true;
                    cmBoxDiacSuggestion.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        // Form Text Change Funtions
        #region Form Text Change Events Functions
        private void txtInputUrdu_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if(chkBoxLoadWhileTyping.Checked)
                    urduTextChanging();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtIPARep_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (chkBoxLoadWhileTyping.Checked)
                    ipaTextChanging();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtUPSRep_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (chkBoxLoadWhileTyping.Checked)
                    upsTextChanging();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgPhonemeDict_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgPhonemeDict.SelectedCells.Count > 0)
                {
                    DataGridViewRow selectedRow = dgPhonemeDict.Rows[dgPhonemeDict.SelectedCells[0].RowIndex];
                    string valueIPA = Convert.ToString(selectedRow.Cells[1].Value);
                    string valueUPS = Convert.ToString(selectedRow.Cells[2].Value);

                    loadingFromDg = true;
                    txtIPARep.Text += " " + valueIPA.Trim();
                    txtUPSRep.Text += " " + valueUPS.Trim();
                    loadingFromDg = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        // Form TextBox Leave Functions
        #region Form TextBox Leave Events

        private void txtInputUrdu_Leave(object sender, EventArgs e)
        {
            try
            {
                if (!chkBoxLoadWhileTyping.Checked)
                    urduTextChanging();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmBoxDiacSuggestion_Leave(object sender, EventArgs e)
            {
            try
            {
                diacriticCmBoxTextChanging();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtIPARep_Leave(object sender, EventArgs e)
        {
            try
            {
                if (!chkBoxLoadWhileTyping.Checked)
                    ipaTextChanging();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtUPSRep_Leave(object sender, EventArgs e)
        {
            try
            {
                if (!chkBoxLoadWhileTyping.Checked)
                    upsTextChanging();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        // Buttons and Control Functions
        #region Buttons and Control Functions
        private void btnNewWordRecord_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtInputUrdu.Text.Trim() == "" || cmBoxDiacSuggestion.Text.Trim() == "" ||
                    txtIPARep.Text.Trim() == "" || txtUPSRep.Text.Trim() == "")
                {
                    MessageBox.Show("Enter Complete Data", "Incomplete");
                    return;
                }

                if(cmBoxDiacSuggestion.SelectedIndex == -1)
                {
                    if (DataAccessLayer.AddNewRecord(new WordRecord(txtInputUrdu.Text.Trim(), cmBoxDiacSuggestion.Text.Trim(),
                    txtIPARep.Text.Trim(), txtUPSRep.Text.Trim())))
                    {
                        MessageBox.Show("New Word Record Saved", "Done");
                        if (chkBoxAutoClear.Checked)
                            clearAllFileds();
                    }
                }
                else if(cmBoxDiacSuggestion.SelectedIndex >= 0)
                {
                    if (DataAccessLayer.UpdateRecord(new WordRecord(wordRecords[cmBoxDiacSuggestion.SelectedIndex].Id, txtInputUrdu.Text.Trim(), cmBoxDiacSuggestion.Text.Trim(),
                    txtIPARep.Text.Trim(), txtUPSRep.Text.Trim())))
                    {
                        MessageBox.Show("Record Updated Successfully", "Done");
                        clearAllFileds();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNewPhonemeEntry_Click(object sender, EventArgs e)
        {
            try
            {
                if (new NewPhonemeEntry().ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("New Phoneme Added", "Done");
                    loadPhonemes();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearAllFileds();
        }

        private void txtUPSRep_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.Modifiers == Keys.Control && e.KeyCode == Keys.Space)
                {
                    speakWord();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        // Mapper Functions For TextChange Events
        #region Intermediate Mapping Functions, Between frontend and functionality
        void urduTextChanging()
        {
            try
            {                 
                cmBoxDiacSuggestion.Items.Clear();
                cmBoxDiacSuggestion.Text = "";
                txtIPARep.Text = "";
                txtUPSRep.Text = "";

                if (txtInputUrdu.Text.Trim() != String.Empty)
                {
                    //Passing Data of Typed Urdu to Phontics Class;
                    wordRecords = DataAccessLayer.SearchRecordsByWord(txtInputUrdu.Text.Trim());
                    if (wordRecords != null)
                    {
                        for (int i = 0; i < wordRecords.Count; i++)
                        {
                            cmBoxDiacSuggestion.Items.Add(wordRecords[i].DiacriticRep);
                        }
                    }
                }
                numDiacsFound.Text = cmBoxDiacSuggestion.Items.Count.ToString();
            }
            catch (Exception)
            {
                throw;
            }
        }

        void diacriticCmBoxTextChanging()
        {
            try
            {
                loadPhoneticRepFromDiacWord();
            }
            catch (Exception)
            {
                throw;
            }
        }

        void ipaTextChanging()
        {
            try
            {
                // if user loaded phoneme from table
                if (loadingFromDg)
                    return;

                // if user is typing in UPS
                if (txtUPS_Access)
                    return;

                txtIPA_Access = true;
                updatePhoneticReps();
                txtIPA_Access = false;

                if (chkBoxAudioOut.Checked)
                    speakWord();
            }
            catch (Exception)
            {
                throw;
            }
        }

        void upsTextChanging()
        {
            try
            {
                // if user loaded phoneme from table
                if (loadingFromDg)
                    return;

                // if user is typing in IPA
                if (txtIPA_Access)
                    return;

                txtUPS_Access = true;
                updatePhoneticReps();
                txtUPS_Access = false;

                if (chkBoxAudioOut.Checked)
                    speakWord();
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion

        // Private Utility Functions
        #region Support Utility Functions
        void speakWord()
        {
            try
            {
                if (txtUPSRep.Text.Trim() == String.Empty)
                    return;

                List<string> upsPhonemes = new List<string>();
                upsPhonemes.Add(txtUPSRep.Text.Trim());

                speechSynth.Volume = Convert.ToInt16(volumeBar.Value * 10);
                speechSynth.SpeakStart(upsPhonemes, false);
            }
            catch (Exception ex)
            {
                if (ex.Message.StartsWith("'ph'"))
                    return;

                throw;
            }
        }

        void updatePhoneticReps()
        {
            try
            {
                // If user is currently typing in IPA text
                if(txtIPA_Access)
                {
                    // then get its phonetic representation for UPS
                    // break txtIPARep.Text into separate phonemes
                    // Like U R D U into separate U, R, D, U
                    // convert each into its UPS
                    List<string> phonemes = breakIntoPhonemes(txtIPARep.Text.Trim());
                    txtUPSRep.Text = "";

                    foreach (string phoneme in phonemes)
                    {
                        txtUPSRep.Text += phonemeIPAToUPS(phoneme) + " ";
                    }
                }

                // If user is currently typing in IPA text
                if (txtUPS_Access)
                {
                    //then get its phonetic representation for UPS
                    List<string> phonemes = breakIntoPhonemes(txtUPSRep.Text.Trim());
                    txtIPARep.Text = "";

                    foreach (string phoneme in phonemes)
                    {
                        txtIPARep.Text += phonemeUPSToIPA(phoneme) + " ";
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        List<string> breakIntoPhonemes(string s, string delimeter = " ")
        {
            try
            {
                List<string> phonemes = new List<string>();
                string temp = "";

                for (int i = 0; i < s.Length; i++)
                {
                    temp += s[i];

                    if (s[i].ToString() == delimeter || i == s.Length - 1)
                    {
                        if ((temp = temp.Trim()) != String.Empty)
                        {
                            phonemes.Add(temp);
                            temp = "";
                        }
                    }
                }

                return phonemes;
            }
            catch (Exception)
            {
                throw;
            }
        }

        void loadPhoneticRepFromDiacWord()
        {
            try
            {
                txtIPA_Access = txtUPS_Access = true;

                if (cmBoxDiacSuggestion.SelectedIndex >= 0)
                {
                    txtIPARep.Text = wordRecords[cmBoxDiacSuggestion.SelectedIndex].IpaRep.Trim();
                    txtUPSRep.Text = wordRecords[cmBoxDiacSuggestion.SelectedIndex].UpsRep.Trim();
                }
                else
                {
                    txtIPARep.Text = txtUPSRep.Text = "";
                }
            
                txtIPA_Access = txtUPS_Access = false;
            }
            catch (Exception)
            {
                throw;
            }
        }
        
        string phonemeIPAToUPS(string ipaPhoneme)
        {
            try
            {
                for (int i = 0; i < dgPhonemeDict.Rows.Count; i++)
                {
                    if (dgPhonemeDict.Rows[i].Cells[1].Value.ToString().Trim() == ipaPhoneme.Trim())
                    {
                        return dgPhonemeDict.Rows[i].Cells[2].Value.ToString();
                    }
                }
                return "";
            }
            catch (Exception)
            {
                throw;
            }
        }

        string phonemeUPSToIPA(string upsPhoneme)
        {
            try
            {
                for (int i = 0; i < dgPhonemeDict.Rows.Count; i++)
                {
                    if (dgPhonemeDict.Rows[i].Cells[2].Value.ToString().Trim() == upsPhoneme.Trim())
                    {
                        return dgPhonemeDict.Rows[i].Cells[1].Value.ToString();
                    }
                }
                return "";
            }
            catch (Exception)
            {
                throw;
            }
        }

        void loadPhonemes()
        {
            try
            {
                dgPhonemeDict.DataSource = DataAccessLayer.GetPhonemeDictionary();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        void clearAllFileds()
        {
            if (enteringUnrecognizedWord)
                Close();

            txtInputUrdu.Text = "";
            cmBoxDiacSuggestion.Text = "";
            txtIPARep.Text = "";
            txtUPSRep.Text = "";
            cmBoxDiacSuggestion.Items.Clear();
            txtInputUrdu.Focus();
        }
        #endregion

    }
}