using CoCowork.DataLayer.Entities;
using System.Collections.Generic;

namespace CoCowork.DataLayer.Repositories
{
    public interface ILaptopRepository
    {
        void Add(Laptop laptop);
        void DeleteLaptopById(int id);
        List<Laptop> GetAllLaptops();
        Laptop GetLaptopsById(int id);
        void UpdateLaptopById(Laptop laptop);
    }
}