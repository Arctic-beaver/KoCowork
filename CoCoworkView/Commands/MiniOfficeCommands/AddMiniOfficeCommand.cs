using CoCowork.BusinessLayer.Models;
using CoCowork.BusinessLayer.Services;
using CoCowork.UI.ViewModels;
using System.Windows;

namespace CoCowork.UI.Commands.MiniOfficeCommands
{
    public class AddMiniOfficeCommand : CommandBase
    {
        private readonly MiniOfficeViewModel _vm;
        private readonly MiniOfficeService _service;

        public AddMiniOfficeCommand(MiniOfficeViewModel vm, MiniOfficeService service)
        {
            _vm = vm;
            _service = service;
        }

        public override void Execute(object parameter)
        {
            _vm.GridVisibility = Visibility.Collapsed;
            var miniOffice = new MiniOfficeModel()
            {
                Name = _vm.Name,
                PricePerDay = _vm.PricePerDay,
                AmountOfPlaces = _vm.AmountOfPlaces,
            };
            _service.InsertMiniOffice(miniOffice);

        }
    }
}
