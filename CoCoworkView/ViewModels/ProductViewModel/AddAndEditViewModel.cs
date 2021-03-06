namespace CoCowork.UI.ViewModels
{
    public abstract class AddAndEditViewModel : InnerGridViewModel
    {
        private string _name;
        private string _description;
        private int _amount;
        private decimal _priceForOne;

        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        public int Amount
        {
            get => _amount;
            set
            {
                _amount = value;
                OnPropertyChanged(nameof(Amount));
            }
        }

        public decimal PriceForOne
        {
            get => _priceForOne;
            set
            {
                _priceForOne = value;
                OnPropertyChanged(nameof(PriceForOne));
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


    }
}
