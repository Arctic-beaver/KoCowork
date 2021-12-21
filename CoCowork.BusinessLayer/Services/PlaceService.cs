using CoCowork.BusinessLayer.Models;
using CoCowork.DataLayer.Entities;
using CoCowork.DataLayer.Repositories;
using PseudoCalc.BusinessLayer.Configuration;
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

        public List<PlaceModel> GetAllThatBotInMiniOffices()
        {
            var places = _placeRepository.GetPlacesThatNotInMiniOffice();
            return CustomMapper.GetInstance().Map<List<PlaceModel>>(places);
        }

        public void DeleteMiniOffice(int id)
        {
            _placeRepository.DeletePlaceById(id);
        }

        public void UpdateMiniOffice(PlaceModel place)
        {
            var placeModel = CustomMapper.GetInstance().Map<Place>(place);
            _placeRepository.UpdatePlaceById(placeModel);
        }

        public void InsertMiniOffice(PlaceModel place)
        {
            var placeModel = CustomMapper.GetInstance().Map<Place>(place);
            _placeRepository.Add(placeModel);
        }
    }
}
