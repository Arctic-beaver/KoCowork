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
                Description = "Место у окна",
                MiniOfficeId = null
            };
            return placeModel;
        }

        public List<Place> GetPlacesThatNotInMiniOfficesForTests()
        {
            List<Place> placesthatNotInMiniOffices = new List<Place>{
                new Place
                {
                    PricePerDay = 500,
                    PriceFixedPerDay = 800,
                    Description = "Место в зале",
                    MiniOfficeId = null
                },
                new Place
                {
                    Id = 2,
                    Number = 2,
                    PricePerDay = 500,
                    PriceFixedPerDay = 800,
                    Description = "Место в зале",
                    MiniOfficeId = null
                },
                new Place
                {
                    Id = 3,
                    Number = 3,
                    PricePerDay = 500,
                    PriceFixedPerDay = 800,
                    Description = "Место в зале",
                    MiniOfficeId = null
                }
            };
            return placesthatNotInMiniOffices;
        }

        public List<Place> GetAllPlacesForTests()
        {
            List<Place> allPlaces = new List<Place>{
                new Place
                {
                    Id = 1,
                    Number = 1,
                    PricePerDay = 500,
                    PriceFixedPerDay = 800,
                    Description = "Место в зале",
                    MiniOfficeId = null
                },
                new Place
                {
                    Id = 2,
                    Number = 2,
                    PricePerDay = 500,
                    PriceFixedPerDay = 800,
                    Description = "Место в зале",
                    MiniOfficeId = null
                },
                new Place
                {
                    Id = 3,
                    Number = 3,
                    PricePerDay = 500,
                    PriceFixedPerDay = 800,
                    Description = "Место в зале",
                    MiniOfficeId = null
                },
                new Place
                {
                    Id = 4,
                    Number = 4,
                    PricePerDay = 500,
                    PriceFixedPerDay = 800,
                    Description = "Офис с диваном",
                    MiniOfficeId = 1
                },
                new Place
                {
                    Id = 5,
                    Number = 5,
                    PricePerDay = 500,
                    PriceFixedPerDay = 800,
                    Description = "Офис с диваном",
                    MiniOfficeId = 1
                },
                new Place
                {
                    Id = 6,
                    Number = 6,
                    PricePerDay = 500,
                    PriceFixedPerDay = 800,
                    Description = "Офис с диваном",
                    MiniOfficeId = 1
                },
                new Place
                {
                    Id = 7,
                    Number = 7,
                    PricePerDay = 500,
                    PriceFixedPerDay = 800,
                    Description = "Офис с диваном",
                    MiniOfficeId = 1
                }
            };
            return allPlaces;
        }
    }
}

