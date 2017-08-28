using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MicroscopeLibrary.Models;
using MicroscopeLibrary;

namespace MicroscopeUI
{
    public partial class MicroscopeMainForm : Form
    {

        public MicroscopeMainForm()
        {
            InitializeComponent();
        }

        public void PopulateTreeView(GameModel game)
        {
            GameTreeView.Nodes.Clear();
            var gameNode = new TreeNode(game.Description);
            gameNode.Tag = new TagModel
            {
                Type = ModelTypes.Game,
                Id = game.Id
            };
            foreach (var period in game.Periods)
            {
                var periodNode = new TreeNode(period.Description);
                periodNode.Tag = new TagModel
                {
                    Type = ModelTypes.Period,
                    Id = period.Id
                };
                foreach (EventModel evnt in period.Events)
                {
                    var eventNode = new TreeNode(evnt.Description);
                    eventNode.Tag = new TagModel
                    {
                        Type = ModelTypes.Event,
                        Id = evnt.Id
                    };
                    foreach (var scene in evnt.Scenes)
                    {
                        var sceneNode = new TreeNode(scene.Question);
                        sceneNode.Tag = new TagModel
                        {
                            Type = ModelTypes.Scene,
                            Id = scene.Id
                        };
                        foreach (var character in scene.Characters)
                        {
                            var characterNode = new TreeNode(character.FirstName);
                            characterNode.Tag = new TagModel
                            {
                                Type = ModelTypes.Character,
                                Id = character.Id
                            };
                        }
                    }
                    periodNode.Nodes.Add(eventNode);
                }
                gameNode.Nodes.Add(periodNode);
            }
            GameTreeView.Nodes.Add(gameNode);
            GameTreeView.Update();
        }



        private void GameMenuButton_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            if (button == GameMenuButton)
            {
                var gameMenu = new MicroscopeGameMenuForm();
                gameMenu.Show();
            }
        }

        private void AddPeriodContext_Click(object sender, EventArgs e)
        {

        }

        private void AddEventContext_Click(object sender, EventArgs e)
        {

        }

        private void AddSceneContext_Click(object sender, EventArgs e)
        {

        }

        private void addPeriodToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }

    
}
