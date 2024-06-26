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

        int skips = 5, correct = 0, wrong = 0, random, image;
        Random generator = new Random();
        SoundPlayer confettiSound = new SoundPlayer(Properties.Resources.Confetti1);

        private void submissionButton_Click(object sender, EventArgs e)
        {
            if (guessText.Text.Trim().ToUpper() == "ATMOSPHERE" && random == 1)
            {
                correct++;
                winCheck();
                newImage();
            }

            else if (guessText.Text.Trim().ToUpper() == "ETHAN" && random == 2)
            {
                correct++;
                winCheck();
                newImage();
            }

            else if (guessText.Text.Trim().ToUpper() == "JIM CARREY" && random == 3)
            {
                correct++;
                winCheck();
                newImage();
            }

            else if (guessText.Text.Trim().ToUpper() == "JUSTIN TRUDEAU" && random == 4)
            {
                correct++;
                winCheck();
            }

            else if (guessText.Text.Trim().ToUpper() == "KANYE WEST" && random == 5)
            {
                correct++;
                winCheck();
                newImage();
            }

            else if (guessText.Text.Trim().ToUpper() == "MARIO" && random == 6)
            {
                correct++;
                winCheck();
                newImage();
            }

            else if (guessText.Text.Trim().ToUpper() == "MONA LISA" && random == 7)
            {
                correct++;
                winCheck();
                newImage();
            }

            else if (guessText.Text.Trim().ToUpper() == "NICK" && random == 8)
            {
                correct++;
                winCheck();
                newImage();
            }

            else
                wrong++;

            winCheck();
        }

        private void skipButton_Click(object sender, EventArgs e)
        {
            skips--;
            skipsCountText.Text = skips + "";
            if (skips == 0)
            {
                skipButton.Enabled = false;
            }
            if (guessPic.BackgroundImage == Properties.Resources.AtmosphereLow)
            {
                guessPic.BackgroundImage = Properties.Resources.AtmosphereMed;
            }
            else if (guessPic.BackgroundImage == Properties.Resources.AtmosphereMed)
            {
                guessPic.BackgroundImage = Properties.Resources.AtmosphereHigh;
            }
            else if (guessPic.BackgroundImage == Properties.Resources.EthanLow)
            {
                guessPic.BackgroundImage = Properties.Resources.EthanMed;
            }
            else if (guessPic.BackgroundImage == Properties.Resources.EthanMed)
            {
                guessPic.BackgroundImage = Properties.Resources.EthanHigh;
            }
            else if (guessPic.BackgroundImage == Properties.Resources.JimCarreyLow)
            {
                guessPic.BackgroundImage = Properties.Resources.JimCarreyMed;
            }
            else if (guessPic.BackgroundImage == Properties.Resources.JimCarreyMed)
            {
                guessPic.BackgroundImage = Properties.Resources.JimCarreyHigh;
            }
            else if (guessPic.BackgroundImage == Properties.Resources.JustinTrudeauLow)
            {
                guessPic.BackgroundImage = Properties.Resources.JustinTrudeauMed;
            }
            else if (guessPic.BackgroundImage == Properties.Resources.JustinTrudeauMed)
            {
                guessPic.BackgroundImage = Properties.Resources.JustinTrudeauHigh;
            }
            else if (guessPic.BackgroundImage == Properties.Resources.KanyeWestLow)
            {
                guessPic.BackgroundImage = Properties.Resources.KanyeWestMed;
            }
            else if (guessPic.BackgroundImage == Properties.Resources.KanyeWestMed)
            {
                guessPic.BackgroundImage = Properties.Resources.KanyeWestHigh;
            }
            else if (guessPic.BackgroundImage == Properties.Resources.MarioLow)
            {
                guessPic.BackgroundImage = Properties.Resources.MarioMed;
            }
            else if (guessPic.BackgroundImage == Properties.Resources.MarioMed)
            {
                guessPic.BackgroundImage = Properties.Resources.MarioHigh;
            }
            else if (guessPic.BackgroundImage == Properties.Resources.MonaLisaLow)
            {
                guessPic.BackgroundImage = Properties.Resources.MonaLisaMed;
            }
            else if (guessPic.BackgroundImage == Properties.Resources.MonaLisaMed)
            {
                guessPic.BackgroundImage = Properties.Resources.MonaLisaHigh;
            }
            else if (guessPic.BackgroundImage == Properties.Resources.NickLow)
            {
                guessPic.BackgroundImage = Properties.Resources.NickMed;
            }
            else if (guessPic.BackgroundImage == Properties.Resources.NickMed)
            {
                guessPic.BackgroundImage = Properties.Resources.NickHigh;
            }
            else
            {
                newImage();
            }

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

        private void newImage()
        {
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
        }
    }
}

