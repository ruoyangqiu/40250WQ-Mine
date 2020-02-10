using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mine.Views;
using Xamarin.Forms.Mocks;

namespace UnitTests.Views.Game
{
    [TestFixture]
    public class MenuPageTests
    {
        [Test]
        public void MenuPage_Constructor_Default_Should_Pass()
        {
            // Arrange

            // Initilize Xamarin Forms
            MockForms.Init();

            // Act
            var result = new MenuPage();

            // Reset

            // Assert
            Assert.IsNotNull(result);
        }

        [Test]
        public void MenuPage_Get_Default_Should_Pass()
        {
            // Arrange

            // Initilize Xamarin Forms
            MockForms.Init();

            var page = new MenuPage();
            // Act
            var result = page.RootPage;

            // Reset

            // Assert
            Assert.IsNotNull(result);
        }
    }
}