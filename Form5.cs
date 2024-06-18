using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escape_The_Haunted_Forest__BOO__
{
    public partial class globeGameForm : Form
    {
        public globeGameForm()
        {
            InitializeComponent();
        }
        SoundPlayer globeGameMusic = new SoundPlayer(Properties.Resources.globeGameMusic1);
        SoundPlayer confettiSound = new SoundPlayer(Properties.Resources.Confetti1);
        Random generator = new Random();
        int country, correct = 0, wrong = 0;

        private void globeGameForm_Load(object sender, EventArgs e)
        { 
            globeGameMusic.Play();
            newCountry();
            //Canada = 0, Brazil = 1, Russia = 2, Mongolia = 3, India = 4, Egypt = 5, Madagascar = 6, Japan = 7, Australia = 8.
        }
        //Add correcr/incorrect counter and tutorial for each game and fail screen

        private void canadaPic_Click(object sender, EventArgs e)
        {
            if (country == 0)
            {
                correct++;
                newCountry();
            }

            else
            {
                wrong++;
                newCountry();
            }
        }

        private void brazilPic_Click(object sender, EventArgs e)
        {
            if (country == 1)
            {
                correct++;
                newCountry();
            }

            else
            {
                wrong++;
                newCountry();
            }
        }

        private void russiaPic_Click(object sender, EventArgs e)
        {
            if (country == 2)
            {
                correct++;
                newCountry();
            }

            else
            {
                wrong++;
                newCountry();
            }
        }

        private void mongoliaPic_Click(object sender, EventArgs e)
        {
            if (country == 3)
            {
                correct++;
                newCountry();
            }

            else
            {
                wrong++;
                newCountry();
            }
        }

        private void indiaPic_Click(object sender, EventArgs e)
        {
            if (country == 4)
            {
                correct++;
                newCountry();
            }

            else
            {
                wrong++;
                newCountry();
            }
        }

        private void egyptPic_Click(object sender, EventArgs e)
        {
            if (country == 5)
            {
                correct++;
                newCountry();
            }

            else
            {
                wrong++;
                newCountry();
            }
        }

        private void madagascarPic_Click(object sender, EventArgs e)
        {
            if (country == 6)
            {
                correct++;
                newCountry();
            }

            else
            {
                wrong++;
                newCountry();
            }
        }

        private void japanPic_Click(object sender, EventArgs e)
        {
            if (country == 7)
            {
                correct++;
                newCountry();
            }

            else
            {
                wrong++;
                newCountry();
            }
        }

        private void globeGameForm_MouseClick(object sender, MouseEventArgs e)
        {
            wrong++;
            newCountry();
        }

        private void australiaPic_Click(object sender, EventArgs e)
        {
            if (country == 8)
            {
                correct++;
                newCountry();
            }

            else
            {
                wrong++;
                newCountry();
            }
        }

        private void newCountry() //Refreshes country
        {
            wrongNumText.Text = wrong + "";
            country = generator.Next(0, 9);

            if (country == 0)
                countryTxt.Text = "Canada";

            else if (country == 1)
                countryTxt.Text = "Brazil";

            else if (country == 2)
                countryTxt.Text = "Russia";

            else if (country == 3)
                countryTxt.Text = "Mongolia";

            else if (country == 4)
                countryTxt.Text = "India";

            else if (country == 5)
                countryTxt.Text = "Egypt";

            else if (country == 6)
                countryTxt.Text = "Madagascar";

            else if (country == 7)
                countryTxt.Text = "Japan";

            else if (country == 8)
                countryTxt.Text = "Australia";

            if (correct == 5)
            {
                globeGameMusic.Stop();
                confettiSound.Play();
                confettiPic.Visible = true;
                confettiPic.Enabled = true;
            }

            if (wrong == 5)
            {

            }

        }
    }
}