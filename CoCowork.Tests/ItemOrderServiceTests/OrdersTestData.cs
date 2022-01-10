using CoCowork.BusinessLayer.Models;
using CoCowork.DataLayer.Entities;
using System;
using System.Collections.Generic;

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
                IsCanceled = true,
                IsPaid = true,
                ClientId = 3
            };
            return order;
        }

        public Order GetOrderForTests()
        {
            var order = new Order
            {
                Id = 1,
                TotalPrice = 13000,
                IsCanceled = true,
                IsPaid = false,
                ClientId = 3,
                Payments = new List<Payment>()

            };
            return order;
        }

        public Order GetOrderWithPaymentsForTests()
        {
            var order = new Order
            {
                Id = 1,
                TotalPrice = 13000,
                IsCanceled = true,
                IsPaid = false,
                ClientId = 3,
                Payments = new List<Payment>
                {
                    new Payment
                    {
                        Id = 1,
                        Amount = 2346
                    },
                    new Payment
                    {
                        Id = 1,
                        Amount = 9346
                    },
                    new Payment
                    {
                        Id = 1,
                        Amount = 2344
                    }
                }
            };
            return order;
        }

        public OrderModel GetOrderModelForTests()
        {
            var order = new OrderModel
            {
                Id = 1,
                TotalPrice = 13000,
                IsCanceled = true,
                IsPaid = false,
                ClientId = 3,
                Payments = new List<PaymentModel>()

            };
            return order;
        }

        public List<Order> GetOrdersListForTests()
        {
            var orders = new List<Order>
            { new Order
            {
                Id = 1,
                TotalPrice = 13000,
                IsCanceled = true,
                IsPaid = false,
                ClientId = 3
            },

            new Order
            {
                Id = 2,
                TotalPrice = 13000,
                IsCanceled = true,
                IsPaid = false,
                ClientId = 3
            },

            new Order
            {
                Id = 3,
                TotalPrice = 13000,
                IsCanceled = false,
                IsPaid = true,
                ClientId = 3
            },

            new Order
            {
                Id = 4,
                TotalPrice = 13000,
                IsCanceled = false,
                IsPaid = false,
                ClientId = 3
            }
            };
            return orders;
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
