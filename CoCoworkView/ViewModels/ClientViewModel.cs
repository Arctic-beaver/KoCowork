
using CoCowork.UI.Commands;

namespace CoCowork.UI.ViewModels
{
    public class ClientViewModel : BaseViewModel
    {
        public ClientViewModel()
        {
            MakeClientVisible = new ChangeVisibleGridCommand(this);
        }
        public ChangeVisibleGridCommand MakeClientVisible { get; set; }
    }
}
