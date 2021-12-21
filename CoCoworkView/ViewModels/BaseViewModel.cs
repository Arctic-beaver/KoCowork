using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;

namespace CoCowork.UI.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
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
