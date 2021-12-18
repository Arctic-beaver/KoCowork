
using CoCowork.BusinessLayer.Models;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CoCowork.UI.ViewModels
{
    class CurrentOrderViewModel : INotifyPropertyChanged
    {
        public CurrentOrderViewModel(iItemModel itemModel)
        {

        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
