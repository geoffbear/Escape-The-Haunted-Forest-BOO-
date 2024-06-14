using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        }

        private void photoPic_Click_1(object sender, EventArgs e)
        {

        }

        private void globeGamePic_Click(object sender, EventArgs e)
        {
            globeGameForm globeGame = new globeGameForm();
            this.Hide();
            globeGame.ShowDialog();
            this.Show();
            this.Dispose();
        }
    }
}
