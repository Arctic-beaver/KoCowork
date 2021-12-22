using CoCowork.BusinessLayer.Models;
using CoCowork.BusinessLayer.Services;
using CoCowork.UI.ViewModels;
using System;
using System.Collections.ObjectModel;

namespace CoCowork.UI.Commands.BookingCommands
{
    public class GetMiniOfficesCommand : CommandBase
    {
        private BookingViewModel _vm;
        private MiniOfficeService _miniOfficeService;

        public GetMiniOfficesCommand(BookingViewModel vm, MiniOfficeService miniOfficeService)
        {
            _vm = vm;
            _miniOfficeService = miniOfficeService;
        }

        public override void Execute(object parameter)
        {
            _vm.MiniOffices = new ObservableCollection<MiniOfficeModel>(_miniOfficeService.GetAll());
        }
    }
}
