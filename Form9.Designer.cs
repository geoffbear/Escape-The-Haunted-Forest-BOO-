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
            this.skipsText = new System.Windows.Forms.Label();
            this.skipsCountText = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.enterText = new System.Windows.Forms.Label();
            this.skipButton = new System.Windows.Forms.Button();
            this.guessPic = new System.Windows.Forms.PictureBox();
            this.submissionText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.guessPic)).BeginInit();
            this.SuspendLayout();
            // 
            // skipsText
            // 
            this.skipsText.AutoSize = true;
            this.skipsText.Font = new System.Drawing.Font("MS Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skipsText.Location = new System.Drawing.Point(488, 449);
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 493);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(360, 29);
            this.textBox1.TabIndex = 4;
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
            // skipButton
            // 
            this.skipButton.BackgroundImage = global::Escape_The_Haunted_Forest__BOO__.Properties.Resources.RedArrow1;
            this.skipButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.skipButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.skipButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skipButton.ForeColor = System.Drawing.Color.Transparent;
            this.skipButton.Location = new System.Drawing.Point(637, 489);
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
            // submissionText
            // 
            this.submissionText.AutoSize = true;
            this.submissionText.Location = new System.Drawing.Point(133, 525);
            this.submissionText.Name = "submissionText";
            this.submissionText.Size = new System.Drawing.Size(111, 13);
            this.submissionText.TabIndex = 6;
            this.submissionText.Text = "(Press enter to submit)";
            // 
            // pictureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 583);
            this.Controls.Add(this.submissionText);
            this.Controls.Add(this.enterText);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.skipButton);
            this.Controls.Add(this.skipsCountText);
            this.Controls.Add(this.skipsText);
            this.Controls.Add(this.guessPic);
            this.Name = "pictureForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Picture Game";
            this.Load += new System.EventHandler(this.pictureForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guessPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox guessPic;
        private System.Windows.Forms.Label skipsText;
        private System.Windows.Forms.Label skipsCountText;
        private System.Windows.Forms.Button skipButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label enterText;
        private System.Windows.Forms.Label submissionText;
    }
}