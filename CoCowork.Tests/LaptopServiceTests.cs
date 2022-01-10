using CoCowork.BusinessLayer.Services;
using CoCowork.DataLayer.Repositories;
using Moq;
using NUnit.Framework;

namespace CoCowork.BusinessLayer.Tests
{
    public class LaptopServiceTests
    {
        private readonly Mock<ILaptopRepository> _laptopRepositoryMock;
        private Mock<ILaptopOrderRepository> _orderRepositoryMock;
        private readonly LaptopTestData _laptopTestData;

        public LaptopServiceTests()
        {
            _laptopRepositoryMock = new Mock<ILaptopRepository>();
            _orderRepositoryMock = new Mock<ILaptopOrderRepository>();
            _laptopTestData = new LaptopTestData();
        }

        [Test]
        public void GetAllPlaces_ShouldReturnPlaces()
        {
            //arrange
            var laptops = _laptopTestData.GetLaptopListForTests();
            _laptopRepositoryMock.Setup(m => m.GetAll()).Returns(laptops);
            _orderRepositoryMock.Setup(m => m.GetAllLaptopOrders());
            var sut = new LaptopService(_orderRepositoryMock.Object, _laptopRepositoryMock.Object);

            //act
            var actual = sut.GetAll();

            //assert
            Assert.IsNotNull(actual);
            Assert.IsTrue(actual.Count > 0);
        }
    }
}
