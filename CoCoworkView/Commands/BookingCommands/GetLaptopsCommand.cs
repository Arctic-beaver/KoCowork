using CoCowork.BusinessLayer.Models;
using CoCowork.BusinessLayer.Services;
using CoCowork.UI.ViewModels;
using System;
using System.Collections.ObjectModel;

namespace CoCowork.UI.Commands.BookingCommands
{
    public class GetLaptopsCommand : CommandBase
    {
        private readonly BookingViewModel _vm;
        private readonly LaptopService _computerService;

        public GetLaptopsCommand(BookingViewModel vm, LaptopService computerService)
        {
            _vm = vm;
            _computerService = computerService;
        }

        public override void Execute(object parameter)
        {
            //_vm.Computers = new ObservableCollection<ComputerModel>(_computerService.GetAll());

            var computers = _computerService.GetAll();

            foreach (var item in computers)
            {
                _vm.Computers.Add(item);
            }
        }
    }
}
