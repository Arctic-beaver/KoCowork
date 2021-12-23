using CoCowork.BusinessLayer.Models;
using CoCowork.UI.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;
using System.Linq;
using Dapper;
using CoCowork.DataLayer.Entities;
using CoCowork.DataLayer.Repositories;
using PseudoCalc.BusinessLayer.Configuration;
using CoCowork.BusinessLayer.Services;

namespace CoCowork.UI.Commands.CurrentOrder
{
    public class AddOrdersToBD : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public List<IItemModel> ListOrders {get; set; }

        private CurrentOrderViewModel _vm;

        public AddOrdersToBD(CurrentOrderViewModel vm)
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
            var newOrder = new OrderService();
            var orderId = newOrder.CreateNewOrder(clientEntity, _vm.IsCancelled, _vm.IsPaid, _vm.TotalPrice);



            

        }
    }
}
