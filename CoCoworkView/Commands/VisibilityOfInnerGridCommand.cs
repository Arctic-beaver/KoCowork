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
        public VisibilityOfInnerGridCommand()
        {
           
        }

        public override void Execute(object parameter)
        {
            InnerGridViewModel vm = (InnerGridViewModel)parameter;
            if (vm.MustBeCollapsed)
            {
                vm.GridVisibility = Visibility.Collapsed;
                vm.MustBeCollapsed = false;
            }
            else
            {
                vm.GridVisibility = Visibility.Visible;
                vm.MustBeCollapsed = true;
            }
        }
    }
}
