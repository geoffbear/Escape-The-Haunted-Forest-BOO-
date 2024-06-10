using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escape_The_Haunted_Forest__BOO__
{
    public partial class introForm : Form
    {
        //public static bool back = false;
        public introForm()
        {
            InitializeComponent();
        }
        
        SoundPlayer introMusic = new SoundPlayer(Properties.Resources.IntroMusic);
        SoundPlayer knockKnock = new SoundPlayer(Properties.Resources.KnockKnock);
        private void Intro_Load(object sender, EventArgs e)
        {

            introMusic.Play();
            IntroTimer.Start();
            
            //if (back)
            {
                introMusic.Stop();
                enterBtn.Visible = true;
                exitbtn.Visible = true;
            }
        }

        private void IntroTimer_Tick(object sender, EventArgs e)
        {
            enterBtn.Visible = true;
            exitbtn.Visible = true;
            IntroTimer.Stop();
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            knockKnock.Play();
            knockTimer.Start();
        }

        private void knockTimer_Tick(object sender, EventArgs e)
        {
            knockTimer.Stop();
            gameplayForm gameplayForm = new gameplayForm();
            this.Hide();
            gameplayForm.ShowDialog();
            this.Show();
            this.Dispose();
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            exitPrompt exitPrompt = new exitPrompt();
            this.Hide();
            exitPrompt.ShowDialog();
            this.Show();
            this.Dispose();
        }
    }
}
