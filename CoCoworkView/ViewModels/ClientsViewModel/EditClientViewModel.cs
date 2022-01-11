using CoCowork.UI.Commands;
using System.Windows;
using System.Windows.Input;

namespace CoCowork.UI.ViewModels
{
    public class EditClientViewModel : AddAndEditClientViewModel
    {
        public EditClientViewModel(ClientViewModel clientVM)
        {
            GridVisibility = Visibility.Collapsed;
            ChangeProductVisibility = new VisibilityOfInnerGridCommand(this);


        }

        public ICommand ChangeProductVisibility { get; set; }
    }
}
