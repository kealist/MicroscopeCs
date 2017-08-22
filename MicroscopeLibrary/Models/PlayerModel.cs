using System.Collections.Generic;

namespace MicroscopeLibrary.Models
{
    public class PlayerModel
    {

        /// <summary>
        /// Unique identifier for the player
        /// </summary>
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public List<GameModel> Games { get; set; } = new List<GameModel>();
    }
}