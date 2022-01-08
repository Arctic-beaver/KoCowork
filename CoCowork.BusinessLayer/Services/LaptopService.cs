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
        private ILaptopOrderRepository _orderRepository;
        public LaptopService()
        {
            _laptopRepository = new LaptopRepository();
            _orderRepository = new LaptopOrderRepository();
        }
        public LaptopService(ILaptopOrderRepository fakeLaptopOrderRepository)
        {
            _orderRepository = fakeLaptopOrderRepository;
            _laptopRepository = new LaptopRepository();

        }

        public List<LaptopModel> GetAll()
        {
            var computers = _laptopRepository.GetAll();
            return CustomMapper.GetInstance().Map<List<LaptopModel>>(computers);
        }

        public void Delete(int id)
        {
            _laptopRepository.DeleteLaptopById(id);
        }

        public void Update(LaptopModel laptop)
        {
            var computers = CustomMapper.GetInstance().Map<Laptop>(laptop);
            _laptopRepository.UpdateLaptopById(computers);
        }

        public void Insert(LaptopModel laptop)
        {
            var computers = CustomMapper.GetInstance().Map<Laptop>(laptop);
            _laptopRepository.Add(computers);
        }
    

        public int AddItemOrder(BookingItemModel bookingItem)
        {
            var _entity = _laptopRepository.GetById(bookingItem.Id);

            _itemOrder = new LaptopOrder { Laptop = _entity, Order = bookingItem.Order, StartDate = bookingItem.StartDate, EndDate = bookingItem.EndDate, SubtotalPrice = bookingItem.SubtotalPrice };

            return _orderRepository.Add(_itemOrder);

        }

        public int AddItemOrder(ItemModel bookingItem)
        {
            throw new NotImplementedException();
        }
    }
}
