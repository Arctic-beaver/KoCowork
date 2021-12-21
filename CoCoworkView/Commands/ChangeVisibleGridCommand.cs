using CoCowork.UI.ViewModels;
using System;
using System.Windows;

namespace CoCowork.UI.Commands
{
    public class ChangeVisibleGridCommand : CommandBase
    {
        public ChangeVisibleGridCommand(BaseViewModel viewModel)
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

        public override void Execute(object parameter)
        {
            throw new NotImplementedException();
        }
    }
}
