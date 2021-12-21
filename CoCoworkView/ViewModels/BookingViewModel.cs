
using CoCowork.UI.Commands;
using System.Windows;
using System.Windows.Input;

namespace CoCowork.UI.ViewModels
{
    public class BookingViewModel : BaseViewModel
    {
        
            
        public BookingViewModel()
        {
            GridVisibility = Visibility.Visible;
            IsGridActive = true;
        }
    }
}
