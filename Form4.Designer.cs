namespace Escape_The_Haunted_Forest__BOO__
{
    partial class loreForm
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
            this.lore3Txt = new System.Windows.Forms.Label();
            this.lore1Txt = new System.Windows.Forms.Label();
            this.lore2Txt = new System.Windows.Forms.Label();
            this.lore4Txt = new System.Windows.Forms.Label();
            this.loreTimer = new System.Windows.Forms.Timer(this.components);
            this.potOGoldPic = new System.Windows.Forms.PictureBox();
            this.leprechaunPic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.potOGoldPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leprechaunPic)).BeginInit();
            this.SuspendLayout();
            // 
            // lore3Txt
            // 
            this.lore3Txt.AutoSize = true;
            this.lore3Txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lore3Txt.Location = new System.Drawing.Point(24, 87);
            this.lore3Txt.Name = "lore3Txt";
            this.lore3Txt.Size = new System.Drawing.Size(803, 18);
            this.lore3Txt.TabIndex = 0;
            this.lore3Txt.Text = "Until one day you stumbled upon an unsuspecful cute little leprechaun who lured y" +
    "ou in offering you his LUCKY CHARMS.";
            // 
            // lore1Txt
            // 
            this.lore1Txt.AutoSize = true;
            this.lore1Txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lore1Txt.Location = new System.Drawing.Point(105, 31);
            this.lore1Txt.Name = "lore1Txt";
            this.lore1Txt.Size = new System.Drawing.Size(641, 18);
            this.lore1Txt.TabIndex = 1;
            this.lore1Txt.Text = "Ever since you could remember your family was far too poor to afford even a singl" +
    "e lucky charm.\r\n";
            // 
            // lore2Txt
            // 
            this.lore2Txt.AutoSize = true;
            this.lore2Txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lore2Txt.Location = new System.Drawing.Point(151, 59);
            this.lore2Txt.Name = "lore2Txt";
            this.lore2Txt.Size = new System.Drawing.Size(549, 18);
            this.lore2Txt.TabIndex = 3;
            this.lore2Txt.Text = "Instead you and your family remained stuck eating BRAN for the rest of your lives" +
    "...";
            // 
            // lore4Txt
            // 
            this.lore4Txt.AutoSize = true;
            this.lore4Txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lore4Txt.Location = new System.Drawing.Point(201, 116);
            this.lore4Txt.Name = "lore4Txt";
            this.lore4Txt.Size = new System.Drawing.Size(420, 18);
            this.lore4Txt.TabIndex = 4;
            this.lore4Txt.Text = "He told you to meet him at his \"definitely not haunted\" mansion.\r\n";
            // 
            // loreTimer
            // 
            this.loreTimer.Interval = 10000;
            this.loreTimer.Tick += new System.EventHandler(this.loreTimer_Tick);
            // 
            // potOGoldPic
            // 
            this.potOGoldPic.Image = global::Escape_The_Haunted_Forest__BOO__.Properties.Resources.PotOGold;
            this.potOGoldPic.Location = new System.Drawing.Point(426, 168);
            this.potOGoldPic.Name = "potOGoldPic";
            this.potOGoldPic.Size = new System.Drawing.Size(320, 321);
            this.potOGoldPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.potOGoldPic.TabIndex = 6;
            this.potOGoldPic.TabStop = false;
            // 
            // leprechaunPic
            // 
            this.leprechaunPic.Image = global::Escape_The_Haunted_Forest__BOO__.Properties.Resources.Leprechaun;
            this.leprechaunPic.Location = new System.Drawing.Point(27, 168);
            this.leprechaunPic.Name = "leprechaunPic";
            this.leprechaunPic.Size = new System.Drawing.Size(335, 311);
            this.leprechaunPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.leprechaunPic.TabIndex = 5;
            this.leprechaunPic.TabStop = false;
            // 
            // loreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 583);
            this.Controls.Add(this.potOGoldPic);
            this.Controls.Add(this.leprechaunPic);
            this.Controls.Add(this.lore4Txt);
            this.Controls.Add(this.lore2Txt);
            this.Controls.Add(this.lore1Txt);
            this.Controls.Add(this.lore3Txt);
            this.Name = "loreForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Story";
            this.Load += new System.EventHandler(this.loreForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.potOGoldPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leprechaunPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lore3Txt;
        private System.Windows.Forms.Label lore1Txt;
        private System.Windows.Forms.Label lore2Txt;
        private System.Windows.Forms.Label lore4Txt;
        private System.Windows.Forms.Timer loreTimer;
        private System.Windows.Forms.PictureBox leprechaunPic;
        private System.Windows.Forms.PictureBox potOGoldPic;
    }
}