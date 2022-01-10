using AutoMapper;
using CoCowork.BusinessLayer.Models;
using CoCowork.DataLayer.Entities;
using System;

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

                cfg.CreateMap<ClientModel, Client>();

                cfg.CreateMap<MiniOffice, MiniOfficeModel>();

                cfg.CreateMap<Laptop, LaptopModel>();

                cfg.CreateMap<LaptopModel, Laptop>();

                cfg.CreateMap<MiniOfficeModel, MiniOffice>();

                //cfg.CreateMap<MiniOfficeOrder, MiniOfficeOrderModel>();

                cfg.CreateMap<Order, OrderModel>();

                cfg.CreateMap<OrderModel, Order>();

                cfg.CreateMap<OrderModel, Order>();

                cfg.CreateMap<Payment, PaymentModel>();

                cfg.CreateMap<PaymentModel, Payment>();

                cfg.CreateMap<Place, PlaceModel>();

                cfg.CreateMap<Product, ProductModel>();

                cfg.CreateMap<PlaceModel, Place>();

                cfg.CreateMap<PlaceOrder, PlaceOrderModel>();

                cfg.CreateMap<Room, RoomModel>();

                cfg.CreateMap<PlaceOrder, PlaceOrderModel>();
            }));
        }
    }
}