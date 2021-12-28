
using CoCowork.UI.Commands;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;

namespace CoCowork.UI.ViewModels
{
    public class MiniOfficeViewModel : InnerGridViewModel
    {
        private string _name;
        private decimal? _pricePerDay;
        private int? _amountOfPlaces;
        private bool _isEditButtonAvailable;

        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChanged(nameof(Name));
                CheckIfAllFieldsFilledCorrectly();
            }
        }

        public decimal? PricePerDay
        {
            get => _pricePerDay;
            set
            {
                _pricePerDay = value;
                OnPropertyChanged(nameof(PricePerDay));
                CheckIfAllFieldsFilledCorrectly();
            }
        }

        public int? AmountOfPlaces
        {
            get => _amountOfPlaces;
            set
            {
                _amountOfPlaces = value;
                OnPropertyChanged(nameof(AmountOfPlaces));
                CheckIfAllFieldsFilledCorrectly();
            }
        }

        public bool IsEditButtonAvailable
        {
            get => _isEditButtonAvailable;
            set
            {
                if (value != _isEditButtonAvailable)
                {
                    _isEditButtonAvailable = value;
                    OnPropertyChanged(nameof(IsEditButtonAvailable));
                }
            }
        }

        public ICommand ChangeMiniOfficeEditVisibility { get; set; }

        public MiniOfficeViewModel()
        {
            GridVisibility = Visibility.Collapsed;

            ChangeMiniOfficeEditVisibility = new VisibilityOfInnerGridCommand(this);
        }

        public void CheckIfAllFieldsFilledCorrectly()
        {
            if (Name != null &&
            PricePerDay != null &&
            AmountOfPlaces != null) IsEditButtonAvailable = true;
            else IsEditButtonAvailable = false;
        }
    }
}
