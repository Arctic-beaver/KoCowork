
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace CoCowork.UI.ViewModels
{
    public class PlaceViewModel : BookingViewModel
    {
        private ObservableCollection<MiniOfficeViewModel> _miniOffices;
        //private ObservableCollection<PlaceTest> _testPlaces;
        public ObservableCollection<MiniOfficeViewModel> MiniOffices
        {
            get => _miniOffices;
            set
            {
                _miniOffices = value;
                OnPropertyChanged(nameof(MiniOffices));
            }
        }
        ////public ObservableCollection<PlaceTest> TestPlaces
        //{
        //    get => _testPlaces;
        //    set
        //    {
        //        _testPlaces = value;
        //        OnPropertyChanged(nameof(TestPlaces));
        //    }
        //}

        public ObservableCollection<PlaceTest> GetPlaces()
        {
            var places = new ObservableCollection<PlaceTest>();

            places.Add(new PlaceTest() { PricePerDay = 600, FixedPricePerDay = 1000, Number = 9 });

            for (int i = 1; i < 9; i++)
            {
                places.Add(new PlaceTest() { PricePerDay = 600, FixedPricePerDay = 800, Number = i });
            }
            places.Add(new PlaceTest() { PricePerDay = 800, FixedPricePerDay = 1100, Number = 10 });
            return places;
        }
    }
}
