using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mine.ViewModels;

namespace UnitTests.ViewModels
{
    [TestFixture]
    public class BaseViewModelTests
    {
        [Test]
        public void BaseViewModel_Constructor_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new BaseViewModel();

            // Reset

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
