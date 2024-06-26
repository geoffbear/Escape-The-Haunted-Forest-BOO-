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
    public partial class pictureForm : Form
    {
        public pictureForm()
        {
            InitializeComponent();
        }

        int skips = 5, correct = 0, wrong = 0, random;
        Random generator = new Random();
        SoundPlayer confettiSound = new SoundPlayer(Properties.Resources.Confetti1);

        private void pictureForm_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void winTimer_Tick(object sender, EventArgs e)
        {
            winTimer.Enabled = false;
            introForm.photo = true;
            gameplayForm gF = new gameplayForm();
            this.Hide();
            gF.ShowDialog();
            this.Show();
            this.Dispose();
        }

        //1 = Atmosphere, 2 = Ethan, 3 = Jim Carrey, 4 = Justin Trudeau, 5 = Kanye West, 6 = Mario, 7 = Mona Lisa, 8 = Nick.

        private void pictureForm_Load(object sender, EventArgs e)
        {
            guessPic.Location = new Point(12, 12);
            guessPic.Size = new Size(815, 436);
            random = generator.Next(1, 9);

            if (random == 1)
            {
                guessPic.BackgroundImage = Properties.Resources.AtmosphereLow;
                guessPic.Location = new Point(12, 12);
                guessPic.Size = new Size(824, 436);
            }

            else if (random == 2)
            {
                guessPic.BackgroundImage = Properties.Resources.EthanLow;
                guessPic.Location = new Point(256, 12);
                guessPic.Size = new Size(339, 436);
            }

            else if (random == 3)
            {
                guessPic.BackgroundImage = Properties.Resources.JimCarreyLow;
                guessPic.Location = new Point(302, 12);
                guessPic.Size = new Size(255, 436);
            }

            else if (random == 4)
            {
                guessPic.BackgroundImage = Properties.Resources.JustinTrudeauLow;
                guessPic.Location = new Point(244, 12);
                guessPic.Size = new Size(367, 436);
            }

            else if (random == 5)
            {
                guessPic.BackgroundImage = Properties.Resources.KanyeWestLow;
                guessPic.Location = new Point(137, 12);
                guessPic.Size = new Size(599, 436);
            }

            else if (random == 6)
            {
                guessPic.BackgroundImage = Properties.Resources.MarioLow;
                guessPic.Location = new Point(324, 12);
                guessPic.Size = new Size(201, 436);
            }

            else if (random == 7)
            {
                guessPic.BackgroundImage = Properties.Resources.MonaLisaLow;
                guessPic.Location = new Point(280, 12);
                guessPic.Size = new Size(293, 436);
            }

            else if (random == 8)
            {
                guessPic.BackgroundImage = Properties.Resources.NickLow;
                guessPic.Location = new Point(324, 12);
                guessPic.Size = new Size(201, 436);
            }

            //Low = Highest number - 32
            //Med = Highest number - 64
            //High = Dowloaded Size
        }

        private void winCheck()
        {
            winCountText.Text = correct + "";

            if (correct == 5)
            {
                winTimer.Enabled = true;
                confettiSound.Play();
            }

            else if (wrong == 1)
            {
                loseForm lF = new loseForm();
                this.Hide();
                lF.ShowDialog();
                this.Show();
                this.Dispose();
            }
        }
    }
}

