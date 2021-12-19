
using System.Collections.ObjectModel;

namespace CoCowork.UI.ViewModels
{
    public class PlaceViewModel : BookingViewModel
    {
        private ObservableCollection<MiniOfficeViewModel> _miniOffices;
        private decimal _pricePerDay;
        public ObservableCollection<MiniOfficeViewModel> MiniOffices
        {
            get => _miniOffices;
            set
            {
                _miniOffices = value;
                OnPropertyChanged(nameof(MiniOffices));
            }
        }
        public decimal PricePerDay { get; }
        public decimal FixedPricePerDay { get; }

        public PlaceViewModel()
        {

        }
    }
}
