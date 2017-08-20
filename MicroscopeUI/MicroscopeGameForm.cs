using System;
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
        public MicroscopeGameForm()
        {
            InitializeComponent();
        }

        private void GameMenuLabel_Click(object sender, EventArgs e)
        {
            var menuWindow = new MicroscopeGameMenuForm();
            menuWindow.Show();
        }

        private void PlayerLabel_Click(object sender, EventArgs e)
        {
            var playersWindow = new MicroscopePlayersForm();
            playersWindow.Show();
        }

        private void Overview_Click(object sender, EventArgs e)
        {
            var gameWindow = new MicroscopeOverviewForm();
            gameWindow.Show();
        }
    }
}
