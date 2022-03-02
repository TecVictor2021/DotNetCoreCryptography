using MarketTecBotApiNet5.Dto;
using MarketTecBotApiNet5.Services.DirectLine;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace MarketTecBotApiNet5.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DirectLineSpeechController : ControllerBase
    {
        private readonly IDirectLineSpeechService _iDirectLineSpeechService;

        public DirectLineSpeechController(IDirectLineSpeechService iDirectLineSpeechService)
        {
            _iDirectLineSpeechService = iDirectLineSpeechService;
        }

        [HttpPost(Name = "PostDirectLineSpeech")]
        public async Task<DirectLineSpeechTokenResponse> Post(Object request)
        {
            return await _iDirectLineSpeechService.Post(request);
        }
    }
}
