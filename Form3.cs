﻿using System;
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
    public partial class exitPrompt : Form
    {
        public exitPrompt()
        {
            InitializeComponent();
        }
        private void noBtn_Click(object sender, EventArgs e)
        {
            introForm.comeback = true;
            introForm intro = new introForm();
            this.Hide();
            intro.ShowDialog();
            this.Show();
            this.Dispose();
        }

        private void yesBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exitPrompt_Load(object sender, EventArgs e)
        {

        }
    }
}
