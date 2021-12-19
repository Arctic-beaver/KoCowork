using CoCowork.BusinessLayer.Models;
using CoCowork.DataLayer.Entities;
using CoCowork.DataLayer.Repositories;
using CoCowork.UI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CoCoworkView
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindowViewModel viewModel = new MainWindowViewModel();

        public MainWindow()
        {
            DataContext = viewModel;

            InitializeComponent();

            var testOrder1 = new LaptopModel { Name = "nout", PricePerMonth = 5000};
            var testOrder2 = new MiniOfficeModel { Name = "mini", PricePerDay = 1000 };
            var testOrder3 = new PlaceModel { Name = "mesto", PricePerDay = 666 };
            var testOrder4 = new ProductModel { Name = "product", PriceForOne = 1 };
            var testOrder5 = new RoomModel { Name = "komnata", PricePerHour = 44 };

            viewModel.CurrentOrder.Add(new CurrentOrderViewModel(testOrder5));
            viewModel.CurrentOrder.Add(new CurrentOrderViewModel(testOrder4));
            viewModel.CurrentOrder.Add(new CurrentOrderViewModel(testOrder3));
            viewModel.CurrentOrder.Add(new CurrentOrderViewModel(testOrder2));
            viewModel.CurrentOrder.Add(new CurrentOrderViewModel(testOrder1));
        }
    }
}
