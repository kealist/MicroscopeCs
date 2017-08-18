using System.Collections.Generic;

namespace MicroscopeLibrary
{
    public class GameModel
    {
        public int Id { get; set; }
        public List<PeriodModel> Periods { get; set; } = new List<PeriodModel>();
        public string Name { get; set; }
        public string Description { get; set; }
        public List<PlayerModel> Players { get; set; } = new List<PlayerModel>();
        public List<LogModel> Logs { get; set; } = new List<LogModel>();
        public List<PaletteModel> Palettes { get; set; } = new List<PaletteModel>();
    }
}
