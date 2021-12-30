using CoCowork.BusinessLayer.Configuration;
using CoCowork.BusinessLayer.Models;
using CoCowork.DataLayer.Entities;
using CoCowork.DataLayer.Repositories;
using System.Collections.Generic;

namespace CoCowork.BusinessLayer.Services
{
    public class RoomService : IRoomService
    {
        private readonly IRoomRepository _roomRepository;
        private const string _meetingRoom = "Переговорная";
        private const string _conferenceRoom = "Конференц-зал";

        public RoomService()
        {
            _roomRepository = new RoomRepository();
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
    }
}
