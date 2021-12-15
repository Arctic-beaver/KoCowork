using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoCowork.DataLayer.Entities
{
    public class Laptop
    {
        public int Id { get; set; } 
        public string Name { get; set; }    
        public int Amout { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
    }
}
