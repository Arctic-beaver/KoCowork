using CoCowork.BusinessLayer.Services;
using CoCowork.UI.ViewModels;

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
            var conferenceRooms = _roomService.GetConferenceRooms();

            foreach (var item in conferenceRooms)
            {
                _vm.ConferenceRooms.Add(item);
            }
        }
    }
}
