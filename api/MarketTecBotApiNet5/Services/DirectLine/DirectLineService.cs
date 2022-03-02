using MarketTecBotApiNet5.Dto;
using MarketTecBotApiNet5.Services.DirectLine;
using Microsoft.Extensions.Configuration;
using System.Diagnostics.CodeAnalysis;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace MarketTecBotApiNet5.Services
{
    [ExcludeFromCodeCoverage]
    public class DirectLineService : IDirectLineService
    {
        private readonly IConfiguration _config;

        public DirectLineService(IConfiguration config)
        {
            _config = config;
        }
        public async Task<string> Post(DirectLineTokenRequest request)
        {
            HttpClient client = new();
            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", _config["DirectLineKey"]);
            //client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", _config.GetValue<string>("DirectLine:Key").ToString());
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = await client.PostAsJsonAsync(
                _config.GetValue<string>("DirectLine:Url").ToString(), request);
            response.EnsureSuccessStatusCode();
            return response.Content.ReadAsStringAsync().Result;
        }
    }
}
