﻿using System.Collections.ObjectModel;
using System.Windows.Input;

namespace CoCowork.UI.ViewModels
{
    public class BookingViewModel : BaseViewModel
    {
        private decimal _pricePerDayField;
        private decimal _pricePerHourField;
        private int _amountOfPlacesField;
        private decimal _pricePerMonthField;
        private string _descriptionField;

        public decimal PricePerDayField
        {
            get => _pricePerDayField;
            set
            {
                _pricePerDayField = value;
                OnPropertyChanged(nameof(PricePerDayField));
            }
        }

        public decimal PricePerHourField
        {
            get => _pricePerHourField;
            set
            {
                _pricePerHourField = value;
                OnPropertyChanged(nameof(PricePerHourField));
            }
        }

        public int AmountOfPlacesField
        {
            get => _amountOfPlacesField;
            set
            {
                _amountOfPlacesField = value;
                OnPropertyChanged(nameof(AmountOfPlacesField));
            }
        }

        public decimal PricePerMonthField
        {
            get => _pricePerMonthField;
            set
            {
                _pricePerMonthField = value;
                OnPropertyChanged(nameof(PricePerMonthField));
            }
        }

        public string DescriptionField
        {
            get => _descriptionField;
            set
            {
                _descriptionField = value;
                OnPropertyChanged(nameof(DescriptionField));
            }
        }

        public ObservableCollection<PlaceViewModel> Places { get; set; }
        public ObservableCollection<MiniOfficeViewModel> MiniOffices { get; set; }
        public ObservableCollection<MeetingRoomViewModel> MeetingRooms { get; set; }
        public ObservableCollection<ConferenceRoomViewModel> ConferenceRooms { get; set; }
        public ObservableCollection<ComputerViewModel> Computers { get; set; }
        public ICommand DeleteBookingItem { get; set; }

        public BookingViewModel()
        {
            Places = new ObservableCollection<PlaceViewModel>();
            MiniOffices = new ObservableCollection<MiniOfficeViewModel>();
            MeetingRooms = new ObservableCollection<MeetingRoomViewModel>();
            ConferenceRooms = new ObservableCollection<ConferenceRoomViewModel>();
            Computers = new ObservableCollection<ComputerViewModel>();
        }
    }
}

