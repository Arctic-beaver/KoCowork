using System.Windows;
using System.Windows.Controls;

namespace CoCowork.UI
{
    public static class UIHelpers
    {
        public static void SetButtonEnabledAndVisibility(Grid grid, bool active)
        {
            if (active)
            {
                grid.Visibility = Visibility.Visible;
                grid.IsEnabled = true;
            }
            else
            {
                grid.Visibility = Visibility.Hidden;
                grid.IsEnabled = false;
            }
        }
    }
}
