using NUnit.Framework;
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
            ViewModel.ForceDataRefresh();
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

        [Test]
        public async Task ItemIndexViewModel_Update_Invalid_Bogus_Should_Fail()
        {
            // Arrange

            // Update only updates what is in the list, so update on something that does not exist will fail
            var newData = new ItemModel();

            // Act
            var result = await ViewModel.Update(newData);

            // Reset

            // Assert
            Assert.AreEqual(false, result);  // Update returned fail
        }

        [Test]
        public async Task ItemIndexViewModel_Add_Valid_Should_Pass()
        {
            // Arrange
            var data = new ItemModel
            {
                Name = "New Item"
            };

            // Act
            var result = await ViewModel.Add(data);

            // Reset

            // Need to clear the added item, and reload the dataset
            ViewModel.Dataset.Clear();
            ViewModel.ForceDataRefresh();

            // Assert
            Assert.AreEqual(true, result);  // Update returned Pass
        }

        [Test]
        public async Task ItemIndexViewModel_Add_InValid_Null_Should_Fail()
        {
            // Arrange

            // Act
            var result = await ViewModel.Add(null);

            // Reset

            // Assert
            Assert.AreEqual(false, result);
        }
    }
}