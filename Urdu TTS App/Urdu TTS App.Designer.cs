namespace Urdu_TTS_App
{
    partial class UrduTTSApp
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
            this.txtUrdu = new System.Windows.Forms.RichTextBox();
            this.btnSpeak = new System.Windows.Forms.Button();
            this.btnPauseResume = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.VolumeBar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SpeechRate = new System.Windows.Forms.TrackBar();
            this.listUnrecognizedWords = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chkWordCaching = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnNewWord = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSaveToFile = new System.Windows.Forms.Button();
            this.listDiacriticsSuggestion = new System.Windows.Forms.ListBox();
            this.IconSync = new System.Windows.Forms.PictureBox();
            this.btnHelp = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpeechRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconSync)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUrdu
            // 
            this.txtUrdu.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.txtUrdu.Location = new System.Drawing.Point(194, 29);
            this.txtUrdu.Name = "txtUrdu";
            this.txtUrdu.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtUrdu.Size = new System.Drawing.Size(578, 290);
            this.txtUrdu.TabIndex = 0;
            this.txtUrdu.Text = "";
            this.txtUrdu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUrdu_KeyDown);
            // 
            // btnSpeak
            // 
            this.btnSpeak.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpeak.Location = new System.Drawing.Point(632, 325);
            this.btnSpeak.Name = "btnSpeak";
            this.btnSpeak.Size = new System.Drawing.Size(140, 57);
            this.btnSpeak.TabIndex = 1;
            this.btnSpeak.Text = "Speak Now";
            this.btnSpeak.UseVisualStyleBackColor = true;
            this.btnSpeak.Click += new System.EventHandler(this.btnSpeak_Click);
            // 
            // btnPauseResume
            // 
            this.btnPauseResume.Location = new System.Drawing.Point(340, 325);
            this.btnPauseResume.Name = "btnPauseResume";
            this.btnPauseResume.Size = new System.Drawing.Size(140, 57);
            this.btnPauseResume.TabIndex = 2;
            this.btnPauseResume.Text = "Pause/Resume";
            this.btnPauseResume.UseVisualStyleBackColor = true;
            this.btnPauseResume.Click += new System.EventHandler(this.btnPauseResume_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(194, 325);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(140, 57);
            this.btnStop.TabIndex = 3;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // VolumeBar
            // 
            this.VolumeBar.Location = new System.Drawing.Point(340, 412);
            this.VolumeBar.Name = "VolumeBar";
            this.VolumeBar.Size = new System.Drawing.Size(211, 45);
            this.VolumeBar.TabIndex = 4;
            this.VolumeBar.Value = 7;
            this.VolumeBar.Scroll += new System.EventHandler(this.VolumeBar_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(337, 392);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Volume";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(554, 392);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Speech rate";
            // 
            // SpeechRate
            // 
            this.SpeechRate.Location = new System.Drawing.Point(557, 412);
            this.SpeechRate.Maximum = 4;
            this.SpeechRate.Minimum = -1;
            this.SpeechRate.Name = "SpeechRate";
            this.SpeechRate.Size = new System.Drawing.Size(215, 45);
            this.SpeechRate.TabIndex = 6;
            this.SpeechRate.Value = 1;
            this.SpeechRate.Scroll += new System.EventHandler(this.SpeechRate_Scroll);
            // 
            // listUnrecognizedWords
            // 
            this.listUnrecognizedWords.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listUnrecognizedWords.FormattingEnabled = true;
            this.listUnrecognizedWords.ItemHeight = 31;
            this.listUnrecognizedWords.Location = new System.Drawing.Point(12, 29);
            this.listUnrecognizedWords.Name = "listUnrecognizedWords";
            this.listUnrecognizedWords.Size = new System.Drawing.Size(176, 283);
            this.listUnrecognizedWords.TabIndex = 8;
            this.listUnrecognizedWords.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listUnrecognizedWords_MouseClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Unrecognized words";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(184, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Type urdu text";
            // 
            // chkWordCaching
            // 
            this.chkWordCaching.AutoSize = true;
            this.chkWordCaching.Location = new System.Drawing.Point(194, 388);
            this.chkWordCaching.Name = "chkWordCaching";
            this.chkWordCaching.Size = new System.Drawing.Size(103, 21);
            this.chkWordCaching.TabIndex = 12;
            this.chkWordCaching.Text = "Word caching";
            this.chkWordCaching.UseVisualStyleBackColor = true;
            this.chkWordCaching.CheckedChanged += new System.EventHandler(this.chkWordCaching_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(191, 412);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 34);
            this.label6.TabIndex = 13;
            this.label6.Text = "Makes application fast,\r\nuses more memory";
            // 
            // btnNewWord
            // 
            this.btnNewWord.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewWord.Location = new System.Drawing.Point(12, 325);
            this.btnNewWord.Name = "btnNewWord";
            this.btnNewWord.Size = new System.Drawing.Size(176, 57);
            this.btnNewWord.TabIndex = 14;
            this.btnNewWord.Text = "Add New Word Records / Modify Existing";
            this.btnNewWord.UseVisualStyleBackColor = true;
            this.btnNewWord.Click += new System.EventHandler(this.btnNewWord_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 388);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 51);
            this.label5.TabIndex = 15;
            this.label5.Text = "Click on word in list\r\nabove to enter that word\r\nin the database";
            // 
            // btnSaveToFile
            // 
            this.btnSaveToFile.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveToFile.Location = new System.Drawing.Point(486, 325);
            this.btnSaveToFile.Name = "btnSaveToFile";
            this.btnSaveToFile.Size = new System.Drawing.Size(140, 57);
            this.btnSaveToFile.TabIndex = 16;
            this.btnSaveToFile.Text = "Save to Wav File";
            this.btnSaveToFile.UseVisualStyleBackColor = true;
            this.btnSaveToFile.Click += new System.EventHandler(this.btnSaveToFile_Click);
            // 
            // listDiacriticsSuggestion
            // 
            this.listDiacriticsSuggestion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listDiacriticsSuggestion.Cursor = System.Windows.Forms.Cursors.No;
            this.listDiacriticsSuggestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listDiacriticsSuggestion.FormattingEnabled = true;
            this.listDiacriticsSuggestion.ItemHeight = 33;
            this.listDiacriticsSuggestion.Location = new System.Drawing.Point(398, 123);
            this.listDiacriticsSuggestion.Name = "listDiacriticsSuggestion";
            this.listDiacriticsSuggestion.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.listDiacriticsSuggestion.Size = new System.Drawing.Size(171, 101);
            this.listDiacriticsSuggestion.TabIndex = 17;
            this.listDiacriticsSuggestion.Visible = false;
            this.listDiacriticsSuggestion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.listDiacriticsSuggestion_KeyPress);
            // 
            // IconSync
            // 
            this.IconSync.BackColor = System.Drawing.Color.White;
            this.IconSync.BackgroundImage = global::Urdu_TTS_App.Properties.Resources.sync_flat;
            this.IconSync.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.IconSync.Location = new System.Drawing.Point(13, 84);
            this.IconSync.Name = "IconSync";
            this.IconSync.Size = new System.Drawing.Size(174, 174);
            this.IconSync.TabIndex = 19;
            this.IconSync.TabStop = false;
            this.IconSync.Visible = false;
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnHelp.Cursor = System.Windows.Forms.Cursors.Help;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.Location = new System.Drawing.Point(752, 9);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(18, 18);
            this.btnHelp.TabIndex = 20;
            this.btnHelp.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnHelp.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(669, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 17);
            this.label7.TabIndex = 21;
            this.label7.Text = "help / guide >";
            // 
            // UrduTTSApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.IconSync);
            this.Controls.Add(this.listDiacriticsSuggestion);
            this.Controls.Add(this.btnSaveToFile);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnNewWord);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.chkWordCaching);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listUnrecognizedWords);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SpeechRate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.VolumeBar);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnPauseResume);
            this.Controls.Add(this.btnSpeak);
            this.Controls.Add(this.txtUrdu);
            this.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "UrduTTSApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Urdu Text to Speech Application";
            ((System.ComponentModel.ISupportInitialize)(this.VolumeBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpeechRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconSync)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtUrdu;
        private System.Windows.Forms.Button btnSpeak;
        private System.Windows.Forms.Button btnPauseResume;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.TrackBar VolumeBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar SpeechRate;
        private System.Windows.Forms.ListBox listUnrecognizedWords;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkWordCaching;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnNewWord;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSaveToFile;
        private System.Windows.Forms.ListBox listDiacriticsSuggestion;
        private System.Windows.Forms.PictureBox IconSync;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Label label7;
    }
}

