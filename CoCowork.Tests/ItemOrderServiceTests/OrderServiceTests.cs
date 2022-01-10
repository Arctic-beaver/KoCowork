using CoCowork.BusinessLayer.Configuration;
using CoCowork.BusinessLayer.Models;
using CoCowork.BusinessLayer.Services;
using CoCowork.BusinessLayer.Tests.ItemOrderServiceTests;
using CoCowork.DataLayer.Entities;
using CoCowork.DataLayer.Repositories;
using Moq;
using NUnit.Framework;
using System.Linq;

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
        public void CheckPayment_ReceivesOrderIdShouldSayIfOrderIsPaid()
        {
            //arrange
            var order = _ordersTestData.GetOrderForTests();
            _orderRepositoryMock.Setup(m => m.GetById(1)).Returns(order);
            var sut = new OrderService(_orderRepositoryMock.Object);

            //act
            var actual = sut.CheckPaymentAndMarkAsPaid(1);

            //assert
            Assert.AreEqual(actual, order.IsPaid);
        }

        [Test]
        public void CheckPayment_ReceivesOrderIdShouldMarkAsPaidIfNecessary()
        {
            //arrange
            var order = _ordersTestData.GetOrderWithPaymentsForTests();
            _orderRepositoryMock.Setup(m => m.GetById(1)).Returns(order);
            var sut = new OrderService(_orderRepositoryMock.Object);

            //act
            var actual = sut.CheckPaymentAndMarkAsPaid(1);

            //assert
            Assert.IsTrue(actual);
        }

        [Test]
        public void UpdateOrder_ReceivesOrderShouldUpdateOrderInDB()
        {
            //arrange
            var orderModel = _ordersTestData.GetOrderModelForTests();
            _orderRepositoryMock.Setup(m => m.Update(It.IsAny<Order>()));
            var sut = new OrderService(_orderRepositoryMock.Object);

            //act
            sut.UpdateOrder(orderModel);

            //assert
            _orderRepositoryMock.Verify(m => m.Update(It.IsAny<Order>()), Times.Once());
        }

        [Test]
        public void GetAllOrders_ShouldSReturnAllOrdersFromDB()
        {
            //arrange
            var orders = _ordersTestData.GetOrdersListForTests();

            _orderRepositoryMock.Setup(m => m.GetAll()).Returns(orders);

            var sut = new OrderService(_orderRepositoryMock.Object);

            //act
            var actual = sut.GetAllOrders();

            //assert
            Assert.IsNotNull(actual);
            Assert.IsTrue(actual.Count > 0);
        }

        [TestCase(true, false, false)]
        [TestCase(true, true, false)]
        [TestCase(false, true, true)]
        public void GetSpecialOrders_ReceivesParamsShouldSReturnSuitableOrdersFromDB(bool showPaid, bool showUnpaid, bool showCanceled)
        {
            //arrange
            var orders = _ordersTestData.GetOrdersListForTests();
            _orderRepositoryMock.Setup(m => m.GetAll()).Returns(orders);
            var sut = new OrderService(_orderRepositoryMock.Object);

            //act
            var actual = sut.GetSpecialOrders(showPaid, showUnpaid, showCanceled);

            //assert
            Assert.AreEqual(actual.First().IsCanceled, showCanceled);
            Assert.IsTrue(actual.First().IsPaid && showPaid || !actual.First().IsPaid && showUnpaid);
        }

        [Test]
        public void AddOrder_ShouldAddOrderToDB()
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
