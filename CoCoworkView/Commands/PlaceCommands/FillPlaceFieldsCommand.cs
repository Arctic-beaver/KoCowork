using CoCowork.UI.ViewModels;

namespace CoCowork.UI.Commands.MiniOfficeCommands
{
    public class FillPlaceFieldsCommand : CommandBase
    {
        private readonly PlaceViewModel _vm;

        public FillPlaceFieldsCommand(PlaceViewModel vm)
        {
            _vm = vm;
        }
        public override void Execute(object parameter)
        {
            _vm.Number = _vm.SelectedPlace.Number;
            _vm.PricePerDay = _vm.SelectedPlace.PricePerDay;
            _vm.PriceFixedPerDay = _vm.SelectedPlace.PriceFixedPerDay;
            _vm.Description = _vm.SelectedPlace.Description;
        }
    }
}
