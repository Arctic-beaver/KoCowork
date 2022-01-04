using CoCowork.BusinessLayer.Models;
using CoCowork.BusinessLayer.Services;
using CoCowork.DataLayer.Entities;
using CoCowork.DataLayer.Repositories;
using Moq;
using NUnit.Framework;
using System.Collections.Generic;

namespace CoCowork.BusinessLayer.Tests
{
    public class MiniOfficeServiceTests
    {
        private readonly Mock<IMiniOfficeRepository> _miniOfficeRepositoryMock;
        private readonly Mock<IPlaceRepository> _placeRepositoryMock;

        public MiniOfficeServiceTests()
        {
            _miniOfficeRepositoryMock = new Mock<IMiniOfficeRepository>();
        }

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GetAllMiniOffices_ShouldReturnMiniOfficesWithPlaces()
        {
            //arrange
            _miniOfficeRepositoryMock.Setup(m => m.GetAll()).Returns(new List<MiniOffice>
            {
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
            });
            var sut = new MiniOfficeService(_miniOfficeRepositoryMock.Object);

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
        public void AddMiniOffice()
        {
            //arrange
            var miniOfficeWithPlaces = new MiniOfficeModel
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

            _miniOfficeRepositoryMock.Setup(m => m.Add(It.IsAny<MiniOffice>())).Returns(23);
            _placeRepositoryMock.Setup(m => m.Add(It.IsAny<Place>())).Returns(42);
            var sut = new MiniOfficeService(_miniOfficeRepositoryMock.Object);

            //act
            var actual = sut.InsertMiniOffice(miniOfficeWithPlaces);

            //assert

        }
    }
}
