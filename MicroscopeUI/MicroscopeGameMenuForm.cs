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
        public GameModel CurrentGame { get; set; }
        public MicroscopeGameMenuForm()
        {
            InitializeComponent();
            
            GameListBox.DataSource = GlobalConfig.Connection.GetGameList().Select(g => g.Description).ToList();
            GameListBox.Update();
            
        }

        private void CreateGameButton_Click(object sender, EventArgs e)
        {
            Button current = (Button) sender;
            //
            if (ValidateForm())
            {
                GameModel model = new GameModel(BigPictureTextbox.Text);
                GlobalConfig.Connection.CreateGame(model);
                GameListBox.DataSource = GlobalConfig.Connection.GetGameList().Select(g => g.Description).ToList();
                GameListBox.Update();
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

        private void GameListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CurrentGame = GlobalConfig.Connection.GetGame(GameListBox.SelectedIndex);
            CurrrentDescriptionLabelData.Text = CurrentGame.Description;
            CurrrentDescriptionLabelData.Update();
            CurrentNumPeriodsLabelData.Text = CurrentGame.Periods.Count.ToString();
            CurrentNumPeriodsLabelData.Update();
            CurrentDateModifiedLabelData.Text = CurrentGame.DModified.ToString();
        }
    }
}
