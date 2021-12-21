
using CoCowork.UI.Commands;
using System.Windows;
using System.Windows.Input;

namespace CoCowork.UI.ViewModels
{
    class CurrentOrderViewModel : BaseViewModel
    {
        public CurrentOrderViewModel()
        {
            GridVisibility = Visibility.Collapsed;
            IsGridActive = false;
        }
    }
}
