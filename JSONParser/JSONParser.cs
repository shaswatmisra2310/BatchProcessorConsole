using Newtonsoft.Json.Linq;
using DBClassLibrary.Models;
namespace JSONParser
{
    public class JSONParser
    {
        public Quotes parse(string body)
        {
            JObject data = JObject.Parse(body);

            var language = data.SelectToken("quoteResponse.result[0].language")?.Value<string>();
            var quoteType = data.SelectToken("quoteResponse.result[0].quoteType")?.Value<string>();
            var TotalCash = data.SelectToken("quoteResponse.result[0].totalCash")?.Value<string>();
            var floatShares = data.SelectToken("quoteResponse.result[0].floatShares")?.Value<string>();
            var preMarketChangePercent = data.SelectToken("quoteResponse.result[0].preMarketChangePercent")?.Value<string>();
            var targetPriceHigh = data.SelectToken("quoteResponse.result[0].targetPriceHigh")?.Value<string>();
            var quoteSourceName = data.SelectToken("quoteResponse.result[0].quoteSourceName")?.Value<string>();
            var symbol = data.SelectToken("quoteResponse.result[0].symbol")?.Value<string>();
            var exchange = data.SelectToken("quoteResponse.result[0].exchange")?.Value<string>();
            var region = data.SelectToken("quoteResponse.result[0].region")?.Value<string>();
            var longName = data.SelectToken("quoteResponse.result[0].longName")?.Value<string>();
            var totalCash = data.SelectToken("quoteResponse.result[0].totalCash")?.Value<string>();
            var preMarketPrice = data.SelectToken("quoteResponse.result[0].preMarketPrice")?.Value<string>();
            var regularMarketPrice = data.SelectToken("quoteResponse.result[0].regularMarketPrice")?.Value<string>();
            try
            {
                var Industry = data.SelectToken("quoteResponse.result[0].Industry")?.Value<string>();
            }

            catch(InvalidCastException e)
            {
                var Industry = "null";
            }

            Quotes q = new Quotes() { SymbolName=symbol, QuoteType=quoteType,Name=quoteSourceName, Exchange =exchange, Industry="Industry name"};

            return q;
        }
    }
}
