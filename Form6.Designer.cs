namespace Escape_The_Haunted_Forest__BOO__
{
    partial class loseForm
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
            this.leprechaunPic = new System.Windows.Forms.PictureBox();
            this.loseMessageTxt = new System.Windows.Forms.Label();
            this.loseSubMessage = new System.Windows.Forms.Label();
            this.loseTmr = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.leprechaunPic)).BeginInit();
            this.SuspendLayout();
            // 
            // leprechaunPic
            // 
            this.leprechaunPic.BackColor = System.Drawing.Color.Transparent;
            this.leprechaunPic.BackgroundImage = global::Escape_The_Haunted_Forest__BOO__.Properties.Resources.LeprechaunCool;
            this.leprechaunPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.leprechaunPic.Location = new System.Drawing.Point(0, -1);
            this.leprechaunPic.Name = "leprechaunPic";
            this.leprechaunPic.Size = new System.Drawing.Size(799, 451);
            this.leprechaunPic.TabIndex = 0;
            this.leprechaunPic.TabStop = false;
            // 
            // loseMessageTxt
            // 
            this.loseMessageTxt.AutoSize = true;
            this.loseMessageTxt.BackColor = System.Drawing.Color.Transparent;
            this.loseMessageTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loseMessageTxt.Location = new System.Drawing.Point(117, -1);
            this.loseMessageTxt.Name = "loseMessageTxt";
            this.loseMessageTxt.Size = new System.Drawing.Size(582, 111);
            this.loseMessageTxt.TabIndex = 1;
            this.loseMessageTxt.Text = "You have lost!\r\nThe Leprechaun has won!\r\nYou are trapped in the mansion forever.";
            this.loseMessageTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // loseSubMessage
            // 
            this.loseSubMessage.AutoSize = true;
            this.loseSubMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loseSubMessage.Location = new System.Drawing.Point(277, 367);
            this.loseSubMessage.Name = "loseSubMessage";
            this.loseSubMessage.Size = new System.Drawing.Size(252, 32);
            this.loseSubMessage.TabIndex = 2;
            this.loseSubMessage.Text = "Thanks for playing!\r\nWould you like to play again (type Y or N)";
            this.loseSubMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.loseSubMessage.Visible = false;
            // 
            // loseTmr
            // 
            this.loseTmr.Interval = 1000;
            this.loseTmr.Tick += new System.EventHandler(this.loseTmr_Tick);
            // 
            // loseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.loseSubMessage);
            this.Controls.Add(this.loseMessageTxt);
            this.Controls.Add(this.leprechaunPic);
            this.Name = "loseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "You Lose!";
            this.Load += new System.EventHandler(this.loseForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.loseForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.leprechaunPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox leprechaunPic;
        private System.Windows.Forms.Label loseMessageTxt;
        private System.Windows.Forms.Label loseSubMessage;
        private System.Windows.Forms.Timer loseTmr;
    }
}