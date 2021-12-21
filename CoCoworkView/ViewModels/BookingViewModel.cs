
using CoCowork.UI.Commands;
using System.Windows.Input;

namespace CoCowork.UI.ViewModels
{
    public class BookingViewModel : BaseViewModel
    {
        public BookingViewModel()
        {
            MakeBookingVisible = new ChangeVisibleGridCommand(this);
        }
        public ICommand MakeBookingVisible { get; set; }
    }
}
