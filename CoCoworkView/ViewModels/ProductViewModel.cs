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
        
        private string _name;
        private string _description;
        private int _amount;
        private decimal _priceForOne;
        private bool _productsInStock;
        private ProductModel _selectedItem;



        private readonly ProductService _productService; 
       

        public ProductViewModel()
        {
            GridVisibility = Visibility.Hidden;
            _productService = new ProductService();
            Products = new ObservableCollection<ProductModel>();
            GetProductsCommand = new GetProductsCommand(this, _productService);
            GetProductsCommand.Execute(Products);
            AddNewProduct = new AddNewProductViewModel();
        }

        public ObservableCollection<ProductModel> Products { get; set; }

        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        public int Amount
        {
            get => _amount;
            set
            {
                _amount = value;
                OnPropertyChanged(nameof(Amount));
            }
        }

        public decimal PriceForOne
        {
            get => _priceForOne;
            set
            {
                _priceForOne = value;
                OnPropertyChanged(nameof(PriceForOne));
            }
        }

        public string Description
        {
            get => _description;
            set
            {
                _description = value;
                OnPropertyChanged(nameof(Description));
            }
        }
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

        public AddNewProductViewModel AddNewProduct { get; set; }

        public ICommand GetProductsCommand { get; set; }

       




    }
}

