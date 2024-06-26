﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;

namespace Escape_The_Haunted_Forest__BOO__
{ 
    public partial class introForm : Form
    {
        public static bool comeback = false;
        public static bool globe = false;
        public static bool butterfly = false;
        public static bool photo = false;
        public static SoundPlayer introMusic = new SoundPlayer(Properties.Resources.IntroMusic);
        public introForm()
        {
            InitializeComponent();
        }

        SoundPlayer knockKnock = new SoundPlayer(Properties.Resources.KnockKnock);
        
        private void Intro_Load(object sender, EventArgs e)
        {
            if (!comeback)
            {
                introMusic.Play();
                IntroTimer.Start();
            }
           
            
            if (comeback)
            {
                enterBtn.Visible = true;
                exitbtn.Visible = true;
            }
        }

        private void IntroTimer_Tick(object sender, EventArgs e)
        {
            enterBtn.Visible = true;
            exitbtn.Visible = true;
            IntroTimer.Stop();
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            knockKnock.Play();
            knockTimer.Start();
        }

        private void knockTimer_Tick(object sender, EventArgs e)
        {
            knockTimer.Stop();
            rulesForm rulesForm = new rulesForm();
            this.Hide();
            rulesForm.ShowDialog();
            this.Show();
            this.Dispose();
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            introMusic.Stop();
            exitPrompt exitPrompt = new exitPrompt();
            this.Hide();
            exitPrompt.ShowDialog();
            this.Show();
            this.Dispose();
        }
    }
}
