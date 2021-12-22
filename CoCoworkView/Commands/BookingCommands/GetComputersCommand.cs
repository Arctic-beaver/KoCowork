using CoCowork.BusinessLayer.Services;
using CoCowork.UI.ViewModels;
using System;

namespace CoCowork.UI.Commands.BookingCommands
{
    public class GetComputersCommand : CommandBase
    {
        private BookingViewModel _vm;
        private ComputerService _computerService;

        public GetComputersCommand(BookingViewModel vm, ComputerService computerService)
        {
            _vm = vm;
            _computerService = computerService;
            Execute(vm);
        }

        public override void Execute(object parameter)
        {
            var computers = _computerService.GetAll();

            foreach (var item in computers)
            {
                _vm.Computers.Add(item);
            }
        }
    }
}
