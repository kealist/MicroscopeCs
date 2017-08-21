using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MicroscopeLibrary;

namespace MicroscopeUI
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
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MicroscopeMainForm());
        }
    }
}
