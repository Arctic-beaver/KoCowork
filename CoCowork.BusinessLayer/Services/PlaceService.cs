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
        private readonly IPlaceRepository _placeRepository;

        public PlaceService()
        {
            _placeRepository = new PlaceRepository();
        }

        public PlaceService(IPlaceRepository fakePlaceRepository)
        {
            _placeRepository = fakePlaceRepository;
        }

        public List<PlaceModel> GetAll()
        {
            var places = _placeRepository.GetAll();
            return CustomMapper.GetInstance().Map<List<PlaceModel>>(places);
        }

        public List<PlaceModel> GetAllThatNotInMiniOffices()
        {
            var places = _placeRepository.GetPlacesThatNotInMiniOffice();
            return CustomMapper.GetInstance().Map<List<PlaceModel>>(places);
        }

        public bool DeletePlace(int id)
        {
            try
            {
                _placeRepository.DeletePlaceById(id);
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public void UpdatePlace(PlaceModel place)
        {
            var placeModel = CustomMapper.GetInstance().Map<Place>(place);
            _placeRepository.UpdatePlaceById(placeModel);
        }

        public int InsertPlace(PlaceModel place)
        {
            var placeModel = CustomMapper.GetInstance().Map<Place>(place);
            int insertedPlaceId = 0;

            try
            {
                insertedPlaceId = _placeRepository.Add(placeModel);
            }
            catch (Exception)
            {
                return -1;
            }
            return insertedPlaceId;
        }
    }
}
