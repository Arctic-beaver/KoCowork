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

        public MiniOfficeService()
        {
            _miniOfficeRepository = new MiniOfficeRepository();
        }

        public List<MiniOfficeModel> GetAll()
        {
            var miniOffices = _miniOfficeRepository.GetAll();
            return CustomMapper.GetInstance().Map<List<MiniOfficeModel>>(miniOffices);
        }

        public void DeleteMiniOffice(int id)
        {
            _miniOfficeRepository.DeleteMiniOfficeById(id);
        }

        public void UpdateMiniOffice(MiniOfficeModel miniOffice)
        {
            var mOffice = CustomMapper.GetInstance().Map<MiniOffice>(miniOffice);
            _miniOfficeRepository.UpdateMiniOfficeById(mOffice);
        }

        public void InsertMiniOffice(MiniOfficeModel miniOffice)
        {
            var mOffice = CustomMapper.GetInstance().Map<MiniOffice>(miniOffice);
            _miniOfficeRepository.Add(mOffice);
        }
    }
}
