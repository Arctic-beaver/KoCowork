using CoCowork.BusinessLayer.Models;
using CoCowork.UI.ViewModels;

namespace CoCowork.UI.Commands.MiniOfficeCommands
{
    public class FillLaptopFieldsCommand : CommandBase
    {
        private readonly LaptopViewModel _vm;
        private readonly BookingViewModel _bookingVM;

        public FillLaptopFieldsCommand(LaptopViewModel vm, BookingViewModel bookingVM)
        {
            _vm = vm;
            _bookingVM = bookingVM;
        }
        public override void Execute(object parameter)
        {
            _vm.SelectedLaptop = (LaptopModel)_bookingVM.BookingSelectedItem;
            _vm.Name = _vm.SelectedLaptop.Name;
            _vm.Number = _vm.SelectedLaptop.Number;
            _vm.PricePerMonth = _vm.SelectedLaptop.PricePerMonth;
            _vm.Description = _vm.SelectedLaptop.Description;
        }
    }
}
