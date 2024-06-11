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
    public partial class globeGameForm : Form
    {
        public globeGameForm()
        {
            InitializeComponent();
        }

        private void globeGameForm_Load(object sender, EventArgs e)
        {
            SoundPlayer globeGameMusic = new SoundPlayer();
        }
    }
}
