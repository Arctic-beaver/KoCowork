using CoCowork.BusinessLayer.Models;
using CoCowork.BusinessLayer.Services;
using CoCowork.UI.Commands;
using CoCowork.UI.Commands.BookingCommands;
using CoCowork.UI.Commands.MiniOfficeCommands;
using System.Windows;
using System.Windows.Input;

namespace CoCowork.UI.ViewModels
{
    public class MiniOfficeViewModel : InnerGridViewModel
    {
        private string _name;
        private decimal? _pricePerDay;
        private decimal? _placePricePerDay;
        private decimal? _placePriceFixedPerDay;
        private int? _placeNumber;
        private int? _amountOfPlaces;
        private bool _isEditButtonAvailable;
        private readonly MiniOfficeService _service;
        private MiniOfficeModel _selectedMiniOffice;
        private bool _isDeleteButtonAvailable;
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

        public decimal? PlacePricePerDay
        {
            get => _placePricePerDay;
            set
            {
                _placePricePerDay = value;
                OnPropertyChanged(nameof(PlacePricePerDay));
                CheckIfAllFieldsFilledCorrectly();
            }
        }

        public decimal? PlacePriceFixedPerDay
        {
            get => _placePriceFixedPerDay;
            set
            {
                _placePriceFixedPerDay = value;
                OnPropertyChanged(nameof(PlacePriceFixedPerDay));
                CheckIfAllFieldsFilledCorrectly();
            }
        }

        public int? PlaceNumber
        {
            get => _placeNumber;
            set
            {
                _placeNumber = value;
                OnPropertyChanged(nameof(PlaceNumber));
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

        public MiniOfficeModel SelectedMiniOffice
        {
            get => _selectedMiniOffice;
            set
            {
                if (value != _selectedMiniOffice)
                {
                    _selectedMiniOffice = value;
                    OnPropertyChanged(nameof(SelectedMiniOffice));

                    if (value != null)
                    {
                        IsDeleteButtonAvailable = true;
                        FillMiniOfficeFields.Execute(this);
                    }
                    else
                    {
                        IsDeleteButtonAvailable = false;
                    }
                }
            }
        }

        public ICommand ChangeMiniOfficeEditVisibility { get; set; }
        public ICommand AddMiniOffice { get; set; }
        public ICommand EditMiniOffice { get; set; }
        public ICommand DeleteMiniOffice { get; set; }
        public ICommand FillMiniOfficeFields { get; set; }

        public MiniOfficeViewModel(BookingViewModel bookingVM)
        {
            GridVisibility = Visibility.Collapsed;
            _service = new MiniOfficeService();

            DeleteMiniOffice = new DeleteMiniOfficeCommand(this, bookingVM, _service);
            AddMiniOffice = new AddMiniOfficeCommand(this, bookingVM, _service);
            EditMiniOffice = new EditMiniOfficeCommand(this, bookingVM, _service);
            FillMiniOfficeFields = new FillMiniOfficeFieldsCommand(this);
            ChangeMiniOfficeEditVisibility = new VisibilityOfInnerGridCommand(this);
        }

        public void CheckIfAllFieldsFilledCorrectly()
        {
            IsEditButtonAvailable = Name != null && PricePerDay != null && AmountOfPlaces != null;

            IsAddButtonAvailable = Name != null && PricePerDay != null && AmountOfPlaces != null
                && PlaceNumber != null && PlacePricePerDay != null && PlacePriceFixedPerDay != null;
        }
    }
}
