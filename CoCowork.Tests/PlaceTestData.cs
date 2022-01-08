using CoCowork.DataLayer.Entities;
using System.Collections.Generic;

namespace CoCowork.BusinessLayer.Tests
{
    public class PlaceTestData
    {
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
                }
            };
            return places;
        }
    }
}
