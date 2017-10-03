using MicroscopeLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroscopeLibrary.DataAccess
{
    public class JsonConnector : IDataConnection
    {

        public GameElementModel CreateEvent(GameElementModel model)
        {
            throw new NotImplementedException();
        }

        public GameModel CreateGame(GameModel model)
        {
            throw new NotImplementedException();
        }

        public GameElementModel CreateGame(GameElementModel model)
        {
            throw new NotImplementedException();
        }

        public GameElementModel CreatePeriod(GameElementModel model)
        {
            throw new NotImplementedException();
        }

        // TODO - Implement JSON code
        public PlayerModel CreatePlayer(PlayerModel model)
        {
            model.Id = 1;
            return model;
        }
        

        public GameElementModel CreateScene(GameElementModel model)
        {
            throw new NotImplementedException();
        }

        public GameElementModel GetEvent(GameElementModel model)
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

        public GameElementModel GetScene(GameElementModel model)
        {
            throw new NotImplementedException();
        }
        
        public GameElementModel UpdatePeriod(GameElementModel model)
        {
            throw new NotImplementedException();
        }

        GameModel IDataConnection.GetGame(int id)
        {
            throw new NotImplementedException();
        }

        GameElementModel IDataConnection.GetPeriod(int id)
        {
            throw new NotImplementedException();
        }
    }
}
