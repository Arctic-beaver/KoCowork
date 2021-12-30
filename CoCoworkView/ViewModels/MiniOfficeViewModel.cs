using CoCowork.BusinessLayer.Models;
using CoCowork.BusinessLayer.Services;
using CoCowork.UI.Commands;
using CoCowork.UI.Commands.BookingCommands;
using System.Windows;
using System.Windows.Input;

namespace CoCowork.UI.ViewModels
{
    public class MiniOfficeViewModel : InnerGridViewModel
    {
        private string _name;
        private decimal? _pricePerDay;
        private int? _amountOfPlaces;
        private bool _isEditButtonAvailable;
        private readonly MiniOfficeService _service;
        private MiniOfficeModel _selectedItem;
        private bool _areButtonsAvailable;
        private bool _isAddButtonAvailable;

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

        public decimal? PricePerDay
        {
            get => _pricePerDay;
            set
            {
                _pricePerDay = value;
                OnPropertyChanged(nameof(PricePerDay));
                CheckIfAllFieldsFilledCorrectly();
            }
        }

        public int? AmountOfPlaces
        {
            get => _amountOfPlaces;
            set
            {
                _amountOfPlaces = value;
                OnPropertyChanged(nameof(AmountOfPlaces));
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
                }
            }
        }

        public bool AreButtonsAvailable
        {
            get => _areButtonsAvailable;
            set
            {
                if (value != _areButtonsAvailable)
                {
                    _areButtonsAvailable = value;
                    OnPropertyChanged(nameof(AreButtonsAvailable));
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

        public MiniOfficeModel SelectedItem
        {
            get => _selectedItem;
            set
            {
                if (value != _selectedItem)
                {
                    _selectedItem = value;

                    OnPropertyChanged(nameof(SelectedItem));
                    if (value != null)
                    {
                        AreButtonsAvailable = true;
                    }
                    else
                    {
                        AreButtonsAvailable = false;
                    }
                }
            }
        }

        public ICommand ChangeMiniOfficeEditVisibility { get; set; }
        public ICommand AddMiniOffice { get; set; }
        public ICommand EditMiniOffice { get; set; }
        public ICommand DeleteMiniOffice { get; set; }

        public MiniOfficeViewModel(BookingViewModel bookingVM)
        {
            GridVisibility = Visibility.Collapsed;

            DeleteMiniOffice = new DeleteMiniOfficeCommand(bookingVM, _service);
            AddMiniOffice = new AddMiniOfficeCommand(this, bookingVM, _service);
            //EditMiniOffice = new EditMiniOfficeCommand(this, _service);
            ChangeMiniOfficeEditVisibility = new VisibilityOfInnerGridCommand(this);
        }

        public void CheckIfAllFieldsFilledCorrectly()
        {
            if (Name != null && PricePerDay != null && AmountOfPlaces != null)
            {
                IsEditButtonAvailable = true;
                IsAddButtonAvailable = true;
            }
            else
            {
                IsEditButtonAvailable = false;
                IsAddButtonAvailable = false;
            }
        }
    }
}
