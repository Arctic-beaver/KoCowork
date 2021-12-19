using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoCowork.UI.ViewModels
{
    public class MainWindowViewModel : BaseViewModel
    {
        private ObservableCollection<CurrentOrderViewModel> _currentOrder;
        public ObservableCollection<CurrentOrderViewModel> CurrentOrder
        {
            get { return _currentOrder; }
            set
            {
                _currentOrder = value;
                OnPropertyChanged("CurrentOrder");
            }
        }
        public MainWindowViewModel()
        {
            CurrentOrder = new ObservableCollection<CurrentOrderViewModel>();
        }
    }
}
