using CoCowork.BusinessLayer.Models;
using CoCowork.BusinessLayer.Services;
using CoCowork.DataLayer.Entities;
using CoCowork.DataLayer.Repositories;
using Moq;
using NUnit.Framework;
using System;

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
            var places = _placeTestData.GetAllPlacesForTests();
            _placeRepositoryMock.Setup(m => m.GetAll()).Returns(places);
            var sut = new PlaceService( _placeRepositoryMock.Object);

            //act
            var actual = sut.GetAll();

            //assert
            Assert.IsNotNull(actual);
            Assert.IsTrue(actual.Count > 0);
            Assert.IsInstanceOf(typeof(PlaceModel), actual[0]);
        }

        [Test]
        public void GetAllPlaces_ShouldThrowAnException()
        {
            //arrange
            var miniOffices = _placeTestData.GetAllPlacesForTests();
            _placeRepositoryMock.Setup(m => m.GetAll()).Throws(new Exception());
            _placeRepositoryMock.Setup(m => m.Add(It.IsAny<Place>())).Returns(42);
            var sut = new PlaceService(_placeRepositoryMock.Object);

            //act, assert
            Assert.Throws<Exception>(() => sut.GetAll());
        }

        [Test]
        public void GetPlacesThatNotInMiniOffices_ShouldReturnPlacesThatNotInMiniOffices()
        {
            //arrange
            var placesThatNotInMiniOffices = _placeTestData.GetPlacesThatNotInMiniOfficesForTests();
            _placeRepositoryMock.Setup(m => m.GetPlacesThatNotInMiniOffice()).Returns(placesThatNotInMiniOffices);
            var sut = new PlaceService(_placeRepositoryMock.Object);

            //act
            var actual = sut.GetAllThatNotInMiniOffices();

            //assert
            Assert.IsNotNull(actual);
            Assert.IsTrue(actual.Count > 0);
            Assert.IsNull(actual[0].MiniOfficeId);
            Assert.IsInstanceOf(typeof(PlaceModel), actual[0]);
        }

        [Test]
        public void GetPlacesThatNotInMiniOffices_ShouldThrowAnException()
        {
            //arrange
            _placeRepositoryMock.Setup(m => m.GetPlacesThatNotInMiniOffice()).Throws(new Exception());
            var sut = new PlaceService(_placeRepositoryMock.Object);

            //act, assert
            Assert.Throws<Exception>(() => sut.GetAllThatNotInMiniOffices());
        }

        [Test]
        public void InsertPlace()
        {
            //arrange
            var placeModel = _placeTestData.GetPlaceModelForTests();
            _placeRepositoryMock.Setup(m => m.Add(It.IsAny<Place>())).Returns(42);
            var sut = new PlaceService(_placeRepositoryMock.Object);

            //act
            var actual = sut.InsertPlace(placeModel);

            //assert
            _placeRepositoryMock.Verify(m => m.Add(It.IsAny<Place>()), Times.Once);
        }

        [Test]
        public void InsertPlace_PlaceRepositoryThrowsAnException_ShouldReturnNegativeOne()
        {
            //arrange
            var placeModel = _placeTestData.GetPlaceModelForTests();
            _placeRepositoryMock.Setup(m => m.Add(It.IsAny<Place>())).Throws(new Exception());
            var sut = new PlaceService(_placeRepositoryMock.Object);

            //act
            var actual = sut.InsertPlace(placeModel);

            //assert
            Assert.AreEqual(actual, -1);
        }

        [Test]
        public void DeletePlace_ShouldReturnTrue()
        {
            //arrange
            var placeModel = _placeTestData.GetPlaceModelForTests();
            _placeRepositoryMock.Setup(m => m.DeletePlace(It.IsAny<int>()));
            var sut = new PlaceService(_placeRepositoryMock.Object);

            //act
            var actual = sut.DeletePlace(placeModel); 

            //assert
            Assert.IsTrue(actual);
        }

        [Test]
        public void DeletePlace_ShouldReturnFalse()
        {
            //arrange
            var placeModel = _placeTestData.GetPlaceModelForTests();
            _placeRepositoryMock.Setup(m => m.DeletePlace(It.IsAny<int>())).Throws(new Exception());
            var sut = new PlaceService(_placeRepositoryMock.Object);

            //act
            var actual = sut.DeletePlace(placeModel);

            //assert
            Assert.IsFalse(actual);
        }

        [Test]
        public void UpdatePlace()
        {
            //arrange
            var placeModel = _placeTestData.GetPlaceModelForTests();
            _placeRepositoryMock.Setup(m => m.UpdatePlaceById(It.IsAny<Place>()));
            var sut = new PlaceService(_placeRepositoryMock.Object);

            //act
            sut.UpdatePlace(placeModel);

            //assert
            _placeRepositoryMock.Verify(m => m.UpdatePlaceById(It.IsAny<Place>()), Times.Once());
        }

        [Test]
        public void UpdatePlace_ShouldThrowAnException()
        {
            //arrange
            var placeModel = _placeTestData.GetPlaceModelForTests();
            _placeRepositoryMock.Setup(m => m.UpdatePlaceById(It.IsAny<Place>())).Throws(new Exception());
            var sut = new PlaceService(_placeRepositoryMock.Object);

            //act, assert
            Assert.Throws<Exception>(() => sut.UpdatePlace(placeModel));
        }
    }
}
