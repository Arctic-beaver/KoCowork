using CoCowork.BusinessLayer.Configuration;
using CoCowork.BusinessLayer.Models;
using CoCowork.DataLayer.Entities;
using CoCowork.DataLayer.Repositories;
using System;
using System.Collections.Generic;

namespace CoCowork.BusinessLayer.Services
{
    public class MiniOfficeService : IMiniOfficeService, IItemService
    {
        private readonly IMiniOfficeRepository _miniOfficeRepository;
        private MiniOfficeOrder _itemOrder;
        private MiniOfficeOrderRepository _orderRepository;

        public MiniOfficeService()
        {
            _miniOfficeRepository = new MiniOfficeRepository();
            _orderRepository = new MiniOfficeOrderRepository();

        }

        public List<MiniOfficeModel> GetAll()
        {
            var miniOffices = _miniOfficeRepository.GetAll();
            return CustomMapper.GetInstance().Map<List<MiniOfficeModel>>(miniOffices);
        }

        public void DeleteMiniOffice(int id)
        {
            _miniOfficeRepository.DeleteMiniOfficeById(id);
        }

        public void UpdateMiniOffice(MiniOfficeModel miniOffice)
        {
            var mOffice = CustomMapper.GetInstance().Map<MiniOffice>(miniOffice);
            _miniOfficeRepository.UpdateMiniOfficeById(mOffice);
        }

        public void InsertMiniOffice(MiniOfficeModel miniOffice)
        {
            var mOffice = CustomMapper.GetInstance().Map<MiniOffice>(miniOffice);
            _miniOfficeRepository.Add(mOffice);
        }

        public void AddItemOrder(int id, Order order, DateTime startDate, DateTime endDate, decimal price)
        {
            var _entity = _miniOfficeRepository.GetAll().Find(x => x.Id == id);

            _itemOrder = new MiniOfficeOrder { MiniOffice = _entity, Order = order, StartDate = startDate, EndDate = endDate };
            //_itemOrder.CalculateSubtotalPrice(price);

            _orderRepository.Add(_itemOrder);
        }
    }
}
