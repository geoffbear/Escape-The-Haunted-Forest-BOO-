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
    public partial class rulesForm : Form
    {
        public rulesForm()
        {
            InitializeComponent();
        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            loreForm loreForm = new loreForm();
            this.Hide();
            loreForm.ShowDialog();
            this.Show();
            this.Dispose();
        }

        private void rulesForm_Load(object sender, EventArgs e)
        {
            introForm.introMusic.PlayLooping();
        }

        private void hintOne_Click(object sender, EventArgs e)
        {
            globeExamplePic.Visible = true;
            hintOne.Visible = false;
        }

        private void hintTwo_Click(object sender, EventArgs e)
        {
            butterflyExamplePic.Visible = true;
            hintTwo.Visible = false;
        }

        private void hintThree_Click(object sender, EventArgs e)
        {
            picExamplePic.Visible = true;
            hintThree.Visible = false;
        }
    }
}
