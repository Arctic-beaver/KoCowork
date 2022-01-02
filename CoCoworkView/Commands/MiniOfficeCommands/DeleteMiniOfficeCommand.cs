using CoCowork.BusinessLayer.Services;
using CoCowork.UI.ViewModels;

namespace CoCowork.UI.Commands.BookingCommands
{
    public class DeleteMiniOfficeCommand : CommandBase
    {
        private readonly BookingViewModel _bookingVM;
        private readonly MiniOfficeViewModel _miniOfficeVM;
        private readonly MiniOfficeService _service;

        public DeleteMiniOfficeCommand(MiniOfficeViewModel miniOfficeVM, BookingViewModel bookingVM, MiniOfficeService service)
        {
            _bookingVM = bookingVM;
            _miniOfficeVM = miniOfficeVM;
            _service = service;
        }

        public override void Execute(object parameter)
        {
            //var miniOffice = _miniOfficeVM.SelectedItem;
            _service.DeleteMiniOffice(_miniOfficeVM.SelectedItem.Id);
            _bookingVM.MiniOffices.Remove(_miniOfficeVM.SelectedItem);
        }
    }
}
