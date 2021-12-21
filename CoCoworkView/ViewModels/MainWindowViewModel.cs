using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        }

        public BookingViewModel Booking { get; set; }
        public ProductViewModel Product { get; set; }
        public ClientViewModel Client { get; set; }
        public OrderViewModel Order { get; set; }
        public CurrentOrderViewModel CurrentOrder { get; set; }
    }
}
