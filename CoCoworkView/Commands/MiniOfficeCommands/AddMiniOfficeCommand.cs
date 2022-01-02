using CoCowork.BusinessLayer.Models;
using CoCowork.BusinessLayer.Services;
using CoCowork.UI.ViewModels;
using System.Windows;

namespace CoCowork.UI.Commands.BookingCommands
{
    public class AddMiniOfficeCommand : CommandBase
    {
        private readonly MiniOfficeViewModel _miniOfficeVM;
        private readonly BookingViewModel _bookingVM;
        private readonly MiniOfficeService _service;

        public AddMiniOfficeCommand(MiniOfficeViewModel miniOfficeVM, BookingViewModel bookingVM, MiniOfficeService service)
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
                AmountOfPlaces = _miniOfficeVM.AmountOfPlaces,
                IsActive = true
            };
            var insertedMiniOfficeId = _service.InsertMiniOffice(miniOffice);
            miniOffice.Id = insertedMiniOfficeId;
            _bookingVM.MiniOffices.Add(miniOffice);
            _miniOfficeVM.GridVisibility = Visibility.Collapsed;
        }
    }
}
