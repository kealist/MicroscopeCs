﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MicroscopeLibrary.Models;

namespace MicroscopeLibrary.DataAccess
{
    public class FileConnector : IDataConnection
    {
        private const string GamesFile = "GameModels.csv";
        private const string PeriodsFile = "PeriodModels.csv";
        private const string EventsFile = "EventModels.csv";
        private const string ScenesFile = "SceneModels.csv";
        private const string CharactersFile = "CharacterModels.csv";
        
        public ElementModel CreateEvent(ElementModel model)
        {
            throw new NotImplementedException();
        }

        public GameModel CreateGame(GameModel model)
        {
            // Load the text file
            // Convert the text to List<GameModel>
            // Find the Id
            // Add the new record with the new ID
            // Convert the records to List<string>
            // Save the List<string> to text file
            throw new NotImplementedException();
        }

        public ElementModel CreateGame(ElementModel model)
        {
            throw new NotImplementedException();
        }
        
        public ElementModel CreatePeriod(ElementModel model)
        {
            throw new NotImplementedException();
        }

        public PlayerModel CreatePlayer(PlayerModel model)
        {
            throw new NotImplementedException();
        }
        

        public ElementModel CreateScene(ElementModel model)
        {
            throw new NotImplementedException();
        }

        public ElementModel GetEvent(ElementModel model)
        {
            throw new NotImplementedException();
        }

        public GameModel GetGame(int id)
        {
            throw new NotImplementedException();
        }

        public List<GameModel> GetGameList()
        {
            throw new NotImplementedException();
        }
        

        public ElementModel GetScene(ElementModel model)
        {
            throw new NotImplementedException();
        }
        
        public ElementModel UpdatePeriod(ElementModel model)
        {
            throw new NotImplementedException();
        }

        ElementModel IDataConnection.GetGame(int id)
        {
            throw new NotImplementedException();
        }

        ElementModel IDataConnection.GetPeriod(int id)
        {
            throw new NotImplementedException();
        }
    }
}
