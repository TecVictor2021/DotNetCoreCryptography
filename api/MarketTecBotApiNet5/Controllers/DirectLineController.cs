using MarketTecBotApiNet5.Dto;
using MarketTecBotApiNet5.Services.DirectLine;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace MarketTecBotApiNet5.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DirectLineController : ControllerBase
    {
        private readonly IDirectLineService _iDirectLineService;

        public DirectLineController(IDirectLineService iDirectLineService)
        {
            _iDirectLineService = iDirectLineService;
        }

        [HttpPost(Name = "PostDirectLine")]
        public async Task<string> Post(DirectLineTokenRequest request)
        {
           return await _iDirectLineService.Post(request);
        }
    }
}
