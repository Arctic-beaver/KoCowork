
using CoCowork.UI.Commands;
using System.Windows.Input;

namespace CoCowork.UI.ViewModels
{
    class CurrentOrderViewModel : BaseViewModel
    {
        public CurrentOrderViewModel()
        {
            MakeCurrentOrderVisible = new ChangeVisibleGridCommand(this);
        }
        public ICommand MakeCurrentOrderVisible { get; set; }
    }
}
