using CoCowork.BusinessLayer.Models;
using CoCowork.BusinessLayer.Services;
using CoCowork.UI.ViewModels;
using System.Windows;

namespace CoCowork.UI.Commands.MiniOfficeCommands
{
    public class EditMiniOfficeCommand : CommandBase
    {
        private readonly MiniOfficeViewModel _miniOfficeVM;
        private readonly BookingViewModel _bookingVM;
        private readonly MiniOfficeService _service;

        public EditMiniOfficeCommand(MiniOfficeViewModel miniOfficeVM, BookingViewModel bookingVM, MiniOfficeService service)
        {
            _miniOfficeVM = miniOfficeVM;
            _bookingVM = bookingVM;
            _service = service;
        }

        public override void Execute(object parameter)
        {
            var miniOffice = new MiniOfficeModel()
            {
                Name = _miniOfficeVM.Name,
                PricePerDay = _miniOfficeVM.PricePerDay,
                AmountOfPlaces = _miniOfficeVM.AmountOfPlaces
            };
            _service.UpdateMiniOffice(miniOffice);
            _bookingVM.MiniOffices.Add(miniOffice);
            _miniOfficeVM.GridVisibility = Visibility.Collapsed;
        }
    }
}
