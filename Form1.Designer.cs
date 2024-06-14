namespace Escape_The_Haunted_Forest__BOO__
{
    partial class introForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(introForm));
            this.titleTxt = new System.Windows.Forms.Label();
            this.subtitleTxt = new System.Windows.Forms.Label();
            this.IntroTimer = new System.Windows.Forms.Timer(this.components);
            this.enterBtn = new System.Windows.Forms.Button();
            this.exitbtn = new System.Windows.Forms.Button();
            this.knockTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // titleTxt
            // 
            resources.ApplyResources(this.titleTxt, "titleTxt");
            this.titleTxt.BackColor = System.Drawing.Color.Transparent;
            this.titleTxt.ForeColor = System.Drawing.Color.MistyRose;
            this.titleTxt.Name = "titleTxt";
            // 
            // subtitleTxt
            // 
            resources.ApplyResources(this.subtitleTxt, "subtitleTxt");
            this.subtitleTxt.BackColor = System.Drawing.Color.Transparent;
            this.subtitleTxt.Cursor = System.Windows.Forms.Cursors.Default;
            this.subtitleTxt.ForeColor = System.Drawing.Color.SaddleBrown;
            this.subtitleTxt.Name = "subtitleTxt";
            // 
            // IntroTimer
            // 
            this.IntroTimer.Interval = 10000;
            this.IntroTimer.Tick += new System.EventHandler(this.IntroTimer_Tick);
            // 
            // enterBtn
            // 
            this.enterBtn.BackColor = System.Drawing.Color.Transparent;
            this.enterBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.enterBtn.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.enterBtn, "enterBtn");
            this.enterBtn.Name = "enterBtn";
            this.enterBtn.UseVisualStyleBackColor = false;
            this.enterBtn.Click += new System.EventHandler(this.EnterButton_Click);
            // 
            // exitbtn
            // 
            this.exitbtn.BackColor = System.Drawing.Color.Transparent;
            this.exitbtn.BackgroundImage = global::Escape_The_Haunted_Forest__BOO__.Properties.Resources.RedArrow;
            resources.ApplyResources(this.exitbtn, "exitbtn");
            this.exitbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitbtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.UseVisualStyleBackColor = false;
            this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click);
            // 
            // knockTimer
            // 
            this.knockTimer.Interval = 1000;
            this.knockTimer.Tick += new System.EventHandler(this.knockTimer_Tick);
            // 
            // introForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Escape_The_Haunted_Forest__BOO__.Properties.Resources.EscapeRoomDoor;
            this.Controls.Add(this.exitbtn);
            this.Controls.Add(this.enterBtn);
            this.Controls.Add(this.subtitleTxt);
            this.Controls.Add(this.titleTxt);
            this.Name = "introForm";
            this.Load += new System.EventHandler(this.Intro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleTxt;
        private System.Windows.Forms.Label subtitleTxt;
        private System.Windows.Forms.Timer IntroTimer;
        private System.Windows.Forms.Button enterBtn;
        private System.Windows.Forms.Button exitbtn;
        private System.Windows.Forms.Timer knockTimer;
    }
}

