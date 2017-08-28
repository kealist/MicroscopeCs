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
        public EventModel CreateEvent(EventModel model)
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

        public PeriodModel CreatePeriod(PeriodModel model)
        {
            throw new NotImplementedException();
        }


        // TODO - Impletment SQL code
        public PlayerModel CreatePlayer(PlayerModel model)
        {
            using (MicroscopeDbContext connection = new MicroscopeDbContext())
            {
                
            }
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
            using (MicroscopeDbContext connection = new MicroscopeDbContext())
            {
                return connection.Games.Where(g => g.Id == id + 1).First();
            }
        }

        public List<GameModel> GetGameList()
        {
            using (MicroscopeDbContext connection = new MicroscopeDbContext())
            {
                connection.Games.Load();
                return connection.Games.ToList();
            }
        }

        public PeriodModel GetPeriod(int id)
        {
            throw new NotImplementedException();
        }

        public SceneModel GetScene(SceneModel model)
        {
            throw new NotImplementedException();
        }

        public PeriodModel UpdatePeriod(PeriodModel model)
        {
            /*
             * db.Users.Attach(updatedUser);
               var entry = db.Entry(updatedUser);
               entry.Property(e => e.Email).IsModified = true;
               // other changed properties
               db.SaveChanges();
             */
            throw new NotImplementedException();
        }
    }
}
