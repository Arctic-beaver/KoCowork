using CoCowork.DataLayer.Entities;
using CoCowork.DataLayer.Repositories;
using CoCowork.UI.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CoCoworkView
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private BookingViewModel _bookingVM;

        public MainWindow()
        {
            InitializeComponent();
            _bookingVM = new BookingViewModel();
            DataContext = _bookingVM;
            FillViewModelWithData();
        }

        public void FillViewModelWithData()
        {
            _bookingVM.ConferenceRooms.Add(new ConferenceRoomViewModel());
            _bookingVM.Places.Add(new PlaceViewModel() { PricePerDay = 600, FixedPricePerDay = 1000, Number = 9 });

            for (int i = 1; i < 9; i++)
            {
                _bookingVM.Places.Add(new PlaceViewModel() { PricePerDay = 600, FixedPricePerDay = 800, Number = i });
            }
            _bookingVM.Places.Add(new PlaceViewModel() { PricePerDay = 800, FixedPricePerDay = 1100, Number = 10 });

            for (int i = 1; i < 4; i++)
            {
                _bookingVM.MeetingRooms.Add(new MeetingRoomViewModel() { PricePerHour = 10, AmountOfPlaces = 4, Number = i });
            }
            _bookingVM.MiniOffices.Add(new MiniOfficeViewModel() { PricePerDay = 2000, Number = 1, AmountOfPlaces = 5 });
            _bookingVM.MiniOffices.Add(new MiniOfficeViewModel() { PricePerDay = 2500, Number = 2, AmountOfPlaces = 8 });
            _bookingVM.MiniOffices.Add(new MiniOfficeViewModel() { PricePerDay = 2000, Number = 3, AmountOfPlaces = 5 });
            _bookingVM.Computers.Add(new ComputerViewModel());
        }
    }
}
