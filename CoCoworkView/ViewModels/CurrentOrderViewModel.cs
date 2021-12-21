
using CoCowork.UI.Commands;

namespace CoCowork.UI.ViewModels
{
    class CurrentOrderViewModel : BaseViewModel
    {
        public CurrentOrderViewModel()
        {
            MakeCurrentOrderVisible = new ChangeVisibleGridCommand(this);
        }
        public ChangeVisibleGridCommand MakeCurrentOrderVisible { get; set; }
    }
}
