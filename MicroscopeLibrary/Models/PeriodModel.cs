using System.Collections.Generic;

namespace MicroscopeLibrary.Models
{
    public class PeriodModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<EventModel> Events { get; set; } = new List<EventModel>();
        public GameModel Parent { get; set; }
    }
}
