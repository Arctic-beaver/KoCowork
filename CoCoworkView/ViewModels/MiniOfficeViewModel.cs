
namespace CoCowork.UI.ViewModels
{
    public class MiniOfficeViewModel : BaseViewModel
    {
        private int _number;
        private decimal _pricePerDay;
        private int _amountOfPlaces;

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
