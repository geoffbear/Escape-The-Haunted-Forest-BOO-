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
            this.guessPic = new System.Windows.Forms.PictureBox();
            this.skipsText = new System.Windows.Forms.Label();
            this.skipsCountText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.guessPic)).BeginInit();
            this.SuspendLayout();
            // 
            // guessPic
            // 
            this.guessPic.BackColor = System.Drawing.Color.Transparent;
            this.guessPic.Location = new System.Drawing.Point(12, 12);
            this.guessPic.Name = "guessPic";
            this.guessPic.Size = new System.Drawing.Size(815, 436);
            this.guessPic.TabIndex = 0;
            this.guessPic.TabStop = false;
            // 
            // skipsText
            // 
            this.skipsText.AutoSize = true;
            this.skipsText.Font = new System.Drawing.Font("MS Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skipsText.Location = new System.Drawing.Point(467, 449);
            this.skipsText.Name = "skipsText";
            this.skipsText.Size = new System.Drawing.Size(321, 37);
            this.skipsText.TabIndex = 1;
            this.skipsText.Text = "Skips Remaining:";
            // 
            // skipsCountText
            // 
            this.skipsCountText.AutoSize = true;
            this.skipsCountText.Font = new System.Drawing.Font("MS Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skipsCountText.Location = new System.Drawing.Point(794, 451);
            this.skipsCountText.Name = "skipsCountText";
            this.skipsCountText.Size = new System.Drawing.Size(33, 35);
            this.skipsCountText.TabIndex = 2;
            this.skipsCountText.Text = "5";
            // 
            // pictureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 583);
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
    }
}