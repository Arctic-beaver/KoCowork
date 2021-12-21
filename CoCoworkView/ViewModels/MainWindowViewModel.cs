using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoCowork.UI.ViewModels
{
    public class MainWindowViewModel : BaseViewModel
    {
        public ObservableCollection<BookingViewModel> Booking { get; set; }

        public MainWindowViewModel()
        {
            Booking = new ObservableCollection<BookingViewModel>();
        }
    }
}
