namespace Escape_The_Haunted_Forest__BOO__
{
    partial class globeGameForm
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
            this.canadaPic = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.canadaPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // canadaPic
            // 
            this.canadaPic.BackColor = System.Drawing.Color.Transparent;
            this.canadaPic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.canadaPic.Location = new System.Drawing.Point(90, 31);
            this.canadaPic.Name = "canadaPic";
            this.canadaPic.Size = new System.Drawing.Size(193, 185);
            this.canadaPic.TabIndex = 0;
            this.canadaPic.TabStop = false;
            this.canadaPic.Click += new System.EventHandler(this.canadaPic_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(439, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(340, 145);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // globeGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Escape_The_Haunted_Forest__BOO__.Properties.Resources.GlobeGameBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(839, 583);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.canadaPic);
            this.DoubleBuffered = true;
            this.Name = "globeGameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Globe Game";
            this.Load += new System.EventHandler(this.globeGameForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.canadaPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox canadaPic;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}