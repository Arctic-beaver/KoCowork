
namespace CoCowork.UI.ViewModels
{
    public class MiniOfficeViewModel : BaseViewModel
    {

        private decimal _pricePerDay;
        private int _number;
        public decimal PricePerDay
        {
            get => _pricePerDay;
            set
            {
                _pricePerDay = value;
                OnPropertyChanged(nameof(PricePerDay));
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
        public string Type { get; } = "Миниофис";
    }
}
