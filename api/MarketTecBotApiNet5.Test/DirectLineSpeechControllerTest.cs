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
    public class DirectLineSpeechControllerTest
    {
        private DirectLineSpeechController controller;

        [Fact]
        public async Task PostTestAsync()
        {
            var mock = new Mock<IDirectLineSpeechService>();
            DirectLineSpeechTokenResponse directLineSpeechTokenResponse = new DirectLineSpeechTokenResponse();
            directLineSpeechTokenResponse.AuthorizationToken = "Auth";
            directLineSpeechTokenResponse.Region = "westus";
            mock.Setup(x => x.Post(It.IsAny<Object>())).Returns(Task.FromResult(directLineSpeechTokenResponse));
            controller = new DirectLineSpeechController(mock.Object);
            DirectLineTokenRequest request = new();
            DirectLineSpeechTokenResponse response = await controller.Post(request);
            Assert.NotNull(response);
        }

    }
}
