using Moq;
using System.Collections.Generic;
using NUnit.Framework;
using GameApi.Models;
using GameApi.Controllers;
using GameApi.Services;

namespace GameApiTest.Tests
{
    [TestFixture]
    public class GameControllerTest
    {
        private GameController _gameController;
        private Mock<GameService> _mockGameService;

        [SetUp]
        public void Setup()
        {
            _mockGameService = new Mock<GameService>();
            _gameController = new GameController(_mockGameService.Object);
        }

        [Test]
        public void GetGames_Success()
        {
            // Arrange 
            var expectedServiceList = new List<Game>{
                
                new Game(){Id = 2, Title="Title2", Price=20},
                new Game(){Id = 1, Title="Title1", Price=10}
            };
            var expectedDtoList = new List<GameDto>{
                new GameDto(){Id = 2, Title="Title2"},

                new GameDto(){Id = 1, Title="Title1"}
            };
            _mockGameService.Setup(mgs => mgs.Get()).Returns(expectedServiceList);

            // Act
            var actual = _gameController.Get();

            // Assert
            Assert.AreEqual(expectedDtoList[0].Id, actual.Value[0].Id);
            Assert.AreEqual(expectedDtoList[1].Id, actual.Value[1].Id);
            _mockGameService.Verify(mgs => mgs.Get(), Times.Once());
        }

        [Test]
        public void GetGame_Success()
        {
            // Arrange 
            var id = 1;
            var expected = new Game(){Id = id, Title="Title1"};
            _mockGameService.Setup(mgs => mgs.Get(id)).Returns(expected);

            // Act
            var actual = _gameController.Get(id);

            // Assert
            Assert.AreEqual(expected, actual.Value);
            _mockGameService.Verify(mgs => mgs.Get(id), Times.Once());
        }
    }
}