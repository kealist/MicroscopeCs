using System.Collections.Generic;

namespace MicroscopeLibrary.Models
{
    public class CharacterModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<SceneModel> Scenes { get; set; } = new List<SceneModel>();
    }
}