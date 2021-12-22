using CoCowork.BusinessLayer.Services;
using CoCowork.UI.ViewModels;
using System;

namespace CoCowork.UI.Commands.BookingCommands
{
    public class GetConferenceRoomsCommand : CommandBase
    {
        private BookingViewModel _vm;
        private RoomService _roomService;

        public GetConferenceRoomsCommand(BookingViewModel vm, RoomService roomService)
        {
            _vm = vm;
            _roomService = roomService;
        }

        public override void Execute(object parameter)
        {
            throw new NotImplementedException();
        }
    }
}
