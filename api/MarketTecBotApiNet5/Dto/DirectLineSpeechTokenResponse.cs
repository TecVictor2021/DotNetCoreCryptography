using System.Diagnostics.CodeAnalysis;

namespace MarketTecBotApiNet5.Dto
{
    [ExcludeFromCodeCoverage]
    public class DirectLineSpeechTokenResponse
    {
        private string authorizationToken;
        private string region;

        public string AuthorizationToken { get => authorizationToken; set => authorizationToken = value; }
        public string Region { get => region; set => region = value; }
    }
}
