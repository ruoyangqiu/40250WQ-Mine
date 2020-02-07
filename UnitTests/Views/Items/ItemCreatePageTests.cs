﻿using NUnit.Framework;
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
    public class ItemCreatePageTests
    {
        [Test]
        public void ItemCreatePage_Constructor_Default_Should_Pass()
        {
            // Arrange
            var ViewModel = new ItemViewModel();

            // Act
            var result = new ItemCreatePage(ViewModel);

            // Reset

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
