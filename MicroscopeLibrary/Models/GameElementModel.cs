using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroscopeLibrary.Models
{
    public class GameElementModel
    {

        public int Id { get; set; }
        public List<GameElementModel> Children { get; set; } = new List<GameElementModel>();
        public GameElementModel Parent { get; set; }
        public GameModel Game {get; set;}
        public string Name { get; set; }
        public ModelTypes Type { get; set; }
        public string Description { get; set; }
        public string Description2 { get; set; }
        public DateTime? DModified { get; set; }

        public void AddChild(GameElementModel childElement)
        {
            Children.Add(childElement);
        }

        public GameElementModel() { }

        public GameElementModel(ModelTypes type, GameElementModel parent, string description)
        {
            Type = type;
            Parent = parent; 
            Description = description;
        }
    }
}
