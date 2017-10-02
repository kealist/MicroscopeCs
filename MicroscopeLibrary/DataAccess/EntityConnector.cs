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
        public DbSet<ElementModel> Elements { get; set; }
        public DbSet<GameModel> Games { get; set; }
        public DbSet<PlayerModel> Players { get; set; }
        public DbSet<PaletteModel> Palettes { get; set; }
        public DbSet<LogModel> Logs { get; set; }
    }

    class EntityConnector : IDataConnection
    {
        public ElementModel CreateEvent(ElementModel model)
        {
            throw new NotImplementedException();
        }

        public ElementModel CreateGame(ElementModel model)
        {
            using (MicroscopeDbContext connection = new MicroscopeDbContext())
            {
                connection.Elements.Add(model);
                connection.SaveChanges();
            }
            return model;
        }

        public ElementModel CreatePeriod(ElementModel period)
        {
            throw new NotImplementedException();
        }

        public PlayerModel CreatePlayer(PlayerModel model)
        {
            throw new NotImplementedException();
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
            using (MicroscopeDbContext connection = new MicroscopeDbContext())
            {
                return connection.Games.Where(g => g.Id == id + 1).First();
            }
        }

        public List<ElementModel> GetGameList()
        {
            using (MicroscopeDbContext connection = new MicroscopeDbContext())
            {
                connection.Games.Load();
                return connection.Elements.Where(e => e.Type == ModelTypes.Game).ToList();
            }
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

        List<GameModel> IDataConnection.GetGameList()
        {

            throw new NotImplementedException();
        }

        ElementModel IDataConnection.GetPeriod(int id)
        {
            throw new NotImplementedException();
        }
    }
}
