using CoCowork.UI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoCowork.UI.Commands
{
    public class FillProductFieldsCommand : CommandBase
    {
        
        private readonly EditProductViewModel _editProductVM;

        public FillProductFieldsCommand(EditProductViewModel editProductVM)
        {
            _editProductVM = editProductVM;
        }

        public override void Execute(object parameter)
        {
            _editProductVM.Name = _editProductVM.SelectedProduct.Name;
            _editProductVM.Description = _editProductVM.SelectedProduct.Description;
            _editProductVM.Amount = _editProductVM.SelectedProduct.Amount;
            _editProductVM.PriceForOne = _editProductVM.SelectedProduct.PriceForOne; 
        }
    }
}
