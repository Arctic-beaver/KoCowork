using CoCowork.BusinessLayer.Models;
using System.Collections.Generic;

namespace CoCowork.BusinessLayer.Services
{
    public interface IRoomService
    {
        void DeleteRoom(int id);
        List<RoomModel> GetAll();
        List<RoomModel> GetConferenceRooms();
        List<RoomModel> GetMeetingRooms();
        void InsertRoom(RoomModel room);
        void UpdateRoom(RoomModel room);
    }
}