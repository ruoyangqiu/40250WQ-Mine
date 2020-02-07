using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mine.Views;

namespace UnitTests.Views.Game
{
    [TestFixture]
    public class GamePageTests
    {
        [Test]
        public void GamePage_Constructor_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new GamePage();

            // Reset

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
