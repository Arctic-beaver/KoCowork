using CoCowork.BusinessLayer.Services;
using CoCowork.UI.ViewModels;

namespace CoCowork.UI.Commands.BookingCommands
{
    public class GetLaptopsCommand : CommandBase
    {
        private readonly BookingViewModel _vm;
        private readonly LaptopService _laptopService;

        public GetLaptopsCommand(BookingViewModel vm, LaptopService laptopService)
        {
            _vm = vm;
            _laptopService = laptopService;
        }

        public override void Execute(object parameter)
        {
            //_vm.Computers = new ObservableCollection<ComputerModel>(_computerService.GetAll());

            var computers = _laptopService.GetAll();

            foreach (var item in computers)
            {
                _vm.Laptops.Add(item);
            }
        }
    }
}
