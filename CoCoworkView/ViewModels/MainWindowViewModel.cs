using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CoCowork.UI.ViewModels
{
    class MainWindowViewModel : BaseViewModel
    {
        public MainWindowViewModel()
        {
            Booking = new BookingViewModel();
            Product = new ProductViewModel();
            Client = new ClientViewModel();
            Order = new OrderViewModel();
            CurrentOrder = new CurrentOrderViewModel();
            VisibleVM = Booking;
            
            Booking.GridVisibility = Visibility.Visible;
            Booking.IsGridActive = true;
            Product.GridVisibility = Visibility.Hidden;
            Product.IsGridActive = false;
            Client.GridVisibility = Visibility.Hidden;
            Client.IsGridActive = false;
            Order.GridVisibility = Visibility.Hidden;
            Order.IsGridActive = false;
            CurrentOrder.GridVisibility = Visibility.Hidden;
            CurrentOrder.IsGridActive = false;
        }

        public BookingViewModel Booking { get; set; }
        public ProductViewModel Product { get; set; }
        public ClientViewModel Client { get; set; }
        public OrderViewModel Order { get; set; }
        public CurrentOrderViewModel CurrentOrder { get; set; }
    }
}
