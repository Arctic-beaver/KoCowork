using CoCowork.BusinessLayer.Services;
using CoCowork.UI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoCowork.UI.Commands.BookingCommands
{
    public class GetMiniOfficesCommand : CommandBase
    {
        public GetMiniOfficesCommand(BookingViewModel vm, MiniOfficeService service)
        {
            //var miniOffices = service.GetAll();
            //foreach(var item in miniOffices)
            //{
            //    vm.MiniOffices.Add(item);
            //}
        }

        public override void Execute(object parameter)
        {
            throw new NotImplementedException();
        }
    }
}
