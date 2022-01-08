using CoCowork.BusinessLayer.Models;
using CoCowork.BusinessLayer.Services;
using CoCowork.DataLayer.Entities;
using CoCowork.DataLayer.Repositories;
using Moq;
using NUnit.Framework;
using System.IO;

namespace CoCowork.BusinessLayer.Tests
{
    public class MiniOfficeServiceTests
    {
        private readonly Mock<IMiniOfficeRepository> _miniOfficeRepositoryMock;
        private readonly Mock<IPlaceRepository> _placeRepositoryMock;
        private readonly MiniOfficeTestData _miniOfficeTestData;

        public MiniOfficeServiceTests()
        {
            _miniOfficeRepositoryMock = new Mock<IMiniOfficeRepository>();
            _placeRepositoryMock = new Mock<IPlaceRepository>();
            _miniOfficeTestData = new MiniOfficeTestData();
        }

        [Test]
        public void GetAllMiniOffices_ShouldReturnMiniOfficesWithPlaces()
        {
            //arrange
            var miniOffices = _miniOfficeTestData.GetMiniOfficesListForTests();
            _miniOfficeRepositoryMock.Setup(m => m.GetAll()).Returns(miniOffices);
            _placeRepositoryMock.Setup(m => m.Add(It.IsAny<Place>())).Returns(42);
            var sut = new MiniOfficeService(_miniOfficeRepositoryMock.Object, _placeRepositoryMock.Object);

            //act
            var actual = sut.GetAll();

            //assert
            Assert.IsNotNull(actual);
            Assert.IsTrue(actual.Count > 0);
            Assert.IsNotNull(actual[0].Places);
            Assert.IsTrue(actual[0].Places.Count > 0);
            Assert.IsInstanceOf(typeof(PlaceModel), actual[0].Places[0]);
        }

        [Test]
        public void GetAllMiniOffices_ShouldThrowAnIOException()
        {
            //arrange
            var miniOffices = _miniOfficeTestData.GetMiniOfficesListForTests();
            _miniOfficeRepositoryMock.Setup(m => m.GetAll()).Throws(new IOException());
            _placeRepositoryMock.Setup(m => m.Add(It.IsAny<Place>())).Returns(42);
            var sut = new MiniOfficeService(_miniOfficeRepositoryMock.Object, _placeRepositoryMock.Object);

            //act, assert
            Assert.Throws<IOException> (() => sut.GetAll());
        }

        [Test]
        public void InsertMiniOfficeWithPlaces()
        {
            //arrange
            var miniOfficeWithPlaces = _miniOfficeTestData.GetMiniOfficeModelForTests();
            _miniOfficeRepositoryMock.Setup(m => m.Add(It.IsAny<MiniOffice>())).Returns(23);
            _placeRepositoryMock.Setup(m => m.Add(It.IsAny<Place>())).Returns(42);
            var sut = new MiniOfficeService(_miniOfficeRepositoryMock.Object, _placeRepositoryMock.Object);

            //act
            var actual = sut.InsertMiniOfficeWithPlaces(miniOfficeWithPlaces);

            //assert
            _miniOfficeRepositoryMock.Verify(m => m.Add(It.IsAny<MiniOffice>()), Times.Once());
            _placeRepositoryMock.Verify(m => m.Add(It.IsAny<Place>()), Times.Exactly(miniOfficeWithPlaces.Places.Count));
        }

        [Test]
        public void InsertMiniOfficeWithPlaces_MiniOfficeRepositoryThrowsAnIOException_ShouldReturnNegativeOne()
        {
            //arrange
            var miniOfficeWithPlaces = _miniOfficeTestData.GetMiniOfficeModelForTests();
            _miniOfficeRepositoryMock.Setup(m => m.Add(It.IsAny<MiniOffice>())).Throws(new IOException());
            _placeRepositoryMock.Setup(m => m.Add(It.IsAny<Place>())).Returns(42);
            var sut = new MiniOfficeService(_miniOfficeRepositoryMock.Object, _placeRepositoryMock.Object);

            //act
            var actual = sut.InsertMiniOfficeWithPlaces(miniOfficeWithPlaces);

            //assert
            Assert.AreEqual(actual, -1);
        }

