using CoCowork.BusinessLayer.Services;
using CoCowork.UI.ViewModels;
using System;

namespace CoCowork.UI.Commands
{
    public class DeleteBookingCommand : CommandBase
    {
        public DeleteBookingCommand(BookingViewModel vm, MiniOfficeService service)
        {
            //service.DeleteMiniOffice();
            //vm.MiniOffices.Remove(vm.MiniOfficeSelectedItem);
        }

        public override void Execute(object parameter)
        {
            throw new NotImplementedException();
        }
    }
}
