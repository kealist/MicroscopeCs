using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroscopeLibrary.Models
{
    public class ElementModel
    {
 
        public int Id { get; set; }
        public List<ElementModel> Children { get; set; } = new List<ElementModel>();
        public ElementModel Parent { get; set; }
        public string Name { get; set; }
        public ModelTypes Type { get; set; }
        public string Description { get; set; }
        public string Description2 { get; set; }
        //public DateTime? DModified { get; set; }

        public void AddChild(ElementModel childElement)
        {
            Children.Add(childElement);
        }

        public ElementModel() { }

        public ElementModel(ModelTypes type, ElementModel parent, string description)
        {
            Type = type;
            Parent = parent; 
            Description = description;
        }
    }
}
