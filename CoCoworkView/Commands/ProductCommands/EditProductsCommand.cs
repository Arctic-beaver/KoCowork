using CoCowork.BusinessLayer.Models;
using CoCowork.BusinessLayer.Services;
using CoCowork.UI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CoCowork.UI.Commands
{
    public class EditProductsCommand : CommandBase
    {
        private readonly AddNewProductViewModel _addNewProductVM;
        private readonly ProductViewModel _productVM;
        private readonly ProductService _service;

        public EditProductsCommand(AddNewProductViewModel addNewProductVM, ProductViewModel productVM, ProductService productService)
        {
            _addNewProductVM = addNewProductVM;
            _productVM = productVM;
            _service = productService;
        }

    

        public override void Execute(object parameter)
        {
            var userAnswer = MessageBox.Show("Вы действительно хотите редактировать выбранный миниофис?", "Редактирование", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (userAnswer == MessageBoxResult.Yes)
            {
                var product = new ProductModel()
                {
                    Id = _productVM.SelectedItem.Id,
                    Name = _addNewProductVM.Name,
                    PriceForOne = _addNewProductVM.PriceForOne,
                    Amount = _addNewProductVM.Amount,
                    Description = _addNewProductVM.Description
                };
                
            }
        }
    }
}
