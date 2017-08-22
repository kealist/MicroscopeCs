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
        public GameModel SelectedGame { get; set; }
        public MicroscopeGameMenuForm()
        {
            InitializeComponent();

            GameListBox.DataSource = GlobalConfig.Connection.GetGameList().Select(g => g.Description).ToList();
            GameListBox.Update();

        }

        private void CreateGameButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (button == CreateGameButton)
            {
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

            if (button == LoadSelectedButton)
            {
                if (GlobalConfig.UnsavedChanges)
                {
                    DialogResult UserChoice = MessageBox.Show(
                        "There are unsaved changes to current game that will be lost.  Are you sure you want to continue",
                        "Microscope Load Game",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);
                    switch (UserChoice)
                    {
                        case DialogResult.Yes:
                            GlobalConfig.CurrentGame = GlobalConfig.Connection.GetGame(GameListBox.SelectedIndex);
                            break;
                        case DialogResult.No:
                            break;
                    }
                }
                else
                {

                }
                GlobalConfig.CurrentGame = GlobalConfig.Connection.GetGame(GameListBox.SelectedIndex);
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
            SelectedGame = GlobalConfig.Connection.GetGame(GameListBox.SelectedIndex);
            CurrrentDescriptionLabelData.Text = SelectedGame.Description;
            CurrrentDescriptionLabelData.Update();
            CurrentNumPeriodsLabelData.Text = SelectedGame.Periods.Count.ToString();
            CurrentNumPeriodsLabelData.Update();
            CurrentDateModifiedLabelData.Text = SelectedGame.DModified.ToString();
        }
    }
}