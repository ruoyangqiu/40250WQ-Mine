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
        [SetUp]
        public void Setup()
        {
            // Initilize Xamarin Forms
            MockForms.Init();

            // Activate the Datastore
            DependencyService.Register<MockDataStore>();
        }

        [Test]
        public async Task ItemIndexViewModel_Read_Invalid_ID_Bogus_Should_Fail()
        {
            // Arrange

            // Act
            var result = await new ItemIndexViewModel().Read("bogus");

            // Reset

            // Assert
            Assert.IsNull(result);
        }
    }
}