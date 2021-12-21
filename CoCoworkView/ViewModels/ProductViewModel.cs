
using CoCowork.UI.Commands;
using System.Windows;
using System.Windows.Input;

namespace CoCowork.UI.ViewModels
{
    public class ProductViewModel : BaseViewModel
    {
        public ProductViewModel()
        {
            GridVisibility = Visibility.Hidden;
            IsGridActive = false;
        }
    }
}
