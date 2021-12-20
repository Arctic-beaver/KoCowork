
namespace CoCowork.UI.ViewModels
{
    public class ComputerViewModel : BaseViewModel
    {
        private int _number;
        private decimal _pricePerMonth;
        private string _description;

        public int Number
        {
            get => _number;
            set
            {
                _number = value;
                OnPropertyChanged(nameof(Number));
            }
        }

        public decimal PricePerMonth
        {
            get => _pricePerMonth;
            set
            {
                _pricePerMonth = value;
                OnPropertyChanged(nameof(PricePerMonth));
            }
        }

        public string Description
        {
            get => _description;
            set
            {
                _description = value;
                OnPropertyChanged(nameof(Description));
            }
        }

        public bool IsActive { get; set; }
    }
}
