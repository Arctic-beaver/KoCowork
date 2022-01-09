using CoCowork.BusinessLayer.Models;
using CoCowork.BusinessLayer.Services;
using CoCowork.UI.ViewModels;
using System.Windows;

namespace CoCowork.UI.Commands.MiniOfficeCommands
{
    public class EditLaptopCommand : CommandBase
    {
        private readonly LaptopViewModel _laptopVM;
        private readonly BookingViewModel _bookingVM;
        private readonly LaptopService _service;

        public EditLaptopCommand(LaptopViewModel laptopVM, BookingViewModel bookingVM, LaptopService service)
        {
            _laptopVM = laptopVM;
            _bookingVM = bookingVM;
            _service = service;
        }

        public override void Execute(object parameter)
        {
            var userAnswer = MessageBox.Show("Вы действительно хотите редактировать выбранное место?", "Редактирование", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (userAnswer == MessageBoxResult.Yes)
            {
                var laptop = new LaptopModel()
                {
                    Id = _laptopVM.SelectedLaptop.Id,
                    Number = _laptopVM.Number,
                    PricePerMonth = _laptopVM.PricePerMonth,
                    Description = _laptopVM.Description
                };
                _service.Update(laptop);
                _bookingVM.Laptops.Remove(_laptopVM.SelectedLaptop);
                _bookingVM.Laptops.Add(laptop);
                _laptopVM.GridVisibility = Visibility.Collapsed;
            }
        }
    }
}

