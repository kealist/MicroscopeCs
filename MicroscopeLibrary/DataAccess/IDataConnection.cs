using MicroscopeLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroscopeLibrary.DataAccess
{
    public interface IDataConnection
    {
        PlayerModel CreatePlayer(PlayerModel model);
        GameModel CreateGame(GameModel model);
        GameModel GetGame(int id);
        PeriodModel GetPeriod(int id);
        PeriodModel CreatePeriod(PeriodModel model);
        EventModel GetEvent(EventModel model);
        EventModel CreateEvent(EventModel model);
        SceneModel GetScene(SceneModel model);
        SceneModel CreateScene(SceneModel model);

        List<GameModel> GetGameList();
    }
}
