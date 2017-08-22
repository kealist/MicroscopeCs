using MicroscopeLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Entity;

namespace MicroscopeLibrary.DataAccess
{
    public class MicroscopeDbContext : DbContext
    {
        public DbSet<GameModel> Games { get; set; }
        public DbSet<PlayerModel> Players { get; set; }
        public DbSet<PaletteModel> Palettes { get; set; }

        public DbSet<PeriodModel> Periods { get; set; }
        public DbSet<EventModel> Events { get; set; }
        public DbSet<SceneModel> Scenes { get; set; }
        public DbSet<CharacterModel> Characters { get; set; }

        public DbSet<LogModel> Logs { get; set; }
    }
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
