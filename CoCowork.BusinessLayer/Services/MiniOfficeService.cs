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
    public class MiniOfficeService
    {
        private readonly IMiniOfficeRepository _miniOfficeRepository;
        private readonly IPlaceRepository _placeRepository;

        public MiniOfficeService()
        {
            _miniOfficeRepository = new MiniOfficeRepository();
            _placeRepository = new PlaceRepository();
        }

        public MiniOfficeService(IMiniOfficeRepository fakeMiniOfficeRepository, IPlaceRepository fakePlaceRepository)
        {
            _miniOfficeRepository = fakeMiniOfficeRepository;
            _placeRepository = fakePlaceRepository;
        }

        public List<MiniOfficeModel> GetAll()
        {
            var miniOffices = _miniOfficeRepository.GetAll();
            return CustomMapper.GetInstance().Map<List<MiniOfficeModel>>(miniOffices);
        }

        public void DeleteMiniOffice(MiniOfficeModel miniOffice)
        {
            _miniOfficeRepository.DeleteMiniOfficeById(miniOffice.Id);
        }

        public void UpdateMiniOffice(MiniOfficeModel miniOffice)
        {
            var mOffice = CustomMapper.GetInstance().Map<MiniOffice>(miniOffice);
            _miniOfficeRepository.UpdateMiniOffice(mOffice);
        }

        public int InsertMiniOfficeWithPlaces(MiniOfficeModel miniOffice)
        {
            var mOffice = CustomMapper.GetInstance().Map<MiniOffice>(miniOffice);

            foreach (var placeEntity in miniOffice.Places)
            {
                var place = CustomMapper.GetInstance().Map<Place>(placeEntity);
                _placeRepository.Add(place);
            }

            return _miniOfficeRepository.Add(mOffice);
        }
    }
}
