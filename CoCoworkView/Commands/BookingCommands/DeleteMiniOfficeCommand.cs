using CoCowork.BusinessLayer.Services;
using CoCowork.UI.ViewModels;

namespace CoCowork.UI.Commands
{
    public class DeleteMiniOfficeCommand : CommandBase
    {
        private BookingViewModel _vm;
        private MiniOfficeService _miniOfficeService;

        public DeleteMiniOfficeCommand(BookingViewModel vm, MiniOfficeService miniOfficeService)
        {
            _vm = vm;
            _miniOfficeService = miniOfficeService;
            Execute(vm);
        }

        public override void Execute(object parameter)
        {
            if (_vm.MiniOfficeSelectedItem is null)
            {
                return;
            }
            else
            {
                var miniOfficeId = _vm.MiniOfficeSelectedItem.Id;
                _miniOfficeService.DeleteMiniOffice(miniOfficeId);
                _vm.MiniOffices.Remove(_vm.MiniOfficeSelectedItem);
            }
        }
    }
}
