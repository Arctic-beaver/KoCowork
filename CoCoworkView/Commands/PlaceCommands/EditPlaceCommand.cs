using CoCowork.BusinessLayer.Models;
using CoCowork.BusinessLayer.Services;
using CoCowork.UI.ViewModels;
using System.Windows;

namespace CoCowork.UI.Commands.MiniOfficeCommands
{
    public class EditPlaceCommand : CommandBase
    {
        private readonly PlaceViewModel _placeVM;
        private readonly BookingViewModel _bookingVM;
        private readonly PlaceService _service;

        public EditPlaceCommand(PlaceViewModel placeVM, BookingViewModel bookingVM, PlaceService service)
        {
            _placeVM = placeVM;
            _bookingVM = bookingVM;
            _service = service;
        }

        public override void Execute(object parameter)
        {
            var userAnswer = MessageBox.Show("Вы действительно хотите редактировать выбранное место?", "Редактирование", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (userAnswer == MessageBoxResult.Yes)
            {
                var place = new PlaceModel()
                {
                    Id = _placeVM.SelectedPlace.Id,
                    Number = _placeVM.Number,
                    PricePerDay = _placeVM.PricePerDay,
                    PriceFixedPerDay = _placeVM.PriceFixedPerDay,
                    Description = _placeVM.Description
                };
                _service.UpdatePlace(place);
                _bookingVM.Places.Remove(_placeVM.SelectedPlace);
                _bookingVM.Places.Add(place);
                _placeVM.GridVisibility = Visibility.Collapsed;
            }
        }
    }
}

