using CoCowork.BusinessLayer.Configuration;
using CoCowork.BusinessLayer.Models;
using CoCowork.DataLayer.Entities;
using CoCowork.DataLayer.Repositories;
using System;
using System.Collections.Generic;

namespace CoCowork.BusinessLayer.Services
{
    public class LaptopService : IItemService, ILaptopService
    {
        private readonly ILaptopRepository _laptopRepository;
        private LaptopOrder _itemOrder;
        private readonly ILaptopOrderRepository _orderRepository;

        public LaptopService()
        {
            _laptopRepository = new LaptopRepository();
            _orderRepository = new LaptopOrderRepository();
        }

        public LaptopService(ILaptopOrderRepository fakeLaptopOrderRepository, ILaptopRepository fakeLaptopRepository)
        {
            _orderRepository = fakeLaptopOrderRepository;
            _laptopRepository = fakeLaptopRepository;
        }

        public List<LaptopModel> GetAll()
        {
            var computers = _laptopRepository.GetAll();
            return CustomMapper.GetInstance().Map<List<LaptopModel>>(computers);
        }

        public bool Delete(int id)
        {
            try
            {
                _laptopRepository.DeleteLaptopById(id);
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public void Update(LaptopModel laptop)
        {
            var computers = CustomMapper.GetInstance().Map<Laptop>(laptop);
            _laptopRepository.UpdateLaptopById(computers);
        }

        public int Insert(LaptopModel laptop)
        {
            var computers = CustomMapper.GetInstance().Map<Laptop>(laptop);
            int insertedLaptopId = 0;

            try
            {
                insertedLaptopId = _laptopRepository.Add(computers);
            }
            catch (Exception ex)
            {
                return -1;
            }
            return insertedLaptopId;
        }


        public int AddItemOrder(BookingItemModel bookingItem)
        {
            var _entity = _laptopRepository.GetById(bookingItem.Id);
            BookingItemModel bookingItemModel = (BookingItemModel)bookingItem;


            _itemOrder = new LaptopOrder { Laptop = _entity, Order = bookingItem.Order, StartDate = bookingItem.StartDate, EndDate = bookingItemModel.EndDate, SubtotalPrice = bookingItemModel.SubtotalPrice };

            return _orderRepository.Add(_itemOrder);

        }

        public int AddItemOrder(ItemModel bookingItem)
        {
            var _entity = _laptopRepository.GetById(bookingItem.Id);
            BookingItemModel bookingItemModel = (BookingItemModel)bookingItem;


            _itemOrder = new LaptopOrder { Laptop = _entity, Order = bookingItem.Order, StartDate = bookingItemModel.StartDate, EndDate = bookingItemModel.EndDate, SubtotalPrice = bookingItem.SubtotalPrice };

            return _orderRepository.Add(_itemOrder);
        }
    }
}
