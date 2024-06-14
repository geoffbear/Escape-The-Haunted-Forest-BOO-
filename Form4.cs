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
    public partial class loreForm : Form
    {
        public loreForm()
        {
            InitializeComponent();
        }

        private void loreForm_Load(object sender, EventArgs e)
        {
            loreTimer.Enabled = true;
        }

        private void loreTimer_Tick(object sender, EventArgs e)
        {
            loreTimer.Stop();
            gameplayForm gameplayForm = new gameplayForm();
            this.Hide();
            gameplayForm.ShowDialog();
            this.Show();
            this.Dispose();
        }
    }
}
