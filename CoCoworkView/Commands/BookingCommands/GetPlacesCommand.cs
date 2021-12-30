using CoCowork.BusinessLayer.Services;
using CoCowork.UI.ViewModels;

namespace CoCowork.UI.Commands.BookingCommands
{
    public class GetPlacesCommand : CommandBase
    {
        private readonly BookingViewModel _vm;
        private readonly PlaceService _placeService;

        public GetPlacesCommand(BookingViewModel vm, PlaceService placeService)
        {
            _vm = vm;
            _placeService = placeService;
        }

        public override void Execute(object parameter)
        {
            var places = _placeService.GetAll();

            foreach (var item in places)
            {
                _vm.Places.Add(item);
            }
        }
    }
}
