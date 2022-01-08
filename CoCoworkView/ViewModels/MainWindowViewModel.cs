using CoCowork.UI.Commands;
using System.Windows.Input;

namespace CoCowork.UI.ViewModels
{
    public class MainWindowViewModel : BaseViewModel
    {
        public MainWindowViewModel()
        {
            Product = new ProductViewModel();
            Client = new ClientViewModel();
            Order = new OrderViewModel();
            CurrentOrder = new CurrentOrderViewModel();
            Booking = new BookingViewModel();
            MakeGridVisible = new ChangeVisibleGridCommand(this);

            VisibleVM = Booking;
        }

        public ICommand MakeGridVisible { get; set; }

        public TabViewModel VisibleVM { get; set; }
        public BookingViewModel Booking { get; set; }
        public ProductViewModel Product { get; set; }
        public ClientViewModel Client { get; set; }
        public OrderViewModel Order { get; set; }
        public CurrentOrderViewModel CurrentOrder { get; set; }
    }
}
