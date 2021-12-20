
namespace CoCowork.UI.ViewModels
{
    public class MeetingRoomViewModel : BaseViewModel
    {
        private int _number;
        private decimal _pricePerHour;
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
        public decimal PricePerHour
        {
            get => _pricePerHour;
            set
            {
                _pricePerHour = value;
                OnPropertyChanged(nameof(PricePerHour));
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
    }
}
