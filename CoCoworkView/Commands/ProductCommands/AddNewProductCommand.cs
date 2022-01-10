using CoCowork.BusinessLayer.Models;
using CoCowork.BusinessLayer.Services;
using CoCowork.UI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            ProductModel product = new ProductModel
            {
                Name = _addProductVM.Name,
                Price = _addProductVM.PriceForOne,
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
