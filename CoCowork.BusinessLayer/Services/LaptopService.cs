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
    public class LaptopService
    {
        private readonly LaptopRepository _laptopRepository;

        public LaptopService()
        {
            _laptopRepository = new LaptopRepository();
        }

        public List<LaptopModel> GetAll()
        {
            var laptops = _laptopRepository.GetAllLaptops();
            return CustomMapper.GetInstance().Map<List<LaptopModel>>(laptops);
        }

        public Laptop ConvertModelToEntities(LaptopModel laptop)
        {
            return CustomMapper.GetInstance().Map<Laptop>(laptop);
        }
    }
}
