using System.Collections.Generic;

namespace MicroscopeLibrary.Models
{
    public class PeriodModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<SceneModel> Scenes { get; set; } = new List<SceneModel>();
        public GameModel Parent { get; set; }
    }
}
