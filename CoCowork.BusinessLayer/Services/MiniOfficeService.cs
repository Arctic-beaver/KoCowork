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
    public class MiniOfficeService
    {
        private readonly MiniOfficeRepository _miniOfficeRepository;

        public MiniOfficeService()
        {
            _miniOfficeRepository = new MiniOfficeRepository();
        }

        public List<MiniOfficeModel> GetAll()
        {
            var laptops = _miniOfficeRepository.GetAll();
            return CustomMapper.GetInstance().Map<List<MiniOfficeModel>>(laptops);
        }

        public MiniOffice ConvertModelToEntities(MiniOfficeModel miniOffice)
        {
            return CustomMapper.GetInstance().Map<MiniOffice>(miniOffice);
        }
    }
}
