using CoCowork.BusinessLayer.Services;
using CoCowork.UI.ViewModels;
using System;

namespace CoCowork.UI.Commands.BookingCommands
{
    public class GetPlacesCommand : CommandBase
    {
        private BookingViewModel _vm;
        private PlaceService _placeService;
        public GetPlacesCommand(BookingViewModel vm, PlaceService placeService)
        {
            _vm = vm;
            _placeService = placeService;
            Execute(vm);
        }

        public override void Execute(object parameter)
        {
            var miniOffices = _placeService.GetAll();

            foreach (var item in miniOffices)
            {
                _vm.Places.Add(item);
            }
        }
    }
}
