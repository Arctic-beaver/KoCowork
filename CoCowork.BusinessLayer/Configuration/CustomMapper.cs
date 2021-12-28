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

        public static Mapper Custom { get; set; }

        private static void InitCustomMapper()
        {
            _instance = new Mapper(new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Client, ClientModel>();
                cfg.CreateMap<Client, ClientShortModel>();

                cfg.CreateMap<MiniOffice, MiniOfficeModel>();

                cfg.CreateMap<Laptop, LaptopModel>();

                cfg.CreateMap<MiniOfficeOrder, MiniOfficeOrderModel>();

                cfg.CreateMap<Order, OrderModel>();

                cfg.CreateMap<Payment, PaymentModel>();

                cfg.CreateMap<Place, PlaceModel>();

                cfg.CreateMap<Product, ProductModel>();

                cfg.CreateMap<Room, RoomModel>();

                cfg.CreateMap<PlaceOrder, PlaceOrderModel>();

                cfg.CreateMap<ClientModel, Client>();

                cfg.CreateMap<RoomModel, Room>();

                cfg.CreateMap<LaptopModel, Laptop>();

                cfg.CreateMap<PlaceModel, Place>();

                cfg.CreateMap<MiniOfficeModel, MiniOffice>();

                cfg.CreateMap<ProductModel, Product>();


            }));
        }
    }
}