using CoCowork.BusinessLayer.Models;
using CoCowork.BusinessLayer.Services;
using CoCowork.UI.ViewModels;
using System.Linq;
using System.Windows;

namespace CoCowork.UI.Commands.LaptopCommands
{
    public class AddLaptopCommand : CommandBase
    {
        private readonly LaptopViewModel _laptopVM;
        private readonly BookingViewModel _bookingVM;
        private readonly LaptopService _service;

        public AddLaptopCommand(LaptopViewModel laptopVM, BookingViewModel bookingVM, LaptopService service)
        {
            _laptopVM = laptopVM;
            _bookingVM = bookingVM;
            _service = service;
        }

        public override void Execute(object parameter)
        {
            if (_bookingVM.Laptops.Any(mo => mo.Number == _laptopVM.Number))
            {
                MessageBox.Show("Компьютер с таким номером уже существует");
                return;
            }

            var laptop = new LaptopModel()
            {
                Number = _laptopVM.Number,
                PricePerMonth = _laptopVM.PricePerMonth,
                Description = _laptopVM.Description
            };

            int insertedLaptopId = _service.Insert(laptop);

            if (insertedLaptopId == -1)
            {
                MessageBox.Show("Ошибка при записи в базу данных", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            else
            {
                laptop.Id = insertedLaptopId;
                _bookingVM.Laptops.Add(laptop);
                _laptopVM.GridVisibility = Visibility.Collapsed;
            }
        }
    }
}
