
using CoCowork.UI.Commands;

namespace CoCowork.UI.ViewModels
{
    public class OrderViewModel : BaseViewModel
    {
        public OrderViewModel()
        {
            MakeOrderVisible = new ChangeVisibleGridCommand(this);
        }
        public ChangeVisibleGridCommand MakeOrderVisible { get; set; }
    }
}
