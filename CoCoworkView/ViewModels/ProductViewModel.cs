using CoCowork.BusinessLayer.Models;
using System.Collections.ObjectModel;
using System.Windows;

namespace CoCowork.UI.ViewModels
{
    public class ProductViewModel : TabViewModel
    {
        
        private string _name;
        private string _description;
        private int _amount;
        private decimal _priceForOne;
        private bool _productInStock;
        

        public ProductViewModel()
        {
            GridVisibility = Visibility.Hidden;
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

       
    }
}

