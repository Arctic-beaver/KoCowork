using CoCowork.UI.Commands;
using System.Windows;
using System.Windows.Input;

namespace CoCowork.UI.ViewModels
{
    public class AddNewClientViewModel : AddAndEditClientViewModel
    {
        public AddNewClientViewModel()
        {
            GridVisibility = Visibility.Collapsed;
            ChangeClientVisibility = new VisibilityOfInnerGridCommand(this);
        }

        public ICommand ChangeClientVisibility { get; set; }
    }
}
