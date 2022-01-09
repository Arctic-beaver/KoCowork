using CoCowork.BusinessLayer.Services;
using CoCowork.UI.ViewModels;
using System.Windows;

namespace CoCowork.UI.Commands.ComputerCommands
{
    public class DeleteLaptopCommand : CommandBase
    {
        private readonly BookingViewModel _bookingVM;
        private readonly LaptopViewModel _laptopVM;
        private readonly LaptopService _service;

        public DeleteLaptopCommand(LaptopViewModel laptopVM, BookingViewModel bookingVM, LaptopService service)
        {
            _bookingVM = bookingVM;
            _laptopVM = laptopVM;
            _service = service;
        }

        public override void Execute(object parameter)
        {
            var userAnswer = MessageBox.Show("Вы действительно хотите удалить выбранный компьютер?", "Удаление", MessageBoxButton.YesNo, MessageBoxImage.Question);
            bool result = _service.Delete(_laptopVM.SelectedLaptop.Id);

            if (userAnswer == MessageBoxResult.Yes)
            {
                if (result)
                {
                    _bookingVM.Laptops.Remove(_laptopVM.SelectedLaptop);
                    _laptopVM.GridVisibility = Visibility.Collapsed;
                }
                else
                {
                    MessageBox.Show("Ошибка при удалении из базы данных", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
    }
}
