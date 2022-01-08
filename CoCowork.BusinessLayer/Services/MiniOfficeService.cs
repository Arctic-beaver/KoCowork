using CoCowork.BusinessLayer.Configuration;
using CoCowork.BusinessLayer.Models;
using CoCowork.DataLayer.Entities;
using CoCowork.DataLayer.Repositories;
using System;
using System.Collections.Generic;

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

        public bool DeleteMiniOffice(MiniOfficeModel miniOffice)
        {
            try
            {
                _miniOfficeRepository.DeleteMiniOffice(miniOffice.Id);
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public void UpdateMiniOffice(MiniOfficeModel miniOffice)
        {
            var mOffice = CustomMapper.GetInstance().Map<MiniOffice>(miniOffice);
            _miniOfficeRepository.UpdateMiniOffice(mOffice);
        }

        public int InsertMiniOfficeWithPlaces(MiniOfficeModel miniOffice)
        {
            var mOffice = CustomMapper.GetInstance().Map<MiniOffice>(miniOffice);
            int insertedMiniOfficeId = 0;

            try
            {
                insertedMiniOfficeId = _miniOfficeRepository.Add(mOffice);
            }
            catch (Exception)
            {
                return -1;
            }

            foreach (var placeEntity in miniOffice.Places)
            {
                var place = CustomMapper.GetInstance().Map<Place>(placeEntity);
                place.MiniOfficeId = insertedMiniOfficeId;

                try
                {
                    _placeRepository.Add(place);
                }
                catch (Exception)
                {
                    return -1;
                }
            }
            return insertedMiniOfficeId;
        }
    }
}
