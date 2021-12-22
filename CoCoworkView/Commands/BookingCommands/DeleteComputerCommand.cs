using CoCowork.BusinessLayer.Services;
using CoCowork.UI.ViewModels;

namespace CoCowork.UI.Commands.BookingCommands
{
    public class DeleteComputerCommand : CommandBase
    {
        private BookingViewModel _vm;
        private ComputerService _computerService;

        public DeleteComputerCommand(BookingViewModel vm, ComputerService computerService)
        {
            _vm = vm;
            _computerService = computerService;
        }

        public override void Execute(object parameter)
        {

        }
    }
}
