using CoCowork.BusinessLayer.Models;
using CoCowork.BusinessLayer.Services;
using CoCowork.UI.Commands;
using CoCowork.UI.Commands.BookingCommands;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace CoCowork.UI.ViewModels
{
    public class BookingViewModel : BaseViewModel
    {
        private MiniOfficeService _miniOfficeService;
        private PlaceService _placeService;
        private ComputerService _computerService;
        private RoomService _roomService;

        private ItemModel _bookingSelectedItem;

        private decimal _pricePerDayField;
        private decimal _pricePerHourField;
        private int _amountOfPlacesField;
        private decimal _pricePerMonthField;
        private string _descriptionField;

        public ItemModel BookingSelectedItem
        {
            get => _bookingSelectedItem;
            set
            {
                _bookingSelectedItem = value;
                OnPropertyChanged(nameof(BookingSelectedItem));
            }
        }

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

        public ObservableCollection<PlaceModel> Places { get; set; }
        public ObservableCollection<MiniOfficeModel> MiniOffices { get; set; }
        public ObservableCollection<RoomModel> MeetingRooms { get; set; }
        public ObservableCollection<RoomModel> ConferenceRooms { get; set; }
        public ObservableCollection<ComputerModel> Computers { get; set; }
        public ICommand GetMiniOffices { get; set; }
        public ICommand GetPlaces { get; set; }
        public ICommand GetComputers { get; set; }
        public ICommand GetMeetingRooms { get; set; }
        public ICommand GetConferenceRooms { get; set; }
        public ICommand DeleteBookingItem { get; set; }

        public BookingViewModel()
        {
            _placeService = new PlaceService();
            _miniOfficeService = new MiniOfficeService();
            _roomService = new RoomService();
            _computerService = new ComputerService();

            Places = new ObservableCollection<PlaceModel>();
            MiniOffices = new ObservableCollection<MiniOfficeModel>();
            MeetingRooms = new ObservableCollection<RoomModel>();
            ConferenceRooms = new ObservableCollection<RoomModel>();
            Computers = new ObservableCollection<ComputerModel>();

            GetPlaces = new GetPlacesCommand(this, _placeService);
            GetMiniOffices = new GetMiniOfficesCommand(this, _miniOfficeService);
            GetMeetingRooms = new GetMeetingRoomsCommand(this, _roomService);
            GetConferenceRooms = new GetConferenceRoomsCommand(this, _roomService);
            GetComputers = new GetComputersCommand(this, _computerService);

            DeleteBookingItem = new DeleteBookingItemCommand(this, _miniOfficeService, _roomService, _computerService, _placeService);
        }
    }
}

