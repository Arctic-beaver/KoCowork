using CoCowork.BusinessLayer.Models;
using CoCowork.DataLayer.Entities;
using CoCowork.DataLayer.Repositories;
using PseudoCalc.BusinessLayer.Configuration;
using System.Collections.Generic;

namespace CoCowork.BusinessLayer.Services
{
    public class RoomService
    {
        private readonly RoomRepository _roomRepository;

        public RoomService()
        {
            _roomRepository = new RoomRepository();
        }

        public List<RoomModel> GetAll()
        {
            var Rooms = _roomRepository.GetAll();
            return CustomMapper.GetInstance().Map<List<RoomModel>>(Rooms);
        }

        public Room ConvertModelToEntities(RoomModel Room)
        {
            return CustomMapper.GetInstance().Map<Room>(Room);
        }
    }
}
