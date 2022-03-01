using MarketTecBotApiNet5.Controllers;
using MarketTecBotApiNet5.Dto;
using MarketTecBotApiNet5.Services;
using MarketTecBotApiNet5.Services.DirectLine;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;

namespace MarketTecBotApiNet5.Test
{
    [ExcludeFromCodeCoverage]
    [TestClass]
    public class DirectLineControllerTest
    {
        private DirectLineController controller;

        [TestMethod]
        public async Task PostTestAsync()
        {
            var mock = new Mock<IDirectLineService>();
            mock.Setup(x => x.Post(It.IsAny<DirectLineTokenRequest>())).Returns(Task.FromResult("{}"));
            controller = new DirectLineController(mock.Object);
            DirectLineTokenRequest request = new();
            string response = await controller.Post(request);
            Assert.IsFalse(string.IsNullOrEmpty(response));
        }
        
    }
}
