using CoCowork.BusinessLayer.Services;
using CoCowork.DataLayer.Entities;
using CoCowork.DataLayer.Repositories;
using Moq;
using NUnit.Framework;

namespace CoCowork.BusinessLayer.Tests.ItemOrderServiceTests
{
    class MiniOfficeOrderServiceTests
    {
        private readonly Mock<IMiniOfficeOrderRepository> _miniOfficeRepositoryMock;
        private readonly OrdersTestData _ordersTestData;

        public MiniOfficeOrderServiceTests()
        {
            _miniOfficeRepositoryMock = new Mock<IMiniOfficeOrderRepository>();
            _ordersTestData = new OrdersTestData();
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
    }
}
