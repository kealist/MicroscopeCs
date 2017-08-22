using MicroscopeLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Entity;
using System.Linq;

namespace MicroscopeLibrary.DataAccess
{
    public class MicroscopeDbContext : DbContext
    {
        public MicroscopeDbContext() :base(GlobalConfig.CnnString("SQLExpress")){}
        public DbSet<GameModel> Games { get; set; }
        public DbSet<PlayerModel> Players { get; set; }
        public DbSet<PaletteModel> Palettes { get; set; }

        public DbSet<PeriodModel> Periods { get; set; }
        public DbSet<EventModel> Events { get; set; }
        public DbSet<SceneModel> Scenes { get; set; }
        public DbSet<CharacterModel> Characters { get; set; }

        public DbSet<LogModel> Logs { get; set; }
    }
    class EntityConnector : IDataConnection
    {

        public GameModel CreateGame(GameModel model)
        {
            using (MicroscopeDbContext connection = new MicroscopeDbContext())
            {
                connection.Games.Add(model);
                connection.SaveChanges();
            }
            return model;
        }


        // TODO - Impletment SQL code
        public PlayerModel CreatePlayer(PlayerModel model)
        {
            using (MicroscopeDbContext connection = new MicroscopeDbContext())
            {

            }
            return model;
        }

        public List<GameModel> GetGameList()
        {
            using (MicroscopeDbContext connection = new MicroscopeDbContext())
            {
                connection.Games.Load();
                return connection.Games.ToList();
            }
        }
    }
}
