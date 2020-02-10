using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mine.Views;
using Xamarin.Forms.Mocks;
using Mine;

namespace UnitTests.Views.Game
{
    [TestFixture]
    public class AppTests : App
    {
        [Test]
        public void App_Constructor_Default_Should_Pass()
        {
            // Arrange

            // Initilize Xamarin Forms
            MockForms.Init();

            // Act
            var result = new Mine.App();

            // Reset

            // Assert
            Assert.IsNotNull(result);
        }

        [Test]
        public void App_OnResume_Default_Should_Pass()
        {
            // Arrange

            // Initilize Xamarin Forms
            MockForms.Init();
            var page = new Mine.App();

            // Act
            OnResume();

            // Reset

            // Assert
            Assert.IsTrue(true); // Got to here, so it happened...
        }

        [Test]
        public void App_OnSleep_Default_Should_Pass()
        {
            // Arrange

            // Initilize Xamarin Forms
            MockForms.Init();
            var page = new Mine.App();

            // Act
            OnSleep();

            // Reset

            // Assert
            Assert.IsTrue(true); // Got to here, so it happened...
        }

        [Test]
        public void App_OnStart_Default_Should_Pass()
        {
            // Arrange

            // Initilize Xamarin Forms
            MockForms.Init();
            var page = new Mine.App();

            // Act
            OnStart();

            // Reset

            // Assert
            Assert.IsTrue(true); // Got to here, so it happened...
        }

        //[Test]
        //public void App_InitializeComponent_Default_Should_Pass()
        //{
        //    Arrange

        //    Initilize Xamarin Forms
        //    MockForms.Init();
        //    var page = new Mine.App();

        //    Act
        //    InitializeComponent();

        //    Reset

        //    Assert
        //    Assert.IsTrue(true); // Got to here, so it happened...
        //}
    }
}