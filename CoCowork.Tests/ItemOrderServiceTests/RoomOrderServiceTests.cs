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
    class RoomOrderServiceTests
    {
        private readonly Mock<IRoomOrderRepository> _roomOrderRepository;
        private readonly OrdersTestData _ordersTestData;

        public RoomOrderServiceTests()
        {
            _roomOrderRepository = new Mock<IRoomOrderRepository>();
            _ordersTestData = new OrdersTestData();
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
