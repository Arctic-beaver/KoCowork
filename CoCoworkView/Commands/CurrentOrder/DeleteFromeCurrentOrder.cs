using CoCowork.UI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoCowork.UI.Commands.CurrentOrder
{
    public class DeleteFromeCurrentOrder : CommandBase
    {
        private readonly CurrentOrderViewModel _vm;

        public DeleteFromeCurrentOrder(CurrentOrderViewModel vm)
        {
            _vm = vm;
            


        }

        public override void Execute(object parameter)
        {
            _vm.CurrentOrder.Remove(_vm.SelectedItemOrder);
        }
    }
}
