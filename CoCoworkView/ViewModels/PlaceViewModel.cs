
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace CoCowork.UI.ViewModels
{
    public class PlaceViewModel : BaseViewModel
    {
        private ObservableCollection<MiniOfficeViewModel> _miniOffices;
        private decimal _pricePerDay;
        private decimal? _fixedPricePerDay;
        private int _number;

        public ObservableCollection<MiniOfficeViewModel> MiniOffices
        {
            get => _miniOffices;
            set
            {
                _miniOffices = value;
                OnPropertyChanged(nameof(MiniOffices));
            }
        }

        public decimal PricePerDay
        {
            get => _pricePerDay;
            set
            {
                _pricePerDay = value;
                OnPropertyChanged(nameof(PricePerDay));
            }
        }

        public decimal? FixedPricePerDay
        {
            get => _fixedPricePerDay;
            set
            {
                _fixedPricePerDay = value;
                OnPropertyChanged(nameof(FixedPricePerDay));
            }
        }

        public int Number
        {
            get => _number;
            set
            {
                _number = value;
                OnPropertyChanged(nameof(Number));
            }
        }

        public bool IsActive { get; set; }
    }
}
