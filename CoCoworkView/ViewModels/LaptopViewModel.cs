using CoCowork.BusinessLayer.Models;
using CoCowork.BusinessLayer.Services;
using CoCowork.UI.Commands;
using CoCowork.UI.Commands.ComputerCommands;
using CoCowork.UI.Commands.LaptopCommands;
using CoCowork.UI.Commands.MiniOfficeCommands;
using System.Windows;
using System.Windows.Input;

namespace CoCowork.UI.ViewModels
{
    public class LaptopViewModel : InnerGridViewModel
    {
        private int? _number;
        private string _name;
        private int? _amount;
        private decimal? _pricePerMonth;
        private string _description;
        private bool _isEditButtonAvailable;
        private bool _isDeleteButtonAvailable;
        private bool _isAddButtonAvailable;
        private readonly LaptopService _service;
        private LaptopModel _selectedLaptop;

        public int? Number
        {
            get => _number;
            set
            {
                _number = value;
                OnPropertyChanged(nameof(Number));
                CheckIfAllFieldsFilledCorrectly();
            }
        }

        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChanged(nameof(Name));
                CheckIfAllFieldsFilledCorrectly();
            }
        }

        public int? Amount
        {
            get => _amount;
            set
            {
                _amount = value;
                OnPropertyChanged(nameof(Amount));
                CheckIfAllFieldsFilledCorrectly();
            }
        }

        public decimal? PricePerMonth
        {
            get => _pricePerMonth;
            set
            {
                _pricePerMonth = value;
                OnPropertyChanged(nameof(PricePerMonth));
                CheckIfAllFieldsFilledCorrectly();
            }
        }

        public string Description
        {
            get => _description;
            set
            {
                _description = value;
                OnPropertyChanged(nameof(Description));
                CheckIfAllFieldsFilledCorrectly();
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
                    CheckIfAllFieldsFilledCorrectly();
                }
            }
        }

        public bool IsDeleteButtonAvailable
        {
            get => _isDeleteButtonAvailable;
            set
            {
                if (value != _isDeleteButtonAvailable)
                {
                    _isDeleteButtonAvailable = value;
                    OnPropertyChanged(nameof(IsDeleteButtonAvailable));
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
                    CheckIfAllFieldsFilledCorrectly();
                }
            }
        }

        public LaptopModel SelectedLaptop
        {
            get => _selectedLaptop;
            set
            {
                if (value != _selectedLaptop)
                {
                    _selectedLaptop = value;
                    OnPropertyChanged(nameof(SelectedLaptop));

                    if (value != null)
                    {
                        IsDeleteButtonAvailable = true;
                        FillLaptopFields.Execute(this);
                    }
                    else
                    {
                        IsDeleteButtonAvailable = false;
                    }
                }
            }
        }

        public ICommand ChangeLaptopEditVisibility { get; set; }
        public ICommand AddLaptop { get; set; }
        public ICommand EditLaptop { get; set; }
        public ICommand DeleteLaptop { get; set; }
        public ICommand FillLaptopFields { get; set; }

        public LaptopViewModel(BookingViewModel bookingVM)
        {
            GridVisibility = Visibility.Collapsed;
            _service = new LaptopService();

            FillLaptopFields = new FillLaptopFieldsCommand(this, bookingVM);
            EditLaptop = new EditLaptopCommand(this, bookingVM, _service);
            AddLaptop = new AddLaptopCommand(this, bookingVM, _service);
            DeleteLaptop = new DeleteLaptopCommand(this, bookingVM, _service);
            ChangeLaptopEditVisibility = new VisibilityOfInnerGridCommand(this);
        }

        public void CheckIfAllFieldsFilledCorrectly()
        {
            bool isAvailable = Number != null && PricePerMonth != null && Description != null;
            IsEditButtonAvailable = isAvailable;
            IsAddButtonAvailable = isAvailable;
        }
    }
}
