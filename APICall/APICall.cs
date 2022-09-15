using DBClassLibrary.Models;

namespace APICall
{
    public class APICall
    {
        public async Task<string> GetData(Header h)
        {


            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri(h.URL),
            Headers =
    {
        { "X-RapidAPI-Key", h.Key },
        { "X-RapidAPI-Host", h.Host },
    },
            };

            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var body1 = response.Content.Headers;
                return body;
            }


            


        }

    }
}