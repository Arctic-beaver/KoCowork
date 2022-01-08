using CoCowork.UI.ViewModels;

namespace CoCowork.UI.Commands.MiniOfficeCommands
{
    public class FillMiniOfficeFieldsCommand : CommandBase
    {
        private readonly MiniOfficeViewModel _vm;

        public FillMiniOfficeFieldsCommand(MiniOfficeViewModel vm)
        {
            _vm = vm;
        }
        public override void Execute(object parameter)
        {
            _vm.Name = _vm.SelectedMiniOffice.Name;
            _vm.PricePerDay = _vm.SelectedMiniOffice.PricePerDay;
            _vm.AmountOfPlaces = _vm.SelectedMiniOffice.AmountOfPlaces;
        }
    }
}
