using System;
using System.Collections.Generic;

namespace MicroscopeLibrary.Models
{
    public class GameModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<PlayerModel> Players { get; set; } = new List<PlayerModel>();
        public List<ElementModel> Elements { get; set; } = new List<ElementModel>();
        public List<LogModel> Logs { get; set; } = new List<LogModel>();
        public List<PaletteModel> Palettes { get; set; } = new List<PaletteModel>();
        public DateTime? DModified { get; set; }
        
        public GameModel(){}

        public GameModel(string description)
        {
            Description = description;
        }
    }
    
}
