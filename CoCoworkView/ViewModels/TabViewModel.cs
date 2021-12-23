using System.Windows;

namespace CoCowork.UI.ViewModels
{
    public abstract class TabViewModel : BaseViewModel
    {
        private Visibility _visibility;
        public Visibility GridVisibility
        {
            get => _visibility;
            set
            {
                if (value != _visibility)
                {
                    _visibility = value;
                    OnPropertyChanged(nameof(GridVisibility));
                }
            }
        }
    }
}
