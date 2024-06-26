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
        int wrong = 0, correct = 0, clicks = 0, random;
        List<int> colourRandomizerStart = new List<int>();
        List<int> colourRandomizerEnd = new List<int>();
        Random generator = new Random();
        string colour1 = "1", colour2 = "2", colour3 = "3", colour4 = "4", colour5 = "5", colour6 = "6";

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

            }

            else if (clicks == 2)
            {
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

            }

            else if (clicks == 2)
            {
                colourRevealTimer.Enabled = true;
                bird1Pic.Enabled = false;
                bird2Pic.Enabled = false;
                bird3Pic.Enabled = false;
                bird4Pic.Enabled = false;
                bird5Pic.Enabled = false;
                bird6Pic.Enabled = false;
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

            }

            else if (clicks == 2)
            {
                colourRevealTimer.Enabled = true;
                bird1Pic.Enabled = false;
                bird2Pic.Enabled = false;
                bird3Pic.Enabled = false;
                bird4Pic.Enabled = false;
                bird5Pic.Enabled = false;
                bird6Pic.Enabled = false;
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

            }

            else if (clicks == 2)
            {
                colourRevealTimer.Enabled = true;
                bird1Pic.Enabled = false;
                bird2Pic.Enabled = false;
                bird3Pic.Enabled = false;
                bird4Pic.Enabled = false;
                bird5Pic.Enabled = false;
                bird6Pic.Enabled = false;
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

            }

            else if (clicks == 2)
            {
                colourRevealTimer.Enabled = true;
                bird1Pic.Enabled = false;
                bird2Pic.Enabled = false;
                bird3Pic.Enabled = false;
                bird4Pic.Enabled = false;
                bird5Pic.Enabled = false;
                bird6Pic.Enabled = false;
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

            }

            else if (clicks == 2)
            {
                colourRevealTimer.Enabled = true;
                bird1Pic.Enabled = false;
                bird2Pic.Enabled = false;
                bird3Pic.Enabled = false;
                bird4Pic.Enabled = false;
                bird5Pic.Enabled = false;
                bird6Pic.Enabled = false;
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
            bird1Pic.BackgroundImage = Properties.Resources.ButterflyBlank;
            bird2Pic.BackgroundImage = Properties.Resources.ButterflyBlank;
            bird3Pic.BackgroundImage = Properties.Resources.ButterflyBlank;
            bird4Pic.BackgroundImage = Properties.Resources.ButterflyBlank;
            bird5Pic.BackgroundImage = Properties.Resources.ButterflyBlank;
            bird6Pic.BackgroundImage = Properties.Resources.ButterflyBlank;

            if (colour1 == colour2 && bird1Pic.Visible && bird2Pic.Visible)
                {
                colour1 = "1";
                colour2 = "2";
                colour3 = "3";
                colour4 = "4";
                colour5 = "5";
                colour6 = "6";
                bird1Pic.Visible = false;
                    bird2Pic.Visible = false;
                    correct++;
                    gameCheck();
                }

                else if (colour1 == colour3 && bird1Pic.Visible && bird3Pic.Visible)
                {
                colour1 = "1";
                colour2 = "2";
                colour3 = "3";
                colour4 = "4";
                colour5 = "5";
                colour6 = "6";
                bird1Pic.Visible = false;
                    bird3Pic.Visible = false;
                    correct++;
                    gameCheck();
                }

                else if (colour1 == colour4 && bird1Pic.Visible && bird4Pic.Visible)
                {
                colour1 = "1";
                colour2 = "2";
                colour3 = "3";
                colour4 = "4";
                colour5 = "5";
                colour6 = "6";
                bird1Pic.Visible = false;
                    bird4Pic.Visible = false;
                    correct++;
                    gameCheck();
                }

                else if (colour1 == colour5 && bird1Pic.Visible && bird5Pic.Visible)
                {
                colour1 = "1";
                colour2 = "2";
                colour3 = "3";
                colour4 = "4";
                colour5 = "5";
                colour6 = "6";
                bird1Pic.Visible = false;
                    bird5Pic.Visible = false;
                    correct++;
                    gameCheck();
                }
                
                else if (colour1 == colour6 && bird1Pic.Visible && bird6Pic.Visible)
                {
                colour1 = "1";
                colour2 = "2";
                colour3 = "3";
                colour4 = "4";
                colour5 = "5";
                colour6 = "6";
                bird1Pic.Visible = false;
                    bird6Pic.Visible = false;
                    correct++;
                    gameCheck();
                }

                else if (colour2 == colour3 && bird2Pic.Visible && bird3Pic.Visible)
                {
                colour1 = "1";
                colour2 = "2";
                colour3 = "3";
                colour4 = "4";
                colour5 = "5";
                colour6 = "6";
                bird2Pic.Visible = false;
                    bird3Pic.Visible = false;
                    correct++;
                    gameCheck();
                }

                else if (colour2 == colour4 && bird2Pic.Visible && bird4Pic.Visible)
                {
                colour1 = "1";
                colour2 = "2";
                colour3 = "3";
                colour4 = "4";
                colour5 = "5";
                colour6 = "6";
                bird2Pic.Visible = false;
                    bird4Pic.Visible = false;
                    correct++;
                    gameCheck();
                }

                else if (colour2 == colour5 && bird2Pic.Visible && bird5Pic.Visible)
                {
                colour1 = "1";
                colour2 = "2";
                colour3 = "3";
                colour4 = "4";
                colour5 = "5";
                colour6 = "6";
                bird2Pic.Visible = false;
                    bird5Pic.Visible = false;
                    correct++;
                    gameCheck();
                }

                else if (colour2 == colour6 && bird2Pic.Visible && bird6Pic.Visible)
                {
                colour1 = "1";
                colour2 = "2";
                colour3 = "3";
                colour4 = "4";
                colour5 = "5";
                colour6 = "6";
                bird2Pic.Visible = false;
                    bird6Pic.Visible = false;
                    correct++;
                    gameCheck();
                }

                else if (colour3 == colour4 && bird3Pic.Visible && bird4Pic.Visible)
                {
                colour1 = "1";
                colour2 = "2";
                colour3 = "3";
                colour4 = "4";
                colour5 = "5";
                colour6 = "6";
                bird3Pic.Visible = false;
                    bird4Pic.Visible = false;
                    correct++;
                    gameCheck();
                }

                else if (colour3 == colour5 && bird3Pic.Visible && bird6Pic.Visible)
                {
                colour1 = "1";
                colour2 = "2";
                colour3 = "3";
                colour4 = "4";
                colour5 = "5";
                colour6 = "6";
                bird3Pic.Visible = false;
                    bird5Pic.Visible = false;
                    correct++;
                    gameCheck();
                }

                else if (colour3 == colour6 && bird3Pic.Visible && bird6Pic.Visible)
                {
                colour1 = "1";
                colour2 = "2";
                colour3 = "3";
                colour4 = "4";
                colour5 = "5";
                colour6 = "6";
                bird3Pic.Visible = false;
                    bird6Pic.Visible = false;
                    correct++;
                    gameCheck();
                }

                else if (colour4 == colour5 && bird4Pic.Visible && bird5Pic.Visible)
                {
                colour1 = "1";
                colour2 = "2";
                colour3 = "3";
                colour4 = "4";
                colour5 = "5";
                colour6 = "6";
                bird4Pic.Visible = false;
                    bird5Pic.Visible = false;
                    correct++;
                    gameCheck();
                }

                else if (colour5 == colour6 && bird5Pic.Visible && bird6Pic.Visible)
                {
                colour1 = "1";
                colour2 = "2";
                colour3 = "3";
                colour4 = "4";
                colour5 = "5";
                colour6 = "6";
                bird5Pic.Visible = false;
                    bird6Pic.Visible = false;
                    correct++;
                    gameCheck();
                }

            else if (colour1 != colour2)
            {
                bird1Pic.BackgroundImage = Properties.Resources.ButterflyBlank;
                bird2Pic.BackgroundImage = Properties.Resources.ButterflyBlank;
                colour1 = "1";
                colour2 = "2";
                colour3 = "3";
                colour4 = "4";
                colour5 = "5";
                colour6 = "6";
                wrong++;
                gameCheck();
            }

            else if (colour1 != colour3)
            {
                bird1Pic.BackgroundImage = Properties.Resources.ButterflyBlank;
                bird3Pic.BackgroundImage = Properties.Resources.ButterflyBlank;
                colour1 = "1";
                colour2 = "2";
                colour3 = "3";
                colour4 = "4";
                colour5 = "5";
                colour6 = "6";
                wrong++;
                gameCheck();
            }

            else if (colour1 != colour4)
            {
                bird1Pic.BackgroundImage = Properties.Resources.ButterflyBlank;
                bird4Pic.BackgroundImage = Properties.Resources.ButterflyBlank;
                colour1 = "1";
                colour2 = "2";
                colour3 = "3";
                colour4 = "4";
                colour5 = "5";
                colour6 = "6";
                wrong++;
                gameCheck();
            }

            else if (colour1 != colour5)
            {
                bird1Pic.BackgroundImage = Properties.Resources.ButterflyBlank;
                bird5Pic.BackgroundImage = Properties.Resources.ButterflyBlank;
                colour1 = "1";
                colour2 = "2";
                colour3 = "3";
                colour4 = "4";
                colour5 = "5";
                colour6 = "6";
                wrong++;
                gameCheck();
            }

            else if (colour1 != colour6)
            {
                bird1Pic.BackgroundImage = Properties.Resources.ButterflyBlank;
                bird6Pic.BackgroundImage = Properties.Resources.ButterflyBlank;
                colour1 = "1";
                colour2 = "2";
                colour3 = "3";
                colour4 = "4";
                colour5 = "5";
                colour6 = "6";
                wrong++;
                gameCheck();
            }

            else if (colour2 != colour3)
            {
                bird2Pic.BackgroundImage = Properties.Resources.ButterflyBlank;
                bird3Pic.BackgroundImage = Properties.Resources.ButterflyBlank;
                colour1 = "1";
                colour2 = "2";
                colour3 = "3";
                colour4 = "4";
                colour5 = "5";
                colour6 = "6";
                wrong++;
                gameCheck();
            }

            else if (colour2 != colour4)
            {
                bird2Pic.BackgroundImage = Properties.Resources.ButterflyBlank;
                bird4Pic.BackgroundImage = Properties.Resources.ButterflyBlank;
                colour1 = "1";
                colour2 = "2";
                colour3 = "3";
                colour4 = "4";
                colour5 = "5";
                colour6 = "6";
                wrong++;
                gameCheck();
            }

            else if (colour2 != colour5)
            {
                bird2Pic.BackgroundImage = Properties.Resources.ButterflyBlank;
                bird5Pic.BackgroundImage = Properties.Resources.ButterflyBlank;
                colour1 = "1";
                colour2 = "2";
                colour3 = "3";
                colour4 = "4";
                colour5 = "5";
                colour6 = "6";
                wrong++;
                gameCheck();
            }

            else if (colour2 != colour6)
            {
                bird2Pic.BackgroundImage = Properties.Resources.ButterflyBlank;
                bird6Pic.BackgroundImage = Properties.Resources.ButterflyBlank;
                colour1 = "1";
                colour2 = "2";
                colour3 = "3";
                colour4 = "4";
                colour5 = "5";
                colour6 = "6";
                wrong++;
                gameCheck();
            }

            else if (colour3 != colour4)
            {
                bird3Pic.BackgroundImage = Properties.Resources.ButterflyBlank;
                bird4Pic.BackgroundImage = Properties.Resources.ButterflyBlank;
                colour1 = "1";
                colour2 = "2";
                colour3 = "3";
                colour4 = "4";
                colour5 = "5";
                colour6 = "6";
                wrong++;
                gameCheck();
            }

            else if (colour3 != colour5)
            {
                bird3Pic.BackgroundImage = Properties.Resources.ButterflyBlank;
                bird5Pic.BackgroundImage = Properties.Resources.ButterflyBlank;
                colour1 = "1";
                colour2 = "2";
                colour3 = "3";
                colour4 = "4";
                colour5 = "5";
                colour6 = "6";
                wrong++;
                gameCheck();
            }

            else if (colour3 != colour6)
            {
                bird3Pic.BackgroundImage = Properties.Resources.ButterflyBlank;
                bird6Pic.BackgroundImage = Properties.Resources.ButterflyBlank;
                colour1 = "1";
                colour2 = "2";
                colour3 = "3";
                colour4 = "4";
                colour5 = "5";
                colour6 = "6";
                wrong++;
                gameCheck();
            }

            else if (colour4 != colour5)
            {
                bird4Pic.BackgroundImage = Properties.Resources.ButterflyBlank;
                bird5Pic.BackgroundImage = Properties.Resources.ButterflyBlank;
                colour1 = "1";
                colour2 = "2";
                colour3 = "3";
                colour4 = "4";
                colour5 = "5";
                colour6 = "6";
                wrong++;
                gameCheck();
            }

            else if (colour5 != colour6)
            {
                bird5Pic.BackgroundImage = Properties.Resources.ButterflyBlank;
                bird6Pic.BackgroundImage = Properties.Resources.ButterflyBlank;
                colour1 = "1";
                colour2 = "2";
                colour3 = "3";
                colour4 = "4";
                colour5 = "5";
                colour6 = "6";
                wrong++;
                gameCheck();
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

                if (!colourRandomizerStart.Contains(2) && colourRandomizerStart.Contains(1) && colourRandomizerStart.Contains(3))
                {
                    while (random == 2)
                        random = generator.Next(colourRandomizerStart.First(), (colourRandomizerStart.Last() + 1));
                }
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
