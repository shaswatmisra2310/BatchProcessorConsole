using System.ComponentModel.DataAnnotations;

namespace DBClassLibrary.Models
{
    public class Header
    {
        [Key]
        public string Key { get; set; }

        public string Host { get; set; }

        public string URL { get; set; }

        public SymbolConfig symbolConfig { get; set; }
    }
}
