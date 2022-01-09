using CoCowork.UI.ViewModels;

namespace CoCowork.UI.Commands.MiniOfficeCommands
{
    public class FillLaptopFieldsCommand : CommandBase
    {
        private readonly LaptopViewModel _vm;

        public FillLaptopFieldsCommand(LaptopViewModel vm)
        {
            _vm = vm;
        }
        public override void Execute(object parameter)
        {
            _vm.Name = _vm.SelectedLaptop.Name;
            _vm.Number = _vm.SelectedLaptop.Number;
            _vm.PricePerMonth = _vm.SelectedLaptop.PricePerMonth;
            _vm.Description = _vm.SelectedLaptop.Description;
        }
    }
}
