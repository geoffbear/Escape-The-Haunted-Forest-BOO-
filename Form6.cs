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
    public partial class loseForm : Form
    {
        public loseForm()
        {
            InitializeComponent();
        }

        private void loseForm_Load(object sender, EventArgs e)
        {
            loseTmr.Start();
        }

        private void loseTmr_Tick(object sender, EventArgs e)
        {
            loseTmr.Stop();
            loseSubMessage.Visible = false;
        }

        private void loseForm_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
