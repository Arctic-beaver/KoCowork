using CoCowork.BusinessLayer.Services;
using CoCowork.UI.ViewModels;

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
            if (_viewModel.ProductsInStock is true)
            {
                //_viewModel.Products = new ObservableCollection<ProductModel>(_productService.GetProductsInStock());
                var products = _productService.GetProductsInStock();

                foreach (var item in products)
                {
                    _viewModel.Products.Add(item);
                }


            }
            else
            {
                //_viewModel.Products = new ObservableCollection<ProductModel>(_productService.GetAll());
                var products = _productService.GetAll();

                foreach (var item in products)
                {
                    _viewModel.Products.Add(item);
                }

            }



        }
    }
}
