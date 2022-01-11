using CoCowork.UI.ViewModels;

namespace CoCowork.UI.Commands
{
    public class FillProductFieldsCommand : CommandBase
    {

        private readonly EditProductViewModel _editProductVM;
        private readonly ProductViewModel _productVM;

        public FillProductFieldsCommand(EditProductViewModel editProductVM, ProductViewModel productVM)
        {
            _editProductVM = editProductVM;
            _productVM = productVM;
        }

        public override void Execute(object parameter)
        {
            _editProductVM.Name = _productVM.SelectedProduct.Name;
            _editProductVM.Description = _productVM.SelectedProduct.Description;
            _editProductVM.Amount = _productVM.SelectedProduct.Amount;
            _editProductVM.PriceForOne = _productVM.SelectedProduct.Price;
        }
    }
}
