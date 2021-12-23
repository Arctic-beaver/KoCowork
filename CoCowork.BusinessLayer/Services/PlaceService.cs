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

        public List<PlaceModel> GetAll()
        {
            var places = _placeRepository.GetAll();
            return CustomMapper.GetInstance().Map<List<PlaceModel>>(places);
        }

        public Place ConvertModelToEntities(PlaceModel place)
        {
            return CustomMapper.GetInstance().Map<Place>(place);
        }
    }
}

