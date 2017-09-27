using MicroscopeLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MicroscopeLibrary.DataAccess
{
    public interface IDataConnection
    {
        PlayerModel CreatePlayer(PlayerModel model);
        ElementModel CreateGame(ElementModel model);
        ElementModel GetGame(int id);
        ElementModel GetPeriod(int id);
        ElementModel CreatePeriod(ElementModel model);
        ElementModel UpdatePeriod(ElementModel model);
        ElementModel GetEvent(ElementModel model);
        ElementModel CreateEvent(ElementModel model);
        ElementModel GetScene(ElementModel model);
        ElementModel CreateScene(ElementModel model);

        List<GameModel> GetGameList();
    }
}
