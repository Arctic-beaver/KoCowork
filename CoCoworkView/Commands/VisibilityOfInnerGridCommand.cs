using CoCowork.UI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CoCowork.UI.Commands
{
    class VisibilityOfInnerGridCommand : CommandBase
    {
        private readonly PaymentViewModel _viewModel;
        public VisibilityOfInnerGridCommand(PaymentViewModel vm)
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
