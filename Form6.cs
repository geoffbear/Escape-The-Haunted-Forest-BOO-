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
    public partial class loseForm : Form
    {
        public loseForm()
        {
            InitializeComponent();
        }
        SoundPlayer clownLaugh = new SoundPlayer(Properties.Resources.ClownLaugh);

        private void loseForm_Load(object sender, EventArgs e)
        {
            clownLaugh.Play();
        }

        private void loseForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Y) 
            {
                introForm.comeback = true;
                introForm intro = new introForm();
                this.Hide();
                intro.ShowDialog();
                this.Show();
                this.Dispose();
            }
            else if (e.KeyCode == Keys.N) 
            { 
                this.Close();
            }
        }
    }
}
