using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoCowork.BusinessLayer.Models;
using CoCowork.BusinessLayer.Services;
using CoCowork.BusinessLayer.Tests.ItemOrderServiceTests;
using CoCowork.DataLayer.Entities;
using CoCowork.DataLayer.Repositories;
using Moq;
using NUnit.Framework;

namespace CoCowork.BusinessLayer.Tests.ItemOrderServiceTests
{
    class PlaceOrderServiceTests
    {
        private readonly Mock<IPlaceOrderRepository> _placeOrderRepository;
        private readonly Mock<IPlaceRepository> _placeRepositoryMock;
        private readonly OrdersTestData _ordersTestData;

        public PlaceOrderServiceTests()
        {
            _placeOrderRepository = new Mock<IPlaceOrderRepository>();
            _placeRepositoryMock = new Mock<IPlaceRepository>();
            _ordersTestData = new OrdersTestData();
        }

        [Test]
        public void AddPlaceOrder()
        {
            //arrange
            var place = _ordersTestData.GetPlaceModelForTests();
            _placeOrderRepository.Setup(m => m.Add(It.IsAny<PlaceOrder>()));
            _placeRepositoryMock.Setup(m => m.Add(It.IsAny<Place>()));
            var sut = new PlaceService(_placeOrderRepository.Object, _placeRepositoryMock.Object);

            ////act
            var actual = sut.AddItemOrder(place);

            //assert
            _placeOrderRepository.Verify(m => m.Add(It.IsAny<PlaceOrder>()), Times.Once());
        }
    }
}
