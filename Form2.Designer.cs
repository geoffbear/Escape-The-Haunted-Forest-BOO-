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
            this.SuspendLayout();
            // 
            // gameplayForm
            // 
            this.ClientSize = new System.Drawing.Size(839, 583);
            this.Name = "gameplayForm";
            this.Text = "Gameplay";
            this.Load += new System.EventHandler(this.gameplayForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox globePic;
        private System.Windows.Forms.PictureBox photoPic;
        private System.Windows.Forms.PictureBox butterflyPic;
    }
}