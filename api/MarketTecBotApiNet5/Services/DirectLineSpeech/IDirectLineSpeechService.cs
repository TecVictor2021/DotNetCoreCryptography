using MarketTecBotApiNet5.Dto;
using System;
using System.Threading.Tasks;

namespace MarketTecBotApiNet5.Services.DirectLine
{
    public interface IDirectLineSpeechService
    {
        Task<DirectLineSpeechTokenResponse> Post(Object request);
    }
}
