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
        private LaptopOrderRepository _orderRepository;
        public LaptopService()
        {
            _laptopRepository = new LaptopRepository();
            _orderRepository = new LaptopOrderRepository();
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
        public void AddItemOrder(int id, Order order, DateTime startDate, DateTime endDate, decimal price)
        {
            var _entity = _laptopRepository.GetAll().Find(x => x.Id == id);

            _itemOrder = new LaptopOrder { Laptop = _entity, Order = order, StartDate = startDate, EndDate = endDate };
            _itemOrder.CalculateSubtotalPrice(price);

            _orderRepository.Add(_itemOrder);
        }
    }
}
