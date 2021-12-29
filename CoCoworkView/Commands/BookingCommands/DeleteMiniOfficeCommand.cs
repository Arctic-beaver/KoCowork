using CoCowork.BusinessLayer.Models;
using CoCowork.BusinessLayer.Services;
using CoCowork.UI.ViewModels;

namespace CoCowork.UI.Commands.BookingCommands
{
    public class DeleteMiniOfficeCommand : CommandBase
    {
        private readonly BookingViewModel _vm;
        private readonly MiniOfficeService _service;

        public DeleteMiniOfficeCommand(BookingViewModel vm, MiniOfficeService service)
        {
            _vm = vm;
            _service = service;
        }

        public override void Execute(object parameter)
        {
            if (_vm.BookingSelectedItem is MiniOfficeModel)
            {
                var miniOffice = (MiniOfficeModel)_vm.BookingSelectedItem;
                _service.DeleteMiniOffice(miniOffice.Id);
                _vm.MiniOffices.Remove(miniOffice);
            }
        }
    }
}
