using CoCowork.BusinessLayer.Models;
using CoCowork.DataLayer.Entities;
using System.Collections.Generic;

namespace CoCowork.BusinessLayer.Tests
{
    public class PlaceTestData
    {
        public PlaceModel GetPlaceModelForTests()
        {
            PlaceModel placeModel = new PlaceModel
            {
                Id = 1,
                Number = 1,
                PricePerDay = 500,
                PriceFixedPerDay = 800,
                Description = "Место у окна"
            };
            return placeModel;
        }

        public List<Place> GetPlacesListForTests()
        {
            List<Place> places = new List<Place>{
                new Place
                {
                    Id = 1,
                    Number = 1,
                    PricePerDay = 500,
                    PriceFixedPerDay = 800,
                    Description = "Место в зале"
                },
                new Place
                {
                    Id = 2,
                    Number = 2,
                    PricePerDay = 500,
                    PriceFixedPerDay = 800,
                    Description = "Место в зале"
                },
                new Place
                {
                    Id = 3,
                    Number = 3,
                    PricePerDay = 500,
                    PriceFixedPerDay = 800,
                    Description = "Место в зале"
                }
            };
            return places;
        }
    }
}
