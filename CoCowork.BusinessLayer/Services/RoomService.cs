using CoCowork.BusinessLayer.Configuration;
using CoCowork.BusinessLayer.Models;
using CoCowork.DataLayer.Entities;
using CoCowork.DataLayer.Repositories;
using System;
using System.Collections.Generic;

namespace CoCowork.BusinessLayer.Services
{
    public class RoomService : IRoomService, IItemService
    {
        private readonly IRoomRepository _roomRepository;
        private const string _meetingRoom = "Переговорная";
        private const string _conferenceRoom = "Конференц-зал";
        private RoomRepository _repository;
        private RoomOrder _itemOrder;
        private IRoomOrderRepository _orderRepository;

        public RoomService()
        {
            _roomRepository = new RoomRepository();
            _orderRepository = new RoomOrderRepository();
        }

        public RoomService(IRoomOrderRepository fakeRoomRepository)
        {
            _roomRepository = new RoomRepository();
            _orderRepository = fakeRoomRepository;
        }

        public List<RoomModel> GetAll()
        {
            var rooms = _roomRepository.GetAll();
            return CustomMapper.GetInstance().Map<List<RoomModel>>(rooms);
        }

        public List<RoomModel> GetConferenceRooms()
        {
            var rooms = _roomRepository.GetAll();
            var roomModels = CustomMapper.GetInstance().Map<List<RoomModel>>(rooms);
            List<RoomModel> conferenceRooms = new();

            foreach (var item in roomModels)
            {
                if (item.Type == _conferenceRoom)
                {
                    conferenceRooms.Add(item);
                }
            }
            return conferenceRooms;
        }

        public List<RoomModel> GetMeetingRooms()
        {
            var rooms = _roomRepository.GetAll();
            var roomModels = CustomMapper.GetInstance().Map<List<RoomModel>>(rooms);
            List<RoomModel> meetingRooms = new();

            foreach (var item in roomModels)
            {
                if (item.Type == _meetingRoom)
                {
                    meetingRooms.Add(item);
                }
            }
            return meetingRooms;
        }

        public void DeleteRoom(int id)
        {
            _roomRepository.Delete(id);
        }

        public void UpdateRoom(RoomModel room)
        {
            var roomModel = CustomMapper.GetInstance().Map<Room>(room);
            _roomRepository.Update(roomModel);
        }

        public void InsertRoom(RoomModel room)
        {
            var roomModel = CustomMapper.GetInstance().Map<Room>(room);
            _roomRepository.Add(roomModel);
        }

        //public void AddItemOrder(int id, Order order, DateTime startDate, DateTime endDate, decimal price)
        //{

        //    var _entity = _repository.GetById(id);

        //    _itemOrder = new RoomOrder { Room = _entity, Order = order, StartDate = startDate, EndDate = endDate };

        //    _orderRepository.Add(_itemOrder);
        //}

        public int AddItemOrder(ItemModel bookingItem)
        {
            var _entity = _roomRepository.GetById(bookingItem.Id);

            BookingItemModel bookingItemModel = (BookingItemModel)bookingItem;

            _itemOrder = new RoomOrder { Room = _entity, Order = bookingItem.Order, StartDate = bookingItemModel.StartDate, EndDate = bookingItemModel.EndDate };

            return _orderRepository.Add(_itemOrder);
        }

        public int AddItemOrder(BookingItemModel bookingItem)
        {
            var _entity = _roomRepository.GetById(bookingItem.Id);

            _itemOrder = new RoomOrder { Room = _entity, Order = bookingItem.Order, StartDate = bookingItem.StartDate, EndDate = bookingItem.EndDate };

            return _orderRepository.Add(_itemOrder);
        }
    }
}
