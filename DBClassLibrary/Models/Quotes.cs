using System.ComponentModel.DataAnnotations;

namespace DBClassLibrary.Models
{
    public class Quotes
    {

        public string Name { get; set; }
        [Key]
        public string SymbolName { get; set; }

        public string QuoteType { get; set; }

        public string Industry { get; set; }

        public string Exchange { get; set; }


    }
}
