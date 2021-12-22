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
            //_vm = vm;
            //_miniOfficeService = miniOfficeService;

            if (vm.MiniOfficeSelectedItem is null)
            {
                return;
            }
            else
            {
                var miniOfficeId = vm.MiniOfficeSelectedItem.Id;
                miniOfficeService.DeleteMiniOffice(miniOfficeId);
                vm.MiniOffices.Remove(vm.MiniOfficeSelectedItem);
            }
        }

        public override void Execute(object parameter)
        {


        }
    }
}
