using CoCowork.BusinessLayer.Models;
using CoCowork.DataLayer.Repositories;
using CoCowork.BusinessLayer.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoCowork.DataLayer.Entities;

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
            var rooms = _roomRepository.GetAll();
            return CustomMapper.GetInstance().Map<List<RoomModel>>(rooms);
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
    }
}
