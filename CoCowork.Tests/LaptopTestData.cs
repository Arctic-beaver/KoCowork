using CoCowork.DataLayer.Entities;
using System.Collections.Generic;

namespace CoCowork.BusinessLayer.Tests
{
    public class LaptopTestData
    {
        public List<Laptop> GetLaptopListForTests()
        {
            List<Laptop> laptops = new List<Laptop>{
                new Laptop
                {
                    Id = 1,
                    Name = "ПК VIP",
                    Number = 1,
                    PricePerMonth = 9000,
                    Description = "Мощная лошадка"
                }
            };
            return laptops;
        }
    }
}
