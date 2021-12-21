using CoCowork.UI.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoCowork.UI.ViewModels
{
    public class ButtonsViewModel : BaseViewModel
    {
        public ButtonsViewModel()
        {

        }

        public ChangeVisibleGridCommand ChangeVisibleGrid { get; set; }
    }
}
