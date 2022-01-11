using CoCowork.BusinessLayer.Models;
using CoCowork.BusinessLayer.Services;
using CoCowork.UI.ViewModels;
using System.Linq;
using System.Windows;

namespace CoCowork.UI.Commands
{
    public class AddNewProductCommand : CommandBase
    {
        private readonly AddNewProductViewModel _addProductVM;
        private readonly ProductViewModel _productVM;
        private readonly ProductService _productService;

        public AddNewProductCommand(AddNewProductViewModel addProductViewModel, ProductViewModel productViewModel, ProductService productService)
        {
            _addProductVM = addProductViewModel;
            _productVM = productViewModel;
            _productService = productService;
        }

        public override void Execute(object parameter)
        {
            if (_productVM.Products.Any(product => product.Name == _addProductVM.Name.Trim()))
            {
                MessageBox.Show("Продукт с таким именем уже существует");
                return;
            }

            ProductModel product = new ProductModel
            {
                Name = _addProductVM.Name,
                PriceForOne = _addProductVM.PriceForOne,
                Amount = _addProductVM.Amount,
                Description = _addProductVM.Description
            };
            _productService.AddProduct(product);
            _productVM.Products.Add(product);
            _addProductVM.Name = null;
            _addProductVM.PriceForOne = 0;
            _addProductVM.Amount = 0;
            _addProductVM.Description = null;


        }
    }
}
