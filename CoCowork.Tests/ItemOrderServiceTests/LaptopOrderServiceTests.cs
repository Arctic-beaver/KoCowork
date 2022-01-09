using CoCowork.BusinessLayer.Models;
using CoCowork.BusinessLayer.Services;
using CoCowork.BusinessLayer.Tests.ItemOrderServiceTests;
using CoCowork.DataLayer.Entities;
using CoCowork.DataLayer.Repositories;
using Moq;
using NUnit.Framework;

namespace CoCowork.BusinessLayer.Tests
{
    internal class LaptopOrderServiceTests
    {
        private readonly Mock<ILaptopOrderRepository> _laptopOrderRepositoryMock;
        private readonly OrdersTestData _ordersTestData;

        public LaptopOrderServiceTests()
        {
            _laptopOrderRepositoryMock = new Mock<ILaptopOrderRepository>();
            _ordersTestData = new OrdersTestData();
        }

        [Test]
        public void AddLaptopOrder()
        {
            //arrange
            var laptop = _ordersTestData.GetLaptopModelForTests();
            var sut = new LaptopService(_laptopOrderRepositoryMock.Object);

            _laptopOrderRepositoryMock.Setup(m => m.Add(It.IsAny<LaptopOrder>()));
            ////act
            var actual = sut.AddItemOrder(laptop);

            //assert
            _laptopOrderRepositoryMock.Verify(m => m.Add(It.IsAny<LaptopOrder>()), Times.Once());
        }
    }
}
