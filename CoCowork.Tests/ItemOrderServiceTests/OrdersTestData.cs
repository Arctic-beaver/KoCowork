using CoCowork.BusinessLayer.Models;
using System;

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
                    Id = 3,
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

        public LaptopModel GetLaptopModelForTests()
        {
            var laptop = new LaptopModel
            {
                Id = 1,
                IsActive = true,
                Description = "kokoko",
                StartDate = DateTime.Now,
                EndDate = DateTime.Now,
            };
            return laptop;
        }

        public ProductModel GetProductModelForTests()
        {
            var product = new ProductModel
            {
                Id = 1,
                SubtotalPrice = 1000,
            };
            return product;
        }

        public PlaceModel GetPlaceModelForTests()
        {
            var place = new PlaceModel
            {
                Id = 1,
                SubtotalPrice = 1000,
            };
            return place;
        }

        public MiniOfficeModel GetMiniOfficeModelForTests()
        {
            var miniOffice = new MiniOfficeModel
            {
                Id = 1,
                SubtotalPrice = 1000,
            };
            return miniOffice;
        }

    }
}
