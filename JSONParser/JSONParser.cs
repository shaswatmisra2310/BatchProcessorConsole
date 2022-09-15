
using Newtonsoft.Json.Linq;

namespace JSONParser
{
    public class JSONParser
    {
        public void parse(string body)
        {
            JObject data = JObject.Parse(body);

            var language = data.SelectToken("quoteResponse.result[0].language")?.Value<string>();
            var quoteType = data.SelectToken("quoteResponse.result[0].quoteType")?.Value<string>();
            var TotalCash = data.SelectToken("quoteResponse.result[0].totalCash")?.Value<string>();
            var floatShares = data.SelectToken("quoteResponse.result[0].floatShares")?.Value<string>();
            var preMarketChangePercent = data.SelectToken("quoteResponse.result[0].preMarketChangePercent")?.Value<string>();
            var targetPriceHigh = data.SelectToken("quoteResponse.result[0].targetPriceHigh")?.Value<string>();
        }
    }
}