using System.Diagnostics.CodeAnalysis;

namespace MarketTecBotApiNet5.Dto
{
    [ExcludeFromCodeCoverage]
    public class DirectLineTokenRequest
    {
        private string id;
        private string name;

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
    }
}
