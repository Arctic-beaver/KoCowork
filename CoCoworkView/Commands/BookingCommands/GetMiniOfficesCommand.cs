using CoCowork.BusinessLayer.Services;
using CoCowork.UI.ViewModels;

namespace CoCowork.UI.Commands.BookingCommands
{
    public class GetMiniOfficesCommand : CommandBase
    {
        private readonly BookingViewModel _vm;
        private readonly MiniOfficeService _miniOfficeService;

        public GetMiniOfficesCommand(BookingViewModel vm, MiniOfficeService miniOfficeService)
        {
            _vm = vm;
            _miniOfficeService = miniOfficeService;
        }

        public override void Execute(object parameter)
        {
            var miniOffices = _miniOfficeService.GetAll();

            foreach (var item in miniOffices)
            {
                _vm.MiniOffices.Add(item);
            }
        }
    }
}
