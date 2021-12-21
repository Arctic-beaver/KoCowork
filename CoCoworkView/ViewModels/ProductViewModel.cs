
using CoCowork.UI.Commands;
using System.Windows.Input;

namespace CoCowork.UI.ViewModels
{
    public class ProductViewModel : BaseViewModel
    {
        public ProductViewModel()
        {
            MakeProductVisible = new ChangeVisibleGridCommand(this);
        }
        public ICommand MakeProductVisible { get; set; }
    }
}
