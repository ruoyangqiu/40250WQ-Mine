﻿using NUnit.Framework;
using Mine.ViewModels;
using Xamarin.Forms.Mocks;
using Xamarin.Forms;
using System.Threading.Tasks;
using System.Linq;

using Mine.Services;
using Mine.Models;

namespace UnitTests.ViewModels
{
    public class ItemIndexViewModelTests
    {
        ItemIndexViewModel ViewModel;

        [SetUp]
        public void Setup()
        {
            // Initilize Xamarin Forms
            MockForms.Init();

            // Activate the Datastore
            DependencyService.Register<MockDataStore>();

            ViewModel = new ItemIndexViewModel();

            // Load Data
            ViewModel.LoadDatasetCommand.Execute(null);
        }

        [Test]
        public async Task ItemIndexViewModel_Read_Invalid_ID_Bogus_Should_Fail()
        {
            // Arrange

            // Act
            var result = await ViewModel.Read("bogus");

            // Reset

            // Assert
            Assert.IsNull(result);
        }

        [Test]
        public async Task ItemIndexViewModel_Read_Valid_ID_Should_Pass()
        {
            // Arrange

            // Find the First ID
            var first = ViewModel.Dataset.FirstOrDefault();

            // Act
            var result = await ViewModel.Read(first.Id);

            // Reset

            // Assert
            Assert.AreEqual(first.Name, result.Name);
        }

        [Test]
        public async Task ItemIndexViewModel_Update_Valid_Should_Pass()
        {
            // Arrange

            // Find the First ID
            var first = ViewModel.Dataset.FirstOrDefault();

            // Make a new item
            first.Name = "New Item";
            first.Value = 1000;

            // Act
            var result = await ViewModel.Update(first);

            // Reset

            // Assert
            Assert.AreEqual(true, result);  // Update returned Pas
            Assert.AreEqual("New Item", first.Name);  // The Name was updated
            Assert.AreEqual(1000, first.Value);  // The Value was updated
        }
    }
}