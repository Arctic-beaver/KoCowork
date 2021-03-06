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
            if (_miniOfficeVM.SelectedMiniOffice is null)
            {
                MessageBox.Show("Выберите миниофис для редактирования");
                return;
            }

            var userAnswer = MessageBox.Show("Вы действительно хотите редактировать выбранный миниофис?", "Редактирование", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (userAnswer == MessageBoxResult.Yes)
            {
                var miniOffice = new MiniOfficeModel()
                {
                    Id = _miniOfficeVM.SelectedMiniOffice.Id,
                    Name = _miniOfficeVM.Name,
                    PricePerDay = _miniOfficeVM.PricePerDay,
                    AmountOfPlaces = _miniOfficeVM.AmountOfPlaces,
                    IsActive = true
                };
                _service.UpdateMiniOffice(miniOffice);
                _bookingVM.MiniOffices.Remove(_miniOfficeVM.SelectedMiniOffice);
                _bookingVM.MiniOffices.Add(miniOffice);
                _miniOfficeVM.GridVisibility = Visibility.Collapsed;
            }
        }
    }
}
