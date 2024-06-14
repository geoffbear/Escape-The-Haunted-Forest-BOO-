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
            this.photoPic = new System.Windows.Forms.PictureBox();
            this.globeGamePic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.photoPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.globeGamePic)).BeginInit();
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
            this.photoPic.Click += new System.EventHandler(this.photoPic_Click_1);
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
            // gameplayForm
            // 
            this.BackgroundImage = global::Escape_The_Haunted_Forest__BOO__.Properties.Resources.EscapeRoom;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(839, 583);
            this.Controls.Add(this.globeGamePic);
            this.Controls.Add(this.photoPic);
            this.Name = "gameplayForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gameplay";
            this.Load += new System.EventHandler(this.gameplayForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.photoPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.globeGamePic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        
        private System.Windows.Forms.PictureBox photoPic;
        private System.Windows.Forms.PictureBox globeGamePic;
    }
}