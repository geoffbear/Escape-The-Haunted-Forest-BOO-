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
    public partial class Intro : Form
    {
        public Intro()
        {
            InitializeComponent();
        }
        SoundPlayer introMusic = new SoundPlayer(Properties.Resources.IntroMusic);
        SoundPlayer knockKnock = new SoundPlayer(Properties.Resources.KnockKnock);
        private void Intro_Load(object sender, EventArgs e)
        {
            introMusic.Play();
            IntroTimer.Start();
        }

        private void IntroTimer_Tick(object sender, EventArgs e)
        {
            EnterButton.Visible = true;
            ExitButton.Visible = true;
            IntroTimer.Stop();
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            knockKnock.Play();
        }

        private void knockTimer_Tick(object sender, EventArgs e)
        {
            //formGameplay formGameplay = new formGameplay();
            //this.Hide();
            //formGameplay.ShowDialog();
            //this.Show();
            //this.Dispose();
            }
    }
}
