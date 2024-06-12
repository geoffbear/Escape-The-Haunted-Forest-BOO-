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
            this.lore3Txt = new System.Windows.Forms.Label();
            this.lore1Txt = new System.Windows.Forms.Label();
            this.lore2Txt = new System.Windows.Forms.Label();
            this.lore4Txt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lore3Txt
            // 
            this.lore3Txt.AutoSize = true;
            this.lore3Txt.Location = new System.Drawing.Point(131, 210);
            this.lore3Txt.Name = "lore3Txt";
            this.lore3Txt.Size = new System.Drawing.Size(581, 13);
            this.lore3Txt.TabIndex = 0;
            this.lore3Txt.Text = "Until one day you stumbled upon an unsuspecful cute little leprechaun who lured y" +
    "ou in offering you his LUCKY CHARMS.";
            // 
            // lore1Txt
            // 
            this.lore1Txt.AutoSize = true;
            this.lore1Txt.Location = new System.Drawing.Point(156, 152);
            this.lore1Txt.Name = "lore1Txt";
            this.lore1Txt.Size = new System.Drawing.Size(457, 13);
            this.lore1Txt.TabIndex = 1;
            this.lore1Txt.Text = "Ever since you could remember your family was far too poor to afford even a singl" +
    "e lucky charm.\r\n";
            // 
            // lore2Txt
            // 
            this.lore2Txt.AutoSize = true;
            this.lore2Txt.Location = new System.Drawing.Point(188, 177);
            this.lore2Txt.Name = "lore2Txt";
            this.lore2Txt.Size = new System.Drawing.Size(396, 13);
            this.lore2Txt.TabIndex = 3;
            this.lore2Txt.Text = "Instead you and your family remained stuck eating BRAN for the rest of your lives" +
    "...";
            // 
            // lore4Txt
            // 
            this.lore4Txt.AutoSize = true;
            this.lore4Txt.Location = new System.Drawing.Point(233, 246);
            this.lore4Txt.Name = "lore4Txt";
            this.lore4Txt.Size = new System.Drawing.Size(305, 13);
            this.lore4Txt.TabIndex = 4;
            this.lore4Txt.Text = "He told you to meet him at his \"definitely not haunted\" mansion.\r\n";
            // 
            // loreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 583);
            this.Controls.Add(this.lore4Txt);
            this.Controls.Add(this.lore2Txt);
            this.Controls.Add(this.lore1Txt);
            this.Controls.Add(this.lore3Txt);
            this.Name = "loreForm";
            this.Text = "Story";
            this.Load += new System.EventHandler(this.loreForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lore3Txt;
        private System.Windows.Forms.Label lore1Txt;
        private System.Windows.Forms.Label lore2Txt;
        private System.Windows.Forms.Label lore4Txt;
    }
}