using CoCowork.BusinessLayer.Models;
using CoCowork.BusinessLayer.Services;
using CoCowork.UI.Commands;
using System.Windows;
using System.Windows.Input;

namespace CoCowork.UI.ViewModels
{
    public class ComputerViewModel : InnerGridViewModel
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
        private LaptopModel _selectedComputer;

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

        public LaptopModel SelectedComputer
        {
            get => _selectedComputer;
            set
            {
                if (value != _selectedComputer)
                {
                    _selectedComputer = value;
                    OnPropertyChanged(nameof(SelectedComputer));

                    if (value != null)
                    {
                        IsDeleteButtonAvailable = true;
                        FillPlaceFields.Execute(this);
                    }
                    else
                    {
                        IsDeleteButtonAvailable = false;
                    }
                }
            }
        }

        public ICommand ChangeComputerEditVisibility { get; set; }
        public ICommand AddComputer { get; set; }
        public ICommand EditComputer { get; set; }
        public ICommand DeleteComputer { get; set; }
        public ICommand FillComputerFields { get; set; }

        public ComputerViewModel(BookingViewModel bookingVM)
        {
            GridVisibility = Visibility.Collapsed;
            _service = new LaptopService();

            //FillComputerFields = new FillPlaceFieldsCommand(this);
            //EditComputer = new EditPlaceCommand(this, bookingVM, _service);
            //AddComputer = new AddPlaceCommand(this, bookingVM, _service);
            //DeleteComputer = new DeleteComputerCommand(this, bookingVM, _service);
            ChangeComputerEditVisibility = new VisibilityOfInnerGridCommand(this);
        }

        public void CheckIfAllFieldsFilledCorrectly()
        {
            bool isAvailable = Number != null && PricePerMonth != null && Description != null;
            IsEditButtonAvailable = isAvailable;
            IsAddButtonAvailable = isAvailable;
        }
    }
}
