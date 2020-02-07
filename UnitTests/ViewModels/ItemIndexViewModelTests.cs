using NUnit.Framework;
using Mine.ViewModels;
using Xamarin.Forms.Mocks;
using Xamarin.Forms;
using Mine.Services;
using System.Threading.Tasks;
using System.Linq;

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
        public async Task ItemIndexViewModel_Read_Valid_ID_Bogus_Should_Pass()
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
    }
}