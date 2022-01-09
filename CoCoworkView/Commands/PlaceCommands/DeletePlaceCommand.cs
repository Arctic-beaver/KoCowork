using CoCowork.BusinessLayer.Services;
using CoCowork.UI.ViewModels;
using System.Windows;

namespace CoCowork.UI.Commands.BookingCommands
{
    public class DeletePlaceCommand : CommandBase
    {
        private readonly BookingViewModel _bookingVM;
        private readonly PlaceViewModel _placeVM;
        private readonly PlaceService _service;

        public DeletePlaceCommand(PlaceViewModel PlaceVM, BookingViewModel bookingVM, PlaceService service)
        {
            _bookingVM = bookingVM;
            _placeVM = PlaceVM;
            _service = service;
        }

        public override void Execute(object parameter)
        {
            bool result = _service.DeletePlace(_placeVM.SelectedPlace.Id);
            var userAnswer = MessageBox.Show("Вы действительно хотите удалить выбранное место?", "Удаление", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (userAnswer == MessageBoxResult.Yes)
            {
                if (result)
                {
                    _bookingVM.Places.Remove(_placeVM.SelectedPlace);
                    _placeVM.GridVisibility = Visibility.Collapsed;
                }
                else
                {
                    MessageBox.Show("Ошибка при удалении из базы данных", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
    }
}

