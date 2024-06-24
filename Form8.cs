using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escape_The_Haunted_Forest__BOO__
{
    public partial class butterflyGameForm : Form
    {
        public butterflyGameForm()
        {
            InitializeComponent();
        }
        SoundPlayer butterflyMusic = new SoundPlayer(Properties.Resources.ButterflyMusic);
        SoundPlayer confettiSound = new SoundPlayer(Properties.Resources.Confetti1);
        int wrong = 0, correct = 0, clicks = 0, random, prevColour, currentColour;
        List<int> colourRandomizerStart = new List<int>();
        List<int> colourRandomizerEnd = new List<int>();
        Random generator = new Random();
        //BACKGROUNDIMAGED CHANGED IS A BOLEAN COULD BE USEFUL!
        private void bird1Pic_Click(object sender, EventArgs e)
        {
            string colour = "";
            clicks++;
            if (colourRandomizerEnd[0] == 1)
            {
                bird1Pic.BackgroundImage = Properties.Resources.ButterflyBlue;
                colour = "blue";
            }

            else if (colourRandomizerEnd[0] == 2)
            {
                bird1Pic.BackgroundImage = Properties.Resources.ButterflyGreen;
                colour = "green";
            }

            else if (colourRandomizerEnd[0] == 3)
            {
                bird1Pic.BackgroundImage = Properties.Resources.ButterflyRed;
                colour = "red";
            }

            if (clicks == 1)
            {
                if (colour == "blue")
                {
                    prevColour = 1;
                }

                else if (colour == "green")
                {
                    prevColour = 2;
                }

                else if (colour == "red")
                {
                    prevColour = 3;
                }
            }

            else if (clicks == 2)
            {
                gameCheck();
                colourRevealTimer.Enabled = true;
                bird1Pic.Enabled = false;
                bird2Pic.Enabled = false;
                bird3Pic.Enabled = false;
                bird4Pic.Enabled = false;
                bird5Pic.Enabled = false;
                bird6Pic.Enabled = false;

                if (colour == "blue")
                {
                    currentColour = 1;
                }

                else if (colour == "green")
                {
                    currentColour = 2;
                }

                else if (colour == "red")
                {
                    currentColour = 3;
                }
                clicks = 0;
            }
        }


        private void bird2Pic_Click(object sender, EventArgs e)
        {
            string colour = "";
            clicks++;
            if (colourRandomizerEnd[1] == 1)
            {
                bird2Pic.BackgroundImage = Properties.Resources.ButterflyBlue;
                colour = "blue";
            }

            else if (colourRandomizerEnd[1] == 2)
            {
                bird2Pic.BackgroundImage = Properties.Resources.ButterflyGreen;
                colour = "green";
            }

            else if (colourRandomizerEnd[1] == 3)
            {
                bird2Pic.BackgroundImage= Properties.Resources.ButterflyRed;
                colour = "red";
            }

            if (clicks == 1)
            {
                if (colour == "blue")
                {
                    prevColour = 1;
                }

                else if (colour == "green")
                {
                    prevColour = 2;
                }

                else if (colour == "red")
                {
                    prevColour = 3;
                }
            }

            else if (clicks == 2)
            {
                gameCheck();
                colourRevealTimer.Enabled = true;
                bird1Pic.Enabled = false;
                bird2Pic.Enabled = false;
                bird3Pic.Enabled = false;
                bird4Pic.Enabled = false;
                bird5Pic.Enabled = false;
                bird6Pic.Enabled = false;

                if (colour == "blue")
                {
                    currentColour = 1;
                }

                else if (colour == "green")
                {
                    currentColour = 2;
                }

                else if (colour == "red")
                {
                    currentColour = 3;
                }
                clicks = 0;
            }
        }

        private void bird3Pic_Click(object sender, EventArgs e)
        {
            string colour = "";
            clicks++;
            if (colourRandomizerEnd[2] == 1)
            {
                bird3Pic.BackgroundImage = Properties.Resources.ButterflyBlue;
                colour = "blue";
            }

            else if (colourRandomizerEnd[2] == 2)
            {
                bird3Pic.BackgroundImage = Properties.Resources.ButterflyGreen;
                colour = "green";
            }

            else if (colourRandomizerEnd[2] == 3)
            {
                bird3Pic.BackgroundImage = Properties.Resources.ButterflyRed;
                colour = "red";
            }

            if (clicks == 1)
            {
                if (colour == "blue")
                {
                    prevColour = 1;
                }

                else if (colour == "green")
                {
                    prevColour = 2;
                }

                else if (colour == "red")
                {
                    prevColour = 3;
                }
            }

            else if (clicks == 2)
            {
                gameCheck();
                colourRevealTimer.Enabled = true;
                bird1Pic.Enabled = false;
                bird2Pic.Enabled = false;
                bird3Pic.Enabled = false;
                bird4Pic.Enabled = false;
                bird5Pic.Enabled = false;
                bird6Pic.Enabled = false;

                if (colour == "blue")
                {
                    currentColour = 1;
                }

                else if (colour == "green")
                {
                    currentColour = 2;
                }

                else if (colour == "red")
                {
                    currentColour = 3;
                }
                clicks = 0;
            }
        }

        private void bird4Pic_Click(object sender, EventArgs e)
        {
            string colour = "";
            clicks++;
            if (colourRandomizerEnd[3] == 1)
            {
                bird4Pic.BackgroundImage = Properties.Resources.ButterflyBlue;
                colour = "blue";
            }

            else if (colourRandomizerEnd[3] == 2)
            {
                bird4Pic.BackgroundImage = Properties.Resources.ButterflyGreen;
                colour = "green";
            }

            else if (colourRandomizerEnd[3] == 3)
            {
                bird4Pic.BackgroundImage = Properties.Resources.ButterflyRed;
                colour = "red";
            }

            if (clicks == 1)
            {
                if (colour == "blue")
                {
                    prevColour = 1;
                }

                else if (colour == "green")
                {
                    prevColour = 2;
                }

                else if (colour == "red")
                {
                    prevColour = 3;
                }
            }

            else if (clicks == 2)
            {
                gameCheck();
                colourRevealTimer.Enabled = true;
                bird1Pic.Enabled = false;
                bird2Pic.Enabled = false;
                bird3Pic.Enabled = false;
                bird4Pic.Enabled = false;
                bird5Pic.Enabled = false;
                bird6Pic.Enabled = false;

                if (colour == "blue")
                {
                    currentColour = 1;
                }

                else if (colour == "green")
                {
                    currentColour = 2;
                }

                else if (colour == "red")
                {
                    currentColour = 3;
                }
                clicks = 0;
            }

        }

        private void bird5Pic_Click(object sender, EventArgs e)
        {
            string colour = "";
            clicks++;
            if (colourRandomizerEnd[4] == 1)
            {
                bird5Pic.BackgroundImage = Properties.Resources.ButterflyBlue;
                colour = "blue";
            }

            else if (colourRandomizerEnd[4] == 2)
            {
                bird5Pic.BackgroundImage = Properties.Resources.ButterflyGreen;
                colour = "green"; 
            }

            else if (colourRandomizerEnd[4] == 3)
            {
                bird5Pic.BackgroundImage = Properties.Resources.ButterflyRed;
                colour = "red";
            }

            if (clicks == 1)
            {
                if (colour == "blue")
                {
                    prevColour = 1;
                }

                else if (colour == "green")
                {
                    prevColour = 2;
                }

                else if (colour == "red")
                {
                    prevColour = 3;
                }
            }

            else if (clicks == 2)
            {
                gameCheck();
                colourRevealTimer.Enabled = true;
                bird1Pic.Enabled = false;
                bird2Pic.Enabled = false;
                bird3Pic.Enabled = false;
                bird4Pic.Enabled = false;
                bird5Pic.Enabled = false;
                bird6Pic.Enabled = false;

                if (colour == "blue")
                {
                    currentColour = 1;
                }

                else if (colour == "green")
                {
                    currentColour = 2;
                }

                else if (colour == "red")
                {
                    currentColour = 3;
                }
                clicks = 0;
            }
        }

        private void bird6Pic_Click(object sender, EventArgs e)
        {
            string colour = "";
            clicks++;
            if (colourRandomizerEnd[5] == 1)
            {
                bird6Pic.BackgroundImage = Properties.Resources.ButterflyBlue;
                colour = "blue";
            }

            else if (colourRandomizerEnd[5] == 2)
            {
                bird6Pic.BackgroundImage = Properties.Resources.ButterflyGreen;
                colour = "green";
            }

            else if (colourRandomizerEnd[5] == 3)
            {
                bird6Pic.BackgroundImage = Properties.Resources.ButterflyRed;
                colour = "red";
            }

            if (clicks == 1)
            {
                if (colour == "blue")
                {
                    prevColour = 1;
                }

                else if (colour == "green")
                {
                    prevColour = 2;
                }

                else if (colour == "red")
                {
                    prevColour = 3;
                }
            }

            else if (clicks == 2)
            {
                gameCheck();
                colourRevealTimer.Enabled = true;
                bird1Pic.Enabled = false;
                bird2Pic.Enabled = false;
                bird3Pic.Enabled = false;
                bird4Pic.Enabled = false;
                bird5Pic.Enabled = false;
                bird6Pic.Enabled = false;

                if (colour == "blue")
                {
                    currentColour = 1;
                }

                else if (colour == "green")
                {
                    currentColour = 2;
                }

                else if (colour == "red")
                {
                    currentColour = 3;
                }
                clicks = 0;
            }
        }
        private void colourRevealTimer_Tick(object sender, EventArgs e)
        {
            colourRevealTimer.Enabled = false;
            bird1Pic.Enabled = true;
            bird2Pic.Enabled = true;
            bird3Pic.Enabled = true;
            bird4Pic.Enabled = true;
            bird5Pic.Enabled = true;
            bird6Pic.Enabled = true;
            if (prevColour == currentColour || prevColour != 0 || currentColour != 0)
            {

            }
        }

        private void butterflyGameForm_Load(object sender, EventArgs e)
        {
            butterflyMusic.PlayLooping();
            colourRandomizerStart.Add(1);
            colourRandomizerStart.Add(1);
            colourRandomizerStart.Add(2);
            colourRandomizerStart.Add(2);
            colourRandomizerStart.Add(3);
            colourRandomizerStart.Add(3);

            for (int i = 0; i < 6; i++)
            {
                colourRandomizerStart.Sort();
                random = generator.Next(colourRandomizerStart.First(), (colourRandomizerStart.Last() + 1));
                colourRandomizerEnd.Add(random);
                colourRandomizerStart.Remove(random);
            }
        }
        private void winTimer_Tick(object sender, EventArgs e)
        {
            winTimer.Enabled = false;
            introForm.butterfly = true;
            gameplayForm gF = new gameplayForm();
            this.Hide();
            gF.ShowDialog();
            this.Show();
            this.Dispose();
        }

        private void gameCheck()
        {
            incorrectCountText.Text = wrong + "";
            correctCountText.Text = correct + "";

            if (prevColour == currentColour)
            {
                correct++;
                correctCountText.Text = correct + "";
            }

            if (prevColour != currentColour)
            {
                wrong++;
                incorrectCountText.Text = wrong + "";
            }

            if (correct == 3)
            {
                butterflyMusic.Stop();
                confettiSound.Play();
                confettiPic.Visible = true;
                confettiPic.Enabled = true;
                winTimer.Enabled = true;
            }

            if (wrong == 3)
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