using System.Collections.Generic;

namespace MicroscopeLibrary.Models
{
    public class LogModel
    {
        public int Id { get; set; }
        public List<string> Changes { get; set; } = new List<string>();
    }
}