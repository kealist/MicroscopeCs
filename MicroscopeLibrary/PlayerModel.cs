using System.Collections.Generic;

namespace MicroscopeLibrary
{
    public class PlayerModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public List<GameModel> Games { get; set; } = new List<GameModel>();
    }
}