namespace CoCowork.UI.ViewModels
{
    public abstract class InnerGridViewModel : TabViewModel
    {
        private bool _mustBeCollapsed;
        public InnerGridViewModel()
        {
            _mustBeCollapsed = false;
        }

        public bool MustBeCollapsed
        {
            get => _mustBeCollapsed;
            set
            {
                if (value != _mustBeCollapsed)
                {
                    _mustBeCollapsed = value;
                    OnPropertyChanged(nameof(MustBeCollapsed));
                }
            }
        }
    }
}
