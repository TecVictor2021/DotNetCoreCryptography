using MarketTecBotApiNet5.Dto;
using System.Threading.Tasks;

namespace MarketTecBotApiNet5.Services.DirectLine
{
    public interface IDirectLineService
    {
        Task<string> Post(DirectLineTokenRequest request);
    }
}
