using CoCowork.BusinessLayer.Models;
using CoCowork.UI.ViewModels;

namespace CoCowork.UI.Commands.MiniOfficeCommands
{
    public class FillPlaceFieldsCommand : CommandBase
    {
        private readonly PlaceViewModel _vm;
        private readonly BookingViewModel _bookingVM;

        public FillPlaceFieldsCommand(PlaceViewModel vm, BookingViewModel bookingVM)
        {
            _vm = vm;
            _bookingVM = bookingVM;
        }
        public override void Execute(object parameter)
        {
            _vm.SelectedPlace = (PlaceModel)_bookingVM.BookingSelectedItem;
            _vm.Number = _vm.SelectedPlace.Number;
            _vm.PricePerDay = _vm.SelectedPlace.PricePerDay;
            _vm.PriceFixedPerDay = _vm.SelectedPlace.PriceFixedPerDay;
            _vm.Description = _vm.SelectedPlace.Description;
        }
    }
}
