using MicroscopeLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroscopeLibrary.DataAccess
{
    public class JsonConnector : IDataConnection
    {
        public EventModel CreateEvent(EventModel model)
        {
            throw new NotImplementedException();
        }

        public GameModel CreateGame(GameModel model)
        {
            throw new NotImplementedException();
        }

        public PeriodModel CreatePeriod(PeriodModel model)
        {
            throw new NotImplementedException();
        }

        // TODO - Implement JSON code
        public PlayerModel CreatePlayer(PlayerModel model)
        {
            model.Id = 1;
            return model;
        }

        public SceneModel CreateScene(SceneModel model)
        {
            throw new NotImplementedException();
        }

        public EventModel GetEvent(EventModel model)
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

        public PeriodModel GetPeriod(int id)
        {
            throw new NotImplementedException();
        }

        public SceneModel GetScene(SceneModel model)
        {
            throw new NotImplementedException();
        }
    }
}
