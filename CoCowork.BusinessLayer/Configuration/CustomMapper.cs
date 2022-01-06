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

        private static void InitCustomMapper()
        {
            _instance = new Mapper(new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Client, ClientModel>();

                cfg.CreateMap<MiniOffice, MiniOfficeModel>();

                cfg.CreateMap<MiniOfficeModel, MiniOffice>();

                cfg.CreateMap<MiniOfficeOrder, MiniOfficeOrderModel>();

                cfg.CreateMap<Order, OrderModel>();

                cfg.CreateMap<Payment, PaymentModel>();

                cfg.CreateMap<Place, PlaceModel>();

                cfg.CreateMap<PlaceModel, Place>();

                cfg.CreateMap<PlaceOrder, PlaceOrderModel>();

                cfg.CreateMap<Room, RoomModel>();

                cfg.CreateMap<Laptop, ComputerModel>();

                cfg.CreateMap<Object, MiniOffice>();

                cfg.CreateMap<Object, Place>();
            }));
        }
    }
}