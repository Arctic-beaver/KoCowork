using CoCowork.BusinessLayer.Models;
using CoCowork.UI.ViewModels;

namespace CoCowork.UI.Commands.MiniOfficeCommands
{
    public class CheckBookingSelectedItemCommand : CommandBase
    {
        private readonly MiniOfficeViewModel _miniOfficeVM;
        private readonly BookingViewModel _bookingVM;

        public CheckBookingSelectedItemCommand(MiniOfficeViewModel miniOfficeVM, BookingViewModel bookingVM)
        {
            _miniOfficeVM = miniOfficeVM;
            _bookingVM = bookingVM;
        }

        public override void Execute(object parameter)
        {
            _miniOfficeVM.SelectedMiniOffice = (MiniOfficeModel)_bookingVM.BookingSelectedItem;
        }
    }
}