        [Test]
        public void InsertMiniOfficeWithPlaces_PlaceRepositoryThrowsAnIOException_ShouldReturnNegativeOne()
        {
            //arrange
            var miniOfficeWithPlaces = _miniOfficeTestData.GetMiniOfficeModelForTests();
            _miniOfficeRepositoryMock.Setup(m => m.Add(It.IsAny<MiniOffice>())).Returns(23);
            _placeRepositoryMock.Setup(m => m.Add(It.IsAny<Place>())).Throws(new IOException());
            var sut = new MiniOfficeService(_miniOfficeRepositoryMock.Object, _placeRepositoryMock.Object);

            //act
            var actual = sut.InsertMiniOfficeWithPlaces(miniOfficeWithPlaces);

            //assert
            Assert.AreEqual(actual, -1);
        }

        [Test]
        public void DeleteMiniOffice_ShouldReturnTrue()
        {
            //arrange
            var miniOfficeWithPlaces = _miniOfficeTestData.GetMiniOfficeModelForTests();
            _miniOfficeRepositoryMock.Setup(m => m.DeleteMiniOffice(It.IsAny<int>()));
            _placeRepositoryMock.Setup(m => m.Add(It.IsAny<Place>())).Returns(42);
            var sut = new MiniOfficeService(_miniOfficeRepositoryMock.Object, _placeRepositoryMock.Object);

            //act
            var actual = sut.DeleteMiniOffice(miniOfficeWithPlaces);

            //assert
            Assert.IsTrue(actual);
        }

        [Test]
        public void DeleteMiniOffice_MiniOfficeRepositoryThrowsAnException_ShouldReturnFalse()
        {
            //arrange
            var miniOfficeWithPlaces = _miniOfficeTestData.GetMiniOfficeModelForTests();
            _miniOfficeRepositoryMock.Setup(m => m.DeleteMiniOffice(It.IsAny<int>())).Throws(new IOException());
            _placeRepositoryMock.Setup(m => m.Add(It.IsAny<Place>())).Returns(42);
            var sut = new MiniOfficeService(_miniOfficeRepositoryMock.Object, _placeRepositoryMock.Object);

            //act
            var actual = sut.DeleteMiniOffice(miniOfficeWithPlaces);

            //assert
            Assert.IsFalse(actual);
        }

        [Test]
        public void UpdateMiniOffice()
        {
            //arrange
            var miniOfficeWithPlaces = _miniOfficeTestData.GetMiniOfficeModelForTests();
            _miniOfficeRepositoryMock.Setup(m => m.UpdateMiniOffice(It.IsAny<MiniOffice>()));
            _placeRepositoryMock.Setup(m => m.Add(It.IsAny<Place>())).Returns(42);
            var sut = new MiniOfficeService(_miniOfficeRepositoryMock.Object, _placeRepositoryMock.Object);

            //act
            sut.UpdateMiniOffice(miniOfficeWithPlaces);

            //assert
            _miniOfficeRepositoryMock.Verify(m => m.UpdateMiniOffice(It.IsAny<MiniOffice>()), Times.Once());
        }

        [Test]
        public void UpdateMiniOffice_ShouldThrowAnIOException()
        {
            //arrange
            var miniOfficeWithPlaces = _miniOfficeTestData.GetMiniOfficeModelForTests();
            _miniOfficeRepositoryMock.Setup(m => m.UpdateMiniOffice(It.IsAny<MiniOffice>())).Throws(new IOException());
            _placeRepositoryMock.Setup(m => m.Add(It.IsAny<Place>())).Returns(42);
            var sut = new MiniOfficeService(_miniOfficeRepositoryMock.Object, _placeRepositoryMock.Object);

            //act, assert
            Assert.Throws<IOException>(() => sut.UpdateMiniOffice(miniOfficeWithPlaces));
        }
    }
}
