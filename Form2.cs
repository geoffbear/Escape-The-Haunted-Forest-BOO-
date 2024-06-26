using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
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
        int win = 0;
        SoundPlayer drumRoll = new SoundPlayer(Properties.Resources.DrumRoll);
        SoundPlayer yay = new SoundPlayer(Properties.Resources.Yay);
        private void gameplayForm_Load(object sender, EventArgs e)
        {
            if (introForm.globe)
            {
                globeGamePic.Enabled = false;
                globeTrophyPic.Visible = true;
                introForm.introMusic.Play();
                introForm.introMusic.PlayLooping();
                globeGamePic.Enabled = false;
                win++;
            }


           if (introForm.butterfly)
           {
                butterflyGamePic.Enabled = false;
                butteflyTrophyPic.Visible = true;
                introForm.introMusic.Play();
                introForm.introMusic.PlayLooping();
                butteflyTrophyPic.Enabled = false;
                win++;
           }


           if (introForm.photo)
           {
                photoPic.Enabled = false;
                photoTrophyPic.Visible = true;
                introForm.introMusic.Play();
                introForm.introMusic.PlayLooping();
                photoTrophyPic.Enabled = false;
                win++;
           }

           if (win == 2)
           {
                //play drum roll and tadah sound, disable clickable buttons, as tadah plays point to the new, clickable door.
                drumRollTimer.Enabled = true;
                drumRoll.Play();
                winPic.Enabled = true;
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
            pictureForm pictureFrm = new pictureForm();
            this.Hide();
            pictureFrm.ShowDialog();
            this.Show();
            this.Dispose();
        }

        private void butterflyGamePic_Click(object sender, EventArgs e)
        {
            butterflyGameForm bGame = new butterflyGameForm();
            this.Hide();
            bGame.ShowDialog();
            this.Show();
            this.Dispose();
        }

        private void drumRollTimer_Tick(object sender, EventArgs e)
        {
            drumRollTimer.Enabled = false;
            drumRoll.Stop();
            yay.Play();
            arrowPic.Visible = true;
        }
    }
}
