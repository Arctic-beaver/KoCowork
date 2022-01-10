using CoCowork.DataLayer.Entities;
using System.Collections.Generic;

namespace CoCowork.DataLayer.Repositories
{
    public interface ILaptopRepository
    {
        int Add(Laptop laptop);
        void DeleteLaptopById(int id);
        List<Laptop> GetAll();
        Laptop GetById(int id);
        void UpdateLaptopById(Laptop laptop);
    }
}