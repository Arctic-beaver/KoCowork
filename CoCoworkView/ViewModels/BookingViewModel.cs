
using CoCowork.UI.Commands;

namespace CoCowork.UI.ViewModels
{
    public class BookingViewModel : BaseViewModel
    {
        public BookingViewModel()
        {
            MakeBookingVisible = new ChangeVisibleGridCommand(this);
        }
        public ChangeVisibleGridCommand MakeBookingVisible { get; set; }
    }
}
