namespace Escape_The_Haunted_Forest__BOO__
{
    partial class Intro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Intro));
            this.TitleLabel = new System.Windows.Forms.Label();
            this.SubtitleLabel = new System.Windows.Forms.Label();
            this.IntroTimer = new System.Windows.Forms.Timer(this.components);
            this.EnterButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            resources.ApplyResources(this.TitleLabel, "TitleLabel");
            this.TitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.TitleLabel.ForeColor = System.Drawing.Color.MistyRose;
            this.TitleLabel.Name = "TitleLabel";
            // 
            // SubtitleLabel
            // 
            resources.ApplyResources(this.SubtitleLabel, "SubtitleLabel");
            this.SubtitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.SubtitleLabel.ForeColor = System.Drawing.Color.SaddleBrown;
            this.SubtitleLabel.Name = "SubtitleLabel";
            // 
            // IntroTimer
            // 
            this.IntroTimer.Interval = 1000;
            this.IntroTimer.Tick += new System.EventHandler(this.IntroTimer_Tick);
            // 
            // EnterButton
            // 
            this.EnterButton.BackColor = System.Drawing.Color.Transparent;
            this.EnterButton.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.EnterButton, "EnterButton");
            this.EnterButton.Name = "EnterButton";
            this.EnterButton.UseVisualStyleBackColor = false;
            this.EnterButton.Click += new System.EventHandler(this.EnterButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Transparent;
            this.ExitButton.ForeColor = System.Drawing.SystemColors.ControlText;
            resources.ApplyResources(this.ExitButton, "ExitButton");
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.UseVisualStyleBackColor = false;
            // 
            // Intro
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Escape_The_Haunted_Forest__BOO__.Properties.Resources.EscapeRoomDoor;
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.EnterButton);
            this.Controls.Add(this.SubtitleLabel);
            this.Controls.Add(this.TitleLabel);
            this.Name = "Intro";
            this.Load += new System.EventHandler(this.Intro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label SubtitleLabel;
        private System.Windows.Forms.Timer IntroTimer;
        private System.Windows.Forms.Button EnterButton;
        private System.Windows.Forms.Button ExitButton;
    }
}

