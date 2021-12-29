using CoCowork.BusinessLayer.Models;
using System;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace CoCowork.UI.ViewModels
{
    internal class AddToCurrentOrders : ICommand
    {

        private CurrentOrderViewModel _vm;
        private ObservableCollection<ItemModel> _currentOrders;
        private ItemModel _selectedItem;

        public AddToCurrentOrders(CurrentOrderViewModel vm, ItemModel selectedItem)
        {
            _vm = vm;
            vm.CurrentOrder = new ObservableCollection<ItemModel>();
            _selectedItem = selectedItem;

        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _vm.CurrentOrder.Add(_selectedItem);
            _vm.RecalculateSum();
        }
    }
}