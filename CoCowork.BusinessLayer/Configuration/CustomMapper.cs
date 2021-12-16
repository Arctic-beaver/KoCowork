using AutoMapper;
using CoCowork.BusinessLayer.Models;
using CoCowork.DataLayer.Entities;

namespace PseudoCalc.BusinessLayer.Configuration
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
                cfg.CreateMap<Client, ClientShortModel>();

                cfg.CreateMap<MiniOffice, MiniOfficeModel>();

                cfg.CreateMap<MiniOfficeOrder, MiniOfficeOrderModel>();

                cfg.CreateMap<Order, OrderModel>();

                cfg.CreateMap<Payment, PaymentModel>();

                cfg.CreateMap<Place, PlaceModel>();

                cfg.CreateMap<PlaceOrder, PlaceOrderModel>();

                cfg.CreateMap<RoomType, RoomTypeModel>();

            }));
        }
    }
}