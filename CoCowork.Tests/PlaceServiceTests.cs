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
        private readonly Mock<IPlaceOrderRepository> _orderRepositoryMock;
        private readonly PlaceTestData _placeTestData;

        public PlaceServiceTests()
        {
            _placeRepositoryMock = new Mock<IPlaceRepository>();
            _orderRepositoryMock = new Mock<IPlaceOrderRepository>();
            _placeTestData = new PlaceTestData();
        }

        [Test]
        public void GetAllPlaces_ShouldReturnPlaces()
        {
            //arrange
            var places = _placeTestData.GetAllPlacesForTests();
            _placeRepositoryMock.Setup(m => m.GetAll()).Returns(places);
            //var sut = new PlaceService(_placeRepositoryMock.Object);

            var sut = new PlaceService(_orderRepositoryMock.Object, _placeRepositoryMock.Object);

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
            _orderRepositoryMock.Setup(m => m.GetAllPlaceOrders());
            var sut = new PlaceService(_orderRepositoryMock.Object, _placeRepositoryMock.Object);

            //act, assert
            Assert.Throws<Exception>(() => sut.GetAll());
        }

        [Test]
        public void GetPlacesThatNotInMiniOffices_ShouldReturnPlacesThatNotInMiniOffices()
        {
            //arrange
            var placesThatNotInMiniOffices = _placeTestData.GetPlacesThatNotInMiniOfficesForTests();
            _placeRepositoryMock.Setup(m => m.GetPlacesThatNotInMiniOffice()).Returns(placesThatNotInMiniOffices);
            _orderRepositoryMock.Setup(m => m.GetAllPlaceOrders());
            var sut = new PlaceService(_orderRepositoryMock.Object, _placeRepositoryMock.Object);

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
            _orderRepositoryMock.Setup(m => m.GetAllPlaceOrders());
            var sut = new PlaceService(_orderRepositoryMock.Object, _placeRepositoryMock.Object);

            //act, assert
            Assert.Throws<Exception>(() => sut.GetAllThatNotInMiniOffices());
        }

        [Test]
        public void InsertPlace()
        {
            //arrange
            var placeModel = _placeTestData.GetPlaceModelForTests();
            _placeRepositoryMock.Setup(m => m.Add(It.IsAny<Place>())).Returns(42);
            _orderRepositoryMock.Setup(m => m.GetAllPlaceOrders());
            var sut = new PlaceService(_orderRepositoryMock.Object, _placeRepositoryMock.Object);

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
            _orderRepositoryMock.Setup(m => m.GetAllPlaceOrders());
            var sut = new PlaceService(_orderRepositoryMock.Object, _placeRepositoryMock.Object);

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
            _placeRepositoryMock.Setup(m => m.DeletePlaceById(It.IsAny<int>()));
            _orderRepositoryMock.Setup(m => m.GetAllPlaceOrders());
            var sut = new PlaceService(_orderRepositoryMock.Object, _placeRepositoryMock.Object);

            //act
            var actual = sut.DeletePlace(placeModel.Id); 

            //assert
            Assert.IsTrue(actual);
        }

        [Test]
        public void DeletePlace_ShouldReturnFalse()
        {
            //arrange
            var placeModel = _placeTestData.GetPlaceModelForTests();
            _placeRepositoryMock.Setup(m => m.DeletePlaceById(It.IsAny<int>())).Throws(new Exception());
            _orderRepositoryMock.Setup(m => m.GetAllPlaceOrders());
            var sut = new PlaceService(_orderRepositoryMock.Object, _placeRepositoryMock.Object);

            //act
            var actual = sut.DeletePlace(placeModel.Id);

            //assert
            Assert.IsFalse(actual);
        }

        [Test]
        public void UpdatePlace()
        {
            //arrange
            var placeModel = _placeTestData.GetPlaceModelForTests();
            _placeRepositoryMock.Setup(m => m.UpdatePlaceById(It.IsAny<Place>()));
            _orderRepositoryMock.Setup(m => m.GetAllPlaceOrders());
            var sut = new PlaceService(_orderRepositoryMock.Object, _placeRepositoryMock.Object);

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
            _orderRepositoryMock.Setup(m => m.GetAllPlaceOrders());
            var sut = new PlaceService(_orderRepositoryMock.Object, _placeRepositoryMock.Object);

            //act, assert
            Assert.Throws<Exception>(() => sut.UpdatePlace(placeModel));
        }
    }
}
