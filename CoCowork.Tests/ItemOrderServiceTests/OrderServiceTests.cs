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
        private readonly Mock<ILaptopOrderRepository> _laptopRepositoryMock;
        private readonly Mock<IMiniOfficeOrderRepository> _miniOfficeRepositoryMock;
        private readonly Mock<IPlaceOrderRepository> _placeOrderRepository;
        private readonly Mock<IProductOrderRepository> _productOrderRepository;
        private readonly Mock<IRoomOrderRepository> _roomOrderRepository;
        private readonly OrdersTestData _ordersTestData;
        private readonly ClientTestData _clientTestData;

        public OrderServiceTests()
        {
            _orderRepositoryMock = new Mock<IOrderRepository>();
            _laptopRepositoryMock = new Mock<ILaptopOrderRepository>();
            _miniOfficeRepositoryMock = new Mock<IMiniOfficeOrderRepository>();
            _placeOrderRepository = new Mock<IPlaceOrderRepository>();
            _productOrderRepository = new Mock<IProductOrderRepository>();
            _roomOrderRepository = new Mock<IRoomOrderRepository>();
            _clientTestData = new ClientTestData();
        }

        [Test]
        public void AddOrder()
        {
            //arrange
            //var order = _ordersTestData.GetOrderWithClientModelForTests();
            var client = _clientTestData.GetClientForTests();

            _orderRepositoryMock.Setup(m => m.Add(It.IsAny<Order>())).Returns(1);
            var sut = new OrderService(_orderRepositoryMock.Object);

            //act
            var actual = sut.InsertOrder(client: client, isCanceled: true, isPaid: true, totalPrice: 1000);

            //assert
            _orderRepositoryMock.Verify(m => m.Add(It.IsAny<Order>()), Times.Once());
        }

        [Test]
        public void AddLaptopOrder()
        {
            //arrange

            _laptopRepositoryMock.Setup(m => m.Add(It.IsAny<LaptopOrder>()));

            //act
            

            //assert
        
        }
    }
}
