namespace Urdu_TTS_App
{
    partial class NewWordEntry
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnNewWordRecord = new System.Windows.Forms.Button();
            this.txtInputUrdu = new System.Windows.Forms.TextBox();
            this.cmBoxDiacSuggestion = new System.Windows.Forms.ComboBox();
            this.txtIPARep = new System.Windows.Forms.TextBox();
            this.txtUPSRep = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.chkBoxAudioOut = new System.Windows.Forms.CheckBox();
            this.dgPhonemeDict = new System.Windows.Forms.DataGridView();
            this.btnNewPhonemeEntry = new System.Windows.Forms.Button();
            this.volumeBar = new System.Windows.Forms.TrackBar();
            this.btnClear = new System.Windows.Forms.Button();
            this.volumeLabel = new System.Windows.Forms.Label();
            this.chkBoxAutoClear = new System.Windows.Forms.CheckBox();
            this.chkBoxLoadWhileTyping = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numDiacsFound = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgPhonemeDict)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumeBar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNewWordRecord
            // 
            this.btnNewWordRecord.Location = new System.Drawing.Point(384, 455);
            this.btnNewWordRecord.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNewWordRecord.Name = "btnNewWordRecord";
            this.btnNewWordRecord.Size = new System.Drawing.Size(231, 48);
            this.btnNewWordRecord.TabIndex = 5;
            this.btnNewWordRecord.Text = "Save Record To Dictionary";
            this.btnNewWordRecord.UseVisualStyleBackColor = true;
            this.btnNewWordRecord.Click += new System.EventHandler(this.btnNewWordRecord_Click);
            // 
            // txtInputUrdu
            // 
            this.txtInputUrdu.Font = new System.Drawing.Font("Calibri Light", 14F);
            this.txtInputUrdu.Location = new System.Drawing.Point(384, 30);
            this.txtInputUrdu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtInputUrdu.Name = "txtInputUrdu";
            this.txtInputUrdu.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtInputUrdu.Size = new System.Drawing.Size(231, 30);
            this.txtInputUrdu.TabIndex = 1;
            this.txtInputUrdu.TextChanged += new System.EventHandler(this.txtInputUrdu_TextChanged);
            this.txtInputUrdu.Leave += new System.EventHandler(this.txtInputUrdu_Leave);
            // 
            // cmBoxDiacSuggestion
            // 
            this.cmBoxDiacSuggestion.Font = new System.Drawing.Font("Calibri Light", 14F);
            this.cmBoxDiacSuggestion.FormattingEnabled = true;
            this.cmBoxDiacSuggestion.Location = new System.Drawing.Point(384, 93);
            this.cmBoxDiacSuggestion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmBoxDiacSuggestion.Name = "cmBoxDiacSuggestion";
            this.cmBoxDiacSuggestion.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmBoxDiacSuggestion.Size = new System.Drawing.Size(231, 31);
            this.cmBoxDiacSuggestion.TabIndex = 2;
            this.cmBoxDiacSuggestion.Leave += new System.EventHandler(this.cmBoxDiacSuggestion_Leave);
            // 
            // txtIPARep
            // 
            this.txtIPARep.Font = new System.Drawing.Font("Calibri Light", 14F);
            this.txtIPARep.Location = new System.Drawing.Point(384, 155);
            this.txtIPARep.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtIPARep.Name = "txtIPARep";
            this.txtIPARep.Size = new System.Drawing.Size(231, 30);
            this.txtIPARep.TabIndex = 3;
            this.txtIPARep.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtIPARep.TextChanged += new System.EventHandler(this.txtIPARep_TextChanged);
            this.txtIPARep.Leave += new System.EventHandler(this.txtIPARep_Leave);
            // 
            // txtUPSRep
            // 
            this.txtUPSRep.Font = new System.Drawing.Font("Calibri Light", 14F);
            this.txtUPSRep.Location = new System.Drawing.Point(384, 218);
            this.txtUPSRep.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUPSRep.Name = "txtUPSRep";
            this.txtUPSRep.Size = new System.Drawing.Size(231, 30);
            this.txtUPSRep.TabIndex = 4;
            this.txtUPSRep.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtUPSRep.TextChanged += new System.EventHandler(this.txtUPSRep_TextChanged);
            this.txtUPSRep.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUPSRep_KeyDown);
            this.txtUPSRep.Leave += new System.EventHandler(this.txtUPSRep_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(490, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Type Urdu Word Here";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(412, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Diacritic Representation of the Word";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(501, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "IPA Representation";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(496, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "UPS Representation";
            // 
            // chkBoxAudioOut
            // 
            this.chkBoxAudioOut.AutoSize = true;
            this.chkBoxAudioOut.Checked = true;
            this.chkBoxAudioOut.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBoxAudioOut.Location = new System.Drawing.Point(384, 266);
            this.chkBoxAudioOut.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkBoxAudioOut.Name = "chkBoxAudioOut";
            this.chkBoxAudioOut.Size = new System.Drawing.Size(210, 19);
            this.chkBoxAudioOut.TabIndex = 7;
            this.chkBoxAudioOut.TabStop = false;
            this.chkBoxAudioOut.Text = "Audio output while typing UPS/IPA";
            this.chkBoxAudioOut.UseVisualStyleBackColor = true;
            // 
            // dgPhonemeDict
            // 
            this.dgPhonemeDict.AllowUserToAddRows = false;
            this.dgPhonemeDict.AllowUserToDeleteRows = false;
            this.dgPhonemeDict.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgPhonemeDict.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgPhonemeDict.Location = new System.Drawing.Point(12, 13);
            this.dgPhonemeDict.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgPhonemeDict.Name = "dgPhonemeDict";
            this.dgPhonemeDict.ReadOnly = true;
            this.dgPhonemeDict.RowHeadersVisible = false;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgPhonemeDict.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgPhonemeDict.Size = new System.Drawing.Size(323, 494);
            this.dgPhonemeDict.TabIndex = 8;
            this.dgPhonemeDict.TabStop = false;
            this.dgPhonemeDict.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPhonemeDict_CellClick);
            // 
            // btnNewPhonemeEntry
            // 
            this.btnNewPhonemeEntry.Location = new System.Drawing.Point(12, 518);
            this.btnNewPhonemeEntry.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNewPhonemeEntry.Name = "btnNewPhonemeEntry";
            this.btnNewPhonemeEntry.Size = new System.Drawing.Size(136, 30);
            this.btnNewPhonemeEntry.TabIndex = 9;
            this.btnNewPhonemeEntry.TabStop = false;
            this.btnNewPhonemeEntry.Text = "New Phoneme Entry";
            this.btnNewPhonemeEntry.UseVisualStyleBackColor = true;
            this.btnNewPhonemeEntry.Click += new System.EventHandler(this.btnNewPhonemeEntry_Click);
            // 
            // volumeBar
            // 
            this.volumeBar.Location = new System.Drawing.Point(375, 402);
            this.volumeBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.volumeBar.Name = "volumeBar";
            this.volumeBar.Size = new System.Drawing.Size(247, 45);
            this.volumeBar.TabIndex = 10;
            this.volumeBar.TabStop = false;
            this.volumeBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.volumeBar.Value = 7;
            // 
            // btnClear
            // 
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClear.Location = new System.Drawing.Point(384, 514);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(231, 30);
            this.btnClear.TabIndex = 11;
            this.btnClear.TabStop = false;
            this.btnClear.Text = "Clear Fields";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // volumeLabel
            // 
            this.volumeLabel.AutoSize = true;
            this.volumeLabel.Location = new System.Drawing.Point(381, 381);
            this.volumeLabel.Name = "volumeLabel";
            this.volumeLabel.Size = new System.Drawing.Size(52, 15);
            this.volumeLabel.TabIndex = 12;
            this.volumeLabel.Text = "Volume:";
            // 
            // chkBoxAutoClear
            // 
            this.chkBoxAutoClear.AutoSize = true;
            this.chkBoxAutoClear.Checked = true;
            this.chkBoxAutoClear.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBoxAutoClear.Location = new System.Drawing.Point(384, 295);
            this.chkBoxAutoClear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkBoxAutoClear.Name = "chkBoxAutoClear";
            this.chkBoxAutoClear.Size = new System.Drawing.Size(125, 19);
            this.chkBoxAutoClear.TabIndex = 13;
            this.chkBoxAutoClear.TabStop = false;
            this.chkBoxAutoClear.Text = "Auto clear on save";
            this.chkBoxAutoClear.UseVisualStyleBackColor = true;
            // 
            // chkBoxLoadWhileTyping
            // 
            this.chkBoxLoadWhileTyping.AutoSize = true;
            this.chkBoxLoadWhileTyping.Checked = true;
            this.chkBoxLoadWhileTyping.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBoxLoadWhileTyping.Location = new System.Drawing.Point(384, 322);
            this.chkBoxLoadWhileTyping.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkBoxLoadWhileTyping.Name = "chkBoxLoadWhileTyping";
            this.chkBoxLoadWhileTyping.Size = new System.Drawing.Size(180, 19);
            this.chkBoxLoadWhileTyping.TabIndex = 15;
            this.chkBoxLoadWhileTyping.TabStop = false;
            this.chkBoxLoadWhileTyping.Text = "Load Diacritics While Typing";
            this.chkBoxLoadWhileTyping.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(399, 345);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "(This makes application slow)";
            // 
            // numDiacsFound
            // 
            this.numDiacsFound.AutoSize = true;
            this.numDiacsFound.Location = new System.Drawing.Point(359, 101);
            this.numDiacsFound.Name = "numDiacsFound";
            this.numDiacsFound.Size = new System.Drawing.Size(14, 15);
            this.numDiacsFound.TabIndex = 17;
            this.numDiacsFound.Text = "0";
            // 
            // NewWordEntry
            // 
            this.AcceptButton = this.btnNewWordRecord;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClear;
            this.ClientSize = new System.Drawing.Size(624, 561);
            this.Controls.Add(this.numDiacsFound);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chkBoxLoadWhileTyping);
            this.Controls.Add(this.chkBoxAutoClear);
            this.Controls.Add(this.volumeLabel);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.volumeBar);
            this.Controls.Add(this.dgPhonemeDict);
            this.Controls.Add(this.chkBoxAudioOut);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmBoxDiacSuggestion);
            this.Controls.Add(this.txtUPSRep);
            this.Controls.Add(this.txtIPARep);
            this.Controls.Add(this.txtInputUrdu);
            this.Controls.Add(this.btnNewPhonemeEntry);
            this.Controls.Add(this.btnNewWordRecord);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "NewWordEntry";
            this.Text = "Word Database Modifier";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgPhonemeDict)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumeBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNewWordRecord;
        private System.Windows.Forms.TextBox txtInputUrdu;
        private System.Windows.Forms.ComboBox cmBoxDiacSuggestion;
        private System.Windows.Forms.TextBox txtIPARep;
        private System.Windows.Forms.TextBox txtUPSRep;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkBoxAudioOut;
        private System.Windows.Forms.DataGridView dgPhonemeDict;
        private System.Windows.Forms.Button btnNewPhonemeEntry;
        private System.Windows.Forms.TrackBar volumeBar;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label volumeLabel;
        private System.Windows.Forms.CheckBox chkBoxAutoClear;
        private System.Windows.Forms.CheckBox chkBoxLoadWhileTyping;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label numDiacsFound;
    }
}

