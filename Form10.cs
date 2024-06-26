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
    public partial class winForm : Form
    {
        public winForm()
        {
            InitializeComponent();
        }
        SoundPlayer win = new SoundPlayer(Properties.Resources.Applause);
        private void winForm_Load(object sender, EventArgs e)
        {
            winTimer.Enabled = true;
            win.Play();
        }

        private void winTimer_Tick(object sender, EventArgs e)
        {
            winTimer.Enabled = false;
            this.Close();
        }
    }
}
