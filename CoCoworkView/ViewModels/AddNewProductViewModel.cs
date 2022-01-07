using CoCowork.BusinessLayer.Services;
using CoCowork.UI.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace CoCowork.UI.ViewModels
{
    public class AddNewProductViewModel : InnerGridViewModel
    {
        private string _name;
        private string _description;
        private int _amount;
        private decimal _priceForOne;

        private readonly ProductService _productService;

        public AddNewProductViewModel()
        {
            GridVisibility = Visibility.Collapsed;
            _productService = new ProductService();
            ChangeProductVisibility = new VisibilityOfInnerGridCommand(this);
            
        }

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

        public ICommand ChangeProductVisibility { get; set; }

         
    }
}
