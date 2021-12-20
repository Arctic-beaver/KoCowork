using CoCowork.BusinessLayer.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace CoCowork.UI.ViewModels
{
    public class BookingViewModel : BaseViewModel
    {
        private ObservableCollection<PlaceViewModel> _places;
        private ObservableCollection<MiniOfficeViewModel> _miniOffices;
        private ObservableCollection<MeetingRoomViewModel> _meetingRooms;
        private ObservableCollection<ConferenceRoomViewModel> _conferenceRooms;
        private ObservableCollection<ComputerViewModel> _computers;
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
        public ObservableCollection<ComputerViewModel> Computers
        {
            get => _computers;
            set
            {
                _computers = value;
                OnPropertyChanged(nameof(Computers));
            }
        }

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

