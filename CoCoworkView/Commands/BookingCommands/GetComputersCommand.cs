using CoCowork.BusinessLayer.Services;
using CoCowork.UI.ViewModels;
using System;

namespace CoCowork.UI.Commands.BookingCommands
{
    public class GetComputersCommand : CommandBase
    {
        public GetComputersCommand(BookingViewModel vm, ComputerService computerService)
        {
            var computers = computerService.GetAll();

            foreach (var item in computers)
            {
                vm.Computers.Add(item);
            }
        }

        public override void Execute(object parameter)
        {
            throw new NotImplementedException();
        }
    }
}
