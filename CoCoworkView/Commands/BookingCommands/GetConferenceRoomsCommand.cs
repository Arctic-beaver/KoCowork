using CoCowork.BusinessLayer.Services;
using CoCowork.UI.ViewModels;
using System;

namespace CoCowork.UI.Commands.BookingCommands
{
    public class GetConferenceRoomsCommand : CommandBase
    {
        private readonly BookingViewModel _vm;
        private readonly RoomService _roomService;

        public GetConferenceRoomsCommand(BookingViewModel vm, RoomService roomService)
        {
            _vm = vm;
            _roomService = roomService;
        }

        public override void Execute(object parameter)
        {
            var rooms = _roomService.GetAll();

            foreach (var item in rooms)
            {
                if (item.Type == "Конференц-зал")
                {
                    _vm.ConferenceRooms.Add(item);
                }
            }
        }
    }
}
