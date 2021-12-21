
using System.Collections.ObjectModel;

namespace CoCowork.UI.ViewModels
{
    public class MiniOfficeViewModel : BaseViewModel
    {
        private string _name;
        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        public ObservableCollection<PlaceViewModel> Places { get; set; }

        private int _number;
        private decimal _pricePerDay;
        private int _amountOfPlaces;

        public int Id { get; }

        public int Number
        {
            get => _number;
            set
            {
                _number = value;
                OnPropertyChanged(nameof(Number));
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

        public int AmountOfPlaces
        {
            get => _amountOfPlaces;
            set
            {
                _amountOfPlaces = value;
                OnPropertyChanged(nameof(AmountOfPlaces));
            }
        }

        public bool IsActive { get; set; }
    }
}
