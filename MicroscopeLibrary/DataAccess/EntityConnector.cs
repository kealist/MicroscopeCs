using MicroscopeLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace MicroscopeLibrary.DataAccess
{
    public class MicroscopeDbContext : DbContext
    {
        public MicroscopeDbContext() :base(GlobalConfig.CnnString("SQLExpress")){}
        public DbSet<GameElementModel> Elements { get; set; }
        public DbSet<GameModel> Games { get; set; }
        public DbSet<PlayerModel> Players { get; set; }
        public DbSet<PaletteModel> Palettes { get; set; }
        public DbSet<LogModel> Logs { get; set; }
    }

    class EntityConnector : IDataConnection
    {
        public GameElementModel CreateEvent(GameElementModel model)
        {
            throw new NotImplementedException();
        }

        public GameModel CreateGame(GameModel model)
        {
            using (MicroscopeDbContext connection = new MicroscopeDbContext())
            {
                connection.Games.Add(model);
                connection.SaveChanges();
            }
            return model;
        }

        public GameElementModel CreatePeriod(GameElementModel period)
        {
            throw new NotImplementedException();
        }

        public PlayerModel CreatePlayer(PlayerModel model)
        {
            throw new NotImplementedException();
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
            using (MicroscopeDbContext connection = new MicroscopeDbContext())
            {
                return connection.Games.Where(g => g.Id == id + 1).First();
            }
        }

        public List<GameElementModel> GetGameList()
        {
            using (MicroscopeDbContext connection = new MicroscopeDbContext())
            {
                connection.Games.Load();
                return connection.Elements.Where(e => e.Type == ModelTypes.Game).ToList();
            }
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
            using (MicroscopeDbContext connection = new MicroscopeDbContext())
            {
                return connection.Games.Where(g => g.Id == id).FirstOrDefault<GameModel>();
            }
        }

        List<GameModel> IDataConnection.GetGameList()
        {
            using (MicroscopeDbContext connection = new MicroscopeDbContext())
            {
                return connection.Games.ToList();
            }
        }

        GameElementModel IDataConnection.GetPeriod(int id)
        {
            throw new NotImplementedException();
        }
    }
}
