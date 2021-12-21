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
        private MainWindowViewModel _mainVM = new MainWindowViewModel();

        public MainWindow()
        {
            InitializeComponent();
            DataContext = _mainVM;
            FillViewModelsWithData();
        }

        public void FillViewModelsWithData()
        {
            //_mainVM.Booking.Add(new ConferenceRoomViewModel() { PricePerHour = 500, AmountOfPlaces = 20, Number = 1 });
            //_mainVM.ConferenceRooms.Add(new ConferenceRoomViewModel() { PricePerHour = 700, AmountOfPlaces = 25, Number = 2 });
            //_mainVM.Places.Add(new PlaceViewModel() { PricePerDay = 600, FixedPricePerDay = 1000, Number = 9 });

            //for (int i = 1; i < 9; i++)
            //{
            //    _bookingVM.Places.Add(new PlaceViewModel() { PricePerDay = 600, FixedPricePerDay = 800, Number = i });
            //}
            //_bookingVM.Places.Add(new PlaceViewModel() { PricePerDay = 800, FixedPricePerDay = 1100, Number = 10 });

            //for (int i = 1; i < 4; i++)
            //{
            //    _bookingVM.MeetingRooms.Add(new MeetingRoomViewModel() { PricePerHour = 150, AmountOfPlaces = 4, Number = i });
            //}
            //_bookingVM.MiniOffices.Add(new MiniOfficeViewModel() { PricePerDay = 2000, Number = 1, AmountOfPlaces = 5 });
            //_bookingVM.MiniOffices.Add(new MiniOfficeViewModel() { PricePerDay = 2500, Number = 2, AmountOfPlaces = 8 });
            //_bookingVM.MiniOffices.Add(new MiniOfficeViewModel() { PricePerDay = 2000, Number = 3, AmountOfPlaces = 5 });

            //for (int i = 1; i < 7; i++)
            //{
            //    _bookingVM.Computers.Add(new ComputerViewModel() { PricePerMonth = 8000, Number = i, Description = "Мощный конь" });
            //}
            //for (int i = 7; i < 14; i++)
            //{
            //    _bookingVM.Computers.Add(new ComputerViewModel() { PricePerMonth = 5000, Number = i, Description = "Стандартный" });
            //}

        }
    }
}
