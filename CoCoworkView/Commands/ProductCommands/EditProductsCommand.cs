using CoCowork.BusinessLayer.Models;
using CoCowork.BusinessLayer.Services;
using CoCowork.UI.ViewModels;
using System.Linq;
using System.Windows;

namespace CoCowork.UI.Commands
{
    public class EditProductsCommand : CommandBase
    {
        private readonly EditProductViewModel _editProductVM;
        private readonly ProductViewModel _productVM;
        private readonly ProductService _service;

        public EditProductsCommand(EditProductViewModel editProductVM, ProductViewModel productVM, ProductService productService)
        {
            _editProductVM = editProductVM;
            _productVM = productVM;
            _service = productService;
        }



        public override void Execute(object parameter)
        {
            if (_productVM.Products.Any(product => product.Name == _editProductVM.Name.Trim()))
            {
                MessageBox.Show("Продукт с таким именем уже существует");
                return;
            }

            var product = new ProductModel()
            {
                Id = _productVM.SelectedProduct.Id,
                Name = _editProductVM.Name,
                Price = _editProductVM.PriceForOne,
                Amount = _editProductVM.Amount,
                Description = _editProductVM.Description
            };
            _service.UpdateProduct(product);
            _productVM.Products.Remove(_productVM.SelectedProduct);
            _productVM.Products.Add(product);
            _editProductVM.GridVisibility = Visibility.Collapsed;

        }
    }
}
