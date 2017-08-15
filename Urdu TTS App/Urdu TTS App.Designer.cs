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
            ((System.ComponentModel.ISupportInitialize)(this.VolumeBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpeechRate)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUrdu
            // 
            this.txtUrdu.Font = new System.Drawing.Font("AlKatib1", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUrdu.Location = new System.Drawing.Point(12, 12);
            this.txtUrdu.Name = "txtUrdu";
            this.txtUrdu.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtUrdu.Size = new System.Drawing.Size(760, 293);
            this.txtUrdu.TabIndex = 0;
            this.txtUrdu.Text = "";
            // 
            // btnSpeak
            // 
            this.btnSpeak.Location = new System.Drawing.Point(632, 311);
            this.btnSpeak.Name = "btnSpeak";
            this.btnSpeak.Size = new System.Drawing.Size(140, 57);
            this.btnSpeak.TabIndex = 1;
            this.btnSpeak.Text = "Speak";
            this.btnSpeak.UseVisualStyleBackColor = true;
            this.btnSpeak.Click += new System.EventHandler(this.btnSpeak_Click);
            // 
            // btnPauseResume
            // 
            this.btnPauseResume.Location = new System.Drawing.Point(486, 311);
            this.btnPauseResume.Name = "btnPauseResume";
            this.btnPauseResume.Size = new System.Drawing.Size(140, 57);
            this.btnPauseResume.TabIndex = 2;
            this.btnPauseResume.Text = "Pause/Resume";
            this.btnPauseResume.UseVisualStyleBackColor = true;
            this.btnPauseResume.Click += new System.EventHandler(this.btnPauseResume_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(340, 311);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(140, 57);
            this.btnStop.TabIndex = 3;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // VolumeBar
            // 
            this.VolumeBar.Location = new System.Drawing.Point(4, 333);
            this.VolumeBar.Name = "VolumeBar";
            this.VolumeBar.Size = new System.Drawing.Size(150, 45);
            this.VolumeBar.TabIndex = 4;
            this.VolumeBar.Value = 7;
            this.VolumeBar.Scroll += new System.EventHandler(this.VolumeBar_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 313);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Volume";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 313);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Speech rate";
            // 
            // SpeechRate
            // 
            this.SpeechRate.Location = new System.Drawing.Point(176, 333);
            this.SpeechRate.Maximum = 4;
            this.SpeechRate.Minimum = 1;
            this.SpeechRate.Name = "SpeechRate";
            this.SpeechRate.Size = new System.Drawing.Size(150, 45);
            this.SpeechRate.TabIndex = 6;
            this.SpeechRate.Value = 1;
            this.SpeechRate.Scroll += new System.EventHandler(this.SpeechRate_Scroll);
            // 
            // UrduTTSApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 382);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SpeechRate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.VolumeBar);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnPauseResume);
            this.Controls.Add(this.btnSpeak);
            this.Controls.Add(this.txtUrdu);
            this.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UrduTTSApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Urdu Text to Speech Application";
            ((System.ComponentModel.ISupportInitialize)(this.VolumeBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpeechRate)).EndInit();
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
    }
}

