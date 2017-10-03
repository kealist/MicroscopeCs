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
        GameModel CreateGame(GameModel model);
        GameModel GetGame(int id);
        GameElementModel GetPeriod(int id);
        GameElementModel CreatePeriod(GameElementModel model);
        GameElementModel UpdatePeriod(GameElementModel model);
        GameElementModel GetEvent(GameElementModel model);
        GameElementModel CreateEvent(GameElementModel model);
        GameElementModel GetScene(GameElementModel model);
        GameElementModel CreateScene(GameElementModel model);

        List<GameModel> GetGameList();
    }
}
