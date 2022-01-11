using CoCowork.UI.Commands;
using System.Windows;
using System.Windows.Input;

namespace CoCowork.UI.ViewModels
{
    public class EditProductViewModel : AddAndEditViewModel
    {


        public EditProductViewModel(ProductViewModel productVM)
        {
            GridVisibility = Visibility.Collapsed;
            ChangeProductVisibility = new VisibilityOfInnerGridCommand(this);


        }

        public ICommand ChangeProductVisibility { get; set; }


    }
}
