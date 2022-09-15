using System.ComponentModel.DataAnnotations;

namespace DBClassLibrary.Models
{
    public class SymbolConfig
    {
        public string SymbolName { get; set; }

        public string Country { get; set; }

        [Key]
        public string Key { get; set; }




    }
}
