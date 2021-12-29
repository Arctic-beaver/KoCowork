using CoCowork.BusinessLayer.Models;
using CoCowork.BusinessLayer.Services;
using CoCowork.UI.Commands;
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
        private ComputerService _computerService;
        private RoomService _roomService;
        private ItemModel _bookingSelectedItem;

        public ItemModel BookingSelectedItem
        {
            get => _bookingSelectedItem;
            set
            {
                _bookingSelectedItem = value;
                OnPropertyChanged(nameof(BookingSelectedItem));
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
        public MiniOfficeViewModel MiniOfficeVM { get; set; }
         
        public BookingViewModel()
        {
            GridVisibility = Visibility.Visible;

            MiniOfficeVM = new MiniOfficeViewModel(this);

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
        }
    }
}

