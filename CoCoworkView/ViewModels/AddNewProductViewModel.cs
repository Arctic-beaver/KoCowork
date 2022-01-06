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
    public class AddNewProductViewModel : InnerGridViewModel
    {
        private string _name;
        private string _description;
        private int _amount;
        private decimal _priceForOne;

        public AddNewProductViewModel()
        {
            GridVisibility = Visibility.Collapsed;
            ChangeProductVisibility = new VisibilityOfInnerGridCommand(this);
        }

        public ICommand ChangeProductVisibility { get; set; }
    }
}
