using CoCowork.UI.Commands;
using System.Windows;
using System.Windows.Input;

namespace CoCowork.UI.ViewModels
{
    public class AddNewProductViewModel : AddAndEditViewModel
    {
        public AddNewProductViewModel()
        {
            GridVisibility = Visibility.Collapsed;
            ChangeProductVisibility = new VisibilityOfInnerGridCommand(this);
        }



        public ICommand ChangeProductVisibility { get; set; }

    }
}
