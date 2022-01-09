using CoCowork.UI.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
