using CoCowork.DataLayer.Entities;
using CoCowork.DataLayer.Repositories;
using System;

namespace CoCowork.BusinessLayer.Models
{
    public class RoomModel : ItemModel
    {
        public string Type { get; set; }
        public int AmountOfPeople { get; set; }
        public decimal PricePerHour { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public int AmountHours { get; set; }
        public string TypeForDisplayInUI = "Комната";
        private RoomRepository _repository;
        private Room _entitie;
        private RoomOrder _itemOrder;
        private RoomOrderRepository _orderRepository;

        public RoomModel()
        {
            _repository = new RoomRepository();
            _orderRepository = new RoomOrderRepository();
        }

        public override void AddItemOrder(int id, Order order, DateTime startDate, DateTime endDate, decimal price)
        {
            _entitie = _repository.GetAll().Find(x => x.Id == id);

            _itemOrder = new RoomOrder { Room = _entitie, Order = order, StartDate = startDate, EndDate = endDate };
            _itemOrder.CalculateSubtotalPrice(price);

            _orderRepository.Add(_itemOrder);
        }

    }
}