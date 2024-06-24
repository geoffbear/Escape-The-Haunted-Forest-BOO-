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
    public partial class pictureForm : Form
    {
        public pictureForm()
        {
            InitializeComponent();
        }
        int skips = 5, correct = 0, wrong = 0;

        private void pictureForm_Load(object sender, EventArgs e)
        {
            guessPic.Size = new Size();
            guessPic.Location = new Point();
            //Low = Highest number - 32
            //Med = Highest number - 64
            //High = Dowloaded Size
        }
    }
}
