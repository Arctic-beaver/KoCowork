using CoCowork.BusinessLayer.Models;
using CoCowork.BusinessLayer.Services;
using CoCowork.UI.Commands.BookingCommands;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;

namespace CoCowork.UI.ViewModels
{
    public class BookingViewModel : TabViewModel
    {
        private MiniOfficeService _miniOfficeService;
        private PlaceService _placeService;
        private LaptopService _laptopService;
        private RoomService _roomService;
        private BookingItemModel _bookingSelectedItem;

        public BookingItemModel BookingSelectedItem
        {
            get => _bookingSelectedItem;
            set
            {
                if (value != _bookingSelectedItem)
                {
                    if (value is null)
                    {
                        value = _bookingSelectedItem;
                    }
                    else
                    {
                        _bookingSelectedItem = value;
                        OnPropertyChanged(nameof(BookingSelectedItem));
                    }
                }
            }
        }

        public ObservableCollection<PlaceModel> Places { get; set; }
        public ObservableCollection<MiniOfficeModel> MiniOffices { get; set; }
        public ObservableCollection<RoomModel> MeetingRooms { get; set; }
        public ObservableCollection<RoomModel> ConferenceRooms { get; set; }
        public ObservableCollection<LaptopModel> Laptops { get; set; }
        public ICommand GetMiniOffices { get; set; }
        public ICommand GetPlaces { get; set; }
        public ICommand GetLaptops { get; set; }
        public ICommand GetMeetingRooms { get; set; }
        public ICommand GetConferenceRooms { get; set; }
        public ICommand AddToCurrentOrders { get; set; }
        public MiniOfficeViewModel MiniOfficeVM { get; set; }
        public PlaceViewModel PlaceVM { get; set; }
        public LaptopViewModel LaptopVM { get; set; }
        public AddBookingItemToCurrentOrderViewModel AddBookingItemToCurrentOrderVM { get; set; }

        public BookingViewModel(CurrentOrderViewModel currentOrderVM)
        {
            GridVisibility = Visibility.Visible;

            MiniOfficeVM = new MiniOfficeViewModel(this);
            PlaceVM = new PlaceViewModel(this);
            LaptopVM = new LaptopViewModel(this);
            AddBookingItemToCurrentOrderVM = new AddBookingItemToCurrentOrderViewModel(this, currentOrderVM);

            _placeService = new PlaceService();
            _miniOfficeService = new MiniOfficeService();
            _roomService = new RoomService();
            _laptopService = new LaptopService();

            Places = new ObservableCollection<PlaceModel>();
            MiniOffices = new ObservableCollection<MiniOfficeModel>();
            MeetingRooms = new ObservableCollection<RoomModel>();
            ConferenceRooms = new ObservableCollection<RoomModel>();
            Laptops = new ObservableCollection<LaptopModel>();


            GetPlaces = new GetPlacesCommand(this, _placeService);
            GetMiniOffices = new GetMiniOfficesCommand(this, _miniOfficeService);
            GetMeetingRooms = new GetMeetingRoomsCommand(this, _roomService);
            GetConferenceRooms = new GetConferenceRoomsCommand(this, _roomService);
            GetLaptops = new GetLaptopsCommand(this, _laptopService);
            //AddToCurrentOrders = new AddToCurrentOrders(currentOrderModel, this);
        }
    }
}

