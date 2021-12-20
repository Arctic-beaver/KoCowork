
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
        public string Type { get; } = "Место";


        //public ObservableCollection<PlaceTest> GetPlaces()
        //{
        //    var places = new ObservableCollection<PlaceTest>();

        //    places.Add(new PlaceTest() { PricePerDay = 600, FixedPricePerDay = 1000, Number = 9 });

        //    for (int i = 1; i < 9; i++)
        //    {
        //        places.Add(new PlaceTest() { PricePerDay = 600, FixedPricePerDay = 800, Number = i });
        //    }
        //    places.Add(new PlaceTest() { PricePerDay = 800, FixedPricePerDay = 1100, Number = 10 });
        //    return places;
        //}
    }
}
