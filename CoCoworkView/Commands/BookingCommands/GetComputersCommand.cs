using CoCowork.BusinessLayer.Services;
using CoCowork.UI.ViewModels;

namespace CoCowork.UI.Commands.BookingCommands
{
    public class GetComputersCommand : CommandBase
    {
        private readonly BookingViewModel _vm;
        private readonly LaptopService _computerService;

        public GetComputersCommand(BookingViewModel vm, LaptopService computerService)
        {
            _vm = vm;
            _computerService = computerService;
        }

        public override void Execute(object parameter)
        {
            var computers = _computerService.GetAll();

            foreach (var item in computers)
            {
                _vm.Laptops.Add(item);
            }
        }
    }
}
