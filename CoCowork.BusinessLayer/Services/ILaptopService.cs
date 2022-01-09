using CoCowork.BusinessLayer.Models;
using System.Collections.Generic;

namespace CoCowork.BusinessLayer.Services
{
    public interface ILaptopService
    {
        bool Delete(int id);
        List<LaptopModel> GetAll();
        void Insert(LaptopModel laptop);
        void Update(LaptopModel laptop);
    }
}