using CoCowork.BusinessLayer.Services;
using CoCowork.UI.ViewModels;
using System;

namespace CoCowork.UI.Commands.BookingCommands
{
    public class GetMeetingRoomsCommand : CommandBase
    {
        private readonly BookingViewModel _vm;
        private readonly RoomService _roomService;

        public GetMeetingRoomsCommand(BookingViewModel vm, RoomService roomService)
        {
            _vm = vm;
            _roomService = roomService;
        }

        public override void Execute(object parameter)
        {
            var meetingRooms = _roomService.GetMeetingRooms();

            foreach (var item in meetingRooms)
            {
                _vm.MeetingRooms.Add(item);
            }
        }
    }
}
