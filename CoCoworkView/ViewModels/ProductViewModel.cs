
using CoCowork.UI.Commands;

namespace CoCowork.UI.ViewModels
{
    public class ProductViewModel : BaseViewModel
    {
        public ProductViewModel()
        {
            MakeProductVisible = new ChangeVisibleGridCommand(this);
        }
        public ChangeVisibleGridCommand MakeProductVisible { get; set; }
    }
}
