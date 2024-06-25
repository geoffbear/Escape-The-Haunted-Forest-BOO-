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
        string colour1 = "", colour2 = "", colour3 = "", colour4 = "", colour5 = "", colour6 = "";
        //BACKGROUNDIMAGED CHANGED IS A BOLEAN COULD BE USEFUL!
        private void bird1Pic_Click(object sender, EventArgs e)
        {
            clicks++;
            if (colourRandomizerEnd[0] == 1)
            {
                bird1Pic.BackgroundImage = Properties.Resources.ButterflyBlue;
                colour1 = "blue";
            }

            else if (colourRandomizerEnd[0] == 2)
            {
                bird1Pic.BackgroundImage = Properties.Resources.ButterflyGreen;
                colour1 = "green";
            }

            else if (colourRandomizerEnd[0] == 3)
            {
                bird1Pic.BackgroundImage = Properties.Resources.ButterflyRed;
                colour1 = "red";
            }

            if (clicks == 1)
            {
                if (colour1 == "blue")
                {
                    prevColour = 1;
                }

                else if (colour1 == "green")
                {
                    prevColour = 2;
                }

                else if (colour1 == "red")
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

                if (colour1 == "blue")
                {
                    currentColour = 1;
                }

                else if (colour1 == "green")
                {
                    currentColour = 2;
                }

                else if (colour1 == "red")
                {
                    currentColour = 3;
                }
                clicks = 0;
            }
        }


        private void bird2Pic_Click(object sender, EventArgs e)
        {

            clicks++;
            if (colourRandomizerEnd[1] == 1)
            {
                bird2Pic.BackgroundImage = Properties.Resources.ButterflyBlue;
                colour2 = "blue";
            }

            else if (colourRandomizerEnd[1] == 2)
            {
                bird2Pic.BackgroundImage = Properties.Resources.ButterflyGreen;
                colour2 = "green";
            }

            else if (colourRandomizerEnd[1] == 3)
            {
                bird2Pic.BackgroundImage= Properties.Resources.ButterflyRed;
                colour2 = "red";
            }

            if (clicks == 1)
            {
                if (colour2 == "blue")
                {
                    prevColour = 1;
                }

                else if (colour2 == "green")
                {
                    prevColour = 2;
                }

                else if (colour2 == "red")
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

                if (colour2 == "blue")
                {
                    currentColour = 1;
                }

                else if (colour2 == "green")
                {
                    currentColour = 2;
                }

                else if (colour2 == "red")
                {
                    currentColour = 3;
                }
                clicks = 0;
            }
        }

        private void bird3Pic_Click(object sender, EventArgs e)
        {
            clicks++;
            if (colourRandomizerEnd[2] == 1)
            {
                bird3Pic.BackgroundImage = Properties.Resources.ButterflyBlue;
                colour3 = "blue";
            }

            else if (colourRandomizerEnd[2] == 2)
            {
                bird3Pic.BackgroundImage = Properties.Resources.ButterflyGreen;
                colour3 = "green";
            }

            else if (colourRandomizerEnd[2] == 3)
            {
                bird3Pic.BackgroundImage = Properties.Resources.ButterflyRed;
                colour3 = "red";
            }

            if (clicks == 1)
            {
                if (colour3 == "blue")
                {
                    prevColour = 1;
                }

                else if (colour3 == "green")
                {
                    prevColour = 2;
                }

                else if (colour3 == "red")
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

                if (colour3 == "blue")
                {
                    currentColour = 1;
                }

                else if (colour3 == "green")
                {
                    currentColour = 2;
                }

                else if (colour3 == "red")
                {
                    currentColour = 3;
                }
                clicks = 0;
            }
        }

        private void bird4Pic_Click(object sender, EventArgs e)
        {
            clicks++;
            if (colourRandomizerEnd[3] == 1)
            {
                bird4Pic.BackgroundImage = Properties.Resources.ButterflyBlue;
                colour4 = "blue";
            }

            else if (colourRandomizerEnd[3] == 2)
            {
                bird4Pic.BackgroundImage = Properties.Resources.ButterflyGreen;
                colour4 = "green";
            }

            else if (colourRandomizerEnd[3] == 3)
            {
                bird4Pic.BackgroundImage = Properties.Resources.ButterflyRed;
                colour4 = "red";
            }

            if (clicks == 1)
            {
                if (colour4 == "blue")
                {
                    prevColour = 1;
                }

                else if (colour4 == "green")
                {
                    prevColour = 2;
                }

                else if (colour4 == "red")
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

                if (colour4 == "blue")
                {
                    currentColour = 1;
                }

                else if (colour4 == "green")
                {
                    currentColour = 2;
                }

                else if (colour4 == "red")
                {
                    currentColour = 3;
                }
                clicks = 0;
            }

        }

        private void bird5Pic_Click(object sender, EventArgs e)
        {
            clicks++;
            if (colourRandomizerEnd[4] == 1)
            {
                bird5Pic.BackgroundImage = Properties.Resources.ButterflyBlue;
                colour5 = "blue";
            }

            else if (colourRandomizerEnd[4] == 2)
            {
                bird5Pic.BackgroundImage = Properties.Resources.ButterflyGreen;
                colour5 = "green"; 
            }

            else if (colourRandomizerEnd[4] == 3)
            {
                bird5Pic.BackgroundImage = Properties.Resources.ButterflyRed;
                colour5 = "red";
            }

            if (clicks == 1)
            {
                if (colour5 == "blue")
                {
                    prevColour = 1;
                }

                else if (colour5 == "green")
                {
                    prevColour = 2;
                }

                else if (colour5 == "red")
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

                if (colour5 == "blue")
                {
                    currentColour = 1;
                }

                else if (colour5 == "green")
                {
                    currentColour = 2;
                }

                else if (colour5 == "red")
                {
                    currentColour = 3;
                }
                clicks = 0;
            }
        }

        private void bird6Pic_Click(object sender, EventArgs e)
        {
            clicks++;
            if (colourRandomizerEnd[5] == 1)
            {
                bird6Pic.BackgroundImage = Properties.Resources.ButterflyBlue;
                colour6 = "blue";
            }

            else if (colourRandomizerEnd[5] == 2)
            {
                bird6Pic.BackgroundImage = Properties.Resources.ButterflyGreen;
                colour6 = "green";
            }

            else if (colourRandomizerEnd[5] == 3)
            {
                bird6Pic.BackgroundImage = Properties.Resources.ButterflyRed;
                colour6 = "red";
            }

            if (clicks == 1)
            {
                if (colour6 == "blue")
                {
                    prevColour = 1;
                }

                else if (colour6 == "green")
                {
                    prevColour = 2;
                }

                else if (colour6 == "red")
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

                if (colour6 == "blue")
                {
                    currentColour = 1;
                }

                else if (colour6 == "green")
                {
                    currentColour = 2;
                }

                else if (colour6 == "red")
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