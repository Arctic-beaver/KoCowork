
using CoCowork.UI.Commands;
using System.Windows.Input;

namespace CoCowork.UI.ViewModels
{
    public class ClientViewModel : BaseViewModel
    {
        public ClientViewModel()
        {
            MakeClientVisible = new ChangeVisibleGridCommand(this);
        }
        public ICommand MakeClientVisible { get; set; }
    }
}
