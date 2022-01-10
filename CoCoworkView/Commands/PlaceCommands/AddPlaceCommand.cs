using CoCowork.BusinessLayer.Models;
using CoCowork.BusinessLayer.Services;
using CoCowork.UI.ViewModels;
using System.Linq;
using System.Windows;

namespace CoCowork.UI.Commands.BookingCommands
{
    public class AddPlaceCommand : CommandBase
    {
        private readonly PlaceViewModel _placeVM;
        private readonly BookingViewModel _bookingVM;
        private readonly PlaceService _service;

        public AddPlaceCommand(PlaceViewModel placeVM, BookingViewModel bookingVM, PlaceService service)
        {
            _placeVM = placeVM;
            _bookingVM = bookingVM;
            _service = service;
        }

        public override void Execute(object parameter)
        {
            var allPlaces = _service.GetAll();

            if (allPlaces.Any(mo => mo.Number == _placeVM.Number))
            {
                MessageBox.Show("Место с таким номером уже существует");
                return;
            }

            var place = new PlaceModel()
            {
                Number = _placeVM.Number,
                PricePerDay = _placeVM.PricePerDay,
                PriceFixedPerDay = _placeVM.PriceFixedPerDay,
                Description = _placeVM.Description
            };

            int insertedPlaceId = _service.InsertPlace(place);

            if (insertedPlaceId == -1)
            {
                MessageBox.Show("Ошибка при записи в базу данных", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            else
            {
                place.Id = insertedPlaceId;
                _bookingVM.Places.Add(place);
                _placeVM.GridVisibility = Visibility.Collapsed;
            }
        }
    }
}

