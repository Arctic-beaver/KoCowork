using CoCowork.BusinessLayer.Configuration;
using CoCowork.BusinessLayer.Models;
using CoCowork.DataLayer.Entities;
using CoCowork.DataLayer.Repositories;
using System.Collections.Generic;

namespace CoCowork.BusinessLayer.Services
{
    public class ComputerService
    {
        private readonly LaptopRepository _laptopRepository;

        public ComputerService()
        {
            _laptopRepository = new LaptopRepository();
        }

        public List<ComputerModel> GetAll()
        {
            var computers = _laptopRepository.GetAllLaptops();
            return CustomMapper.GetInstance().Map<List<ComputerModel>>(computers);
        }

        public void Delete(int id)
        {
            _laptopRepository.DeleteLaptopById(id);
        }

        public void Update(ComputerModel laptop)
        {
            var computers = CustomMapper.GetInstance().Map<Laptop>(laptop);
            _laptopRepository.UpdateLaptopById(computers);
        }

        public void Insert(ComputerModel laptop)
        {
            var computers = CustomMapper.GetInstance().Map<Laptop>(laptop);
            _laptopRepository.Add(computers);
        }
    }
}
