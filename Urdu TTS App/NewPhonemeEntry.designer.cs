namespace Urdu_TTS_App
{
    partial class NewPhonemeEntry
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
            this.btnSave = new System.Windows.Forms.Button();
            this.txtNewUrdu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtnewIPA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnewUPS = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(177, 121);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(87, 30);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtNewUrdu
            // 
            this.txtNewUrdu.Location = new System.Drawing.Point(115, 17);
            this.txtNewUrdu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNewUrdu.Name = "txtNewUrdu";
            this.txtNewUrdu.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtNewUrdu.Size = new System.Drawing.Size(149, 24);
            this.txtNewUrdu.TabIndex = 1;
            this.txtNewUrdu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Urdu Phoneme";
            // 
            // txtnewIPA
            // 
            this.txtnewIPA.Location = new System.Drawing.Point(115, 52);
            this.txtnewIPA.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtnewIPA.Name = "txtnewIPA";
            this.txtnewIPA.Size = new System.Drawing.Size(149, 24);
            this.txtnewIPA.TabIndex = 2;
            this.txtnewIPA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "IPA";
            // 
            // txtnewUPS
            // 
            this.txtnewUPS.Location = new System.Drawing.Point(115, 89);
            this.txtnewUPS.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtnewUPS.Name = "txtnewUPS";
            this.txtnewUPS.Size = new System.Drawing.Size(149, 24);
            this.txtnewUPS.TabIndex = 3;
            this.txtnewUPS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "UPS";
            // 
            // NewPhonemeEntry
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 163);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtnewUPS);
            this.Controls.Add(this.txtnewIPA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNewUrdu);
            this.Controls.Add(this.btnSave);
            this.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewPhonemeEntry";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New Entry";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtNewUrdu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnewIPA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnewUPS;
        private System.Windows.Forms.Label label3;
    }
}