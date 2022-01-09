using CoCowork.BusinessLayer.Models;
using CoCowork.BusinessLayer.Services;
using CoCowork.BusinessLayer.Tests.ItemOrderServiceTests;
using CoCowork.DataLayer.Entities;
using CoCowork.DataLayer.Repositories;
using Moq;
using NUnit.Framework;

namespace CoCowork.BusinessLayer.Tests
{
    public class OrderServiceTests
    {
        private readonly Mock<IOrderRepository> _orderRepositoryMock;
        private readonly OrdersTestData _ordersTestData;
        private readonly ClientTestData _clientTestData;

        public OrderServiceTests()
        {
            _orderRepositoryMock = new Mock<IOrderRepository>();
            _clientTestData = new ClientTestData();
            _ordersTestData = new OrdersTestData();
        }

        [Test]
        public void AddOrder()
        {
            //arrange
            var order = _ordersTestData.GetOrderWithClientModelForTests();
            var client = _clientTestData.GetClientForTests();

            _orderRepositoryMock.Setup(m => m.Add(It.IsAny<Order>())).Returns(1);
            var sut = new OrderService(_orderRepositoryMock.Object);

            //act
            var actual = sut.InsertOrder(order);

            //assert
            _orderRepositoryMock.Verify(m => m.Add(It.IsAny<Order>()), Times.Once());
        }
    }
}
