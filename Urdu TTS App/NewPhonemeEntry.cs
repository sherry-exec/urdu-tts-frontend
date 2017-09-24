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
    public partial class NewPhonemeEntry : Form
    {
        public NewPhonemeEntry()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNewUrdu.Text.Trim() == "" || txtnewIPA.Text.Trim() == "" || txtnewUPS.Text.Trim() == "")
                {
                    MessageBox.Show("Enter Complete Data", "Incomplete");
                    return;
                }

                if(DataAccessLayer.AddNewPhoneme(new PhonemeRecord(txtNewUrdu.Text.Trim(), txtnewIPA.Text.Trim(), txtnewUPS.Text.Trim())))
                    DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
