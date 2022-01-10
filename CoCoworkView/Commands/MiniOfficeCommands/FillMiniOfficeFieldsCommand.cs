using CoCowork.BusinessLayer.Models;
using CoCowork.UI.ViewModels;

namespace CoCowork.UI.Commands.MiniOfficeCommands
{
    public class FillMiniOfficeFieldsCommand : CommandBase
    {
        private readonly MiniOfficeViewModel _vm;
        private readonly BookingViewModel _bookingVM;

        public FillMiniOfficeFieldsCommand(MiniOfficeViewModel vm, BookingViewModel bookingVM)
        {
            _vm = vm;
            _bookingVM = bookingVM;
        }
        public override void Execute(object parameter)
        {
            _vm.SelectedMiniOffice = (MiniOfficeModel)_bookingVM.BookingSelectedItem;
            _vm.Name = _vm.SelectedMiniOffice.Name;
            _vm.PricePerDay = _vm.SelectedMiniOffice.PricePerDay;
            _vm.AmountOfPlaces = _vm.SelectedMiniOffice.AmountOfPlaces;
        }
    }
}
