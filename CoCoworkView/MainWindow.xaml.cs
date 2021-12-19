using CoCowork.DataLayer.Entities;
using CoCowork.DataLayer.Repositories;
using CoCowork.UI.ViewModels;
using System;
using System.Collections.Generic;
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
        private BookingViewModel _bookingViewModel;

        public MainWindow()
        {
            InitializeComponent();
            _bookingViewModel = new BookingViewModel();
            DataContext = _bookingViewModel;
            FillViewModelWithData();
        }

        public void FillViewModelWithData()
        {
            _bookingViewModel.ConferenceRooms.Add(new ConferenceRoomViewModel());
        }
    }
}
