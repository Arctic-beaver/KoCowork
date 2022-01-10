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
        private readonly Mock<ProductRepository> _productRepositoryMock;

        private readonly Mock<IMiniOfficeOrderRepository> _miniOfficeRepositoryMock;
        private readonly Mock<IOrderRepository> _orderRepositoryMock;
        private readonly Mock<IPlaceOrderRepository> _placeOrderRepository;
        private readonly Mock<IProductOrderRepository> _productOrderRepository;
        private readonly Mock<ILaptopOrderRepository> _laptopOrderRepositoryMock;
        private readonly Mock<IRoomOrderRepository> _roomOrderRepository;
        private readonly Mock<ILaptopRepository> _laptopRepositoryMock;


        private readonly OrdersTestData _ordersTestData;
        private readonly ClientTestData _clientTestData;

        public OrderServiceTests()
        {
            _orderRepositoryMock = new Mock<IOrderRepository>();
            _laptopOrderRepositoryMock = new Mock<ILaptopOrderRepository>();
            _miniOfficeRepositoryMock = new Mock<IMiniOfficeOrderRepository>();
            _placeOrderRepository = new Mock<IPlaceOrderRepository>();
            _productOrderRepository = new Mock<IProductOrderRepository>();
            _roomOrderRepository = new Mock<IRoomOrderRepository>();
            _clientTestData = new ClientTestData();
            _laptopRepositoryMock = new Mock<ILaptopRepository>();
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

        [Test]
        public void AddLaptopOrder()
        {
            //arrange
            var laptop = _ordersTestData.GetLaptopModelForTests();
            _laptopRepositoryMock.Setup(m => m.Add(It.IsAny<Laptop>()));
            _laptopOrderRepositoryMock.Setup(m => m.Add(It.IsAny<LaptopOrder>()));
            var sut = new LaptopService(_laptopOrderRepositoryMock.Object, _laptopRepositoryMock.Object);

            ////act
            var actual = sut.AddItemOrder(laptop);

            //assert
            _laptopOrderRepositoryMock.Verify(m => m.Add(It.IsAny<LaptopOrder>()), Times.Once());
        }

        [Test]
        public void AddProductOrder()
        {
            //arrange
            var product = _ordersTestData.GetProductModelForTests();
            _productOrderRepository.Setup(m => m.Add(It.IsAny<ProductOrder>()));
            var sut = new ProductService(_productOrderRepository.Object);

            ////act
            var actual = sut.AddItemOrder(product);

            //assert
            _productOrderRepository.Verify(m => m.Add(It.IsAny<ProductOrder>()), Times.Once());
        }

        [Test]
        public void AddPlaceOrder()
        {
            //arrange
            var place = _ordersTestData.GetPlaceModelForTests();
            _placeOrderRepository.Setup(m => m.Add(It.IsAny<PlaceOrder>()));
            var sut = new PlaceService(_placeOrderRepository.Object);

            //act
            var actual = sut.AddItemOrder(place);

            //assert
            _placeOrderRepository.Verify(m => m.Add(It.IsAny<PlaceOrder>()), Times.Once());
        }

        [Test]
        public void AddMiniOfficeOrder()
        {
            //arrange
            var miniOffice = _ordersTestData.GetMiniOfficeModelForTests();
            _miniOfficeRepositoryMock.Setup(m => m.Add(It.IsAny<MiniOfficeOrder>()));
            var sut = new MiniOfficeService(_miniOfficeRepositoryMock.Object);

            ////act
            var actual = sut.AddItemOrder(miniOffice);

            //assert
            _miniOfficeRepositoryMock.Verify(m => m.Add(It.IsAny<MiniOfficeOrder>()), Times.Once());
        }

        [Test]
        public void AddRoomOrder()
        {
            //arrange
            var roomOffice = _ordersTestData.GetRoomModelForTests();
            _roomOrderRepository.Setup(m => m.Add(It.IsAny<RoomOrder>()));
            var sut = new RoomService(_roomOrderRepository.Object);

            ////act
            var actual = sut.AddItemOrder(roomOffice);

            //assert
            _roomOrderRepository.Verify(m => m.Add(It.IsAny<RoomOrder>()), Times.Once());
        }

    }
}
