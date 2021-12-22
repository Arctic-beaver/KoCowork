using CoCowork.BusinessLayer.Services;
using CoCowork.UI.ViewModels;
using System;

namespace CoCowork.UI.Commands.BookingCommands
{
    public class DeletePlaceCommand : CommandBase
    {
        private BookingViewModel _vm;
        private PlaceService _placeService;

        public DeletePlaceCommand(BookingViewModel vm, PlaceService placeService)
        {
            _vm = vm;
            _placeService = placeService;
        }

        public override void Execute(object parameter)
        {
            throw new NotImplementedException();
        }
    }
}
