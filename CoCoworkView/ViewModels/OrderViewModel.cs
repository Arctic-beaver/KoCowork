
using CoCowork.UI.Commands;
using System.Windows.Input;

namespace CoCowork.UI.ViewModels
{
    public class OrderViewModel : BaseViewModel
    {
        public OrderViewModel()
        {
            MakeOrderVisible = new ChangeVisibleGridCommand(this);
        }
        public ICommand MakeOrderVisible { get; set; }
    }
}
