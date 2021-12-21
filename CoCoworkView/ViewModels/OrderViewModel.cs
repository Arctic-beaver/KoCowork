
using CoCowork.UI.Commands;
using System.Windows;
using System.Windows.Input;

namespace CoCowork.UI.ViewModels
{
    public class OrderViewModel : BaseViewModel
    {
        public OrderViewModel()
        {
            GridVisibility = Visibility.Hidden;
            IsGridActive = false;            
        }
    }
}
