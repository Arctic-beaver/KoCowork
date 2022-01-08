using CoCowork.UI.ViewModels;
using System.Windows;

namespace CoCowork.UI.Commands
{
    public class VisibilityOfInnerGridCommand : CommandBase
    {
        private readonly InnerGridViewModel _viewModel;
        public VisibilityOfInnerGridCommand(InnerGridViewModel vm)
        {
            _viewModel = vm;
        }

        public override void Execute(object parameter)
        {
            if (_viewModel.MustBeCollapsed)
            {
                _viewModel.GridVisibility = Visibility.Collapsed;
                _viewModel.MustBeCollapsed = false;
            }
            else
            {
                _viewModel.GridVisibility = Visibility.Visible;
                _viewModel.MustBeCollapsed = true;
            }
        }
    }
}
