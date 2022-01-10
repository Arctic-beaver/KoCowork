using CoCowork.BusinessLayer.Models;
using CoCowork.BusinessLayer.Services;
using CoCowork.UI.Commands;
using CoCowork.UI.Commands.BookingCommands;
using CoCowork.UI.Commands.MiniOfficeCommands;
using System.Windows;
using System.Windows.Input;

namespace CoCowork.UI.ViewModels
{
    public class PlaceViewModel : InnerGridViewModel
    {
        private decimal? _pricePerDay;
        private decimal? _priceFixedPerDay;
        private int? _number;
        private string _description;
        private bool _isEditButtonAvailable;
        private readonly PlaceService _service;
        private PlaceModel _selectedPlace;
        private bool _isDeleteButtonAvailable;
        private bool _isAddButtonAvailable;

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

        public decimal? PriceFixedPerDay
        {
            get => _priceFixedPerDay;
            set
            {
                _priceFixedPerDay = value;
                OnPropertyChanged(nameof(PriceFixedPerDay));
                CheckIfAllFieldsFilledCorrectly();
            }
        }

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

        public PlaceModel SelectedPlace
        {
            get => _selectedPlace;
            set
            {
                if (value != _selectedPlace)
                {
                    _selectedPlace = value;
                    OnPropertyChanged(nameof(SelectedPlace));

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

        public ICommand ChangePlaceEditVisibility { get; set; }
        public ICommand AddPlace { get; set; }
        public ICommand EditPlace { get; set; }
        public ICommand DeletePlace { get; set; }
        public ICommand FillPlaceFields { get; set; }

        public PlaceViewModel(BookingViewModel bookingVM)
        {
            GridVisibility = Visibility.Collapsed;
            _service = new PlaceService();

            FillPlaceFields = new FillPlaceFieldsCommand(this, bookingVM);
            EditPlace = new EditPlaceCommand(this, bookingVM, _service);
            AddPlace = new AddPlaceCommand(this, bookingVM, _service);
            DeletePlace = new DeletePlaceCommand(this, bookingVM, _service);
            ChangePlaceEditVisibility = new VisibilityOfInnerGridCommand(this);
        }

        public void CheckIfAllFieldsFilledCorrectly()
        {
            bool isAvailable = Number != null && PricePerDay != null && PriceFixedPerDay != null && Description != null;
            IsEditButtonAvailable = isAvailable;
            IsAddButtonAvailable = isAvailable;
        }
    }
}
