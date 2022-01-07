using CoCowork.BusinessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoCowork.BusinessLayer.Tests.ItemOrderServiceTests
{
    public class OrdersTestData
    {
        public OrderModel GetOrderWithClientModelForTests()
        {
            var order = new OrderModel
            {
                Id = 1,
                TotalPrice = 13000,
                IsCancelled = true,
                IsPaid = true,
                Client = new ClientModel
                {
                    Id = 666,
                    PaperAmount = 3,
                    BirthDate = DateTime.Now,
                    FirstName = "Vasya",
                    LastName = "Vasiliev",
                    Email = "kkk",
                    Phone = "8999",
                }
            };
            return order;
        }

        public RoomModel GetRoomModelForTests()
        {
            var room = new RoomModel
            {
                Id = 1,
                AmountOfPeople = 666,
                PricePerHour = 30,
                AmountHours = 10,
                Name = "kokoko",
                SubtotalPrice = 10000,
                StartDate = DateTime.Now,
                EndDate = DateTime.Now,

            };
            return room;
        }

    }
}
