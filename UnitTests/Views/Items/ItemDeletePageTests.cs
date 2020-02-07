using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mine.Views;
using Mine.ViewModels;
using Mine.Models;

namespace UnitTests.Views.Game
{
    [TestFixture]
    public class ItemDeletePageTests
    {
        [Test]
        public void ItemDeletePage_Constructor_Default_Should_Pass()
        {
            // Arrange
            var ViewModel = new ItemViewModel();

            // Act
            var result = new ItemDeletePage(ViewModel);

            // Reset

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
