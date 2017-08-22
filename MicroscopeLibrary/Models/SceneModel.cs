using System.Collections.Generic;

namespace MicroscopeLibrary.Models
{
    public class SceneModel
    {
        public int Id { get; set; }
        public string Question { get; set; }
        public List<CharacterModel> Characters { get; set; } = new List<CharacterModel>();
        public string Dialog { get; set; }
        public EventModel Parent { get; set; }
    }
}
