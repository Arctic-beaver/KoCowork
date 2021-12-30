using CoCowork.BusinessLayer.Configuration;
using CoCowork.BusinessLayer.Models;
using CoCowork.DataLayer.Entities;
using CoCowork.DataLayer.Repositories;
using System.Collections.Generic;

namespace CoCowork.BusinessLayer.Services
{
    public class LaptopService : ILaptopService
    {
        private readonly ILaptopRepository _laptopRepository;

        public LaptopService()
        {
            _laptopRepository = new LaptopRepository();
        }

        public List<LaptopModel> GetAll()
        {
            var computers = _laptopRepository.GetAll();
            return CustomMapper.GetInstance().Map<List<LaptopModel>>(computers);
        }

        public void Delete(int id)
        {
            _laptopRepository.DeleteLaptopById(id);
        }

        public void Update(LaptopModel laptop)
        {
            var computers = CustomMapper.GetInstance().Map<Laptop>(laptop);
            _laptopRepository.UpdateLaptopById(computers);
        }

        public void Insert(LaptopModel laptop)
        {
            var computers = CustomMapper.GetInstance().Map<Laptop>(laptop);
            _laptopRepository.Add(computers);
        }
    }
}
