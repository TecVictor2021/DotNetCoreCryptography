using MarketTecBotApiNet5.Controllers;
using MarketTecBotApiNet5.Dto;
using MarketTecBotApiNet5.Services.DirectLine;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;

namespace MarketTecBotApiNet5.Test
{
    [ExcludeFromCodeCoverage]
    [TestClass]
    public class DirectLineSpeechControllerTest
    {
        private DirectLineSpeechController controller;

        [TestMethod]
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
            Assert.IsNotNull(response);
        }
    }
}
