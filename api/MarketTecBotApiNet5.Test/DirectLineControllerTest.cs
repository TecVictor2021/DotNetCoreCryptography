using MarketTecBotApiNet5.Controllers;
using MarketTecBotApiNet5.Dto;
using MarketTecBotApiNet5.Services.DirectLine;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace MarketTecBotApiNet5.Test
{
    public class DirectLineControllerTest
    {
        private DirectLineController controller;

        [Fact]
        public async Task PostTestAsync()
        {
            var mock = new Mock<IDirectLineService>();
            mock.Setup(x => x.Post(It.IsAny<DirectLineTokenRequest>())).Returns(Task.FromResult("{}"));
            controller = new DirectLineController(mock.Object);
            DirectLineTokenRequest request = new();
            string response = await controller.Post(request);
            Assert.False(string.IsNullOrEmpty(response));
        }
    }
}
