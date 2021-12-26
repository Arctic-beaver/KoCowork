using CoCowork.DataLayer.Entities;
using CoCowork.DataLayer.Repositories;
using Moq;
using NUnit.Framework;
using System.Collections.Generic;

namespace CoCowork.Tests
{
    public class PlaceServiceTests
    {
        private readonly Mock<IPlaceRepository> _placeRepositoryMock;

        public PlaceServiceTests()
        {
            _placeRepositoryMock = new Mock<IPlaceRepository>();
        }

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GetAllPlaces_ShouldReturnPlacesWithMiniOffices()
        {
            //Arrange
            //_placeRepositoryMock.Setup(m => m.GetAll()).Returns(new List<Place>
            //{
            //    new Place
            //    {
            //        Id = 1,
            //        Number = 1,
            //        PricePerDay = 1000,
            //        PriceFixedPerDay = 1300,
            //        Description = "Место в зале",
            //        MiniOffice = new MiniOffice
            //        {
            //            Id = 1,
            //            Name = "С диваном",
            //            AmountOfPlaces = 5,
            //            PricePerDay = 1200,
            //            IsActive = false
            //        }
    
            //    }
            //}
            //Assert.Pass();
        }
    }
}