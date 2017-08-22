using MicroscopeLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroscopeLibrary.DataAccess
{
    class SqlConnector : IDataConnection
    {

        public GameModel CreateGame(GameModel model)
        {
            model.Id = 1;
            return model;
        }

        // TODO - Impletment SQL code
        public PlayerModel CreatePlayer(PlayerModel model)
        {
            model.Id = 1;
            return model;
        }
    }
}
