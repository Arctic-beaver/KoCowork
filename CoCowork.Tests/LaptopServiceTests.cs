using CoCowork.BusinessLayer.Services;
using CoCowork.DataLayer.Repositories;
using Moq;
using NUnit.Framework;

namespace CoCowork.BusinessLayer.Tests
{
    public class LaptopServiceTests
    {
        private readonly Mock<ILaptopRepository> _laptopRepositoryMock;
        private readonly LaptopTestData _laptopTestData;

        public LaptopServiceTests()
        {
            _laptopRepositoryMock = new Mock<ILaptopRepository>();
            _laptopTestData = new LaptopTestData();
        }

        [Test]
        public void GetAllPlaces_ShouldReturnPlaces()
        {
            //arrange
            var laptops = _laptopTestData.GetLaptopListForTests();
            _laptopRepositoryMock.Setup(m => m.GetAll()).Returns(laptops);
            var sut = new LaptopService(_laptopRepositoryMock.Object);

            //act
            var actual = sut.GetAll();

            //assert
            Assert.IsNotNull(actual);
            Assert.IsTrue(actual.Count > 0);
        }
    }
}
