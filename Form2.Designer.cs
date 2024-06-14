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
            this.globePic = new System.Windows.Forms.PictureBox();
            this.photoPic = new System.Windows.Forms.PictureBox();
            this.butterflyPic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.globePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.butterflyPic)).BeginInit();
            this.SuspendLayout();
            // 
            // globePic
            // 
            this.globePic.BackColor = System.Drawing.Color.Transparent;
            this.globePic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.globePic.Location = new System.Drawing.Point(392, 310);
            this.globePic.Name = "globePic";
            this.globePic.Size = new System.Drawing.Size(150, 101);
            this.globePic.TabIndex = 0;
            this.globePic.TabStop = false;
            this.globePic.Click += new System.EventHandler(this.globePic_Click);
            // 
            // photoPic
            // 
            this.photoPic.BackColor = System.Drawing.Color.Transparent;
            this.photoPic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.photoPic.Location = new System.Drawing.Point(108, 0);
            this.photoPic.Name = "photoPic";
            this.photoPic.Size = new System.Drawing.Size(151, 143);
            this.photoPic.TabIndex = 1;
            this.photoPic.TabStop = false;
            this.photoPic.Click += new System.EventHandler(this.photoPic_Click);
            // 
            // butterflyPic
            // 
            this.butterflyPic.BackColor = System.Drawing.Color.Transparent;
            this.butterflyPic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butterflyPic.Location = new System.Drawing.Point(290, 236);
            this.butterflyPic.Name = "butterflyPic";
            this.butterflyPic.Size = new System.Drawing.Size(55, 57);
            this.butterflyPic.TabIndex = 2;
            this.butterflyPic.TabStop = false;
            this.butterflyPic.Click += new System.EventHandler(this.butterflyPic_Click);
            // 
            // gameplayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Escape_The_Haunted_Forest__BOO__.Properties.Resources.EscapeRoom1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(839, 583);
            this.Controls.Add(this.butterflyPic);
            this.Controls.Add(this.photoPic);
            this.Controls.Add(this.globePic);
            this.Name = "gameplayForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gameplay";
            ((System.ComponentModel.ISupportInitialize)(this.globePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.butterflyPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox globePic;
        private System.Windows.Forms.PictureBox photoPic;
        private System.Windows.Forms.PictureBox butterflyPic;
    }
}