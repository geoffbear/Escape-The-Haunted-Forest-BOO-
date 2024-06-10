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
    public partial class Intro : Form
    {
        public Intro()
        {
            InitializeComponent();
        }

        private void Intro_Load(object sender, EventArgs e)
        {
            IntroTimer.Start();
        }

        private void IntroTimer_Tick(object sender, EventArgs e)
        {

            IntroTimer.Stop();
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {

        }
    }
}
