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
        int wrong = 0, correct = 0;
        List<int> list = new List<int>();
        Random generator = new Random();
        //1 = Red, 2 = Blue, 3 = Green

        private void bird1Pic_Click(object sender, EventArgs e)
        {

        }

        private void bird2Pic_Click(object sender, EventArgs e)
        {

        }

        private void bird3Pic_Click(object sender, EventArgs e)
        {

        }

        private void bird4Pic_Click(object sender, EventArgs e)
        {

        }

        private void bird5Pic_Click(object sender, EventArgs e)
        {

        }

        private void bird6Pic_Click(object sender, EventArgs e)
        {

        }

        private void butterflyGameForm_Load(object sender, EventArgs e)
        {
            butterfylMusic.PlayLooping();
        }
    }
}
