
using CoCowork.UI.Commands;

namespace CoCowork.UI.ViewModels
{
    class CurrentOrderGrid : BaseViewModel
    {
        public CurrentOrderGrid()
        {
            ChangeVisibleGrid = new ChangeVisibleGridCommand(this);
        }
        public ChangeVisibleGridCommand ChangeVisibleGrid { get; set; }
    }
}
