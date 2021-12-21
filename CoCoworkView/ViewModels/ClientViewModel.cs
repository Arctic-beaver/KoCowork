
using CoCowork.UI.Commands;
using System.Windows;
using System.Windows.Input;

namespace CoCowork.UI.ViewModels
{
    public class ClientViewModel : BaseViewModel
    {
        public ClientViewModel()
        {
            GridVisibility = Visibility.Hidden;
            IsGridActive = false;
        }
    }
}
