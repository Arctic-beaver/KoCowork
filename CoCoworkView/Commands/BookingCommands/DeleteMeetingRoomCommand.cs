using CoCowork.BusinessLayer.Services;
using CoCowork.UI.ViewModels;

namespace CoCowork.UI.Commands.BookingCommands
{
    public class DeleteMeetingRoomCommand : CommandBase
    {
        private BookingViewModel _vm;
        private RoomService _roomService;

        public DeleteMeetingRoomCommand(BookingViewModel vm, RoomService roomService)
        {
            _vm = vm;
            _roomService = roomService;
        }

        public override void Execute(object parameter)
        {

        }
    }
}
