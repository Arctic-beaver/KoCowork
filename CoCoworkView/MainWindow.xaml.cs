using CoCowork.BusinessLayer.Models;
using CoCowork.UI.ViewModels;
using System.Collections.ObjectModel;
using System.Windows;

namespace CoCoworkView
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {

            InitializeComponent();
            var vm = new MainWindowViewModel();
            DataContext = vm;
            var newItem = new LaptopModel { AmountMonth = 1, Id = 3, Name = "zhopa", Price = 500 };
            var newItem1 = new MiniOfficeModel { AmountDays = 10, Price = 300, Name = "pisun", Id = 5 };
            var newItem2 = new PlaceModel { Id = 1, Name = "zhopun", Price = 200, AmountDays = 20, IsFixed = false };
            var newItem3 = new ProductModel { Price = 100, Name = "chipsi", Id = 0 };
            var newItem4 = new RoomModel { Id = 1, AmountHours = 5, Name = "kokoko", Price = 1000 };

            vm.CurrentOrder.CurrentOrder = new ObservableCollection<IItemModel>();
            vm.CurrentOrder.CurrentOrder.Add(newItem);
            vm.CurrentOrder.TotalPrice = newItem.Price * newItem.AmountMonth;
            vm.CurrentOrder.CurrentOrder.Add(newItem1);
            vm.CurrentOrder.CurrentOrder.Add(newItem2);
            vm.CurrentOrder.CurrentOrder.Add(newItem3);
            vm.CurrentOrder.CurrentOrder.Add(newItem4);
            vm.CurrentOrder.RecalculateSum();
            
        }
    }
}
