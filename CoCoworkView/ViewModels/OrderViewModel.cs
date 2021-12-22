using CoCowork.BusinessLayer.Models;
using System.Collections.ObjectModel;
using System.Windows;

namespace CoCowork.UI.ViewModels
{
    public class OrderViewModel : TabViewModel
    {
        public OrderViewModel()
        {
            GridVisibility = Visibility.Hidden;
        }

        public ObservableCollection<OrderModel> Orders { get; set; }

        //public bool IsButtonDeleteAvailable => 
        
        
    }
}
    

