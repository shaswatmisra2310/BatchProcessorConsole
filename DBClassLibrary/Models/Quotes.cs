using System.ComponentModel.DataAnnotations;

namespace DBClassLibrary.Models
{
    public class Quotes
    {
        [Key]

        public int primarykey { get; set; }

        public string Name { get; set; }
        
        public string SymbolName { get; set; }

        public string QuoteType { get; set; }

        public string Industry { get; set; }

        public string Exchange { get; set; }


    }
}
