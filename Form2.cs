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
using System.Windows.Input;

namespace Escape_The_Haunted_Forest__BOO__
{
    public partial class gameplayForm : Form
    {
        public gameplayForm()
        {
            InitializeComponent();
        }

        private void gameplayForm_Load(object sender, EventArgs e)
        {
            if (introForm.globe == true)
            {
                globeTrophyPic.Visible = true;
                introForm.introMusic.Play();
                introForm.introMusic.PlayLooping();
                globeGamePic.Enabled = false;
            }


           else if (introForm.butterfly == true)
            {
                butteflyTrophyPic.Visible = true;
                introForm.introMusic.Play();
                introForm.introMusic.PlayLooping();
                butteflyTrophyPic.Enabled = false;
            }


            else if (introForm.photo == true)
            {
                photoTrophyPic.Visible = true;
                introForm.introMusic.Play();
                introForm.introMusic.PlayLooping();
                photoTrophyPic.Enabled = false;
            }

        }

        private void globeGamePic_Click(object sender, EventArgs e)
        {
            globeGameForm globeGame = new globeGameForm();
            this.Hide();
            globeGame.ShowDialog();
            this.Show();
            this.Dispose();
        }

        private void photoPic_Click(object sender, EventArgs e)
        {

        }

        private void butterflyGamePic_Click(object sender, EventArgs e)
        {

        }
    }
}
