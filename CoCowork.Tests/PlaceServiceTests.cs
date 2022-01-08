using CoCowork.BusinessLayer.Models;
using CoCowork.BusinessLayer.Services;
using CoCowork.DataLayer.Entities;
using CoCowork.DataLayer.Repositories;
using Moq;
using NUnit.Framework;

namespace CoCowork.BusinessLayer.Tests
{
    public class PlaceServiceTests
    {
        private readonly Mock<IPlaceRepository> _placeRepositoryMock;
        private readonly PlaceTestData _placeTestData;

        public PlaceServiceTests()
        {
            _placeRepositoryMock = new Mock<IPlaceRepository>();
            _placeTestData = new PlaceTestData();
        }

        [Test]
        public void GetAllPlaces_ShouldReturnPlaces()
        {
            //arrange
            var places = _placeTestData.GetPlacesListForTests();
            _placeRepositoryMock.Setup(m => m.GetAll()).Returns(places);
            var sut = new PlaceService( _placeRepositoryMock.Object);

            //act
            var actual = sut.GetAll();

            //assert
            Assert.IsNotNull(actual);
            Assert.IsTrue(actual.Count > 0);
        }
    }
}
