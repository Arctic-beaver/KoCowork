using AutoMapper;
using CoCowork.BusinessLayer.Models;
using CoCowork.DataLayer.Entities;

namespace CoCowork.BusinessLayer.Configuration
{
    public static class CustomMapper
    {
        private static Mapper _instance;

        public static Mapper GetInstance()
        {
            if (_instance == null)
                InitCustomMapper();
            return _instance;
        }

        private static void InitCustomMapper()
        {
            _instance = new Mapper(new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<ClientModel, Client>();

                cfg.CreateMap<Client, ClientModel>();

                cfg.CreateMap<MiniOffice, MiniOfficeModel>();

                cfg.CreateMap<MiniOfficeOrder, MiniOfficeOrderModel>();

                cfg.CreateMap<Order, OrderModel>();

                cfg.CreateMap<Payment, PaymentModel>();

                cfg.CreateMap<Place, PlaceModel>();

                cfg.CreateMap<PlaceOrder, PlaceOrderModel>();

                cfg.CreateMap<Product, ProductModel>();

                cfg.CreateMap<Room, RoomModel>();

                cfg.CreateMap<Laptop, ComputerModel>();

                cfg.CreateMap<ProductModel, Product>();

            }));
        }
    }
}