using CoCowork.UI.ViewModels;
using System;
using System.Windows;

namespace CoCowork.UI.Commands
{
    public class ChangeVisibleGridCommand : CommandBase
    {
        public ChangeVisibleGridCommand(BaseViewModel viewModel)
        {
            _viewModel = viewModel;
        }

        private BaseViewModel _viewModel;
        public override void Execute(object parameter)
        {
            //делаем видимым и активным нужное окно
            _viewModel.GridVisibility = Visibility.Visible;
            _viewModel.IsGridActive = true;

            //делаем невидимым и неактивным ненужное окно
            BaseViewModel.VisibleVM.GridVisibility = Visibility.Hidden;
            BaseViewModel.VisibleVM.IsGridActive = false;

            //записываем инфу о том, какое сейчас активно
            BaseViewModel.VisibleVM = _viewModel;
        }
    }
}
