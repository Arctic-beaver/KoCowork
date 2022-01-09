﻿using CoCowork.UI.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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