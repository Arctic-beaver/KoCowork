using CoCowork.BusinessLayer.Models;
using CoCowork.BusinessLayer.Services;
using CoCowork.UI.Commands;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;

namespace CoCowork.UI.ViewModels
{
    public class ProductViewModel : InnerGridViewModel
    {
        private bool _productsInStock;
        private ProductModel _selectedItem;
        
        private readonly ProductService _productService; 
       

        public ProductViewModel()
        {
            GridVisibility = Visibility.Hidden;
            _productService = new ProductService();
            AddNewProductViewModel = new AddNewProductViewModel();
            Products = new ObservableCollection<ProductModel>();
            GetProductsCommand = new GetProductsCommand(this, _productService);
            AddNewProduct = new AddNewProductCommand (AddNewProductViewModel, this, _productService);
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

        public ProductModel SelectedItem
        {
            get => _selectedItem;
            set
            {
                if(value != _selectedItem)
                {
                    _selectedItem = value;
                    OnPropertyChanged(nameof(SelectedItem));
                    
                }
            }
        }

        public AddNewProductViewModel AddNewProductViewModel { get; set; }  

        public ICommand GetProductsCommand { get; set; }

        public ICommand AddNewProduct { get; set; }






    }
}

