using CoCowork.BusinessLayer.Models;
using CoCowork.BusinessLayer.Services;
using CoCowork.DataLayer.Entities;
using CoCowork.UI.ViewModels;
using System;
using System.Collections.Generic;
using System.Windows.Input;

namespace CoCowork.UI.Commands.CurrentOrder
{
    public class AddOrdersToDB : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public List<IItemModel> ListOrders { get; set; }

        private CurrentOrderViewModel _vm;

        public AddOrdersToDB(CurrentOrderViewModel vm)
        {
            _vm = vm;

        }

        public Client ClientEntity { get; set; }


        public bool CanExecute(object parameter)
        {
            throw new NotImplementedException();
        }

        public void Execute(object parameter)
        {
            var client = new ClientService();
            var clientEntity = client.ConvertClientModelToEntities(_vm.SelectedClient);
            var orderService = new OrderService();
            var newOrder = orderService.AddedOrderToDB(clientEntity, _vm.IsCancelled, _vm.IsPaid, _vm.TotalPrice);





        }
    }
}
