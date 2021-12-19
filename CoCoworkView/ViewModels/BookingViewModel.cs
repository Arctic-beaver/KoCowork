
using System.Collections.ObjectModel;

namespace CoCowork.UI.ViewModels
{
    public class BookingViewModel : BaseViewModel
    {
        private ObservableCollection<PlaceViewModel> _places;
        private ObservableCollection<MiniOfficeViewModel> _miniOffices;
        private ObservableCollection<MeetingRoomViewModel> _meetingRooms;
        private ObservableCollection<ConferenceRoomViewModel> _conferenceRooms;
        public ObservableCollection<PlaceViewModel> Places
        { 
            get => _places;
            set
            {
                _places = value;
                OnPropertyChanged(nameof(Places)); 
            }
        }
        public ObservableCollection<MiniOfficeViewModel> MiniOffices
        {
            get => _miniOffices;
            set
            {
                _miniOffices = value;
                OnPropertyChanged(nameof(MiniOffices));
            }
        }
        public ObservableCollection<MeetingRoomViewModel> MeetingRooms
        {
            get => _meetingRooms;
            set
            {
                _meetingRooms = value;
                OnPropertyChanged(nameof(MeetingRooms));
            }
        }
        public ObservableCollection<ConferenceRoomViewModel> ConferenceRooms
        {
            get => _conferenceRooms;
            set
            {
                _conferenceRooms = value;
                OnPropertyChanged(nameof(ConferenceRooms));
            }
        }

        public BookingViewModel()
        {
            Places = new ObservableCollection<PlaceViewModel>();
            MiniOffices = new ObservableCollection<MiniOfficeViewModel>();
            MeetingRooms = new ObservableCollection<MeetingRoomViewModel>();
            ConferenceRooms = new ObservableCollection<ConferenceRoomViewModel>();

        }
    }
}

