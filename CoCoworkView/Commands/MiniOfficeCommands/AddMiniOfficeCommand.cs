using CoCowork.BusinessLayer.Configuration;
using CoCowork.BusinessLayer.Models;
using CoCowork.BusinessLayer.Services;
using CoCowork.UI.ViewModels;
using System.Collections.Generic;
using System.Linq;
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
            if (_bookingVM.MiniOffices.Any(mo => mo.Name == _miniOfficeVM.Name.Trim()))
            {
                MessageBox.Show("Миниофис с таким описанием уже существует");
                return;
            }
            List<PlaceModel> places = new List<PlaceModel>();

            for (int i = 0; i < _miniOfficeVM.AmountOfPlaces; i++)
            {
                places.Add(new PlaceModel
                {
                    PricePerDay = _miniOfficeVM.PlacePricePerDay,
                    PriceFixedPerDay = _miniOfficeVM.PlacePriceFixedPerDay,
                    Description = _miniOfficeVM.Name.Trim()
                });
            }

            var miniOffice = new MiniOfficeModel()
            {
                Name = _miniOfficeVM.Name.Trim(),
                PricePerDay = _miniOfficeVM.PricePerDay,
                AmountOfPlaces = _miniOfficeVM.AmountOfPlaces,
                IsActive = true,
                Places = places
            };

            int insertedMiniOfficeId = _service.InsertMiniOfficeWithPlaces(miniOffice);
            miniOffice.Id = insertedMiniOfficeId;
            _bookingVM.MiniOffices.Add(miniOffice);
            _miniOfficeVM.GridVisibility = Visibility.Collapsed;
        }
    }
}
