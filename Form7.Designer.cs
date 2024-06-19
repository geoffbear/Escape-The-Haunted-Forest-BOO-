namespace Escape_The_Haunted_Forest__BOO__
{
    partial class rulesForm
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
            this.ruleText = new System.Windows.Forms.Label();
            this.globeGameRules = new System.Windows.Forms.Label();
            this.butterflyGameRules = new System.Windows.Forms.Label();
            this.picRules = new System.Windows.Forms.Label();
            this.continueButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ruleText
            // 
            this.ruleText.AutoSize = true;
            this.ruleText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ruleText.Location = new System.Drawing.Point(37, 9);
            this.ruleText.Name = "ruleText";
            this.ruleText.Size = new System.Drawing.Size(700, 75);
            this.ruleText.TabIndex = 0;
            this.ruleText.Text = "You will be placed in a room with clickable puzzles.\r\nAfter completing all the pu" +
    "zzles, you will be able to escape the mansion.\r\nFailing one puzzle, will cause y" +
    "ou to lose.\r\n";
            this.ruleText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // globeGameRules
            // 
            this.globeGameRules.AutoSize = true;
            this.globeGameRules.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.globeGameRules.Location = new System.Drawing.Point(39, 125);
            this.globeGameRules.Name = "globeGameRules";
            this.globeGameRules.Size = new System.Drawing.Size(535, 36);
            this.globeGameRules.TabIndex = 1;
            this.globeGameRules.Text = "In the globe puzzle, you will need to find 5 random countres on a map.\r\nGet 5 wro" +
    "ng, you lose.";
            // 
            // butterflyGameRules
            // 
            this.butterflyGameRules.AutoSize = true;
            this.butterflyGameRules.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butterflyGameRules.Location = new System.Drawing.Point(39, 203);
            this.butterflyGameRules.Name = "butterflyGameRules";
            this.butterflyGameRules.Size = new System.Drawing.Size(474, 54);
            this.butterflyGameRules.TabIndex = 2;
            this.butterflyGameRules.Text = "In the butterfly puzzle, you will be given 6 black butterflies.\r\nLike a game of m" +
    "emory, you will need to match 3 pairs to win.\r\nGet 3 wrong, you fail.";
            this.butterflyGameRules.Visible = false;
            // 
            // picRules
            // 
            this.picRules.AutoSize = true;
            this.picRules.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.picRules.Location = new System.Drawing.Point(39, 327);
            this.picRules.Name = "picRules";
            this.picRules.Size = new System.Drawing.Size(65, 18);
            this.picRules.TabIndex = 3;
            this.picRules.Text = "picRules";
            this.picRules.Visible = false;
            // 
            // continueButton
            // 
            this.continueButton.Location = new System.Drawing.Point(12, 522);
            this.continueButton.Name = "continueButton";
            this.continueButton.Size = new System.Drawing.Size(815, 49);
            this.continueButton.TabIndex = 4;
            this.continueButton.Text = "Continue";
            this.continueButton.UseVisualStyleBackColor = true;
            this.continueButton.Click += new System.EventHandler(this.continueButton_Click);
            // 
            // rulesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 583);
            this.Controls.Add(this.continueButton);
            this.Controls.Add(this.picRules);
            this.Controls.Add(this.butterflyGameRules);
            this.Controls.Add(this.globeGameRules);
            this.Controls.Add(this.ruleText);
            this.Name = "rulesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rules (Read Up)";
            this.Load += new System.EventHandler(this.rulesForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ruleText;
        private System.Windows.Forms.Label globeGameRules;
        private System.Windows.Forms.Label butterflyGameRules;
        private System.Windows.Forms.Label picRules;
        private System.Windows.Forms.Button continueButton;
    }
}