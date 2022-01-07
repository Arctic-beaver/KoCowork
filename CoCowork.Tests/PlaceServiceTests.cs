using CoCowork.DataLayer.Repositories;
using Moq;
using NUnit.Framework;

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

        }
    }
}