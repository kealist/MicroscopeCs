using MicroscopeLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroscopeLibrary.DataAccess
{
    public class JsonConnector : IDataConnection
    {
        public GameModel CreateGame(GameModel model)
        {
            throw new NotImplementedException();
        }

        // TODO - Implement JSON code
        public PlayerModel CreatePlayer(PlayerModel model)
        {
            model.Id = 1;
            return model;
        }

        public GameModel GetGame(int id)
        {
            throw new NotImplementedException();
        }

        public List<GameModel> GetGameList()
        {
            throw new NotImplementedException();
        }
    }
}
