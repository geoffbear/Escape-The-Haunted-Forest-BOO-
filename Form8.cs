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
        SoundPlayer butterfylMusic = new SoundPlayer(Properties.Resources.ButterflyMusic);
        int wrong = 0, correct = 0, clicks = 0, random, prevColour, currentColour;
        List<int> colourRandomizerStart = new List<int>();
        List<int> colourRandomizerEnd = new List<int>();
        Random generator = new Random();

        private void bird1Pic_Click(object sender, EventArgs e)
        {
            clicks++;
            if (colourRandomizerEnd[0] == 1)
            {
                bird1Pic.BackgroundImage = Properties.Resources.ButterflyBlue;
            }

            else if (colourRandomizerEnd[0] == 2)
            {
                bird1Pic.BackgroundImage = Properties.Resources.ButterflyGreen;
            }

            else if (colourRandomizerEnd[0] == 3)
            {
                bird1Pic.BackgroundImage = Properties.Resources.ButterflyRed;
            }

            if (clicks == 1)
            {
                if (bird1Pic.BackgroundImage == Properties.Resources.ButterflyBlue)
                {
                    prevColour = 1;
                }

                else if (bird1Pic.BackgroundImage == Properties.Resources.ButterflyGreen)
                {
                    prevColour = 2;
                }

                else if (bird1Pic.BackgroundImage == Properties.Resources.ButterflyRed)
                {
                    prevColour = 3;
                }
            }

            else if (clicks == 2)
            {
                gameCheck();
                colourRevealTimer.Enabled = true;
                
                if (bird1Pic.BackgroundImage == Properties.Resources.ButterflyBlue)
                {
                    currentColour = 1;
                }

                else if (bird1Pic.BackgroundImage == Properties.Resources.ButterflyGreen)
                {
                    currentColour = 2;
                }

                else if (bird1Pic.BackgroundImage == Properties.Resources.ButterflyRed)
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
            }

            else if (colourRandomizerEnd[1] == 2)
            {
                bird2Pic.BackgroundImage = Properties.Resources.ButterflyGreen;
            }

            else if (colourRandomizerEnd[1] == 3)
            {
                bird2Pic.BackgroundImage= Properties.Resources.ButterflyRed;
            }

            if (clicks == 1)
            {
                if (bird2Pic.BackgroundImage == Properties.Resources.ButterflyBlue)
                {
                    prevColour = 1;
                }

                else if (bird2Pic.BackgroundImage == Properties.Resources.ButterflyGreen)
                {
                    prevColour = 2;
                }

                else if (bird2Pic.BackgroundImage == Properties.Resources.ButterflyRed)
                {
                    prevColour = 3;
                }
            }

            else if (clicks == 2)
            {
                gameCheck();
                colourRevealTimer.Enabled = true;

                if (bird2Pic.BackgroundImage == Properties.Resources.ButterflyBlue)
                {
                    currentColour = 1;
                }

                else if (bird2Pic.BackgroundImage == Properties.Resources.ButterflyGreen)
                {
                    currentColour = 2;
                }

                else if (bird2Pic.BackgroundImage == Properties.Resources.ButterflyRed)
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
            }

            else if (colourRandomizerEnd[2] == 2)
            {
                bird3Pic.BackgroundImage = Properties.Resources.ButterflyGreen;
            }

            else if (colourRandomizerEnd[2] == 3)
            {
                bird3Pic.BackgroundImage = Properties.Resources.ButterflyRed;
            }

            if (clicks == 1)
            {
                if (bird3Pic.BackgroundImage == Properties.Resources.ButterflyBlue)
                {
                    prevColour = 1;
                }

                else if (bird3Pic.BackgroundImage == Properties.Resources.ButterflyGreen)
                {
                    prevColour = 2;
                }

                else if (bird3Pic.BackgroundImage == Properties.Resources.ButterflyRed)
                {
                    prevColour = 3;
                }
            }

            else if (clicks == 2)
            {
                gameCheck();
                colourRevealTimer.Enabled = true;

                if (bird3Pic.BackgroundImage == Properties.Resources.ButterflyBlue)
                {
                    currentColour = 1;
                }

                else if (bird3Pic.BackgroundImage == Properties.Resources.ButterflyGreen)
                {
                    currentColour = 2;
                }

                else if (bird3Pic.BackgroundImage == Properties.Resources.ButterflyRed)
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
            }

            else if (colourRandomizerEnd[3] == 2)
            {
                bird4Pic.BackgroundImage = Properties.Resources.ButterflyGreen;
            }

            else if (colourRandomizerEnd[3] == 3)
            {
                bird4Pic.BackgroundImage = Properties.Resources.ButterflyRed;
            }

            if (clicks == 1)
            {
                if (bird4Pic.BackgroundImage == Properties.Resources.ButterflyBlue)
                {
                    prevColour = 1;
                }

                else if (bird4Pic.BackgroundImage == Properties.Resources.ButterflyGreen)
                {
                    prevColour = 2;
                }

                else if (bird4Pic.BackgroundImage == Properties.Resources.ButterflyRed)
                {
                    prevColour = 3;
                }
            }

            else if (clicks == 2)
            {
                gameCheck();
                colourRevealTimer.Enabled = true;

                if (bird4Pic.BackgroundImage == Properties.Resources.ButterflyBlue)
                {
                    currentColour = 1;
                }

                else if (bird4Pic.BackgroundImage == Properties.Resources.ButterflyGreen)
                {
                    currentColour = 2;
                }

                else if (bird4Pic.BackgroundImage == Properties.Resources.ButterflyRed)
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
            }

            else if (colourRandomizerEnd[4] == 2)
            {
                bird5Pic.BackgroundImage = Properties.Resources.ButterflyGreen;
            }

            else if (colourRandomizerEnd[4] == 3)
            {
                bird5Pic.BackgroundImage = Properties.Resources.ButterflyRed;
            }

            if (clicks == 1)
            {
                if (bird5Pic.BackgroundImage == Properties.Resources.ButterflyBlue)
                {
                    prevColour = 1;
                }

                else if (bird5Pic.BackgroundImage == Properties.Resources.ButterflyGreen)
                {
                    prevColour = 2;
                }

                else if (bird5Pic.BackgroundImage == Properties.Resources.ButterflyRed)
                {
                    prevColour = 3;
                }
            }

            else if (clicks == 2)
            {
                gameCheck();
                colourRevealTimer.Enabled = true;

                if (bird5Pic.BackgroundImage == Properties.Resources.ButterflyBlue)
                {
                    currentColour = 1;
                }

                else if (bird5Pic.BackgroundImage == Properties.Resources.ButterflyGreen)
                {
                    currentColour = 2;
                }

                else if (bird5Pic.BackgroundImage == Properties.Resources.ButterflyRed)
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
            }

            else if (colourRandomizerEnd[5] == 2)
            {
                bird6Pic.BackgroundImage = Properties.Resources.ButterflyGreen;
            }

            else if (colourRandomizerEnd[5] == 3)
            {
                bird6Pic.BackgroundImage = Properties.Resources.ButterflyRed;
            }

            if (clicks == 1)
            {
                if (bird6Pic.BackgroundImage == Properties.Resources.ButterflyBlue)
                {
                    prevColour = 1;
                }

                else if (bird6Pic.BackgroundImage == Properties.Resources.ButterflyGreen)
                {
                    prevColour = 2;
                }

                else if (bird6Pic.BackgroundImage == Properties.Resources.ButterflyRed)
                {
                    prevColour = 3;
                }
            }

            else if (clicks == 2)
            {
                gameCheck();
                colourRevealTimer.Enabled = true;

                if (bird6Pic.BackgroundImage == Properties.Resources.ButterflyBlue)
                {
                    currentColour = 1;
                }

                else if (bird6Pic.BackgroundImage == Properties.Resources.ButterflyGreen)
                {
                    currentColour = 2;
                }

                else if (bird6Pic.BackgroundImage == Properties.Resources.ButterflyRed)
                {
                    currentColour = 3;
                }
                clicks = 0;
            }
        }
        private void colourRevealTimer_Tick(object sender, EventArgs e)
        {
            colourRevealTimer.Enabled = false;
        }

        private void butterflyGameForm_Load(object sender, EventArgs e)
        {
            butterfylMusic.PlayLooping();
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

        private void gameCheck()
        {
            incorrectCountText.Text = wrong + "";

            if (correct == 3)
            {

            }

            if (wrong == 3)
            {
                loseForm lF = new loseForm();
                this.Hide();
                lF.ShowDialog();
                this.Show();
                this.Dispose();
            }

            if (prevColour == currentColour)
            {
                correct++;
            }

            if (prevColour != currentColour)
            {
                wrong++;
            }
        }

    }
}