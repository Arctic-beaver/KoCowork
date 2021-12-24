using CoCowork.BusinessLayer.Models;
using CoCowork.BusinessLayer.Services;
using CoCowork.UI.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoCowork.UI.Commands
{
    public class GetProductsCommand : CommandBase
    {
        private readonly ProductViewModel _viewModel;
        private readonly ProductService _productService;
        
        public GetProductsCommand(ProductViewModel vm, ProductService productService)
        {
            _viewModel = vm;
            _productService = productService;
            
        }

        public override void Execute(object obj)
        {
            if(_viewModel.ProductsInStock is true)
            {
                _viewModel.Products = new ObservableCollection<ProductModel>(_productService.GetProductsInStock());
                

            }
            else
            {
                _viewModel.Products = new ObservableCollection<ProductModel>(_productService.GetAll());
                //var products = _productService.GetAll();

                //foreach (var item in products)
                //{
                //    _viewModel.Products.Add(item);
                //}
 
            }



        }
    }
}
