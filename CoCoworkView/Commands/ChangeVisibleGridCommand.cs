using CoCowork.UI.ViewModels;
using System;
using System.Windows;

namespace CoCowork.UI.Commands
{
    public class ChangeVisibleGridCommand : CommandBase
    {
        public ChangeVisibleGridCommand()
        {
        }

        public override void Execute(object parameter)
        {
            BaseViewModel viewModel = (BaseViewModel)parameter;
            if (!viewModel.Equals(BaseViewModel.VisibleVM))
            {
                //делаем видимым и активным нужное окно
                viewModel.GridVisibility = Visibility.Visible;
                viewModel.IsGridActive = true;

                //делаем невидимым и неактивным ненужное окно
                BaseViewModel.VisibleVM.GridVisibility = Visibility.Hidden;
                BaseViewModel.VisibleVM.IsGridActive = false;

                //записываем инфу о том, какое сейчас активно
                BaseViewModel.VisibleVM = viewModel;
            }
        }
    }
}
