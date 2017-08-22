using MicroscopeLibrary;
using MicroscopeLibrary.DataAccess;
using MicroscopeLibrary.Models;
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
    public partial class MicroscopeGameMenuForm : Form
    {
        public MicroscopeGameMenuForm()
        {
            InitializeComponent();
        }

        private void CreateGameButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                GameModel model = new GameModel(BigPictureTextbox.Text);
                
                foreach (IDataConnection db in GlobalConfig.Connections)
                {
                    db.CreateGame(model);
                }
                BigPictureTextbox.Clear();
            }
            else
            {
                MessageBox.Show("Non-Whitespace characters required to create game");
            }
        }

        private bool ValidateForm()
        {
            bool output = true;

            if (string.IsNullOrWhiteSpace(BigPictureTextbox.Text)) output = false;
            
            return output;
        }
    }
}
