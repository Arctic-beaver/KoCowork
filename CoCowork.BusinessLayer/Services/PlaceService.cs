using CoCowork.BusinessLayer.Models;
using CoCowork.DataLayer.Entities;
using CoCowork.DataLayer.Repositories;
using CoCowork.BusinessLayer.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoCowork.BusinessLayer.Services
{
    public class PlaceService
    {
        private readonly PlaceRepository _placeRepository;

        public PlaceService()
        {
            _placeRepository = new PlaceRepository();
        }

        public List<PlaceModel> GetAll()
        {
            var places = _placeRepository.GetAllPlaces();
            return CustomMapper.GetInstance().Map<List<PlaceModel>>(places);
        }

        public List<PlaceModel> GetAllThatNotInMiniOffices()
        {
            var places = _placeRepository.GetPlacesThatNotInMiniOffice();
            return CustomMapper.GetInstance().Map<List<PlaceModel>>(places);
        }

        public void DeletePlace(int id)
        {
            _placeRepository.DeletePlaceById(id);
        }

        public void UpdatePlace(PlaceModel place)
        {
            var placeModel = CustomMapper.GetInstance().Map<Place>(place);
            _placeRepository.UpdatePlaceById(placeModel);
        }

        public void InsertPlace(PlaceModel place)
        {
            var placeModel = CustomMapper.GetInstance().Map<Place>(place);
            _placeRepository.Add(placeModel);
        }
    }
}
