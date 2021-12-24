using CoCowork.BusinessLayer.Configuration;
using CoCowork.BusinessLayer.Models;
using CoCowork.DataLayer.Repositories;
using System.Collections.Generic;

namespace CoCowork.BusinessLayer.Services
{
    public class MeetingRoomService
    {
        private readonly RoomRepository _roomRepository;

        public MeetingRoomService()
        {
            _roomRepository = new RoomRepository();
        }

        public List<RoomModel> GetAll()
        {
            var rooms = _roomRepository.GetAll();
            return CustomMapper.GetInstance().Map<List<RoomModel>>(rooms);
        }
    }
}
