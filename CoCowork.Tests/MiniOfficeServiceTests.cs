﻿using CoCowork.BusinessLayer.Models;
using CoCowork.BusinessLayer.Services;
using CoCowork.DataLayer.Entities;
using CoCowork.DataLayer.Repositories;
using Moq;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

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
        public void AddMiniOfficeWithPlaces()
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
        public void DeleteMiniOffice()
        {
            //arrange
            var miniOfficeWithPlaces = _miniOfficeTestData.GetMiniOfficeModelForTests();
            _miniOfficeRepositoryMock.Setup(m => m.DeleteMiniOfficeById(It.IsAny<int>()));
            _placeRepositoryMock.Setup(m => m.Add(It.IsAny<Place>())).Returns(42);
            var sut = new MiniOfficeService(_miniOfficeRepositoryMock.Object, _placeRepositoryMock.Object);

            //act
            sut.DeleteMiniOffice(miniOfficeWithPlaces);

            //assert
            _miniOfficeRepositoryMock.Verify(m => m.DeleteMiniOfficeById(It.IsAny<int>()), Times.Once());
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
    }
}
