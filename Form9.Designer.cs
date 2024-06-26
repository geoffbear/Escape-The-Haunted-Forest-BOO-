namespace Escape_The_Haunted_Forest__BOO__
{
    partial class pictureForm
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
            this.components = new System.ComponentModel.Container();
            this.skipsText = new System.Windows.Forms.Label();
            this.skipsCountText = new System.Windows.Forms.Label();
            this.guessText = new System.Windows.Forms.TextBox();
            this.enterText = new System.Windows.Forms.Label();
            this.submissionText = new System.Windows.Forms.Label();
            this.winCountText = new System.Windows.Forms.Label();
            this.winText = new System.Windows.Forms.Label();
            this.winTimer = new System.Windows.Forms.Timer(this.components);
            this.confettiPic = new System.Windows.Forms.PictureBox();
            this.skipButton = new System.Windows.Forms.Button();
            this.guessPic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.confettiPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guessPic)).BeginInit();
            this.SuspendLayout();
            // 
            // skipsText
            // 
            this.skipsText.AutoSize = true;
            this.skipsText.Font = new System.Drawing.Font("MS Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skipsText.Location = new System.Drawing.Point(496, 449);
            this.skipsText.Name = "skipsText";
            this.skipsText.Size = new System.Drawing.Size(321, 37);
            this.skipsText.TabIndex = 1;
            this.skipsText.Text = "Skips Remaining:";
            // 
            // skipsCountText
            // 
            this.skipsCountText.AutoSize = true;
            this.skipsCountText.Font = new System.Drawing.Font("MS Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skipsCountText.Location = new System.Drawing.Point(803, 451);
            this.skipsCountText.Name = "skipsCountText";
            this.skipsCountText.Size = new System.Drawing.Size(33, 35);
            this.skipsCountText.TabIndex = 2;
            this.skipsCountText.Text = "5";
            // 
            // guessText
            // 
            this.guessText.Location = new System.Drawing.Point(12, 493);
            this.guessText.Multiline = true;
            this.guessText.Name = "guessText";
            this.guessText.Size = new System.Drawing.Size(360, 29);
            this.guessText.TabIndex = 4;
            // 
            // enterText
            // 
            this.enterText.AutoSize = true;
            this.enterText.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterText.Location = new System.Drawing.Point(5, 451);
            this.enterText.Name = "enterText";
            this.enterText.Size = new System.Drawing.Size(367, 39);
            this.enterText.TabIndex = 5;
            this.enterText.Text = "Enter your guess here:";
            // 
            // submissionText
            // 
            this.submissionText.AutoSize = true;
            this.submissionText.Location = new System.Drawing.Point(133, 525);
            this.submissionText.Name = "submissionText";
            this.submissionText.Size = new System.Drawing.Size(111, 13);
            this.submissionText.TabIndex = 6;
            this.submissionText.Text = "(Press enter to submit)";
            // 
            // winCountText
            // 
            this.winCountText.AutoSize = true;
            this.winCountText.Font = new System.Drawing.Font("NSimSun", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winCountText.Location = new System.Drawing.Point(638, 520);
            this.winCountText.Name = "winCountText";
            this.winCountText.Size = new System.Drawing.Size(20, 19);
            this.winCountText.TabIndex = 7;
            this.winCountText.Text = "0";
            // 
            // winText
            // 
            this.winText.AutoSize = true;
            this.winText.Font = new System.Drawing.Font("NSimSun", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winText.Location = new System.Drawing.Point(456, 519);
            this.winText.Name = "winText";
            this.winText.Size = new System.Drawing.Size(185, 19);
            this.winText.TabIndex = 8;
            this.winText.Text = "Answers Correct:";
            // 
            // winTimer
            // 
            this.winTimer.Interval = 2500;
            this.winTimer.Tick += new System.EventHandler(this.winTimer_Tick);
            // 
            // confettiPic
            // 
            this.confettiPic.BackColor = System.Drawing.Color.Transparent;
            this.confettiPic.BackgroundImage = global::Escape_The_Haunted_Forest__BOO__.Properties.Resources.Confetti;
            this.confettiPic.Enabled = false;
            this.confettiPic.Location = new System.Drawing.Point(310, -15);
            this.confettiPic.Name = "confettiPic";
            this.confettiPic.Size = new System.Drawing.Size(834, 586);
            this.confettiPic.TabIndex = 13;
            this.confettiPic.TabStop = false;
            this.confettiPic.Visible = false;
            // 
            // skipButton
            // 
            this.skipButton.BackgroundImage = global::Escape_The_Haunted_Forest__BOO__.Properties.Resources.RedArrow1;
            this.skipButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.skipButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.skipButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skipButton.ForeColor = System.Drawing.Color.Transparent;
            this.skipButton.Location = new System.Drawing.Point(664, 489);
            this.skipButton.Name = "skipButton";
            this.skipButton.Size = new System.Drawing.Size(172, 82);
            this.skipButton.TabIndex = 3;
            this.skipButton.UseVisualStyleBackColor = true;
            // 
            // guessPic
            // 
            this.guessPic.BackColor = System.Drawing.Color.Transparent;
            this.guessPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guessPic.Location = new System.Drawing.Point(324, 12);
            this.guessPic.Name = "guessPic";
            this.guessPic.Size = new System.Drawing.Size(201, 436);
            this.guessPic.TabIndex = 0;
            this.guessPic.TabStop = false;
            // 
            // pictureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 583);
            this.Controls.Add(this.confettiPic);
            this.Controls.Add(this.winText);
            this.Controls.Add(this.winCountText);
            this.Controls.Add(this.submissionText);
            this.Controls.Add(this.enterText);
            this.Controls.Add(this.guessText);
            this.Controls.Add(this.skipButton);
            this.Controls.Add(this.skipsCountText);
            this.Controls.Add(this.skipsText);
            this.Controls.Add(this.guessPic);
            this.Name = "pictureForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Picture Game";
            this.Load += new System.EventHandler(this.pictureForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pictureForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.confettiPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guessPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox guessPic;
        private System.Windows.Forms.Label skipsText;
        private System.Windows.Forms.Label skipsCountText;
        private System.Windows.Forms.Button skipButton;
        private System.Windows.Forms.TextBox guessText;
        private System.Windows.Forms.Label enterText;
        private System.Windows.Forms.Label submissionText;
        private System.Windows.Forms.Label winCountText;
        private System.Windows.Forms.Label winText;
        private System.Windows.Forms.PictureBox confettiPic;
        private System.Windows.Forms.Timer winTimer;
    }
}