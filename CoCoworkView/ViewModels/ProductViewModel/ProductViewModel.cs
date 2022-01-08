using CoCowork.BusinessLayer.Models;
using CoCowork.BusinessLayer.Services;
using CoCowork.UI.Commands;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;

namespace CoCowork.UI.ViewModels
{
    public class ProductViewModel : TabViewModel
    {
        private bool _productsInStock;
        private bool _isEditButtonAvailable;
        private ProductModel _selectedProduct;




        private readonly ProductService _productService; 
       

        public ProductViewModel()
        {
            GridVisibility = Visibility.Hidden;

            _productService = new ProductService();
            AddNewProductViewModel = new AddNewProductViewModel();
            EditProductViewModel = new EditProductViewModel();

            Products = new ObservableCollection<ProductModel>();

            GetProductsCommand = new GetProductsCommand(this, _productService);
            AddNewProduct = new AddNewProductCommand (AddNewProductViewModel, this, _productService);
            EditProduct = new EditProductsCommand(EditProductViewModel, this, _productService);
            
        }

        public ProductModel SelectedProduct
        {
            get => _selectedProduct;
            set
            {
                if (value != _selectedProduct)
                {
                    _selectedProduct = value;
                    OnPropertyChanged(nameof(SelectedProduct));

                    IsEditButtonAvailable = (value != null);

                }
            }
        }

        public bool IsEditButtonAvailable
        {
            get => _isEditButtonAvailable;
            set
            {
                if (value != _isEditButtonAvailable)
                {
                    _isEditButtonAvailable = value;
                    OnPropertyChanged(nameof(IsEditButtonAvailable));

                }
            }
        }

        public ObservableCollection<ProductModel> Products { get; set; }

        public bool ProductsInStock
        {
            get => _productsInStock;
            set
            {
                if (value != _productsInStock)
                {
                    _productsInStock = value;
                    OnPropertyChanged(nameof(ProductsInStock));
                    GetProductsCommand.Execute(this);
                }
            }
        }

        public AddNewProductViewModel AddNewProductViewModel { get; set; }

        public EditProductViewModel EditProductViewModel { get; set; }


        public ICommand GetProductsCommand { get; set; }

        public ICommand AddNewProduct { get; set; }

        public ICommand EditProduct { get; set; }

        public ICommand FillProductFields { get; set; }

        






    }
}

