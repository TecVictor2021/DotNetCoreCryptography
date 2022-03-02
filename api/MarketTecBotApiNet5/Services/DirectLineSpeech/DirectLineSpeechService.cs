using MarketTecBotApiNet5.Dto;
using MarketTecBotApiNet5.Services.DirectLine;
using Microsoft.Extensions.Configuration;
using System;
using System.Diagnostics.CodeAnalysis;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace MarketTecBotApiNet5.Services
{
    [ExcludeFromCodeCoverage]
    public class DirectLineSpeechService : IDirectLineSpeechService
    {
        private readonly IConfiguration _config;

        public DirectLineSpeechService(IConfiguration config)
        {
            _config = config;
        }
        public async Task<DirectLineSpeechTokenResponse> Post(Object request)
        {
            DirectLineSpeechTokenResponse dto = new();
            HttpClient client = new();
            client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", _config["DirectLineSpeechKey"]);
            //client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", _config.GetValue<string>("DirectLineSpeech:Key").ToString());
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = await client.PostAsJsonAsync(
                _config.GetValue<string>("DirectLineSpeech:Url").ToString(), request);
            response.EnsureSuccessStatusCode();
            dto.AuthorizationToken = response.Content.ReadAsStringAsync().Result;
            dto.Region = _config.GetValue<string>("DirectLineSpeech:Region").ToString();
            return dto;
        }

    }
}
