﻿using CoCowork.UI.Commands;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;

namespace CoCowork.UI.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public BaseViewModel()
        {
            MakeGridVisible = new ChangeVisibleGridCommand(this);
        }
        public ChangeVisibleGridCommand MakeGridVisible { get; set; }

        public Visibility GridVisibility { get; set; }
        public bool IsGridActive { get; set; }
        public static BaseViewModel VisibleVM { get; set; }
        

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
