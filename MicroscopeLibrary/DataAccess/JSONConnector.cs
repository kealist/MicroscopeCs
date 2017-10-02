using MicroscopeLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroscopeLibrary.DataAccess
{
    public class JsonConnector : IDataConnection
    {

        public ElementModel CreateEvent(ElementModel model)
        {
            throw new NotImplementedException();
        }

        public GameModel CreateGame(GameModel model)
        {
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

        // TODO - Implement JSON code
        public PlayerModel CreatePlayer(PlayerModel model)
        {
            model.Id = 1;
            return model;
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
