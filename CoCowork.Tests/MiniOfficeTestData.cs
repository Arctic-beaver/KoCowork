using CoCowork.BusinessLayer.Models;
using CoCowork.DataLayer.Entities;
using System.Collections.Generic;

namespace CoCowork.BusinessLayer.Tests
{
    public class MiniOfficeTestData
    {
        public MiniOfficeModel GetMiniOfficeModelForTests()
        {
            MiniOfficeModel miniOfficeWithPlaces = new MiniOfficeModel
            {
                Id = 1,
                Name = "Офис с диваном",
                AmountOfPlaces = 5,
                PricePerDay = 1000,
                IsActive = true,
                Places = new List<PlaceModel> {
                    new PlaceModel {
                        Id = 1,
                        Number = 1,
                        PricePerDay = 500,
                        PriceFixedPerDay = 800,
                        Description = "Офис с диваном"
                    },
                    new PlaceModel {
                        Id = 2,
                        Number = 2,
                        PricePerDay = 500,
                        PriceFixedPerDay = 800,
                        Description = "Офис с диваном"
                    }
                }
            };
            return miniOfficeWithPlaces;
        }

        public List<MiniOffice> GetMiniOfficesListForTests()
        {
            List<MiniOffice> miniOffices = new List<MiniOffice>{
                new MiniOffice
                {
                    Id = 1,
                    Name = "Офис с диваном",
                    AmountOfPlaces = 5,
                    PricePerDay = 1000,
                    IsActive = true,
                    Places = new List<Place> {
                        new Place {
                            Id = 1,
                            Number = 1,
                            PricePerDay = 500,
                            PriceFixedPerDay = 800,
                            Description = "Офис с диваном"
                        },
                        new Place {
                            Id = 2,
                            Number = 2,
                            PricePerDay = 500,
                            PriceFixedPerDay = 800,
                            Description = "Офис с диваном"
                        },
                        new Place {
                            Id = 3,
                            Number = 3,
                            PricePerDay = 500,
                            PriceFixedPerDay = 800,
                            Description = "Офис с диваном"
                        }
                    }
                }
            };
            return miniOffices;
        }
    }
}
