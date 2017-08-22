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
        List<GameModel> GetGameList();
    }
}
