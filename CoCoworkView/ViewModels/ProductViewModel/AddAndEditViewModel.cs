using CoCowork.BusinessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoCowork.UI.ViewModels
{
    public abstract class AddAndEditViewModel:InnerGridViewModel
    {
        private string _name;
        private string _description;
        private int _amount;
        private decimal _priceForOne;
        private bool _isEditButtonAvailable;
        private bool _isAddButtonAvailable;
        private ProductModel _selectedProduct;

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

        public bool IsAddButtonAvailable
        {
            get => _isAddButtonAvailable;
            set
            {
                if (value != _isAddButtonAvailable)
                {
                    _isAddButtonAvailable = value;
                    OnPropertyChanged(nameof(IsAddButtonAvailable));

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



    }
}
