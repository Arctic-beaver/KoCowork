using CoCowork.BusinessLayer.Models;
using CoCowork.BusinessLayer.Services;
using CoCowork.UI.ViewModels;
using System.Windows;

namespace CoCowork.UI.Commands.BookingCommands
{
    public class DeleteMiniOfficeCommand : CommandBase
    {
        private readonly BookingViewModel _bookingVM;
        private readonly MiniOfficeViewModel _miniOfficeVM;
        private readonly MiniOfficeService _service;

        public DeleteMiniOfficeCommand(MiniOfficeViewModel miniOfficeVM, BookingViewModel bookingVM, MiniOfficeService service)
        {
            _bookingVM = bookingVM;
            _miniOfficeVM = miniOfficeVM;
            _service = service;
        }

        public override void Execute(object parameter)
        {
            if (_bookingVM.BookingSelectedItem is MiniOfficeModel)
            {
                MiniOfficeModel selectedMiniOffice = (MiniOfficeModel)_bookingVM.BookingSelectedItem;
                bool result = _service.DeleteMiniOffice(selectedMiniOffice);
                var userAnswer = MessageBox.Show("Вы действительно хотите удалить выбранный миниофис?", "Удаление", MessageBoxButton.YesNo, MessageBoxImage.Question);

                if (userAnswer == MessageBoxResult.Yes)
                {
                    if (result)
                    {
                        _bookingVM.MiniOffices.Remove(selectedMiniOffice);
                        _miniOfficeVM.GridVisibility = Visibility.Collapsed;
                    }
                    else
                    {
                        MessageBox.Show("Ошибка при удалении из базы данных", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
            }
        }
    }
}
