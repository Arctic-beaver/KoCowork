using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoCowork.BusinessLayer.Models
{
    public class RoomModel : ItemModel
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public BookingChecker BookingChecker { get; set; }
        public int AmountOfPeople { get; set; }
        public decimal PricePerHour { get; set; }
        public bool IsActive { get; set; }
        public string Description { get; set; }
        public RoomType RoomType { get; set; }

        public RoomModel()
        {
            AssignRoomType();
        }

        private void AssignRoomType()
        {
            if (Type == "Конференц-зал")
            {
                RoomType = RoomType.ConferenceRoom;
            }
            else if (Type == "Переговорная")
            {
                RoomType = RoomType.MeetingRoom;
            }
        }
    }
}
