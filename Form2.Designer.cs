namespace Escape_The_Haunted_Forest__BOO__
{
    partial class gameplayForm
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
            this.photoPic = new System.Windows.Forms.PictureBox();
            this.globeGamePic = new System.Windows.Forms.PictureBox();
            this.butterflyGamePic = new System.Windows.Forms.PictureBox();
            this.globeTrophyPic = new System.Windows.Forms.PictureBox();
            this.butteflyTrophyPic = new System.Windows.Forms.PictureBox();
            this.photoTrophyPic = new System.Windows.Forms.PictureBox();
            this.winPic = new System.Windows.Forms.PictureBox();
            this.drumRollTimer = new System.Windows.Forms.Timer(this.components);
            this.arrowPic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.photoPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.globeGamePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.butterflyGamePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.globeTrophyPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.butteflyTrophyPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoTrophyPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.winPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrowPic)).BeginInit();
            this.SuspendLayout();
            // 
            // photoPic
            // 
            this.photoPic.BackColor = System.Drawing.Color.Transparent;
            this.photoPic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.photoPic.Location = new System.Drawing.Point(106, 1);
            this.photoPic.Name = "photoPic";
            this.photoPic.Size = new System.Drawing.Size(155, 144);
            this.photoPic.TabIndex = 0;
            this.photoPic.TabStop = false;
            this.photoPic.Click += new System.EventHandler(this.photoPic_Click);
            // 
            // globeGamePic
            // 
            this.globeGamePic.BackColor = System.Drawing.Color.Transparent;
            this.globeGamePic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.globeGamePic.Location = new System.Drawing.Point(395, 311);
            this.globeGamePic.Name = "globeGamePic";
            this.globeGamePic.Size = new System.Drawing.Size(155, 101);
            this.globeGamePic.TabIndex = 1;
            this.globeGamePic.TabStop = false;
            this.globeGamePic.Click += new System.EventHandler(this.globeGamePic_Click);
            // 
            // butterflyGamePic
            // 
            this.butterflyGamePic.BackColor = System.Drawing.Color.Transparent;
            this.butterflyGamePic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butterflyGamePic.Location = new System.Drawing.Point(289, 232);
            this.butterflyGamePic.Name = "butterflyGamePic";
            this.butterflyGamePic.Size = new System.Drawing.Size(56, 59);
            this.butterflyGamePic.TabIndex = 2;
            this.butterflyGamePic.TabStop = false;
            this.butterflyGamePic.Click += new System.EventHandler(this.butterflyGamePic_Click);
            // 
            // globeTrophyPic
            // 
            this.globeTrophyPic.BackColor = System.Drawing.Color.Transparent;
            this.globeTrophyPic.BackgroundImage = global::Escape_The_Haunted_Forest__BOO__.Properties.Resources.GlobeTrophy;
            this.globeTrophyPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.globeTrophyPic.Location = new System.Drawing.Point(12, 502);
            this.globeTrophyPic.Name = "globeTrophyPic";
            this.globeTrophyPic.Size = new System.Drawing.Size(51, 69);
            this.globeTrophyPic.TabIndex = 3;
            this.globeTrophyPic.TabStop = false;
            this.globeTrophyPic.Visible = false;
            // 
            // butteflyTrophyPic
            // 
            this.butteflyTrophyPic.BackColor = System.Drawing.Color.Transparent;
            this.butteflyTrophyPic.BackgroundImage = global::Escape_The_Haunted_Forest__BOO__.Properties.Resources.ButterflyTrophy;
            this.butteflyTrophyPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butteflyTrophyPic.Location = new System.Drawing.Point(69, 523);
            this.butteflyTrophyPic.Name = "butteflyTrophyPic";
            this.butteflyTrophyPic.Size = new System.Drawing.Size(75, 48);
            this.butteflyTrophyPic.TabIndex = 4;
            this.butteflyTrophyPic.TabStop = false;
            this.butteflyTrophyPic.Visible = false;
            // 
            // photoTrophyPic
            // 
            this.photoTrophyPic.BackColor = System.Drawing.Color.Transparent;
            this.photoTrophyPic.BackgroundImage = global::Escape_The_Haunted_Forest__BOO__.Properties.Resources.PhotoTrophy;
            this.photoTrophyPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.photoTrophyPic.Location = new System.Drawing.Point(150, 485);
            this.photoTrophyPic.Name = "photoTrophyPic";
            this.photoTrophyPic.Size = new System.Drawing.Size(70, 86);
            this.photoTrophyPic.TabIndex = 5;
            this.photoTrophyPic.TabStop = false;
            this.photoTrophyPic.Visible = false;
            // 
            // winPic
            // 
            this.winPic.BackColor = System.Drawing.Color.Transparent;
            this.winPic.Enabled = false;
            this.winPic.Location = new System.Drawing.Point(640, 92);
            this.winPic.Name = "winPic";
            this.winPic.Size = new System.Drawing.Size(120, 356);
            this.winPic.TabIndex = 6;
            this.winPic.TabStop = false;
            // 
            // drumRollTimer
            // 
            this.drumRollTimer.Interval = 5500;
            this.drumRollTimer.Tick += new System.EventHandler(this.drumRollTimer_Tick);
            // 
            // arrowPic
            // 
            this.arrowPic.BackColor = System.Drawing.Color.Transparent;
            this.arrowPic.BackgroundImage = global::Escape_The_Haunted_Forest__BOO__.Properties.Resources.RedArrow1;
            this.arrowPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.arrowPic.Location = new System.Drawing.Point(480, 92);
            this.arrowPic.Name = "arrowPic";
            this.arrowPic.Size = new System.Drawing.Size(154, 139);
            this.arrowPic.TabIndex = 7;
            this.arrowPic.TabStop = false;
            this.arrowPic.Visible = false;
            // 
            // gameplayForm
            // 
            this.BackgroundImage = global::Escape_The_Haunted_Forest__BOO__.Properties.Resources.EscapeRoom;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(839, 583);
            this.Controls.Add(this.arrowPic);
            this.Controls.Add(this.winPic);
            this.Controls.Add(this.photoTrophyPic);
            this.Controls.Add(this.butteflyTrophyPic);
            this.Controls.Add(this.globeTrophyPic);
            this.Controls.Add(this.butterflyGamePic);
            this.Controls.Add(this.globeGamePic);
            this.Controls.Add(this.photoPic);
            this.Name = "gameplayForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gameplay";
            this.Load += new System.EventHandler(this.gameplayForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.photoPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.globeGamePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.butterflyGamePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.globeTrophyPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.butteflyTrophyPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoTrophyPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.winPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrowPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        
        private System.Windows.Forms.PictureBox photoPic;
        private System.Windows.Forms.PictureBox globeGamePic;
        private System.Windows.Forms.PictureBox butterflyGamePic;
        private System.Windows.Forms.PictureBox globeTrophyPic;
        private System.Windows.Forms.PictureBox butteflyTrophyPic;
        private System.Windows.Forms.PictureBox photoTrophyPic;
        private System.Windows.Forms.PictureBox winPic;
        private System.Windows.Forms.Timer drumRollTimer;
        private System.Windows.Forms.PictureBox arrowPic;
    }
}