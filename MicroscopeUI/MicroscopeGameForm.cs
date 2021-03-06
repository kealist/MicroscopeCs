﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MicroscopeUI
{
    public partial class MicroscopeGameForm : Form
    {
        MicroscopeGameMenuForm menuWindow = new MicroscopeGameMenuForm();
        MicroscopePlayersForm playersWindow = new MicroscopePlayersForm();
        MicroscopeOverviewForm gameWindow = new MicroscopeOverviewForm();
        MicroscopePlayForm playWindow = new MicroscopePlayForm();

        public MicroscopeGameForm()
        {
            InitializeComponent();
        }

        private void GameMenuLabel_Click(object sender, EventArgs e)
        {
            
            menuWindow.Show();
        }

        private void PlayerLabel_Click(object sender, EventArgs e)
        {
           
            playersWindow.Show();
        }

        private void Overview_Click(object sender, EventArgs e)
        {
           
            gameWindow.Show();
        }

        private void PlayLabel_Click(object sender, EventArgs e)
        {
            playWindow.Show();
        }
    }
}
