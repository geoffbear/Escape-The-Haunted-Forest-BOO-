namespace Escape_The_Haunted_Forest__BOO__
{
    partial class winForm
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
            this.winText = new System.Windows.Forms.Label();
            this.luckyCharmsPic = new System.Windows.Forms.PictureBox();
            this.subWinText = new System.Windows.Forms.Label();
            this.winTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.luckyCharmsPic)).BeginInit();
            this.SuspendLayout();
            // 
            // winText
            // 
            this.winText.AutoSize = true;
            this.winText.Font = new System.Drawing.Font("Segoe UI Symbol", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winText.Location = new System.Drawing.Point(469, 188);
            this.winText.Name = "winText";
            this.winText.Size = new System.Drawing.Size(333, 86);
            this.winText.TabIndex = 0;
            this.winText.Text = "YOU WIN!";
            // 
            // luckyCharmsPic
            // 
            this.luckyCharmsPic.BackColor = System.Drawing.Color.Transparent;
            this.luckyCharmsPic.BackgroundImage = global::Escape_The_Haunted_Forest__BOO__.Properties.Resources.LuckyCharms;
            this.luckyCharmsPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.luckyCharmsPic.Location = new System.Drawing.Point(4, 12);
            this.luckyCharmsPic.Name = "luckyCharmsPic";
            this.luckyCharmsPic.Size = new System.Drawing.Size(464, 559);
            this.luckyCharmsPic.TabIndex = 1;
            this.luckyCharmsPic.TabStop = false;
            // 
            // subWinText
            // 
            this.subWinText.AutoSize = true;
            this.subWinText.Location = new System.Drawing.Point(474, 274);
            this.subWinText.Name = "subWinText";
            this.subWinText.Size = new System.Drawing.Size(328, 13);
            this.subWinText.TabIndex = 2;
            this.subWinText.Text = "You now have access to the world\'s supply of Lucky Charms! Enjoy!";
            // 
            // winTimer
            // 
            this.winTimer.Interval = 7900;
            this.winTimer.Tick += new System.EventHandler(this.winTimer_Tick);
            // 
            // winForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 583);
            this.Controls.Add(this.subWinText);
            this.Controls.Add(this.luckyCharmsPic);
            this.Controls.Add(this.winText);
            this.Name = "winForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "You Win!";
            this.Load += new System.EventHandler(this.winForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.luckyCharmsPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label winText;
        private System.Windows.Forms.PictureBox luckyCharmsPic;
        private System.Windows.Forms.Label subWinText;
        private System.Windows.Forms.Timer winTimer;
    }
}